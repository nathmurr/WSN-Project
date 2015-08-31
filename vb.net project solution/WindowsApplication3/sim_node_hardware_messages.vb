Imports MySql.Data.MySqlClient
Public Class sim_node_hardware_messages
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
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        

    End Sub
    Private Sub combo_serial_populate()
        Dim result As DataTable
        Dim table As String

        combo_serial.Items.Clear()              'clear listview box so items are not duplicated
        combo_serial.Text = "Select.." 'load default value into combo box

        dbcommand = "SELECT * FROM t_node_hw WHERE (d_serialno)<>'';"
        result = Database_functions.database_getall_single_column(dbcommand)

        For Each row As DataRow In result.Rows      'for every row in dt datatable
            table = row.Item("d_serialno")    'add value into variable from d_zone column of t_zones table
            combo_serial.Items.Add(table)    'add value to combobox
            combo_serial.EndUpdate()               'update combobox
        Next row        'next row until all rows are obtained
    End Sub

    Private Sub sim_node_hardware_messages_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call combo_serial_populate()
    End Sub

    Private Sub combo_serial_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combo_serial.SelectedIndexChanged

    End Sub

    Private Sub combo_serial_SelectedValueChanged(sender As Object, e As EventArgs) Handles combo_serial.SelectedValueChanged
        'node type
        '10 = motion
        '11 = hall
        '12 = light
        '13 = temperature
        '14 = humidity
        '15 = accelerometer
        '16 = particulate
        '17 = fsr
        '18 = fall detection
        '19 = noise
        '20 = electricity
        '23 = Temperature on/off
        '29 = Noise on/off

        Dim serialnum_validate As String
        Dim sensor_type As String
        Dim sensor_serial As Integer
        Dim result As DataTable
        Dim table As String
        sensor_serial = combo_serial.Text
        serialnum_validate = combo_serial.Text.ToString
        sensor_type = serialnum_validate.Substring(0, 2)

        Select Case sensor_type
            Case "10"
                'motion
                label_sensor_type.Text = "PIR"
            Case "11"
                'Hall sensor
                label_sensor_type.Text = "Hall"
            Case "12"
                'light
                label_sensor_type.Text = "Light Sensor"
                combo_send_data.Items.Add("0")
                combo_send_data.Items.Add("1")
                combo_send_data.EndUpdate()
            Case "13"
                'Ambient Temp
                label_sensor_type.Text = "Ambient Temperature"
            Case "14"
                'Ambient Humidity
                label_sensor_type.Text = "Ambient Humidity"
            Case "15"
                'Accelerometer
                label_sensor_type.Text = "Accelerometer"
            Case "16"
                'Particulate
                label_sensor_type.Text = "Particulate"
            Case "17"
                'FSR
                label_sensor_type.Text = "FSR"
            Case "18"
                'fall Detection
                label_sensor_type.Text = "Fall Detection"
            Case "19"
                'Ambient Noise
                label_sensor_type.Text = "Ambient Noise"
            Case "20"
                'Electricity
                label_sensor_type.Text = "Electricity"
            Case "23"
                'Temperature on/off
                label_sensor_type.Text = "Temperature On/Off"
            Case "29"
                'Electricity
                label_sensor_type.Text = "Noise On/Off"
            Case Else
                label_sensor_type.Text = "Invalid"
        End Select

        'find zone/object associated with sensor serial number chosen in combo box

        dbcommand = "SELECT * FROM t_node_hw WHERE d_serialno= '" & sensor_serial & "';"
        result = Database_functions.database_getall_single_column(dbcommand)

        For Each row As DataRow In result.Rows      'for every row in dt datatable

            If result.Rows(0).Item(8).ToString <> "" Then
                table = row.Item("d_zones_key")    'add value into variable from d_zone column of t_zones table
                Label_zoneobject.Text = table     'add value to combobox
            Else
                table = row.Item("d_objects_key")    'add value into variable from d_zone column of t_zones table
                Label_zoneobject.Text = table     'add value to combobox
            End If
        Next row        'next row until all rows are obtained

        'dbcommand = "SELECT * FROM t_zones WHERE d_node_serial= '" & sensor_serial & "';"
        'result = Database_functions.database_getall_single_column(dbcommand)

        'For Each row As DataRow In result.Rows      'for every row in dt datatable
        'table = row.Item("d_object")    'add value into variable from d_zone column of t_zones table
        'Label_zoneobject.Text = table     'add value to combobox
        'Next row        'next row until all rows are obtained


    End Sub

    
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim serial_no As String
        Dim serial_no_int As Integer
        Dim data As String
        Dim data_int As Integer
        Dim timeStamp As DateTime = DateTime.Now
        Dim timestamp_str As String
        Dim milliseconds As Integer

        milliseconds = timeStamp.Millisecond

        serial_no = combo_serial.Text
        serial_no_int = Val(serial_no)

        data = combo_send_data.Text
        data_int = Val(data)

        timestamp_str = timeStamp.ToString("yyyy-MM-dd HH:mm:ss")
        dbdata = timestamp_str
        'message = serial_no_int & data_int

        dbcommand = "INSERT INTO sensor_received_data VALUES('" & timestamp_str & "','" & serial_no_int & "','" & data_int & "','" & milliseconds & "',DEFAULT,DEFAULT);"
        dbpointer = "@pointer"
        Database_functions.database_insert_single_column(dbcommand, dbpointer, dbdata)
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
        Services.Show()
    End Sub

    Private Sub SendMessageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SendMessageToolStripMenuItem.Click
        Me.Show()
    End Sub
End Class