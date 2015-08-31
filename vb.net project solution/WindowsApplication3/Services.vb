Imports MySql.Data.MySqlClient
Imports MScience.Sms


Public Class Services
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

    Dim tr_timestamp As DateTime
    Dim temp_timestamp As DateTime
    Dim tr_ms, tr_sensdata, tr_serial As Integer
    Dim newlistview_flag As Integer = 0

    Private Sub Services_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim counter As Integer = 1
        'Map.Show()

        'Call Service_all_onoff()
        'Call service_PIR_sensor()
        'Call service_electricity_usage()
        'Call service_ambient_sensors()
        Call update_service_combo()
        Call service_activity()
        'Call Service_zone_time_algorithm()
        'Call send_sms()
        'Call service_person_count()
        combo_onoff.Items.Add("off")    'add value to combobox
        combo_onoff.Items.Add("on")    'add value to combobox
        combo_onoff.EndUpdate()               'update combobox
        'Call printscreen()
        'Call ftp()

    End Sub
    Public Sub send_sms(sendtext As String)
        ' Dim client As New SmsClient()
        ' client.AccountId = "47133"
        ' client.Password = "m00tu100"

        'Dim sendResult As SendResult = client.Send("+447788880788", "+441234567890", "Test", 0, False)

        'Console.WriteLine(sendResult.Code)

        'If (sendResult.HasError) Then
        'Console.WriteLine(SendResult.ErrorMessage)
        'Else
        'Console.WriteLine("Message Id {0}", SendResult.MessageId)
        'Console.WriteLine("Balance {0}", SendResult.MessageBalance)
        'Console.WriteLine("Pending : {0}", SendResult.PendingMessages)
        'Console.WriteLine("Surcharge : {0}", SendResult.SurchargeBalance)

        'Dim status As StatusResult()
        'status = client.GetMessageStatus({SendResult.MessageId})
        'Console.WriteLine("Message Status Code = {0}, Status = {1}",
        '                  status.First().Code, status.First().Status)
        'End If

        'Dim deliveryReceipts As InboundMessageResult()
        'deliveryReceipts = client.GetDeliveryReceipts()

        'If (deliveryReceipts.Length > 0) Then
        'Console.WriteLine("Delivery Receipts:")
        'End If

        'For Each deliveryReceipt As InboundMessageResult In deliveryReceipts
        'Console.WriteLine(deliveryReceipt.Text)
        'Next
    End Sub
    
    Public Sub service_zone_time_algorithm()
        Dim result As DataTable
        Dim counter As Integer = 1
        Dim serial(10000) As Integer
        Dim serial_same(10000) As Integer
        Dim counter_end As Integer
        Dim d_zones(10000) As String
        Dim d_timestamp(10000) As String
        Dim timestamp_new As String
        Dim timestamp_old As String
        Dim count_found As Integer = 0
        Dim tr_timestamp As DateTime
        Dim temp_timestamp As DateTime
        Dim tr_ms, tr_sensdata, tr_serial As Integer


        'Get each motion serial number
        'get all serial numbers from received data store in serial(counter)
        dbcommand = "SELECT * FROM sensor_received_data WHERE d_sensor_serial LIKE '10%';"
        result = Database_functions.database_getall_single_column(dbcommand)
        For Each row As DataRow In result.Rows      'for every row in dt datatable
            serial(counter) = row.Item("d_sensor_serial")    'add value into variable from d_zone column of t_zones table
            d_timestamp(counter) = row.Item("d_timestamp")

            counter += 1
        Next row
        counter_end = counter

        'get all zones related to captured serial number
        For a = 0 To counter_end
            dbcommand = "SELECT * FROM t_node_hw WHERE d_serialno='" & serial(a) & "';"
            result = Database_functions.database_getall_single_column(dbcommand)
            For Each row As DataRow In result.Rows      'for every row in dt datatable

                d_zones(a) = row.Item("d_zones_key")    'add value into variable from d_zone column of t_zones table
                counter += 1
            Next row
        Next


        For a = 1 To counter_end
            If serial(a) = serial(a - 1) Then
                count_found += 1
            Else
                count_found = 0
            End If

            If count_found > 0 Then
                timestamp_new = d_timestamp(a)    'get current timestamp
                timestamp_old = d_timestamp(a - count_found) ' get old timestamp

                Dim temp_dateandtime As DateTime = timestamp_new
                Dim temp_dateandtime_old As DateTime = timestamp_old

                Dim timeSpan As TimeSpan = temp_dateandtime.Subtract(temp_dateandtime_old)
                Dim difDays As Integer = timeSpan.Days
                Dim difHr As Integer = timeSpan.Hours
                Dim difMin As Integer = timeSpan.Minutes



                ' difHr *= 2
                ' difMin *= 2
                ' If difMin > 59 Then  'if mins is greater than 60 then add 1 to hrs and deduct 60 from mins
                ' difHr += 1
                ' difMin -= 60
                'End If

                dbcommand = "UPDATE activity_zones SET Max_time_hrs='" & difHr & "' WHERE Zone='" & d_zones(a) & "';"
                dbpointer = "@pointer"
                Database_functions.database_insert_single_column(dbcommand, dbpointer, difHr)

                dbcommand = "UPDATE activity_zones SET Max_time_mins='" & difMin & "' WHERE Zone='" & d_zones(a) & "';"
                dbpointer = "@pointer"
                Database_functions.database_insert_single_column(dbcommand, dbpointer, difMin)



            End If
        Next
    End Sub

    Public Sub service_activity()
        Dim result As DataTable
        Dim data(3000) As Integer
        Dim counter As Integer = 0
        Dim serial_str(5) As String
        Dim d_object_codename1 As String
        Dim d_object_codename2 As String
        Dim d_object_location_x As Integer
        Dim d_object_location_y As Integer
        Dim dateandtime As String
        Dim dateandtime2 As String
        Dim dateandtime_old As String
        Dim object_name As String
        Dim unique_serials(100) As Integer
        Dim unique_counter As Integer = 0
        Dim a As Integer
        Dim count As Integer = 0
        Dim sensor_data As Integer
        Dim sensor_data_old As Integer
        Dim sensor_number(20) As String
        Dim label_count As Integer = 1
        Dim timestamp_str As String
        Dim tr_timestamp As DateTime
        Dim tr_ms, tr_sensdata, tr_serial As Integer

        sensor_number = {"11", "15", "17", "22", "23", "29", "end"}


        'all on off sensors
        '11 Hall sensors
        '15 accelerometer/gyro
        '17 FSR
        '22 light on off
        '23 temperature on/off
        '29 noise on/off


        While sensor_number(count) <> "end"

            dbcommand = "SELECT * FROM sensor_received_data WHERE d_sensor_serial LIKE '" & sensor_number(count) & "%' ORDER BY d_sensor_serial;"
            result = Database_functions.database_getall_single_column(dbcommand)
            For Each row As DataRow In result.Rows      'for every row in dt datatable
                data(counter) = row.Item("d_sensor_serial")    'add value into variable from d_zone column of t_zones table
                'tr_timestamp = row.Item("d_timestamp")
                'tr_serial = row.Item("d_sensor_serial")
                'tr_sensdata = row.Item("d_sensor_data")
                'tr_ms = row.Item("d_milliseconds")
                'Database_functions.transfer_received_data(temp_timestamp, tr_serial, tr_sensdata, tr_ms)


                If counter > 0 Then
                    If data(counter) <> unique_serials(unique_counter - 1) Then
                        unique_serials(unique_counter) = data(counter)
                        unique_counter += 1
                    End If
                ElseIf counter = 0 Then
                    unique_serials(unique_counter) = data(counter)
                    unique_counter += 1
                End If
                counter += 1
            Next row        'next row until all rows are obtaine

            counter = 0

            For a = 0 To unique_counter - 1
                dbcommand = "SELECT * FROM t_zones WHERE d_node_serial='" & unique_serials(a) & "';"
                result = Database_functions.database_getall_single_column(dbcommand)

                For Each row As DataRow In result.Rows      'for every row in dt datatable
                    object_name = row.Item("d_object")
                    d_object_codename1 = row.Item("d_object_codename1")
                    d_object_codename2 = row.Item("d_object_codename2")
                    d_object_location_x = row.Item("d_object_location_x")
                    d_object_location_y = row.Item("d_object_location_y")
                Next row        'next row until all rows are obtaine

                'get last data for serial number

                dbcommand = "SELECT * FROM sensor_received_data WHERE d_sensor_serial='" & unique_serials(a) & "' ORDER BY d_timestamp DESC LIMIT 0,1;"
                result = Database_functions.database_getall_single_column(dbcommand)

                For Each row As DataRow In result.Rows      'for every row in dt datatable
                    dateandtime = row.Item("d_timestamp")
                    sensor_data = row.Item("d_sensor_data")

                Next row        'next row until all rows are obtained

                If sensor_data = 1 Then
                    dbcommand = "SELECT * FROM sensor_received_data WHERE d_sensor_serial='" & unique_serials(a) & "' AND d_sensor_data='0' ORDER BY d_timestamp DESC LIMIT 0,1;"
                    result = Database_functions.database_getall_single_column(dbcommand)
                    sensor_data_old = 1
                    For Each row As DataRow In result.Rows      'for every row in dt datatable
                        dateandtime_old = row.Item("d_timestamp")
                        sensor_data_old = row.Item("d_sensor_data")


                    Next row        'next row until all rows are obtained


                    If sensor_data_old = 0 Then
                        Dim temp_dateandtime As DateTime = dateandtime
                        Dim temp_dateandtime2 As DateTime = dateandtime_old

                        Dim timeSpan As TimeSpan = temp_dateandtime.Subtract(dateandtime_old)
                        Dim difDays As Integer = timeSpan.Days   'get 3 days
                        Dim difHr As Integer = timeSpan.Hours    'get 0 hours although 3 days difference
                        Dim difMin As Integer = timeSpan.Minutes 'get 0 minutes although 3 days difference



                        Dim activity_label As New Label

                        activity_label.Name = "lv_ambient_sensors" & (label_count).ToString
                        activity_label.Anchor = AnchorStyles.Top Or AnchorStyles.Left
                        activity_label.Width = 150
                        activity_label.Location = New Point(d_object_location_x, d_object_location_y - 25)
                        activity_label.Text = "Active for " & difDays & " Ds " & difHr & " Hs " & difMin & " Ms"
                        Map.pnl_people.Controls.Add(activity_label)
                        label_count += 1

                        'also update activity database for inactive/active data

                        Dim timeStamp As DateTime = DateTime.Now 'get current datetime
                        timestamp_str = timeStamp.ToString("yyyy-MM-dd HH:mm:ss") ' convert to datetime for mysql format


                        dbcommand = "UPDATE activity_objects SET  active_hrs='" & difHr & "',active_mins='" & difMin & "',timestamp='" & timestamp_str & "'  WHERE (Object='" & object_name & "');"
                        'dbcommand = "INSERT INTO activity_objects (Object,active_hrs,active_mins,timestamp) VALUES('" & object_name & "','" & difHr & "','" & difMin & "','" & timestamp_str & "');"
                        dbpointer = "@pointer"
                        Database_functions.database_insert_single_column(dbcommand, dbpointer, dbdata)

                        'double the time for maximum limit
                        difHr *= 2
                        difMin *= 2
                        If difMin > 59 Then  'if mins is greater than 60 then add 1 to hrs and deduct 60 from mins
                            difHr += 1
                            difMin -= 60
                        End If

                        'also update activity database for max time active or inactive
                        'get current max time for object active for
                        Dim active_hrs As Integer
                        Dim active_mins As Integer
                        dbcommand = "SELECT * FROM activity_objects WHERE Object='" & object_name & "' AND Max_time_active_hrs IS NOT NULL;"
                        result = Database_functions.database_getall_single_column(dbcommand)
                        For Each row As DataRow In result.Rows      'for every row in dt datatable
                            active_hrs = row.Item("Max_time_active_hrs")
                            active_mins = row.Item("Max_time_active_mins")
                        Next row        'next row until all rows are obtained

                        If difHr > active_hrs Then
                            'update the new max time as new hours are greater than the database stored value
                            dbcommand = "UPDATE activity_objects SET Max_time_active_hrs='" & difHr & "',Max_time_active_mins='" & difMin & "'  WHERE (Object='" & object_name & "' AND Max_time_active_hrs IS NOT NULL);"
                            dbpointer = "@pointer"
                            Database_functions.database_insert_single_column(dbcommand, dbpointer, dbdata)

                        ElseIf (difHr = active_hrs) And difMin > active_mins Then
                            'if hours are the same but minutes obtained is greater then also update the database
                            dbcommand = "UPDATE activity_objects SET Max_time_active_hrs='" & difHr & "',Max_time_active_mins='" & difMin & "'  WHERE (Object='" & object_name & "' AND Max_time_active_hrs IS NOT NULL);"
                            dbpointer = "@pointer"
                            Database_functions.database_insert_single_column(dbcommand, dbpointer, dbdata)
                        End If
                    End If
                End If

                If sensor_data = 0 Then
                    dbcommand = "SELECT * FROM sensor_received_data WHERE d_sensor_serial='" & unique_serials(a) & "' AND d_sensor_data='1' ORDER BY d_timestamp DESC LIMIT 0,1;"
                    result = Database_functions.database_getall_single_column(dbcommand)
                    sensor_data_old = 0
                    For Each row As DataRow In result.Rows      'for every row in dt datatable
                        dateandtime_old = row.Item("d_timestamp")
                        sensor_data_old = row.Item("d_sensor_data")


                    Next row        'next row until all rows are obtained

                    If sensor_data_old = 1 Then
                        Dim temp_dateandtime As DateTime = dateandtime
                        Dim temp_dateandtime_old As DateTime = dateandtime_old

                        Dim timeSpan As TimeSpan = temp_dateandtime.Subtract(temp_dateandtime_old)
                        Dim difDays As Integer = timeSpan.Days   'get 3 days
                        Dim difHr As Integer = timeSpan.Hours    'get 0 hours although 3 days difference
                        Dim difMin As Integer = timeSpan.Minutes 'get 0 minutes although 3 days difference



                        Dim activity_label As New Label

                        activity_label.Name = "lv_ambient_sensors" & (label_count).ToString
                        activity_label.Anchor = AnchorStyles.Top Or AnchorStyles.Left
                        activity_label.Width = 150
                        activity_label.Location = New Point(d_object_location_x, d_object_location_y - 25)
                        activity_label.Text = "Inactive for " & difDays & " Ds " & difHr & " Hs " & difMin & " Ms"
                        Map.pnl_people.Controls.Add(activity_label)
                        label_count += 1

                        'also update activity database for inactive/active data
                        Dim timeStamp As DateTime = DateTime.Now 'get current datetime
                        timestamp_str = timeStamp.ToString("yyyy-MM-dd HH:mm:ss") ' convert to datetime for mysql format




                        dbcommand = "UPDATE activity_objects SET inactive_hrs='" & difHr & "',inactive_mins='" & difMin & "',timestamp='" & timestamp_str & "'  WHERE (Object='" & object_name & "');"
                        ' dbcommand = "INSERT INTO activity_objects (Object,inactive_hrs,inactive_mins,timestamp) VALUES('" & object_name & "','" & difHr & "','" & difMin & "','" & timestamp_str & "');"
                        dbpointer = "@pointer"
                        Database_functions.database_insert_single_column(dbcommand, dbpointer, dbdata)

                        timeStamp = DateTime.Now 'get current datetime
                        timestamp_str = timeStamp.ToString("yyyy-MM-dd HH:mm:ss") ' convert to datetime for mysql format

                        dbcommand = "UPDATE activity_objects SET  active_hrs='" & difHr & "',active_mins='" & difMin & "',timestamp='" & timestamp_str & "'  WHERE (Object='" & object_name & "');"
                        'dbcommand = "INSERT INTO activity_objects (Object,active_hrs,active_mins,timestamp) VALUES('" & object_name & "','" & difHr & "','" & difMin & "','" & timestamp_str & "');"
                        dbpointer = "@pointer"
                        Database_functions.database_insert_single_column(dbcommand, dbpointer, dbdata)

                        'double the time for maximum limit
                        difHr *= 2
                        difMin *= 2
                        If difMin > 59 Then  'if mins is greater than 60 then add 1 to hrs and deduct 60 from mins
                            difHr += 1
                            difMin -= 60
                        End If

                        'also update activity database for max time active or inactive
                        'get current max time for object active for
                        Dim inactive_hrs As Integer
                        Dim inactive_mins As Integer
                        dbcommand = "SELECT * FROM activity_objects WHERE Object='" & object_name & "' AND Max_time_active_hrs IS NOT NULL;"
                        result = Database_functions.database_getall_single_column(dbcommand)
                        For Each row As DataRow In result.Rows      'for every row in dt datatable
                            inactive_hrs = row.Item("Max_time_inactive_hrs")
                            inactive_mins = row.Item("Max_time_inactive_mins")
                        Next row        'next row until all rows are obtained

                        If difHr > inactive_hrs Then
                            'update the new max time as new hours are greater than the database stored value
                            dbcommand = "UPDATE activity_objects SET Max_time_inactive_hrs='" & difHr & "',Max_time_inactive_mins='" & difMin & "'  WHERE (Object='" & object_name & "' AND Max_time_active_hrs IS NOT NULL);"
                            dbpointer = "@pointer"
                            Database_functions.database_insert_single_column(dbcommand, dbpointer, dbdata)

                        ElseIf (difHr = inactive_hrs) And difMin > inactive_mins Then
                            'if hours are the same but minutes obtained is greater then also update the database
                            dbcommand = "UPDATE activity_objects SET Max_time_inactive_hrs='" & difHr & "',Max_time_inactive_mins='" & difMin & "'  WHERE (Object='" & object_name & "' AND Max_time_active_hrs IS NOT NULL);"
                            dbpointer = "@pointer"
                            Database_functions.database_insert_single_column(dbcommand, dbpointer, dbdata)
                        End If

                    End If
                End If

                Map.lv_messages.Items.Add(dateandtime & ", Object = " & object_name & ", Data = " & sensor_data)    'add value to combobox
                Map.lv_messages.EndUpdate()               'update combobox
            Next
            count += 1
        End While


    End Sub

    'WORKING
    Public Sub service_person_count()
        Dim result As DataTable
        Dim data As Integer
        Dim data2 As Integer
        Dim counter As Integer = 0
        Dim serial_str(5) As String
        Dim unique_serials(100) As Integer
        Dim unique_counter As Integer = 0
        Dim timedatestamp As DateTime
        Dim millisecondstamp As Integer
        Dim old_timedatestamp As DateTime
        Dim old_millisecondstamp As Integer
        Dim timestamp_str As String
        Dim old_count As Integer
        Dim tr_timestamp As DateTime
        Dim tr_ms, tr_sensdata, tr_serial As Integer





        'entry data = 1
        'exit data = 2

        'get last entry or exit data from database and also last entry exit saved in database
        dbcommand = "SELECT * FROM sensor_received_data WHERE d_sensor_serial LIKE '21%'" 'select all entry exit
        result = Database_functions.database_getall_single_column(dbcommand)
        For Each row As DataRow In result.Rows      'for every row in dt datatable
            data = row.Item("d_sensor_data")    'add value into variable from d_zone column of t_zones table
            timedatestamp = row.Item("d_timestamp")
            millisecondstamp = row.Item("d_milliseconds")
            ' old_timedatestamp = row.Item("d_person_entexit_datetime")
            'old_millisecondstamp = row.Item("d_person_entexit_ms")


        Next row
        timestamp_str = timedatestamp.ToString("yyyy-MM-dd HH:mm:ss")
        'GET OLD DATETIMESTAMP IF IT EXISTS
        dbcommand = "SELECT * FROM statistics WHERE person_entexit_datetime<>'';" 'select all entry exit
        result = Database_functions.database_getall_single_column(dbcommand)
        For Each row As DataRow In result.Rows      'for every row in dt datatable
            old_timedatestamp = row.Item("person_entexit_datetime")
            old_millisecondstamp = row.Item("person_entexit_ms")
        Next row

        'if new data
        If (timestamp_str <> old_timedatestamp.ToString) And (millisecondstamp <> old_millisecondstamp) Then
            'get person count from database
            dbcommand = "SELECT person_count FROM statistics;" 'select all entry exit
            result = Database_functions.database_getall_single_column(dbcommand)
            For Each row As DataRow In result.Rows      'for every row in dt datatable
                data2 = row.Item("person_count")    'add value into variable from d_zone column of t_zones table
            Next row

            old_count = data2

            If data = 1 Then
                If data2 <> 0 Then
                    data2 -= 1
                End If
            ElseIf data = 2 Then
                data2 += 1
            End If

            'update new datetimestamp and person count
            dbdata = timestamp_str
            'message = serial_no_int & data_int

            dbcommand = "UPDATE statistics SET person_count='" & data2 & "' WHERE person_count='" & old_count & "';"
            dbpointer = "@pointer"
            Database_functions.database_insert_single_column(dbcommand, dbpointer, data2)

            dbcommand = "UPDATE statistics SET person_entexit_datetime='" & timestamp_str & "' WHERE person_count='" & data2 & "';"
            dbpointer = "@pointer"
            Database_functions.database_insert_single_column(dbcommand, dbpointer, data2)

            dbcommand = "UPDATE statistics SET person_entexit_ms='" & millisecondstamp & "' WHERE person_count='" & data2 & "';"
            dbpointer = "@pointer"
            Database_functions.database_insert_single_column(dbcommand, dbpointer, millisecondstamp)

            Map.Controls("pnl_people").Show()
            Map.people.Text = data2.ToString


        End If



    End Sub
    Private Sub update_listview()

    End Sub


    Public Sub update_service_combo()
        Dim result As DataTable
        Dim table As String
        Dim onoff As String
        Dim set_database As Integer
        lv_services.Clear()
        lv_onoff.Clear()
        dbcommand = "UPDATE t_zones SET temp_listview='" & set_database & "';" 'clear all temporary listviews from t_zones
        Database_functions.database_insert_single_column(dbcommand, dbpointer, set_database)

        combo_services.Items.Clear()              'clear listview box so items are not duplicated
        combo_services.Text = "Select.." 'load default value into combo box

        dbcommand = "SELECT * FROM services WHERE (d_service_name)<>'';"
        result = Database_functions.database_getall_single_column(dbcommand)

        For Each row As DataRow In result.Rows      'for every row in dt datatable
            table = row.Item("d_service_name")    'add value into variable from d_zone column of t_zones table
            onoff = row.Item("d_service_active")
            combo_services.Items.Add(table)    'add value to combobox
            combo_services.EndUpdate()               'update combobox
            lv_services.Items.Add(table)    'add value to combobox
            lv_services.EndUpdate()               'update combobox
            lv_onoff.Items.Add(onoff)    'add value to combobox
            lv_onoff.EndUpdate()
        Next row        'next row until all rows are obtained
    End Sub
    'WORKING
    Public Sub service_all_onoff()
        Dim result As DataTable
        Dim data(3000) As Integer
        Dim counter As Integer = 0
        Dim serial_str(5) As String
        Dim d_object_codename1 As String
        Dim d_object_codename2 As String
        Dim dateandtime As String
        Dim object_name As String
        Dim unique_serials(100) As Integer
        Dim unique_counter As Integer = 0
        Dim a As Integer
        Dim count As Integer = 0
        Dim sensor_data As Integer
        Dim sensor_number(20) As String
        Dim str As String = Nothing
        Dim tr_timestamp As DateTime
        Dim tr_ms, tr_sensdata, tr_serial As Integer

        sensor_number = {"11", "15", "17", "22", "23", "29", "end"}

        'all on off sensors
        '11 Hall sensors
        '15 accelerometer/gyro
        '17 FSR
        '22 light on off
        '23 temperature on/off
        '29 noise on/off

        While sensor_number(count) <> "end"


            dbcommand = "SELECT * FROM sensor_received_data WHERE d_sensor_serial LIKE '" & sensor_number(count) & "%' ORDER BY d_timestamp DESC LIMIT 0,1;"
            result = Database_functions.database_getall_single_column(dbcommand)
            For Each row As DataRow In result.Rows      'for every row in dt datatable
                data(counter) = row.Item("d_sensor_serial")    'add value into variable from d_zone column of t_zones table

                If counter > 0 Then
                    If data(counter) <> unique_serials(unique_counter - 1) Then
                        unique_serials(unique_counter) = data(counter)
                        unique_counter += 1
                    End If
                ElseIf counter = 0 Then
                    unique_serials(unique_counter) = data(counter)
                    unique_counter += 1
                End If
                counter += 1
            Next row        'next row until all rows are obtaine

            counter = 0

            For a = 0 To unique_counter - 1
                dbcommand = "SELECT * FROM t_zones WHERE d_node_serial='" & unique_serials(a) & "';"
                result = Database_functions.database_getall_single_column(dbcommand)

                For Each row As DataRow In result.Rows      'for every row in dt datatable
                    object_name = row.Item("d_object")
                    d_object_codename1 = row.Item("d_object_codename1")
                    d_object_codename2 = row.Item("d_object_codename2")
                Next row        'next row until all rows are obtaine

                'dbcommand = "SELECT * FROM sensor_received_data WHERE d_sensor_serial='" & unique_serials(a) & "' ORDER BY d_timestamp LIMIT 0,1;"
                dbcommand = "SELECT * FROM sensor_received_data WHERE d_sensor_serial='" & unique_serials(a) & "';"
                result = Database_functions.database_getall_single_column(dbcommand)

                For Each row As DataRow In result.Rows      'for every row in dt datatable
                    dateandtime = row.Item("d_timestamp")
                    sensor_data = row.Item("d_sensor_data")
                Next row        'next row until all rows are obtained

                If sensor_data = 0 Then
                    Map.Controls(d_object_codename1).Show()
                    Map.Controls(d_object_codename2).Hide()
                ElseIf sensor_data = 1 Then
                    Map.Controls(d_object_codename1).Hide()
                    Map.Controls(d_object_codename2).Show()
                End If

                Map.lv_messages.Items.Add(dateandtime & ", Object = " & object_name & ", Data = " & sensor_data)    'add value to combobox
                Map.lv_messages.EndUpdate()               'update combobox
            Next

            count += 1
        End While




    End Sub
    'working don't touch
    Public Sub service_PIR_sensor()
        Dim result As DataTable
        Dim result2 As DataTable
        Dim counter As Integer = 0
        Dim serial_str(5) As String
        Dim zone_name(100) As DataRow
        Dim serial_temp(500) As Integer
        Dim serial(500) As Integer
        Dim unique_counter As Integer = 0
        Dim a As Integer
        Dim d_zones_key(500) As String
        Dim man_x(500) As Integer
        Dim man_x_stairs(500) As Integer
        Dim man_y_stairs(500) As Integer
        Dim man_y(500) As Integer
        Dim counter_end As Integer
        Dim linked(500) As Integer
        Dim man_img_count As Integer = 1
        Dim man_direction(500) As String
        Dim zone(500) As String
        Dim zone_to(500) As String
        Dim tr_timestamp As DateTime
        Dim tr_ms, tr_sensdata, tr_serial As Integer
        Dim count_reverse As Integer = 0
        Dim count_up As Integer = 0


        'hide all men first

        For a = 1 To 13
            Map.Controls("person" & (a).ToString).Hide()
            Map.Controls("person_up" & (a).ToString).Hide()
            Map.Controls("person_down" & (a).ToString).Hide()
            Map.Controls("person_left" & (a).ToString).Hide()
            Map.Controls("person_right" & (a).ToString).Hide()
        Next



        'get all serial numbers from received data store in serial(counter)
        dbcommand = "SELECT * FROM sensor_received_data WHERE d_sensor_serial LIKE '10%' ORDER BY d_timestamp DESC LIMIT 0,13;"
        result = Database_functions.database_getall_single_column(dbcommand)
        For Each row As DataRow In result.Rows      'for every row in dt datatable
            serial_temp(counter) = row.Item("d_sensor_serial")    'add value into variable from d_zone column of t_zones table
            counter += 1
        Next row
        counter_end = counter - 1

        'need to reverse data as DESC command gets oldest first

        Do While counter > 0
            counter -= 1
            serial(count_up) = serial_temp(counter)
            count_up += 1
        Loop






        'get all zones for received data store in d_zones_key(counter)
        counter = 0
        For a = 0 To counter_end + 1
            dbcommand = "SELECT * FROM t_node_hw WHERE d_serialno='" & serial(counter) & "';"
            result2 = Database_functions.database_getall_single_column(dbcommand)
            For Each row As DataRow In result2.Rows      'for every row in dt datatable

                d_zones_key(counter) = row.Item("d_zones_key")    'add value into variable from d_zone column of t_zones table
                counter += 1
            Next row
        Next

        'is zone in d_zones_key linked to next zone store in linked(a) 0 = not linked 1 = forward linked 2 = reverse linked
        counter = 0
        For a = 0 To counter_end

            'forward link
            For b = 1 To 5
                dbcommand = "SELECT * FROM t_zones WHERE d_zone='" & d_zones_key(a) & "' AND d_zone_link" & b.ToString & "='" & d_zones_key(a + 1) & "';"
                result2 = Database_functions.database_getall_single_column(dbcommand)
                For Each row As DataRow In result2.Rows      'for every row in dt datatable
                    linked(a) = 1
                    zone(a) = row.Item("d_zone")
                    zone_to(a) = row.Item("d_zone_link1")
                    If zone_to(a) = "" Then
                        zone_to(a) = row.Item("d_zone_link2")
                    ElseIf zone_to(a) = "" Then
                        zone_to(a) = row.Item("d_zone_link2")
                    ElseIf zone_to(a) = "" Then
                        zone_to(a) = row.Item("d_zone_link3")
                    ElseIf zone_to(a) = "" Then
                        zone_to(a) = row.Item("d_zone_link4")
                    ElseIf zone_to(a) = "" Then
                        zone_to(a) = row.Item("d_zone_link5")
                    End If
                Next row
            Next

        Next


        'reverse link
        counter = 0
        For a = 0 To counter_end
            For b = 1 To 5
                dbcommand = "SELECT * FROM t_zones WHERE d_zone='" & d_zones_key(a + 1) & "' AND d_zone_link" & b.ToString & "='" & d_zones_key(a) & "';"
                result2 = Database_functions.database_getall_single_column(dbcommand)
                For Each row As DataRow In result2.Rows      'for every row in dt datatable
                    linked(a) = 2
                    zone(a) = row.Item("d_zone")
                    zone_to(a) = row.Item("d_zone_link1")
                    If zone_to(a) = "" Then
                        zone_to(a) = row.Item("d_zone_link2")
                    ElseIf zone_to(a) = "" Then
                        zone_to(a) = row.Item("d_zone_link2")
                    ElseIf zone_to(a) = "" Then
                        zone_to(a) = row.Item("d_zone_link3")
                    ElseIf zone_to(a) = "" Then
                        zone_to(a) = row.Item("d_zone_link4")
                    ElseIf zone_to(a) = "" Then
                        zone_to(a) = row.Item("d_zone_link5")
                    End If
                Next row
            Next
        Next


        'get all man locations for received data

        For a = 0 To counter_end
            If linked(a) = 1 Then
                dbcommand = "SELECT * FROM t_man_locations WHERE d_zone1='" & d_zones_key(a) & "' AND d_zone2='" & d_zones_key(a + 1) & "';"
                result2 = Database_functions.database_getall_single_column(dbcommand)
                man_x(a) = result2.Rows(0).Item(2) ' get data from last item in received data
                man_x_stairs(a) = result2.Rows(0).Item(5) ' get data from last item in received data
                man_y(a) = result2.Rows(0).Item(3) ' get data from last item in received data
                man_y_stairs(a) = result2.Rows(0).Item(6) ' get data from last item in received data
                man_direction(a) = result2.Rows(0).Item(4) ' get data from last item in received data)

            End If
        Next

        For a = 0 To counter_end
            If linked(a) = 0 Then
                dbcommand = "SELECT * FROM t_man_locations WHERE d_zone1='" & d_zones_key(a) & "';"
                result2 = Database_functions.database_getall_single_column(dbcommand)
                For Each row As DataRow In result2.Rows      'for every row in dt datatable
                    man_x(a) = result2.Rows(0).Item(2) ' get data from last item in received data
                    man_x_stairs(a) = result2.Rows(0).Item(5) ' get data from last item in received data
                    man_y(a) = result2.Rows(0).Item(3) ' get data from last item in received data
                    man_y_stairs(a) = result2.Rows(0).Item(6) ' get data from last item in received data
                    man_direction(a) = result2.Rows(0).Item(4) ' get data from last item in received data
                Next row

            End If
        Next

        For a = 0 To counter_end
            If linked(a) = 2 Then
                dbcommand = "SELECT * FROM t_man_locations WHERE d_zone1='" & d_zones_key(a + 1) & "' AND d_zone2='" & d_zones_key(a) & "';"
                result2 = Database_functions.database_getall_single_column(dbcommand)
                For Each row As DataRow In result2.Rows      'for every row in dt datatable
                    man_x(a) = result2.Rows(0).Item(2) ' get data from last item in received data
                    man_x_stairs(a) = result2.Rows(0).Item(5) ' get data from last item in received data
                    man_y(a) = result2.Rows(0).Item(3) ' get data from last item in received data
                    man_y_stairs(a) = result2.Rows(0).Item(6) ' get data from last item in received data
                    man_direction(a) = result2.Rows(0).Item(4) ' get data from last item in received data
                Next row
            End If
        Next



        'get direction


        'place man/move man
        For a = 0 To counter_end

            If linked(a) = 0 Then

                If man_x(a) = 0 Then ' no zone found in d_zone1
                    dbcommand = "SELECT * FROM t_man_locations WHERE d_zone2='" & d_zones_key(a) & "';"
                    result2 = Database_functions.database_getall_single_column(dbcommand)
                    For Each row As DataRow In result2.Rows      'for every row in dt datatable
                        man_x(a) = result2.Rows(0).Item(2) ' get data from last item in received data
                        man_y(a) = result2.Rows(0).Item(3) ' get data from last item in received data
                        man_direction(a) = result2.Rows(0).Item(4)
                    Next row
                    If man_direction(a) = "Up" Then
                        Map.Controls("person" & (man_img_count).ToString).Location = New Point(man_x(a), man_y(a) - 128)
                        Map.Controls("person" & (man_img_count).ToString).Show()
                        man_img_count += 1
                    ElseIf man_direction(a) = "Down" Then
                        Map.Controls("person" & (man_img_count).ToString).Location = New Point(man_x(a), man_y(a) + 128)
                        Map.Controls("person" & (man_img_count).ToString).Show()
                        man_img_count += 1
                    ElseIf man_direction(a) = "Left" Then
                        Map.Controls("person" & (man_img_count).ToString).Location = New Point(man_x(a) - 118, man_y(a))
                        Map.Controls("person" & (man_img_count).ToString).Show()
                        man_img_count += 1
                    ElseIf man_direction(a) = "Right" Then
                        Map.Controls("person" & (man_img_count).ToString).Location = New Point(man_x(a) + 118, man_y(a))
                        Map.Controls("person" & (man_img_count).ToString).Show()
                        man_img_count += 1
                    End If
                Else
                    Map.Controls("person" & (man_img_count).ToString).Location = New Point(man_x(a), man_y(a))
                    Map.Controls("person" & (man_img_count).ToString).Show()
                    man_img_count += 1
                End If

            ElseIf linked(a) = 1 Then
                'forward linked
                'where is it linked get man locations

                If man_direction(a) = "Up" Then
                    If man_x_stairs(a) = 0 Then
                        Map.Controls("person_up" & (man_img_count).ToString).Location = New Point(man_x(a), man_y(a))
                        Map.Controls("person_up" & (man_img_count).ToString).Show()

                        Map.Controls("person" & (man_img_count).ToString).Location = New Point(man_x(a), man_y(a) - 128)
                        Map.Controls("person" & (man_img_count).ToString).Show()
                    Else
                        Map.Controls("person_up" & (man_img_count).ToString).Location = New Point(man_x(a), man_y(a))
                        Map.Controls("person_up" & (man_img_count).ToString).Show()
                        Map.Controls("person" & (man_img_count).ToString).Location = New Point(man_x_stairs(a), man_y_stairs(a))
                        Map.Controls("person" & (man_img_count).ToString).Show()
                        man_img_count += 1
                    End If


                ElseIf man_direction(a) = "Down" Then
                    If man_x_stairs(a) = 0 Then
                        Map.Controls("person_down" & (man_img_count).ToString).Location = New Point(man_x(a), man_y(a))
                        Map.Controls("person_down" & (man_img_count).ToString).Show()

                        Map.Controls("person" & (man_img_count).ToString).Location = New Point(man_x(a), man_y(a) + 128)
                        Map.Controls("person" & (man_img_count).ToString).Show()
                        man_img_count += 1
                    Else
                        Map.Controls("person_down" & (man_img_count).ToString).Location = New Point(man_x(a), man_y(a))
                        Map.Controls("person_down" & (man_img_count).ToString).Show()
                        Map.Controls("person" & (man_img_count).ToString).Location = New Point(man_x_stairs(a), man_y_stairs(a))
                        Map.Controls("person" & (man_img_count).ToString).Show()
                        man_img_count += 1
                    End If

                ElseIf man_direction(a) = "Left" Then
                    If man_x_stairs(a) = 0 Then
                        Map.Controls("person_left" & (man_img_count).ToString).Location = New Point(man_x(a), man_y(a))
                        Map.Controls("person_left" & (man_img_count).ToString).Show()

                        Map.Controls("person" & (man_img_count).ToString).Location = New Point(man_x(a) - 118, man_y(a))
                        Map.Controls("person" & (man_img_count).ToString).Show()
                        man_img_count += 1
                    Else
                        Map.Controls("person_left" & (man_img_count).ToString).Location = New Point(man_x(a), man_y(a))
                        Map.Controls("person_left" & (man_img_count).ToString).Show()
                        Map.Controls("person" & (man_img_count).ToString).Location = New Point(man_x_stairs(a), man_y_stairs(a))
                        Map.Controls("person" & (man_img_count).ToString).Show()
                        man_img_count += 1
                    End If

                ElseIf man_direction(a) = "Right" Then

                    If man_x_stairs(a) = 0 Then
                        Map.Controls("person_right" & (man_img_count).ToString).Location = New Point(man_x(a), man_y(a))
                        Map.Controls("person_right" & (man_img_count).ToString).Show()

                        Map.Controls("person" & (man_img_count).ToString).Location = New Point(man_x(a) + 118, man_y(a))
                        Map.Controls("person" & (man_img_count).ToString).Show()
                        man_img_count += 1
                    Else
                        Map.Controls("person_right" & (man_img_count).ToString).Location = New Point(man_x(a), man_y(a))
                        Map.Controls("person_right" & (man_img_count).ToString).Show()
                        Map.Controls("person" & (man_img_count).ToString).Location = New Point(man_x_stairs(a), man_y_stairs(a))
                        Map.Controls("person" & (man_img_count).ToString).Show()
                        man_img_count += 1
                    End If

                End If



            ElseIf linked(a) = 2 Then
                'reverse linked
                'where is it linked get man locations

                If man_direction(a) = "Up" Then
                    If man_x_stairs(a) = 0 Then

                        Map.Controls("person_down" & (man_img_count).ToString).Location = New Point(man_x(a), man_y(a) - 128)
                        Map.Controls("person_down" & (man_img_count).ToString).Show()

                        Map.Controls("person" & (man_img_count).ToString).Location = New Point(man_x(a), man_y(a))
                        Map.Controls("person" & (man_img_count).ToString).Show()
                        man_img_count += 1
                    Else
                        Map.Controls("person_down" & (man_img_count).ToString).Location = New Point(man_x_stairs(a + 1), man_y_stairs(a + 1))
                        Map.Controls("person_down" & (man_img_count).ToString).Show()
                        Map.Controls("person" & (man_img_count).ToString).Location = New Point(man_x(a + 1), man_y(a + 1))
                        Map.Controls("person" & (man_img_count).ToString).Show()
                        man_img_count += 1
                    End If

                ElseIf man_direction(a) = "Down" Then
                    If man_x_stairs(a) = 0 Then

                        Map.Controls("person_up" & (man_img_count).ToString).Location = New Point(man_x(a), man_y(a) + 128)
                        Map.Controls("person_up" & (man_img_count).ToString).Show()

                        Map.Controls("person" & (man_img_count).ToString).Location = New Point(man_x(a), man_y(a))
                        Map.Controls("person" & (man_img_count).ToString).Show()
                        man_img_count += 1
                    Else
                        Map.Controls("person_up" & (man_img_count).ToString).Location = New Point(man_x_stairs(a + 1), man_y_stairs(a + 1))
                        Map.Controls("person_up" & (man_img_count).ToString).Show()
                        Map.Controls("person" & (man_img_count).ToString).Location = New Point(man_x(a + 1), man_y(a + 1))
                        Map.Controls("person" & (man_img_count).ToString).Show()
                        man_img_count += 1
                    End If

                ElseIf man_direction(a) = "Left" Then
                    If man_x_stairs(a) = 0 Then
                        Map.Controls("person_right" & (man_img_count).ToString).Location = New Point(man_x(a) - 118, man_y(a))
                        Map.Controls("person_right" & (man_img_count).ToString).Show()

                        Map.Controls("person" & (man_img_count).ToString).Location = New Point(man_x(a), man_y(a))
                        Map.Controls("person" & (man_img_count).ToString).Show()
                        man_img_count += 1
                    Else
                        Map.Controls("person_right" & (man_img_count).ToString).Location = New Point(man_x_stairs(a), man_y_stairs(a))
                        Map.Controls("person_right" & (man_img_count).ToString).Show()
                        Map.Controls("person" & (man_img_count).ToString).Location = New Point(man_x(a + 1), man_y(a + 1))
                        Map.Controls("person" & (man_img_count).ToString).Show()
                        man_img_count += 1
                    End If

                ElseIf man_direction(a) = "Right" Then
                    If man_x_stairs(a) = 0 Then
                        Map.Controls("person_left" & (man_img_count).ToString).Location = New Point(man_x(a) + 118, man_y(a))
                        Map.Controls("person_left" & (man_img_count).ToString).Show()

                        Map.Controls("person" & (man_img_count).ToString).Location = New Point(man_x(a), man_y(a))
                        Map.Controls("person" & (man_img_count).ToString).Show()
                        man_img_count += 1
                    Else
                        Map.Controls("person_left" & (man_img_count).ToString).Location = New Point(man_x_stairs(a + 1), man_y_stairs(a + 1))
                        Map.Controls("person_left" & (man_img_count).ToString).Show()
                        Map.Controls("person" & (man_img_count).ToString).Location = New Point(man_x(a + 1), man_y(a + 1))
                        Map.Controls("person" & (man_img_count).ToString).Show()
                        man_img_count += 1
                    End If

                End If
            End If
        Next


    End Sub

    Public Sub service_electricity_usage()

        Dim data(3000) As Integer
        Dim counter As Integer = 0
        Dim result As DataTable

        Dim serial_str(5) As String
        Dim unique_serials(100) As Integer
        Dim unique_counter As Integer = 0
        Dim electricity_usage As String
        Dim tr_timestamp As DateTime
        Dim tr_ms, tr_sensdata, tr_serial As Integer


        dbcommand = "SELECT * FROM sensor_received_data WHERE d_sensor_serial LIKE '20%' ORDER BY d_timestamp DESC LIMIT 0,1;"
        result = Database_functions.database_getall_single_column(dbcommand)

        For Each row As DataRow In result.Rows      'for every row in dt datatable
            electricity_usage = row.Item("d_sensor_data")    'add value into variable from d_zone column of t_zones table
        Next row        'next row until all rows are obtained

        Map.Controls("electricity_panel").Show()
        Map.tb_electricity.Text = electricity_usage & " Watts"


    End Sub
    'works don't touch
    Public Sub service_ambient_sensors()
        Dim result As DataTable
        Dim data(3000) As Integer
        Dim counter As Integer = 0
        Dim serial_str(5) As String
        Dim unique_serials(100) As Integer
        Dim unique_counter As Integer = 0
        Dim panel As Integer = 1
        Dim ambient_x(100) As Integer
        Dim ambient_y(100) As Integer
        Dim zone(300) As String
        Dim count As Integer = 0
        Dim rownum As Integer
        Dim count_end As Integer
        Dim light_serials(300)
        Dim sensor_data As Integer
        Dim sens_data As Integer
        Dim temp_listview As Integer
        Dim lv_count As Integer = 0
        Dim sensors(10) As String
        Dim sensor_names(10) As String
        Dim b As Integer
        Dim listview_contents(20, 20) As String
        Dim listview_name(20) As String


        'delete all temporary listbox numbers from database
        dbcommand = "UPDATE t_zones SET temp_listview='0' WHERE temp_listview<>'0';"
        dbpointer = "@pointer"
        Database_functions.database_insert_single_column(dbcommand, dbpointer, dbdata)

        sensors = {"12", "13", "14", "19"}
        sensor_names = {"Light", "Temperature", "Humidity", "Noise"}
        'get all serial numbers and associated zones for light sensor
        For b = 0 To 3
            dbcommand = "SELECT * FROM t_node_hw WHERE d_serialno LIKE '" & sensors(b) & "%';"
            result = Database_functions.database_getall_single_column(dbcommand)

            For Each row As DataRow In result.Rows      'for every row in dt datatable
                light_serials(count) = row.Item("d_serialno")    'add value into variable from d_zone column of t_zones table
                zone(count) = row.Item("d_zones_key")    'add value into variable from d_zone column of t_zones table
                count += 1
            Next row        'next row until all rows are obtained
            count_end = count

            'get listview location for zones

            For a = 0 To count_end
                dbcommand = "SELECT * FROM t_zones WHERE d_zone='" & zone(a) & "';"
                result = Database_functions.database_getall_single_column(dbcommand)
                For Each row As DataRow In result.Rows      'for every row in dt datatable
                    ambient_x(a) = row.Item("d_ambient_x")    'add value into variable from d_zone column of t_zones table
                    ambient_y(a) = row.Item("d_ambient_y")    'add value into variable from d_zone column of t_zones table
                Next row        'next row until all rows are obtained
            Next


            For a = 0 To count_end

                'does any data exist

                dbcommand = "SELECT COUNT(*) FROM sensor_received_data WHERE d_sensor_serial='" & light_serials(a) & "';"
                rownum = Database_functions.database_row_numbers(dbcommand)
                'if yes
                If rownum <> 0 Then
                    dbcommand = "SELECT * FROM sensor_received_data WHERE d_sensor_serial='" & light_serials(a) & "' ORDER BY d_timestamp LIMIT 0,1;"
                    result = Database_functions.database_getall_single_column(dbcommand)
                    sens_data = result.Rows(0).Item(2) ' get data from last item in received data

                    'set up temporary listview
                    dbcommand = "SELECT * FROM t_zones WHERE d_zone='" & zone(a) & "';"
                    result = Database_functions.database_getall_single_column(dbcommand)
                    If result.Rows(0).Item(17) = 0 Then 'listview not assigned to zone

                        'set temporary listview to zone in database
                        dbcommand = "UPDATE t_zones SET temp_listview='" & lv_count & "' WHERE d_zone='" & zone(a) & "';"
                        dbpointer = "@pointer"
                        Database_functions.database_insert_single_column(dbcommand, dbpointer, dbdata)
                        lv_count += 1 'increment listview counter
                        temp_listview = lv_count    'this is the number for the temporay listview to use

                    Else
                        temp_listview = result.Rows(0).Item(17) 'this is the temporary listview obtained from database

                    End If



                    listview_name(temp_listview) = "lv_ambient_sensors" & (temp_listview).ToString
                    listview_contents(temp_listview, b) = zone(a) & " " & sensor_names(b) & " = " & sens_data.ToString

                    'position and populate listview
                End If
            Next
            count = 0
        Next



        Dim listname As Integer = 0
        Dim listcont As Integer = 0

        For listname = 1 To count_end
            Dim lv_list As New ListView
            Dim lv_item As New ListViewItem
            lv_list.Name = listview_name(listname)

            listcont = 0
            Do While listview_contents(listname, listcont) <> ""
                lv_list.Items.Add(listview_contents(listname, listcont))
                listcont += 1
            Loop
            lv_list.EndUpdate()
            lv_list.Anchor = AnchorStyles.Top Or AnchorStyles.Left
            lv_list.Location = New Point(ambient_x(listname - 1), ambient_y(listname - 1))
            lv_list.Width = 170
            lv_list.Height = 97
            lv_list.View = View.List

            Map.pnl_people.Controls.Add(lv_list)

        Next
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim service_name As String
        Dim state As String
        state = combo_onoff.Text
        service_name = combo_services.Text

        If service_name <> "Select.." Then
            dbcommand = "UPDATE services SET d_service_active='" & state & "' WHERE d_service_name='" & service_name & "';"
            dbpointer = "@pointer"
            Database_functions.database_insert_single_column(dbcommand, dbpointer, state)
        End If
        Call update_service_combo()
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
        Rules.Show()
    End Sub

    Private Sub ServicesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServicesToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub SendMessageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SendMessageToolStripMenuItem.Click
        sim_node_hardware_messages.Show()
    End Sub
End Class