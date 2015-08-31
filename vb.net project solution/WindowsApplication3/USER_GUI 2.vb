Imports MySql.Data.MySqlClient
Public Class USER_GUI_2
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
    Private Sub USER_GUI_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call combo_zoneobjects_populate()
        Call update_listview()
        Call populate_serial_no_combo()
    End Sub
    
    Private Sub populate_serial_no_combo()
        Dim result As DataTable
        Dim table As String

        combo_remove_node_sn.Items.Clear()              'clear listview box so items are not duplicated
        combo_remove_node_sn.Text = "Select.." 'load default value into combo box

        dbcommand = "SELECT * FROM t_node_hw WHERE (d_serialno)<>'';"
        result = Database_functions.database_getall_single_column(dbcommand)

        For Each row As DataRow In result.Rows      'for every row in dt datatable


            table = row.Item("d_serialno")    'add value into variable from d_zone column of t_zones table
            combo_remove_node_sn.Items.Add(table)    'add value to combobox
            combo_remove_node_sn.EndUpdate()               'update combobox


        Next row        'next row until all rows are obtained
    End Sub

    Private Sub update_listview()
        Dim result As DataTable
        Dim result_array(300)
        Dim count As Integer = 0
        Dim count_end As Integer
        lv_node_sn.Items.Clear()              'clear listview box so items are not duplicated

        'zones
        dbcommand = "SELECT * FROM t_zones WHERE (d_zone)<>'';"
        result = Database_functions.database_getall_single_column(dbcommand)


        For Each row As DataRow In result.Rows      'for every row in dt datatable
            result_array(count) = row.Item("d_zone")    'add value into variable from d_zone column of t_zones table
            count += 1
        Next row        'next row until all rows are obtained
        count_end = count
        'now have array of zones
        count = 0

        Do While (count < count_end)
            dbcommand = "SELECT * FROM t_node_hw WHERE (d_zones_key)='" & result_array(count) & "';"
            result = Database_functions.database_getall_single_column(dbcommand)

            For Each row As DataRow In result.Rows      'for every row in dt datatable
                lv_node_sn.Items.Add(result_array(count) & "  --->  " & row.Item("d_serialno") & vbCrLf)
            Next row
            count += 1
        Loop

        'objects
        count = 0
        dbcommand = "SELECT * FROM t_zones WHERE (d_object)<>'';"
        result = Database_functions.database_getall_single_column(dbcommand)


        For Each row As DataRow In result.Rows      'for every row in dt datatable
            result_array(count) = row.Item("d_object")    'add value into variable from d_zone column of t_zones table
            count += 1
        Next row        'next row until all rows are obtained
        count_end = count
        'now have array of zones
        count = 0

        Do While (count < count_end)
            dbcommand = "SELECT * FROM t_node_hw WHERE (d_objects_key)='" & result_array(count) & "';"
            result = Database_functions.database_getall_single_column(dbcommand)

            For Each row As DataRow In result.Rows      'for every row in dt datatable
                lv_node_sn.Items.Add(result_array(count) & "  --->  " & row.Item("d_serialno") & vbCrLf)
            Next row
            count += 1
        Loop


    End Sub
    'WORKING
    Private Sub combo_zoneobjects_populate()
        Dim result As DataTable
        Dim table As String
        Dim resultarray(100, 100)

        combo_zone.Items.Clear()     'clear the combobox items so data is not duplicated

        dbcommand = "SELECT * FROM t_zones WHERE (d_zone)<>'';"
        result = Database_functions.database_getall_single_column(dbcommand)
        For Each row As DataRow In result.Rows      'for every row in dt datatable
            table = row.Item("d_zone")    'add value into variable from d_zone column of t_zones table
            combo_zone.Items.Add(table)    'add value to combobox
            combo_zone.EndUpdate()               'update combobox
        Next row        'next row until all rows are obtained

        dbcommand = "SELECT * FROM t_zones WHERE d_object <>'';"
        result = Database_functions.database_getall_single_column(dbcommand)
        For Each row As DataRow In result.Rows      'for every row in dt datatable
            table = row.Item("d_object")    'add value into variable from d_zone column of t_zones table
            combo_objects.Items.Add(table)    'add value to combobox
            combo_objects.EndUpdate()               'update combobox
        Next row        'next row until all rows are obtained

    End Sub

    Private Sub btn_add_zone_Click(sender As Object, e As EventArgs) Handles btn_add_node_zone.Click
        user_selected = combo_zone.Text
        dbdata = text_add_node_sn.Text
        If user_selected = "Zone.." Then
            messageboxuser = True
            GoTo not_valid
        End If

        If dbdata = "Insert Serial no here" Then
            messageboxuser = True
            GoTo not_valid
        End If

        Dim num As Integer
        If Not Integer.TryParse(dbdata, num) Then
            messageboxuser_num = True
            GoTo not_valid_number
        End If


        dbcommand = "INSERT INTO t_node_hw (d_serialno) VALUES(@pointer);"
        dbpointer = "@pointer"
        Database_functions.database_insert_single_column(dbcommand, dbpointer, dbdata)

        dbcommand = "UPDATE t_node_hw SET d_zones_key='" & user_selected & "' WHERE d_serialno='" & dbdata & "';"
        dbpointer = "@pointer"
        Database_functions.database_insert_single_column(dbcommand, dbpointer, dbdata)

        dbcommand = "UPDATE t_zones SET d_node_serial='" & dbdata & "' WHERE d_zone='" & user_selected & "';"
        dbpointer = "@pointer"
        Database_functions.database_insert_single_column(dbcommand, dbpointer, dbdata)

        Call populate_serial_no_combo()
        Call update_listview()

