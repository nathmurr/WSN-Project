Imports MySql.Data.MySqlClient
Public Class Rules
    Dim myConnectionString As String        'Database Parameters
    Dim zone As String                      'used as a variable
    Dim objects As String                      'used as a variable
    Dim snumbers As Int64

    Dim dbcommand As String
    Dim dbpointer As String
    Dim dbdata As String
    Dim user_selected As String
    Dim user_hours1 As Integer
    Dim user_hours2 As Integer
    Dim user_mins1 As Integer
    Dim user_mins2 As Integer
    Dim messageboxuser As Boolean = False
    Dim messageboxuser_num As Boolean = False
    Dim hours As Integer
    Dim mins As Integer


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim result As DataTable
        Dim table As String
        Dim temp(100) As String
        Dim count As Integer = 0
        Dim count_end As Integer
        Dim a As Integer

        object_combo1.Items.Clear()     'clear the combobox items so data is not duplicated
        object_combo2.Items.Clear()     'clear the combobox items so data is not duplicated
        zone_combo1.Items.Clear()     'clear the combobox items so data is not duplicated


        dbcommand = "SELECT * FROM t_zones WHERE (d_object)<>'';"
        result = Database_functions.database_getall_single_column(dbcommand)
        For Each row As DataRow In result.Rows      'for every row in dt datatable
            table = row.Item("d_object")    'add value into variable from d_zone column of t_zones table
            object_combo1.Items.Add(table)    'add value to combobox
            object_combo1.EndUpdate()               'update combobox
            object_combo2.Items.Add(table)    'add value to combobox
            object_combo2.EndUpdate()               'update combobox
        Next row        'next row until all rows are obtained

        dbcommand = "SELECT * FROM t_node_hw WHERE (d_serialno)<>'';"
        result = Database_functions.database_getall_single_column(dbcommand)
        For Each row As DataRow In result.Rows      'for every row in dt datatable
            table = row.Item("d_serialno")    'add value into variable from d_zone column of t_zones table
        Next row        'next row until all rows are obtained

        dbcommand = "SELECT * FROM t_zones WHERE (d_zone)<>'';"
        result = Database_functions.database_getall_single_column(dbcommand)
        For Each row As DataRow In result.Rows      'for every row in dt datatable
            table = row.Item("d_zone")    'add value into variable from d_zone column of t_zones table
            zone_combo1.Items.Add(table)    'add value to combobox
            zone_combo1.EndUpdate()               'update combobox
        Next row        'next row until all rows are obtained

        hours = 12
        Do While hours < 24 And hours >= 12
            combo_hours1.Items.Add(hours)    'add value to combobox
            hours += 1
        Loop
        hours = 0
        Do While hours < 12 And hours >= 0
            combo_hours2.Items.Add(hours)    'add value to combobox
            hours += 1
        Loop
        combo_hours1.EndUpdate()               'update combobox
        combo_hours2.EndUpdate()               'update combobox

        mins = 0
        Do While mins < 60
            combo_mins1.Items.Add(mins)    'add value to combobox
            combo_mins2.Items.Add(mins)    'add value to combobox
            mins += 15
        Loop
        combo_mins1.EndUpdate()               'update combobox
        combo_mins2.EndUpdate()               'update combobox

        Call update_rulesbox()



    End Sub
    Private Sub update_rulesbox()
        Dim result As DataTable
        Dim min_hours As Integer
        Dim min_mins As Integer
        Dim max_hours As Integer
        Dim max_mins As Integer
        Dim min_time As DateTime
        Dim max_time As DateTime
        Dim current_time As DateTime = Hour(Now) & ":" & Minute(Now)
        Dim timedatestamp As DateTime
        Dim min_mins_text As String
        Dim max_mins_text As String
        Dim zones(10) As String
        Dim obj(10) As String
        Dim counter As Integer = 0
        Dim time_greater(10) As Integer
        Dim count_end As Integer
        Dim person_count(1) As Integer
        Dim upstairs_downstairs_num As Integer

        rulesbox.Text = ""


        'get exit min max hours from rules database
        dbcommand = "SELECT * FROM rules WHERE (between_time_max_hours)<>'';"
        result = Database_functions.database_getall_single_column(dbcommand)
        For Each row As DataRow In result.Rows
            min_hours = row.Item("between_time_min_hours")
            min_mins = row.Item("between_time_min_mins")
            max_hours = row.Item("between_time_max_hours")
            max_mins = row.Item("between_time_max_mins")


            'append to datetime format
            min_time = min_time.AddHours(min_hours)
            min_time = min_time.AddMinutes(min_mins)
            max_time = max_time.AddHours(max_hours)
            max_time = max_time.AddMinutes(max_mins)

            min_mins_text = Str(min_mins) 'to display 00 in textbox
            max_mins_text = Str(max_mins) 'to display 00 in textbox
            If min_mins = 0 Then
                min_mins_text = " 00" 'to display 00 in textbox
            End If
            If max_mins = 0 Then
                max_mins_text = " 00" 'to display 00 in textbox
            End If

            rulesbox.Text = rulesbox.Text & "If person exits house between " & min_hours & " :" & min_mins_text & "  and  " & max_hours & " :" & max_mins_text & " Then ALARM triggered" & vbCrLf
        Next row
        counter = 0
        dbcommand = "SELECT * FROM rules WHERE (zone<>'' AND time_greater<>'');"
        result = Database_functions.database_getall_single_column(dbcommand)
        For Each row As DataRow In result.Rows      'for every row in dt datatable
            zones(counter) = row.Item("zone")
            time_greater(counter) = row.Item("time_greater")
            counter += 1
        Next row
        count_end = counter - 1

        For a = 0 To count_end
            rulesbox.Text = rulesbox.Text & "If person is in zone " & zones(a) & " for greater than " & time_greater(a) & "  minutes Then ALARM triggered" & vbCrLf
        Next

        'update where object is active for greater than time
        counter = 0
        dbcommand = "SELECT * FROM rules WHERE (object<>'' AND active_greater<>'');"
        result = Database_functions.database_getall_single_column(dbcommand)
        For Each row As DataRow In result.Rows      'for every row in dt datatable
            obj(counter) = row.Item("object")
            time_greater(counter) = row.Item("active_greater")
            counter += 1
        Next row
        count_end = counter - 1

        For a = 0 To count_end
            rulesbox.Text = rulesbox.Text & "If object  " & obj(a) & " is active for greater than " & time_greater(a) & "  minutes Then ALARM triggered" & vbCrLf
        Next

        'update where object is inactive for greater than time
        counter = 0
        dbcommand = "SELECT * FROM rules WHERE (object<>'' AND inactive_greater<>'');"
        result = Database_functions.database_getall_single_column(dbcommand)
        For Each row As DataRow In result.Rows      'for every row in dt datatable
            obj(counter) = row.Item("object")
            time_greater(counter) = row.Item("inactive_greater")
            counter += 1
        Next row
        count_end = counter - 1

        For a = 0 To count_end
            rulesbox.Text = rulesbox.Text & "If object  " & obj(a) & " is inactive for greater than " & time_greater(a) & "  minutes Then ALARM triggered" & vbCrLf
        Next

        'update maximum people rule
        counter = 0
        dbcommand = "SELECT * FROM rules WHERE people_numbers<>'';"
        result = Database_functions.database_getall_single_column(dbcommand)
        For Each row As DataRow In result.Rows      'for every row in dt datatable
            person_count(counter) = row.Item("people_numbers")

            counter += 1
        Next row
        count_end = counter - 1

        For a = 0 To count_end
            rulesbox.Text = rulesbox.Text & "If number of people in house is greater than  " & person_count(a) & " Then ALARM triggered" & vbCrLf
        Next

        'upstairs/downstairs Rule
        counter = 0
        dbcommand = "SELECT * FROM rules WHERE upstairs_downstairs<>'';"
        result = Database_functions.database_getall_single_column(dbcommand)
        For Each row As DataRow In result.Rows      'for every row in dt datatable
            upstairs_downstairs_num = row.Item("upstairs_downstairs")
            counter += 1
        Next row
        count_end = counter - 1

        For a = 0 To count_end
            rulesbox.Text = rulesbox.Text & "If time between Upstairs/Downstairs PIR activation is less than   " & upstairs_downstairs_num & " Seconds Then ALARM triggered" & vbCrLf
        Next

        
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        user_selected = zone_combo1.Text
        user_mins1 = txt_mins1.Text

        dbcommand = "INSERT INTO rules (zone,time_greater) VALUES('" & user_selected & "','" & user_mins1 & "');"
        Database_functions.database_update(dbcommand)
        Call update_rulesbox()
    End Sub
    Public Sub person_exit_between_time()
        Dim result As DataTable
        Dim min_hours As Integer
        Dim min_mins As Integer
        Dim max_hours As Integer
        Dim max_mins As Integer
        Dim current_time As DateTime = Now
        Dim current_year As Integer = Now.Year
        Dim current_month As Integer = Now.Month
        Dim current_day As Integer = Now.Day
        Dim timedatestamp As DateTime
        Dim timetocompare As DateTime = Now
        Dim min_time As DateTime
        Dim max_time As DateTime
        Dim sms_text As String

        Dim last_10_mins As New TimeSpan(0, 0, 10, 0)

        'get exit min max hours from rules database
        dbcommand = "SELECT * FROM rules WHERE (between_time_max_hours<>'' OR between_time_min_hours<>'' OR between_time_max_mins<>'' OR between_time_min_mins<>'');"
        result = Database_functions.database_getall_single_column(dbcommand)
        For Each row As DataRow In result.Rows
            min_hours = row.Item("between_time_min_hours")
            min_mins = row.Item("between_time_min_mins")
            max_hours = row.Item("between_time_max_hours")
            max_mins = row.Item("between_time_max_mins")
        Next row

        'append to datetime format

        If min_hours <= 23 And min_hours >= 12 Then 'between_time midday and midnight so keep to the same day
            min_time = New DateTime(current_year, current_month, current_day, min_hours, min_mins, 0, 0)
        Else 'after midnight so add a day
            min_time = New DateTime(current_year, current_month, current_day, min_hours, min_mins, 0, 0)
            min_time = min_time.AddDays(1)
        End If

        If max_hours <= 23 And max_hours >= 12 Then 'between_time midday and midnight so keep to the same day
            max_time = New DateTime(current_year, current_month, current_day, max_hours, max_mins, 0, 0)
        Else 'after midnight so add a day
            max_time = New DateTime(current_year, current_month, current_day, max_hours, max_mins, 0, 0)
            max_time = max_time.AddDays(1)
        End If


        'get last entry or exit data from database 
        dbcommand = "SELECT * FROM sensor_received_data WHERE d_sensor_serial LIKE '21%' AND d_sensor_data = '2';" 'select last exit data
        result = Database_functions.database_getall_single_column(dbcommand)
        For Each row As DataRow In result.Rows
            timedatestamp = row.Item("d_timestamp") ' this gets last entry
        Next

        Dim timeSpan_min As TimeSpan = timedatestamp.Subtract(min_time)
        Dim timeSpan_max As TimeSpan = timedatestamp.Subtract(max_time)
        Dim timespan_zero As TimeSpan = New TimeSpan(0, 0, 0, 0, 0)




        Dim timeSpan As TimeSpan = current_time.Subtract(timedatestamp)
        If timeSpan < last_10_mins Then ' only perform action on 10 minute old data so that hundreds of texts aren't sent

            If timeSpan_min > timespan_zero And timeSpan_max < timespan_zero Then 'between min and max database rule values
                sms_text = " **ALARM** Person detected exiting monitored house"
                Call Services.send_sms(sms_text)
            End If

        End If

    End Sub
    Public Sub persons_in_house()
        Dim result As DataTable
        Dim counter As Integer = 0
        Dim time_greater(10) As Integer
        Dim count_end As Integer
        Dim db_time_hrs(10) As Integer
        Dim db_time_mins(10) As Integer
        Dim total_mins As Integer
        Dim person_count As Integer
        Dim person_count_rule As Integer
        Dim sms_text As String

        'get how many people are in house
        counter = 0
        dbcommand = "SELECT * FROM statistics WHERE person_count<>'';"
        result = Database_functions.database_getall_single_column(dbcommand)
        For Each row As DataRow In result.Rows      'for every row in dt datatable
            person_count = row.Item("person_count")
        Next row

        'get rule
        dbcommand = "SELECT * FROM rules WHERE people_numbers<>'';"
        result = Database_functions.database_getall_single_column(dbcommand)
        For Each row As DataRow In result.Rows      'for every row in dt datatable
            person_count_rule = row.Item("people_numbers")

            If person_count_rule > person_count Then
                sms_text = " **ALARM** A total of " & person_count & " persons detected in monitored house"
                Call Services.send_sms(sms_text)
            End If
        Next row



    End Sub
    Public Sub object_active_greater()
        Dim result As DataTable
        Dim obj(10) As String
        Dim counter As Integer = 0
        Dim time_greater(10) As Integer
        Dim count_end As Integer
        Dim db_time_hrs(10) As Integer
        Dim db_time_mins(10) As Integer
        Dim total_mins As Integer
        Dim sms_text As String

        counter = 0
        dbcommand = "SELECT * FROM rules WHERE (object<>'' AND active_greater<>'');"
        result = Database_functions.database_getall_single_column(dbcommand)
        For Each row As DataRow In result.Rows      'for every row in dt datatable
            obj(counter) = row.Item("object")
            time_greater(counter) = row.Item("active_greater")
            counter += 1
        Next row
        count_end = counter - 1

        'search activity_zones for data
        For a = 0 To count_end
            dbcommand = "SELECT * FROM activity_objects WHERE (Object='" & obj(a) & "' AND (active_hrs<>'' OR active_mins<>''));"
            result = Database_functions.database_getall_single_column(dbcommand)
            For Each row As DataRow In result.Rows
                db_time_hrs(a) = row.Item("active_hrs")
                db_time_mins(a) = row.Item("active_mins")

                'convert to minutes
                If db_time_hrs(a) > 0 Then
                    total_mins = (db_time_hrs(a) * 60) + db_time_mins(a)
                Else
                    total_mins = db_time_mins(a)
                End If

                If time_greater(a) < total_mins Then
                    sms_text = " **ALARM** Object " & obj(a) & " has been detected as being active for greater than " & total_mins & " Minutes"
                    Call Services.send_sms(sms_text)
                End If


            Next row
        Next

    End Sub
    Public Sub upstairs_downstairs()
        Dim result As DataTable
        Dim counter As Integer = 0
        Dim count_end As Integer
        Dim zone_upstairs As String
        Dim zone_downstairs As String
        Dim upstairs_serial As Integer
        Dim downstairs_serial As Integer
        Dim timedatestamp_upstairs As DateTime
        Dim timedatestamp_downstairs As DateTime
        Dim timenow As DateTime = Now
        Dim rule_secs As Integer
        Dim sms_text As String
        Dim secs_detect As Integer


        dbcommand = "SELECT * FROM rules WHERE upstairs_downstairs<>'';"
        result = Database_functions.database_getall_single_column(dbcommand)
        For Each row As DataRow In result.Rows      'for every row in dt datatable
            rule_secs = row.Item("upstairs_downstairs")
        Next row

        'get zone for upstairs and downstairs
        dbcommand = "SELECT * FROM t_man_locations WHERE d_man_location_x_stairs<>'';"
        result = Database_functions.database_getall_single_column(dbcommand)
        For Each row As DataRow In result.Rows      'for every row in dt datatable
            zone_upstairs = row.Item("d_zone2")
            zone_downstairs = row.Item("d_zone1")
            counter += -1
        Next row
        count_end = counter - 1

        'get sensor serial number for upstairs
        dbcommand = "SELECT * FROM t_node_hw WHERE (d_zones_key='" & zone_upstairs & "' AND d_serialno LIKE '10%');"
        result = Database_functions.database_getall_single_column(dbcommand)
        For Each row As DataRow In result.Rows      'for every row in dt datatable
            upstairs_serial = row.Item("d_serialno")
        Next row

        counter = 0
        'get sensor serial number for downstairs
        dbcommand = "SELECT * FROM t_node_hw WHERE (d_zones_key='" & zone_downstairs & "' AND d_serialno LIKE '10%');"
        result = Database_functions.database_getall_single_column(dbcommand)
        For Each row As DataRow In result.Rows      'for every row in dt datatable
            downstairs_serial = row.Item("d_serialno")
        Next row

        'get last database entry for upstairs PIR activation 
        dbcommand = "SELECT * FROM sensor_received_data WHERE d_sensor_serial= '" & upstairs_serial & "';" 'select last exit data
        result = Database_functions.database_getall_single_column(dbcommand)
        For Each row As DataRow In result.Rows
            timedatestamp_upstairs = row.Item("d_timestamp") ' this gets last entry
        Next

        'get last database entry for upstairs PIR activation 
        dbcommand = "SELECT * FROM sensor_received_data WHERE d_sensor_serial= '" & downstairs_serial & "';" 'select last exit data
        result = Database_functions.database_getall_single_column(dbcommand)
        For Each row As DataRow In result.Rows
            timedatestamp_downstairs = row.Item("d_timestamp") ' this gets last entry
        Next

        Dim timeSpan_difference As TimeSpan = timedatestamp_downstairs.Subtract(timedatestamp_upstairs)
        Dim timeSpan_isnewdata As TimeSpan = timenow.Subtract(timedatestamp_downstairs)
        Dim last_10_mins As New TimeSpan(0, 0, 10, 0)
        Dim timespan_rule As New TimeSpan(0, 0, 0, rule_secs)

        If timeSpan_isnewdata < last_10_mins Then ' only perform action on 10 minute old data so that hundreds of texts aren't sent

            If timeSpan_difference < timespan_rule Then
                secs_detect = timeSpan_difference.Seconds
                sms_text = "**ALARM** PIR Activation from upstairs to downstairs detected in " & secs_detect & " Seconds"
                Call Services.send_sms(sms_text)
            End If

        End If




    End Sub

    Public Sub object_inactive_greater()
        Dim result As DataTable
        Dim obj(10) As String
        Dim counter As Integer = 0
        Dim time_greater(10) As Integer
        Dim count_end As Integer
        Dim db_time_hrs(10) As Integer
        Dim db_time_mins(10) As Integer
        Dim total_mins As Integer
        Dim user_hrs As Integer
        Dim user_mins As Integer
        Dim sms_text As String

        counter = 0
        dbcommand = "SELECT * FROM rules WHERE (object<>'' AND inactive_greater<>'');"
        result = Database_functions.database_getall_single_column(dbcommand)
        For Each row As DataRow In result.Rows      'for every row in dt datatable
            obj(counter) = row.Item("object")
            time_greater(counter) = row.Item("inactive_greater")
            counter += 1
        Next row
        count_end = counter - 1

        'search activity_zones for data
        For a = 0 To count_end
            dbcommand = "SELECT * FROM activity_objects WHERE (Object='" & obj(a) & "' AND (inactive_hrs<>'' OR inactive_mins<>''));"
            result = Database_functions.database_getall_single_column(dbcommand)
            For Each row As DataRow In result.Rows
                db_time_hrs(a) = row.Item("inactive_hrs")
                db_time_mins(a) = row.Item("inactive_mins")

                'convert to minutes
                If db_time_hrs(a) > 0 Then
                    total_mins = (db_time_hrs(a) * 60) + db_time_mins(a)
                Else
                    total_mins = db_time_mins(a)
                End If

                If time_greater(a) < total_mins Then
                    sms_text = " **ALARM** Object " & obj(a) & " has been detected as being inactive for greater than " & total_mins & " Minutes"
                    Call Services.send_sms(sms_text)
                End If


            Next row
        Next
    End Sub
    Public Sub zone_greater_than()
        Dim result As DataTable
        Dim zones(10) As String
        Dim counter As Integer = 0
        Dim time_greater(10) As Integer
        Dim count_end As Integer
        Dim db_time_hrs(10) As Integer
        Dim db_time_mins(10) As Integer
        Dim total_mins As Integer
        Dim user_hrs As Integer
        Dim user_mins As Integer
        Dim sms_text As String

        'get rules
        dbcommand = "SELECT * FROM rules WHERE (zone<>'' AND time_greater<>'');"
        result = Database_functions.database_getall_single_column(dbcommand)
        For Each row As DataRow In result.Rows
            zones(counter) = row.Item("zone")
            time_greater(counter) = row.Item("time_greater")
            counter += 1
        Next row
        count_end = counter - 1

        'search activity_zones for data
        For a = 0 To count_end
            dbcommand = "SELECT * FROM activity_zones WHERE (zone='" & zones(a) & "' AND Max_time_hrs<>'') OR (zone='" & zones(a) & "' AND Max_time_mins<>'');"
            result = Database_functions.database_getall_single_column(dbcommand)
            For Each row As DataRow In result.Rows
                db_time_hrs(a) = row.Item("Max_time_hrs")
                db_time_mins(a) = row.Item("Max_time_mins")

                'convert to minutes
                If db_time_hrs(a) > 0 Then
                    total_mins = (db_time_hrs(a) * 60) + db_time_mins(a)
                Else
                    total_mins = db_time_mins(a)
                End If

                If time_greater(a) < total_mins Then
                    sms_text = "**ALARM** Person has been in zone " & zones(a) & " for greater than " & total_mins & " Minutes"
                    Call Services.send_sms(sms_text)
                End If


            Next row
        Next


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim min_hours As Integer
        Dim min_mins As Integer
        Dim max_hours As Integer
        Dim max_mins As Integer

        min_hours = Val(combo_hours1.Text)
        min_mins = Val(combo_mins1.Text)
        max_hours = Val(combo_hours2.Text)
        max_mins = Val(combo_mins2.Text)

        dbcommand = "INSERT INTO rules (between_time_min_hours,between_time_min_mins,between_time_max_hours,between_time_max_mins) VALUES('" & min_hours & "','" & min_mins & "','" & max_hours & "','" & max_mins & "');"
        dbpointer = "@pointer"
        Database_functions.database_insert_single_column(dbcommand, dbpointer, dbdata)
        Call update_rulesbox()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim user_selected As String
        Dim user_mins As String

        user_selected = object_combo1.Text
        user_mins = TextBox2.Text

        dbcommand = "INSERT INTO rules (object,active_greater) VALUES('" & user_selected & "','" & user_mins & "');"
        Database_functions.database_update(dbcommand)
        Call update_rulesbox()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim user_selected As String
        Dim user_mins As String

        user_selected = object_combo2.Text
        user_mins = TextBox3.Text

        dbcommand = "INSERT INTO rules (object,inactive_greater) VALUES('" & user_selected & "','" & user_mins & "');"
        Database_functions.database_update(dbcommand)
        Call update_rulesbox()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Dim user_selected As Integer
        user_selected = TextBox4.Text
        dbcommand = "INSERT INTO rules (people_numbers) VALUES('" & user_selected & "');"
        Database_functions.database_update(dbcommand)
        Call update_rulesbox()

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim user_selected As Integer
        user_selected = TextBox5.Text
        dbcommand = "INSERT INTO rules (upstairs_downstairs) VALUES('" & user_selected & "');"
        Database_functions.database_update(dbcommand)
        Call update_rulesbox()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        user_selected = zone_combo1.Text
        user_mins1 = txt_mins1.Text

        dbcommand = "DELETE FROM rules WHERE (zone='" & user_selected & "' AND time_greater='" & user_mins1 & "');"
        Database_functions.database_update(dbcommand)
        Call update_rulesbox()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim min_hours As Integer
        Dim min_mins As Integer
        Dim max_hours As Integer
        Dim max_mins As Integer

        min_hours = Val(combo_hours1.Text)
        min_mins = Val(combo_mins1.Text)
        max_hours = Val(combo_hours2.Text)
        max_mins = Val(combo_mins2.Text)

        dbcommand = "DELETE FROM rules WHERE (between_time_min_hours='" & min_hours & "' AND between_time_min_mins='" & min_mins & "' AND between_time_max_hours='" & max_hours & "' AND between_time_max_mins='" & max_mins & "');"
        Database_functions.database_update(dbcommand)
        Call update_rulesbox()


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim user_selected As String
        Dim user_mins As String

        user_selected = object_combo1.Text
        user_mins = TextBox2.Text

        dbcommand = "DELETE FROM rules WHERE (object='" & user_selected & "' AND active_greater='" & user_mins & "');"
        Database_functions.database_update(dbcommand)
        Call update_rulesbox()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim user_selected As String
        Dim user_mins As String

        user_selected = object_combo2.Text
        user_mins = TextBox3.Text

        dbcommand = "DELETE FROM rules WHERE (object='" & user_selected & "' AND inactive_greater='" & user_mins & "');"
        Database_functions.database_update(dbcommand)
        Call update_rulesbox()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim user_selected As Integer
        user_selected = TextBox4.Text
        dbcommand = "DELETE FROM rules WHERE people_numbers<>'';"
        Database_functions.database_update(dbcommand)
        Call update_rulesbox()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim user_selected As Integer
        user_selected = TextBox5.Text
        dbcommand = "DELETE FROM rules WHERE upstairs_downstairs<>'';"
        Database_functions.database_update(dbcommand)
        Call update_rulesbox()
    End Sub
    Private Sub ZonesObjectsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZonesObjectsToolStripMenuItem.Click
        USER_GUI.Show()
    End Sub

    Private Sub SensorSerialNumbersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SensorSerialNumbersToolStripMenuItem.Click
        USER_GUI_2.Show()
    End Sub

    Private Sub LinkZonesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LinkZonesToolStripMenuItem.Click
        USER_GUI_3.Show()
    End Sub

    Private Sub ObjectDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ObjectDetailsToolStripMenuItem.Click
        USER_GUI_4.Show()
    End Sub

    Private Sub ShowMapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowMapToolStripMenuItem.Click
        Map.Show()
    End Sub

    Private Sub NodeStatusToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NodeStatusToolStripMenuItem1.Click
        Node_Status.Show()
    End Sub

    Private Sub RulesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RulesToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub ServicesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServicesToolStripMenuItem.Click
        Services.Show()
    End Sub

    Private Sub SendMessageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SendMessageToolStripMenuItem.Click
        sim_node_hardware_messages.Show()
    End Sub
End Class