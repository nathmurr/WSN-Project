Imports MySql.Data.MySqlClient

Public Class USER_GUI_4
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
    Private Sub USER_GUI_4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call update_listview()
        Call update_objects_combo()
    End Sub
    Private Sub update_objects_combo()
        Dim result As DataTable
        Dim table As String

        combo_zone_link.Items.Clear()     'clear the combobox items so data is not duplicated

        dbcommand = "SELECT * FROM t_zones WHERE (d_object)<>'';"
        result = Database_functions.database_getall_single_column(dbcommand)
        For Each row As DataRow In result.Rows      'for every row in dt datatable
            table = row.Item("d_object")    'add value into variable from d_zone column of t_zones table
            combo_zone_link.Items.Add(table)    'add value to combobox
            combo_zone_link.EndUpdate()               'update combobox
        Next row        'next row until all rows are obtained

    End Sub
    Private Sub update_listview()
        Dim result As DataTable
        Dim get_object As String
        Dim object_x As Integer
        Dim object_y As Integer
        Dim name_1 As String
        Dim name_2 As String


        lv_Objects.Items.Clear()     'clear the combobox items so data is not duplicated

        dbcommand = "SELECT * FROM t_zones WHERE (d_object)<>'' AND (d_object_location_x)<>'' AND (d_object_codename1)<>'';"
        result = Database_functions.database_getall_single_column(dbcommand)
        For Each row As DataRow In result.Rows      'for every row in dt datatable
            get_object = row.Item("d_object")    'add value into variable from d_zone column of t_zones table
            object_x = row.Item("d_object_location_x")
            object_y = row.Item("d_object_location_y")
            name_1 = row.Item("d_object_codename1")
            name_2 = row.Item("d_object_codename2")
            lv_Objects.Items.Add("Object " & get_object & ":, x = " & object_x & ", y = " & object_y & ", name1= " & name_1 & ", name2= " & name_2 & ";")    'add value to combobox
            lv_Objects.EndUpdate()               'update combobox
        Next row        'next row until all rows are obtained
    End Sub

    Private Sub btn_man_add_Click(sender As Object, e As EventArgs) Handles btn_man_add.Click
        Dim combo_object As String
        Dim object_x As String
        Dim object_y As String
        Dim objectname_inactive As String
        Dim objectname_active As String

        object_x = tb_object_x.Text
        object_y = tb_object_y.Text
        objectname_inactive = tb_objectname_inactive.Text
        objectname_active = tb_objectname_active.Text
        combo_object = combo_zone_link.Text

        dbcommand = "UPDATE t_zones SET d_object_location_x='" & object_x & "' WHERE d_object='" & combo_object & "';"
        dbpointer = "@pointer"
        Database_functions.database_insert_single_column(dbcommand, dbpointer, object_x)

        dbcommand = "UPDATE t_zones SET d_object_location_y='" & object_y & "' WHERE d_object='" & combo_object & "';"
        dbpointer = "@pointer"
        Database_functions.database_insert_single_column(dbcommand, dbpointer, object_y)

        dbcommand = "UPDATE t_zones SET d_object_codename1='" & objectname_inactive & "' WHERE d_object='" & combo_object & "';"
        dbpointer = "@pointer"
        Database_functions.database_insert_single_column(dbcommand, dbpointer, objectname_inactive)

        dbcommand = "UPDATE t_zones SET d_object_codename2='" & objectname_active & "' WHERE d_object='" & combo_object & "';"
        dbpointer = "@pointer"
        Database_functions.database_insert_single_column(dbcommand, dbpointer, objectname_inactive)
        Call update_listview()
    End Sub

    
    Private Sub btn_remove_Click(sender As Object, e As EventArgs) Handles btn_remove.Click
        Dim combo_object As String
        Dim object_x As String
        Dim object_y As String
        Dim object_codename1 As String
        Dim object_codename2 As String

        combo_object = combo_zone_link.Text
        object_x = "NULL"
        object_y = "NULL"
        object_codename1 = "NULL"
        object_codename2 = "NULL"

        dbcommand = "UPDATE t_zones SET d_object_location_x=NULL WHERE d_object='" & combo_object & "';"
        Database_functions.database_update(dbcommand)

        dbcommand = "UPDATE t_zones SET d_object_location_y=NULL WHERE d_object='" & combo_object & "';"
        Database_functions.database_update(dbcommand)

        dbcommand = "UPDATE t_zones SET d_object_codename1=NULL WHERE d_object='" & combo_object & "';"
        Database_functions.database_update(dbcommand)

        dbcommand = "UPDATE t_zones SET d_object_codename2=NULL WHERE d_object='" & combo_object & "';"
        Database_functions.database_update(dbcommand)

        Call update_listview()
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
        Me.Show()
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