not_valid:
        If messageboxuser = True Then
            MsgBox("Entry Not Valid")
            messageboxuser = False
        End If
not_valid_number:
        If messageboxuser_num = True Then
            MsgBox("Not a valid number")
            messageboxuser_num = False
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_add_object.Click
        user_selected = combo_objects.Text
        dbdata = text_add_node_sn.Text
        If user_selected = "Object.." Then
            messageboxuser = True
            GoTo not_valid
        End If
        If dbdata = "Insert Serial no here" Then
            messageboxuser = True
            GoTo not_valid
        End If

        Dim num As Integer
        If Not Integer.TryParse(dbdata, num) Then
            messageboxuser_num = True
            GoTo not_valid_number
        End If
        dbcommand = "INSERT INTO t_node_hw (d_serialno) VALUES(@pointer);"
        dbpointer = "@pointer"
        Database_functions.database_insert_single_column(dbcommand, dbpointer, dbdata)

        dbcommand = "UPDATE t_zones SET d_node_serial='" & dbdata & "' WHERE d_object='" & user_selected & "';"
        dbpointer = "@pointer"
        Database_functions.database_insert_single_column(dbcommand, dbpointer, dbdata)

        dbcommand = "UPDATE t_node_hw SET d_objects_key='" & user_selected & "' WHERE d_serialno='" & dbdata & "';"
        dbpointer = "@pointer"
        Database_functions.database_insert_single_column(dbcommand, dbpointer, dbdata)

        Call populate_serial_no_combo()
        Call update_listview()
not_valid:
        If messageboxuser = True Then
            MsgBox("Entry Not Valid")
            messageboxuser = False
        End If

not_valid_number:
        If messageboxuser_num = True Then
            MsgBox("Not a valid number")
            messageboxuser_num = False
        End If
    End Sub



    Private Sub btn_remove_node_sn_Click(sender As Object, e As EventArgs) Handles btn_remove_node_sn.Click
        dbdata = combo_remove_node_sn.Text   'load zone to be removed from combobox to zone variable
        dbcommand = "DELETE FROM t_node_hw WHERE d_serialno = '" & dbdata & "';"
        Call Database_functions.database_remove_single_row(dbcommand)

        dbcommand = "UPDATE t_zones SET d_node_serial=NULL WHERE d_node_serial='" & Val(dbdata) & "';"
        dbpointer = "@pointer"
        Database_functions.database_insert_single_column(dbcommand, dbpointer, dbdata)
        Call update_listview()
        Call combo_zoneobjects_populate()
        Call populate_serial_no_combo()

        
    End Sub

    Private Sub ZonesObjectsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZonesObjectsToolStripMenuItem.Click
        USER_GUI.Show()
    End Sub

    Private Sub SensorSerialNumbersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SensorSerialNumbersToolStripMenuItem.Click
        Me.Show()
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