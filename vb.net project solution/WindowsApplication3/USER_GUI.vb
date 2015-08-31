Imports MySql.Data.MySqlClient
Public Class USER_GUI
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
    Dim messageboxuser As Boolean = False



    Private Sub USER_GUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call populate_zone_combo()      'Populate Combobox with all zones stored in t_zones table when form loads
        Call populate_object_combo()
    End Sub
    'WORKING
    Private Sub btn_add_zone_Click(sender As Object, e As EventArgs) Handles btn_add_zone.Click
        dbdata = text_add_zone.Text
        If dbdata = "Insert zone name here" Then
            messageboxuser = True
            GoTo not_valid
        End If

        dbcommand = "INSERT INTO t_zones (d_zone) VALUES(@pointer);"
        dbpointer = "@pointer"
        Database_functions.database_insert_single_column(dbcommand, dbpointer, dbdata)

        dbcommand = "INSERT INTO activity_zones (Zone) VALUES(@pointer);"
        dbpointer = "@pointer"
        Database_functions.database_insert_single_column(dbcommand, dbpointer, dbdata)
        Call populate_zone_combo()      'Populate Combobox with all zones stored in t_zones table when form loads
not_valid:
        If messageboxuser = True Then
            MsgBox("Entry Not Valid")
            messageboxuser = False
        End If

    End Sub
    'WORKING
    Private Sub btn_remove_zone_Click(sender As Object, e As EventArgs) Handles btn_remove_zone.Click   'removes zone from t_zones table if it is not required to be monitored
        dbdata = combo_remove_zone.Text   'load zone to be removed from combobox to zone variable
        If dbdata = "Select.." Then
            messageboxuser = True
            GoTo not_valid
        End If
        dbcommand = "DELETE FROM t_zones WHERE d_zone = '" & dbdata & "';"
        Call Database_functions.database_remove_single_row(dbcommand)

        dbcommand = "DELETE FROM activity_zones WHERE d_zone = '" & dbdata & "';"
        Call Database_functions.database_remove_single_row(dbcommand)
        Call populate_zone_combo()      'update combobox and listview from t_zones table
not_valid:
        If messageboxuser = True Then
            MsgBox("Entry Not Valid")
            messageboxuser = False
        End If

    End Sub
    'WORKING
    Private Sub populate_zone_combo()
        Dim result As DataTable

        lv_zones.Items.Clear()              'clear listview box so items are not duplicated
        combo_remove_zone.Items.Clear()
        combo_remove_zone.Text = "Select.." 'load default value into combo box

        dbcommand = "SELECT * FROM t_zones WHERE (d_zone)<>'';"
        result = Database_functions.database_getall_single_column(dbcommand)

        Dim table As String

        For Each row As DataRow In result.Rows      'for every row in dt datatable


            table = row.Item("d_zone")    'add value into variable from d_zone column of t_zones table
            combo_remove_zone.Items.Add(table)    'add value to combobox
            combo_remove_zone.EndUpdate()               'update combobox
            lv_zones.Items.Add(table)             'add value to listview

        Next row        'next row until all rows are obtained

    End Sub
    'WORKING
    Private Sub populate_object_combo()
        Dim result As DataTable
        Dim table As String

        lv_objects.Items.Clear()              'clear listview box so items are not duplicated
        combo_remove_object.Items.Clear()
        combo_remove_object.Text = "Select.." 'load default value into combo box

        dbcommand = "SELECT * FROM t_zones WHERE (d_object)<>'';"
        result = Database_functions.database_getall_single_column(dbcommand)

        For Each row As DataRow In result.Rows      'for every row in dt datatable


            table = row.Item("d_object")    'add value into variable from d_zone column of t_zones table
            combo_remove_object.Items.Add(table)    'add value to combobox
            combo_remove_object.EndUpdate()               'update combobox
            lv_objects.Items.Add(table)             'add value to listview

        Next row        'next row until all rows are obtained

    End Sub
    'WORKING
    Private Sub btn_add_object_Click(sender As Object, e As EventArgs) Handles btn_add_object.Click
        dbdata = text_add_object.Text

        'insert into t_zones
        If dbdata = "Insert Object name here" Then
            messageboxuser = True
            GoTo not_valid
        End If
        dbcommand = "INSERT INTO t_zones (d_object) VALUES(@pointer);"
        dbpointer = "@pointer"
        Database_functions.database_insert_single_column(dbcommand, dbpointer, dbdata)
        'insert into activities database object and set max times to zero to initialise the row to store the max times
        dbcommand = "INSERT INTO activity_objects (Object,Max_time_active_hrs,Max_time_active_mins,Max_time_inactive_hrs,Max_time_inactive_mins) VALUES('" & dbdata & "','0','0','0','0');"
        dbpointer = "@pointer"
        Database_functions.database_insert_single_column(dbcommand, dbpointer, dbdata)

        Call populate_object_combo()      'Populate Combobox with all zones stored in t_zones table when form loads
