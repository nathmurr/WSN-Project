Imports MySql.Data.MySqlClient
Public Class USER_GUI_3
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
    Dim user_link As String
    Dim user_to_link As String
    Private Sub USER_GUI_3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim result As DataTable
        Dim table As String
        Dim resultarray(100, 100)

        combo_zone_link.Items.Clear()     'clear the combobox items so data is not duplicated
        combo_zone_to.Items.Clear()     'clear the combobox items so data is not duplicated

        dbcommand = "SELECT * FROM t_zones WHERE (d_zone)<>'';"
        result = Database_functions.database_getall_single_column(dbcommand)
        For Each row As DataRow In result.Rows      'for every row in dt datatable
            table = row.Item("d_zone")    'add value into variable from d_zone column of t_zones table
            combo_zone_link.Items.Add(table)    'add value to combobox
            combo_zone_to.Items.Add(table)    'add value to combobox

            combo_zone_link.EndUpdate()               'update combobox
        Next row        'next row until all rows are obtained

        Call update_listview()

        combo_man_location_direction.Items.Add("Up")    'add value to combobox
        combo_man_location_direction.Items.Add("Down")    'add value to combobox
        combo_man_location_direction.Items.Add("Left")    'add value to combobox
        combo_man_location_direction.Items.Add("Right")    'add value to combobox
        combo_man_location_direction.EndUpdate()               'update combobox
        combo_zone_to.Items.Add("not linked")    'add value to combobox
        combo_zone_to.EndUpdate()               'update combobox
        Call man_listview_update()

    End Sub
    Private Sub update_listview()
        Dim result As DataTable
        Dim linked_zone As String
        Dim linked_to As String
        Dim resultarray(100, 100)
        linked_zones.Items.Clear()

        

        dbcommand = "SELECT * FROM t_zones WHERE (d_zone)<>'' AND (d_zone_link1)<>'';"
        result = Database_functions.database_getall_single_column(dbcommand)
        For Each row As DataRow In result.Rows      'for every row in dt datatable
            linked_zone = row.Item("d_zone")    'add value into variable from d_zone column of t_zones table
            linked_to = row.Item("d_zone_link1")    'add value into variable from d_zone column of t_zones table
            linked_zones.Items.Add(linked_zone & "   linked to   " & linked_to)             'add value to listview
        Next row        'next row until all rows are obtained

        dbcommand = "SELECT * FROM t_zones WHERE (d_zone)<>'' AND (d_zone_link2)<>'';"
        result = Database_functions.database_getall_single_column(dbcommand)
        For Each row As DataRow In result.Rows      'for every row in dt datatable
            linked_zone = row.Item("d_zone")    'add value into variable from d_zone column of t_zones table
            linked_to = row.Item("d_zone_link2")    'add value into variable from d_zone column of t_zones table
            linked_zones.Items.Add(linked_zone & "   linked to   " & linked_to)             'add value to listview
        Next row        'next row until all rows are obtained

        dbcommand = "SELECT * FROM t_zones WHERE (d_zone)<>'' AND (d_zone_link3)<>'';"
        result = Database_functions.database_getall_single_column(dbcommand)
        For Each row As DataRow In result.Rows      'for every row in dt datatable
            linked_zone = row.Item("d_zone")    'add value into variable from d_zone column of t_zones table
            linked_to = row.Item("d_zone_link3")    'add value into variable from d_zone column of t_zones table
            linked_zones.Items.Add(linked_zone & "   linked to   " & linked_to)             'add value to listview
        Next row        'next row until all rows are obtained

        dbcommand = "SELECT * FROM t_zones WHERE (d_zone)<>'' AND (d_zone_link4)<>'';"
        result = Database_functions.database_getall_single_column(dbcommand)
        For Each row As DataRow In result.Rows      'for every row in dt datatable
            linked_zone = row.Item("d_zone")    'add value into variable from d_zone column of t_zones table
            linked_to = row.Item("d_zone_link4")    'add value into variable from d_zone column of t_zones table
            linked_zones.Items.Add(linked_zone & "   linked to   " & linked_to)             'add value to listview
        Next row        'next row until all rows are obtained

        dbcommand = "SELECT * FROM t_zones WHERE (d_zone)<>'' AND (d_zone_link5)<>'';"
        result = Database_functions.database_getall_single_column(dbcommand)
        For Each row As DataRow In result.Rows      'for every row in dt datatable
            linked_zone = row.Item("d_zone")    'add value into variable from d_zone column of t_zones table
            linked_to = row.Item("d_zone_link5")    'add value into variable from d_zone column of t_zones table
            linked_zones.Items.Add(linked_zone & "   linked to   " & linked_to)             'add value to listview
        Next row        'next row until all rows are obtained

    End Sub

    Private Sub btnlink_Click(sender As Object, e As EventArgs) Handles btnlink.Click
        Dim result As DataTable
        Dim linked_zone As String
        Dim linked_to As String
        Dim paste_link As String
        linked_zones.Items.Clear()
        paste_link = "1"
        user_link = combo_zone_link.Text
        user_to_link = combo_zone_to.Text

        

        dbcommand = "SELECT * FROM t_zones WHERE (d_zone_link1)<>'';"
        result = Database_functions.database_getall_single_column(dbcommand)
        For Each row As DataRow In result.Rows      'for every row in dt datatable
            linked_zone = row.Item("d_zone")    'add value into variable from d_zone column of t_zones table

            If linked_zone = user_link Then
                paste_link = "2"
            End If

        Next row        'next row until all rows are obtained

        dbcommand = "SELECT * FROM t_zones WHERE (d_zone_link2)<>'';"
        result = Database_functions.database_getall_single_column(dbcommand)
        For Each row As DataRow In result.Rows      'for every row in dt datatable
            linked_zone = row.Item("d_zone")    'add value into variable from d_zone column of t_zones table

            If linked_zone = user_link Then
                paste_link = "3"
            End If

        Next row        'next row until all rows are obtained

        dbcommand = "SELECT * FROM t_zones WHERE (d_zone_link3)<>'';"
        result = Database_functions.database_getall_single_column(dbcommand)
        For Each row As DataRow In result.Rows      'for every row in dt datatable
            linked_zone = row.Item("d_zone")    'add value into variable from d_zone column of t_zones table

            If linked_zone = user_link Then
                paste_link = "4"
            End If

        Next row        'next row until all rows are obtained

        dbcommand = "SELECT * FROM t_zones WHERE (d_zone_link4)<>'';"
        result = Database_functions.database_getall_single_column(dbcommand)
        For Each row As DataRow In result.Rows      'for every row in dt datatable
            linked_zone = row.Item("d_zone")    'add value into variable from d_zone column of t_zones table

            If linked_zone = user_link Then
                paste_link = "5"
            End If

        Next row        'next row until all rows are obtained

        dbcommand = "UPDATE t_zones SET d_zone_link" & paste_link & "='" & user_to_link & "' WHERE d_zone='" & user_link & "';"
        Database_functions.database_insert_single_column(dbcommand, dbpointer, dbdata)

        Call update_listview()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        user_link = combo_zone_link.Text
        user_to_link = combo_zone_to.Text
        dbcommand = "UPDATE t_zones SET d_zone_link1=NULL WHERE d_zone = '" & user_link & "' AND d_zone_link1 = '" & user_to_link & "';"
        Call Database_functions.database_remove_single_row(dbcommand)
        dbcommand = "UPDATE t_zones SET d_zone_link2=NULL WHERE d_zone = '" & user_link & "' AND d_zone_link2 = '" & user_to_link & "';"
        Call Database_functions.database_remove_single_row(dbcommand)
        dbcommand = "UPDATE t_zones SET d_zone_link3=NULL WHERE d_zone = '" & user_link & "' AND d_zone_link3 = '" & user_to_link & "';"
        Call Database_functions.database_remove_single_row(dbcommand)
        dbcommand = "UPDATE t_zones SET d_zone_link4=NULL WHERE d_zone = '" & user_link & "' AND d_zone_link4 = '" & user_to_link & "';"
        Call Database_functions.database_remove_single_row(dbcommand)
        dbcommand = "UPDATE t_zones SET d_zone_link5=NULL WHERE d_zone = '" & user_link & "' AND d_zone_link5 = '" & user_to_link & "';"
        Call Database_functions.database_remove_single_row(dbcommand)
        Call update_listview()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim man_x As Integer
        Dim man_x_stairs As Integer
        Dim man_y As Integer
        Dim man_y_stairs As Integer
        Dim man_location_direction As String
        user_link = combo_zone_link.Text
        user_to_link = combo_zone_to.Text
        man_x = tb_man_location_x.Text
        man_y = tb_man_location_y.Text
        man_location_direction = combo_man_location_direction.Text

        If user_to_link = "not linked" Then
            dbcommand = "INSERT INTO t_man_locations_non_linked VALUES('" & user_link & "','" & man_x & "','" & man_y & "');"
            Database_functions.database_insert_man_location(dbcommand)
        End If

        If user_to_link <> "not linked" And tb_man_location_x_stairwell.Text <> "" Then
            man_x_stairs = tb_man_location_x_stairwell.Text
            man_y_stairs = tb_man_location_x_stairwell.Text
        Else
            man_x_stairs = 123
            man_y_stairs = 123
        End If



        If user_to_link <> "not linked" And user_link <> "not linked" And tb_man_location_x_stairwell.Text = "" Then
            dbcommand = "INSERT INTO t_man_locations VALUES('" & user_link & "','" & user_to_link & "','" & man_x & "','" & man_y & "','" & man_location_direction & "',NULL,NULL);"
            Database_functions.database_insert_man_location(dbcommand)
        End If


        Call man_listview_update()
    End Sub

    Private Sub man_listview_update()
        Dim result As DataTable
        Dim d_zone1 As String
        Dim d_zone2 As String
        Dim d_man_location_x As Integer
        Dim d_man_location_y As Integer
        Dim d_man_location_direction As String

        bb.Items.Clear()

        dbcommand = "SELECT * FROM t_man_locations WHERE (d_zone1)<>'';"
        result = Database_functions.database_getall_single_column(dbcommand)
        For Each row As DataRow In result.Rows      'for every row in dt datatable
            d_zone1 = row.Item("d_zone1")    'add value into variable from d_zone column of t_zones table
            d_zone2 = row.Item("d_zone2")    'add value into variable from d_zone column of t_zones table
            d_man_location_x = row.Item("d_man_location_x")    'add value into variable from d_zone column of t_zones table
            d_man_location_y = row.Item("d_man_location_y")    'add value into variable from d_zone column of t_zones table
            d_man_location_direction = row.Item("d_man_location_direction")    'add value into variable from d_zone column of t_zones table
            
            bb.Items.Add(d_zone1 & " to " & d_zone2 & " man image details; x = " & d_man_location_x & ", y = " & d_man_location_y & ", direction = " & d_man_location_direction)             'add value to listview
        Next row

        dbcommand = "SELECT * FROM t_man_locations_non_linked;"
        result = Database_functions.database_getall_single_column(dbcommand)
        For Each row As DataRow In result.Rows      'for every row in dt datatable
            d_zone1 = row.Item("d_zone")    'add value into variable from d_zone column of t_zones table
            d_man_location_x = row.Item("d_man_location_x_non_linked")    'add value into variable from d_zone column of t_zones table
            d_man_location_y = row.Item("d_man_location_y_non_linked")    'add value into variable from d_zone column of t_zones table
            bb.Items.Add(d_zone1 & " is non linked, man image details; x = " & d_man_location_x & ", y = " & d_man_location_y & ", direction = " & d_man_location_direction)             'add value to listview
        Next row        'next row until all rows are obtained

    End Sub

    Private Sub btn_man_remove_Click(sender As Object, e As EventArgs) Handles btn_man_remove.Click
        user_link = combo_zone_link.Text
        user_to_link = combo_zone_to.Text
        dbcommand = "DELETE FROM t_man_locations WHERE d_zone1='" & user_link & "' AND d_zone2='" & user_to_link & "';"
        Call Database_functions.database_remove_single_row(dbcommand)
        Call man_listview_update()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        user_link = combo_zone_link.Text
        user_to_link = combo_zone_to.Text
        dbcommand = "DELETE FROM t_man_locations WHERE d_zone1='" & user_link & "';"
        Call Database_functions.database_remove_single_row(dbcommand)
        Call man_listview_update()
    End Sub
    Private Sub ZonesObjectsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZonesObjectsToolStripMenuItem.Click
        USER_GUI.Show()
    End Sub

    Private Sub SensorSerialNumbersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SensorSerialNumbersToolStripMenuItem.Click
        USER_GUI_2.Show()
    End Sub

    Private Sub LinkZonesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LinkZonesToolStripMenuItem.Click
        Me.Show()
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