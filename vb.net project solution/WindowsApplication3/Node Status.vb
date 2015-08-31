
Public Class Node_Status
    Dim dbcommand As String
    Dim dbpointer As String
    Dim dbdata As String
    Dim result As DataTable
    Dim serial As Integer
    Dim batt_perc As Integer
    Dim rssi As Byte
    Dim rssi_int As Integer
    Dim nodename As String

    Private Sub Node_Status_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rtb_nodestatus.Text = "Object/Zone" & vbTab & "Serial No" & vbTab & vbTab & "Battery Percentage" & vbTab & vbTab & "RSSI" & vbTab & vbTab & "Name" & vbCrLf & vbCrLf


        'select all node battery and rssi values from database that are objects
        dbcommand = "SELECT * FROM t_node_hw WHERE (d_batt_perc)<>'' AND (d_objects_key)<>'';"
        result = Database_functions.database_getall_single_column(dbcommand)
        For Each row As DataRow In result.Rows      'for every row in dt datatable
            serial = row.Item("d_serialno")
            batt_perc = row.Item("d_batt_perc")
            rssi = row.Item("d_rssi")
            nodename = row.Item("d_objects_key")
            'perform 2s compliment on rssi value
            If (rssi <= 255) And (rssi >= 128) Then
                rssi_int = -(Not rssi) + 1
            End If
            rtb_nodestatus.Text = rtb_nodestatus.Text & "Object" & vbTab & vbTab & Str(serial) & vbTab & vbTab & Str(batt_perc) & "%" & vbTab & vbTab & vbTab & Str(rssi_int) & "dBm" & vbTab & vbTab & nodename & vbCrLf
        Next row        'next row until all rows are obtained

        'select all node battery and rssi values from database that are zones
        dbcommand = "SELECT * FROM t_node_hw WHERE (d_batt_perc)<>'' AND (d_zones_key)<>'';"
        result = Database_functions.database_getall_single_column(dbcommand)
        For Each row As DataRow In result.Rows      'for every row in dt datatable
            serial = row.Item("d_serialno")
            batt_perc = row.Item("d_batt_perc")
            rssi = row.Item("d_rssi")
            nodename = row.Item("d_zones_key")
            'perform 2s compliment on rssi value
            If (rssi <= 255) And (rssi >= 128) Then
                rssi_int = -(Not rssi) + 1
            End If
            rtb_nodestatus.Text = rtb_nodestatus.Text & "Zone" & vbTab & vbTab & Str(serial) & vbTab & vbTab & Str(batt_perc) & "%" & vbTab & vbTab & vbTab & Str(rssi_int) & "dBm" & vbTab & vbTab & nodename & vbCrLf
        Next row        'next row until all rows are obtained

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
        Me.Show()
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