not_valid:
        If messageboxuser = True Then
            MsgBox("Entry Not Valid")
            messageboxuser = False
        End If

    End Sub
    Private Sub database_select()
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection      'define mysql connection
        Dim cmd As New MySqlCommand             'defined to build mysql command 
        myConnectionString = "server=localhost;" _
                   & "uid=root;" _
                   & "pwd=root;" _
                   & "database=wsn_network;"
        Try
            conn.ConnectionString = myConnectionString      'build connectionstring
            conn.Open()                                     'open database connection
            cmd.Connection = conn                           'define command connection parameters
            ' cmd.CommandText = temp_datstr  'This is the mysql command.  d_key column in t_zones table autincrements and is private key so NULL added, @number is a pointer for text_add_zone textbox
            cmd.Prepare()       'this has to be called not exactly sure what it is doing
            'cmd.Parameters.AddWithValue(temp_datname, temp_user)    'text_add_zone textbox added to cmd
            cmd.ExecuteNonQuery()           'execute mysql command

            dr = cmd.ExecuteReader()                    'tell mysql to put results in dr
            dt.Load(dr)                                 'load results into dt datatable
        Catch ex As MySqlException          'on error
            MessageBox.Show("Error " & ex.Number & " has occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Try
            conn.Close()        'close database connection
        Catch myerror As MySql.Data.MySqlClient.MySqlException  'on error
        End Try

    End Sub


    

    
    Sub populate_serial_combo()
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection 'define mysql connection
        Dim cmd As New MySqlCommand     'defined to build mysql command
        Dim dr As MySqlDataReader       'object which mysql uses to put retrieved values
        Dim dt As New DataTable         'table created to store values from mysql
        'combo_remove_node_sn.Items.Clear()     'clear the combobox items so data is not duplicated
        'lv_node_sn.Items.Clear()              'clear listview box so items are not duplicated
        'combo_remove_node_sn.Text = "Select.." 'load default value into combo box
        ' Call load_node_sn()       'get all zones from t_zones table

        Try             'connect to database
            conn.ConnectionString = myConnectionString
            conn.Open()
            cmd.Connection = conn
        Catch ex As Exception
        End Try

        cmd.CommandText = "SELECT * FROM t_node_hw;"  'select all rows from t_zones
        dr = cmd.ExecuteReader()                    'tell mysql to put results in dr
        dt.Load(dr)                                 'load results into dt datatable

        Try     'close database connection
            conn.Close()
        Catch myerror As MySql.Data.MySqlClient.MySqlException
        End Try

        Dim node_sn As String

        For Each row As DataRow In dt.Rows      'for every row in dt datatable

            node_sn = row.Item("d_serialno")    'add value into variable from d_zone column of t_zones table
            ' combo_remove_node_sn.Items.Add(node_sn)    'add value to combobox
            'combo_remove_node_sn.EndUpdate()               'update combobox
            ' lv_node_sn.Items.Add(node_sn)             'add value to listview

        Next row        'next row until all rows are obtained
    End Sub
   

    Private Sub btn_remove_object_Click(sender As Object, e As EventArgs) Handles btn_remove_object.Click
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection 'define mysql connection
        Dim cmd As New MySqlCommand     'defined to build mysql command 
        dbdata = combo_remove_object.Text   'load zone to be removed from combobox to zone variable
        If dbdata = "Select.." Then
            messageboxuser = True
            GoTo not_valid
        End If

        dbcommand = "DELETE FROM t_zones WHERE d_object = '" & dbdata & "';"
        Call Database_functions.database_remove_single_row(dbcommand)

        dbcommand = "DELETE FROM activity_objects WHERE d_object = '" & dbdata & "';"
        Call Database_functions.database_remove_single_row(dbcommand)
        Call populate_object_combo()      'update combobox and listview from t_zones table
not_valid:
        If messageboxuser = True Then
            MsgBox("Entry Not Valid")
            messageboxuser = False
        End If
    End Sub

    Private Sub btn_add_node_sn_Click(sender As Object, e As EventArgs)
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection      'define mysql connection
        Dim cmd As New MySqlCommand             'defined to build mysql command 
        'Call load_node_sn()
        'snumbers = text_add_node_sn.Text               'get zone to be added from text_add_zone textbox

        Try
            conn.ConnectionString = myConnectionString      'build connectionstring
            conn.Open()                                     'open database connection
            cmd.Connection = conn                           'define command connection parameters
            'cmd.CommandText = "INSERT INTO t_node_hw VALUES(@userobject);"  'This is the mysql command.  d_key column in t_zones table autincrements and is private key so NULL added, @number is a pointer for text_add_zone textbox
            cmd.CommandText = "INSERT INTO t_node_hw (d_serialno) VALUE(@userserial);"  'This is the mysql command.  d_key column in t_zones table autincrements and is private key so NULL added, @number is a pointer for text_add_zone textbox
            cmd.Prepare()       'this has to be called not exactly sure what it is doing
            cmd.Parameters.AddWithValue("@userserial", snumbers)    'text_add_zone textbox added to cmd
            cmd.ExecuteNonQuery()           'execute mysql command

        Catch ex As MySqlException          'on error
            MessageBox.Show("Error " & ex.Number & " has occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Try
            conn.Close()        'close database connection
        Catch myerror As MySql.Data.MySqlClient.MySqlException  'on error
        End Try

        Call populate_serial_combo()  're-populate combobox and zones listview with newly added zone 
    End Sub

    Private Sub btn_remove_node_sn_Click(sender As Object, e As EventArgs)
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection 'define mysql connection
        Dim cmd As New MySqlCommand     'defined to build mysql command 
        ' Call load_node_sn()   'load t_zones database connection parameters
        ' snumbers = combo_remove_node_sn.Text   'load zone to be removed from combobox to zone variable

        Try
            conn.ConnectionString = myConnectionString  'build connectionstring
            conn.Open()                                     'open database connection
            cmd.Connection = conn                           'define command connection parameters
            cmd.CommandText = "DELETE FROM t_node_hw WHERE d_serialno = '" & snumbers & "';"      'command for mysql to delete a row in t_zones table which matches the selected item from the combobox
            cmd.Prepare()                                   'this has to be called not exactly sure what it is doing
            cmd.ExecuteNonQuery()                           'execute mysql command

        Catch ex As MySqlException  'on error
            MessageBox.Show("Error " & ex.Number & " has occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Try
            conn.Close()        'close database connection
        Catch myerror As MySql.Data.MySqlClient.MySqlException      'on error
        End Try

        Call populate_serial_combo()      'update combobox and listview from t_zones table
    End Sub
    Private Sub btn_add_ambient_Click(sender As Object, e As EventArgs) Handles btn_add_ambient.Click
        Dim zone As String
        Dim d_ambient_x As Integer
        Dim d_ambient_y As Integer
        d_ambient_x = tb_ambient_x.Text
        d_ambient_y = tb_ambient_y.Text
        zone = text_add_zone.Text

        dbcommand = "UPDATE t_zones SET d_ambient_x='" & d_ambient_x & "' WHERE d_zone='" & zone & "';"
        dbpointer = "@pointer"
        Database_functions.database_insert_single_column(dbcommand, dbpointer, d_ambient_x)

        dbcommand = "UPDATE t_zones SET d_ambient_y='" & d_ambient_y & "' WHERE d_zone='" & zone & "';"
        dbpointer = "@pointer"
        Database_functions.database_insert_single_column(dbcommand, dbpointer, d_ambient_y)
    End Sub

    Private Sub btnuserguinext_Click(sender As Object, e As EventArgs)
        USER_GUI_2.Show()

    End Sub

    Private Sub ZonesObjectsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZonesObjectsToolStripMenuItem.Click
        Me.Show()
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
        sim_node_hardware_messages.Show()
    End Sub
End Class