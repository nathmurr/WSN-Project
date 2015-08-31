Imports MySql.Data.MySqlClient
Public Class Map
    Dim myConnectionString As String        'Database Parameters
    Dim zone As String                      'used as a variable
    Dim objects As String                      'used as a variable
    Dim snumbers As Int64
    Dim dr As MySqlDataReader       'object which mysql uses to put retrieved values
    Dim dt As New DataTable         'table created to store values from mysql
    Dim dr2 As MySqlDataReader       'object which mysql uses to put retrieved values
    Dim dt2 As New DataTable         'table created to store values from mysql

    Dim dbcommand As String
    Dim dbpointer As String
    Dim dbdata As String
    Dim user_selected As String
    Dim messageboxuser As Boolean = False
    Dim messageboxuser_num As Boolean = False

    Private Sub Map_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim result As DataTable
        Dim table As String

        'pnl_people.Hide()

        'dbcommand = "DELETE FROM sensor_received_data;"
        'result = Database_functions.database_getall_single_column(dbcommand)

        dbcommand = "SELECT * FROM t_zones WHERE d_object<>'' AND (d_object_codename1)<>'';"
        result = Database_functions.database_getall_single_column(dbcommand)
        For Each row As DataRow In result.Rows      'for every row in dt datatable
            table = row.Item("d_object_codename1")    'add value into variable from d_zone column of t_zones table
            Me.Controls(table.ToString).Hide()
        Next row        'next row until all rows are obtained

        dbcommand = "SELECT * FROM t_zones WHERE (d_object)<>'' AND (d_object_codename2)<>'';"
        result = Database_functions.database_getall_single_column(dbcommand)
        For Each row As DataRow In result.Rows      'for every row in dt datatable
            table = row.Item("d_object_codename2")    'add value into variable from d_zone column of t_zones table
            Me.Controls(table.ToString).Hide()
        Next row        'next row until all rows are obtained

        Call run_services()
        bath_toilet.Show()
        master_bed_occ.Show()
        bath_toilet.Show()
        bath_shower.Show()
        guest_bed.Show()
        comp_off.Show()
        img_live_sofa_on.Show()
        img_live_tv_on.Show()
    End Sub
    Private Sub process_services() ' not used
        Dim result As DataTable
        Dim service As String
        Dim test As DateTime
        Dim timestamp_str As String
        Dim service_interval As Integer




        'get from database all services which are active
        dbcommand = "SELECT * FROM services WHERE d_service_active=True;"
        result = Database_functions.database_getall_single_column(dbcommand)
        For Each row As DataRow In result.Rows      'for every row in dt datatable
            service = row.Item("d_service_name")    'add value into variable from d_zone column of t_zones table
            Dim last_timestamp As DateTime = row.Item("lastrun_timestamp")
            service_interval = row.Item("d_service_interval_mins")

            'is it time to run service yet
            Dim current_timeStamp As DateTime = DateTime.Now 'get current datetime

            Dim timeSpan As TimeSpan = current_timeStamp.Subtract(last_timestamp)
            Dim difDays As Integer = timeSpan.Days   'get 3 days
            Dim difHr As Integer = timeSpan.Hours    'get 0 hours although 3 days difference
            Dim difMin As Integer = timeSpan.Minutes 'get 0 minutes although 3 days difference

            'set service timespan to equal service interval
            Dim timespan_service As New TimeSpan(0, 0, service_interval, 0)

            If timeSpan > timespan_service Then
                'run service
                Dim routine As String = service
                Dim service_form As Object = WindowsApplication3.Services
                CallByName(service_form, service, CallType.Method)

                'set current timestamp to service
                current_timeStamp = DateTime.Now 'get current datetime
                timestamp_str = current_timeStamp.ToString("yyyy-MM-dd HH:mm:ss") ' convert to datetime for mysql format
                dbcommand = "UPDATE services SET lastrun_timestamp='" & timestamp_str & "' WHERE d_service_name='" & service & "';"
                dbpointer = "@pointer"
                Database_functions.database_insert_single_column(dbcommand, dbpointer, timestamp_str)
            End If

        Next row        'next row until all rows are obtained

    End Sub
    Sub run_services()
        Dim result As DataTable
        Dim service_name(30) As String
        Dim service_state(30) As String
        Dim count As Integer = 0
        Dim count_end As Integer = 0

        'get all services from database and their whether they are on or off
        dbcommand = "SELECT * FROM services;"
        result = Database_functions.database_getall_single_column(dbcommand)

        For Each row As DataRow In result.Rows      'for every row in dt datatable
            service_name(count) = row.Item("d_service_name")    'add value into variable from d_zone column of t_zones table
            service_state(count) = row.Item("d_service_active")
            count += 1
        Next row        'next row until all rows are obtained
        count_end = count - 1

        count = 0 'start at 0

        For a = 0 To count_end
            If service_state(count) = "on" Then
                CallByName(Services, service_name(count), CallType.Method)
                count += 1
            End If
        Next
    End Sub


    Private Sub ftp_upload_timer_Tick(sender As Object, e As EventArgs) Handles ftp_upload_timer.Tick

        Dim d As DateTime
        d = Now
        Dim datestring As String
        Dim filedatestr As String
        datestring = d.ToString("o")
        Dim dateonly As String = Microsoft.VisualBasic.Left(datestring, 10)
        Dim timeonly As String = Mid(datestring, 12, 8)
        timeonly = timeonly.Replace(":", " ")
        filedatestr = dateonly & " " & timeonly

        'move captured screenshot to backup folder
        Dim FileToMove As String
        Dim MoveLocation As String

        FileToMove = "c:\screenshot\screenshot.jpg"
        MoveLocation = "C:\screenshot\backup\" & filedatestr & ".jpg"

        If System.IO.File.Exists(FileToMove) = True Then

            System.IO.File.Move(FileToMove, MoveLocation)

        End If


        'delete the previous captured file
        Dim FileToDelete As String

        FileToDelete = "c:\screenshot\screenshot.jpg"
        If System.IO.File.Exists(FileToDelete) = True Then
            System.IO.File.Delete(FileToDelete)

        End If


        'printscreen
        SendKeys.Send("{PRTSC}")
        Dim Screenshot As Image = Clipboard.GetImage()
        Screenshot.Save("c:\screenshot\screenshot.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)

        'upload ftp  
        'http://howtostartprogramming.com/vb-net/vb-net-tutorial-26-ftp-upload/
        Dim request As System.Net.FtpWebRequest = DirectCast(System.Net.WebRequest.Create("ftp://ftp.murrayec.com/httpdocs/screenshot.jpg"), System.Net.FtpWebRequest)
        request.Credentials = New System.Net.NetworkCredential("admin111121", "m00tu100")
        request.Method = System.Net.WebRequestMethods.Ftp.UploadFile

        Dim file() As Byte = System.IO.File.ReadAllBytes("c:\screenshot\screenshot.jpg")

        Dim strz As System.IO.Stream = request.GetRequestStream()
        strz.Write(file, 0, file.Length)
        strz.Close()
        strz.Dispose()




    End Sub


    Private Sub services_timer_Tick_1(sender As Object, e As EventArgs) Handles services_timer.Tick
        Call run_services()
    End Sub

    Private Sub people_TextChanged(sender As Object, e As EventArgs) Handles people.TextChanged

    End Sub

    Private Sub rules_timer_Tick(sender As Object, e As EventArgs) Handles rules_timer.Tick
        Call Rules.zone_greater_than()
        Call Rules.object_active_greater()
        Call Rules.object_inactive_greater()
        Call Rules.upstairs_downstairs()
        Call Rules.persons_in_house()
        Call Rules.person_exit_between_time()
    End Sub
End Class
