<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sim_node_hardware_messages
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.combo_serial = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.combo_send_data = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label_zoneobject = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.label_sensor_type = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZonesObjectsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SensorSerialNumbersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LinkZonesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ObjectDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RulesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SimulationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SendMessageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MapToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowMapToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NodeStatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NodeStatusToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'combo_serial
        '
        Me.combo_serial.FormattingEnabled = True
        Me.combo_serial.Location = New System.Drawing.Point(9, 67)
        Me.combo_serial.Name = "combo_serial"
        Me.combo_serial.Size = New System.Drawing.Size(121, 21)
        Me.combo_serial.TabIndex = 0
        Me.combo_serial.Text = "Select.."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sensor Serial number"
        '
        'combo_send_data
        '
        Me.combo_send_data.FormattingEnabled = True
        Me.combo_send_data.Location = New System.Drawing.Point(6, 205)
        Me.combo_send_data.Name = "combo_send_data"
        Me.combo_send_data.Size = New System.Drawing.Size(117, 21)
        Me.combo_send_data.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label_zoneobject)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.label_sensor_type)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.combo_serial)
        Me.GroupBox1.Controls.Add(Me.combo_send_data)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(222, 289)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Node Message Creation Simulator"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Zone/Object Location"
        '
        'Label_zoneobject
        '
        Me.Label_zoneobject.AutoSize = True
        Me.Label_zoneobject.Location = New System.Drawing.Point(6, 122)
        Me.Label_zoneobject.Name = "Label_zoneobject"
        Me.Label_zoneobject.Size = New System.Drawing.Size(0, 13)
        Me.Label_zoneobject.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(9, 232)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Send to Database"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Sensor Type"
        '
        'label_sensor_type
        '
        Me.label_sensor_type.AutoSize = True
        Me.label_sensor_type.Location = New System.Drawing.Point(6, 169)
        Me.label_sensor_type.Name = "label_sensor_type"
        Me.label_sensor_type.Size = New System.Drawing.Size(0, 13)
        Me.label_sensor_type.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 189)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Send_Data"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetupToolStripMenuItem, Me.SimulationToolStripMenuItem, Me.MapToolStripMenuItem, Me.NodeStatusToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(604, 24)
        Me.MenuStrip1.TabIndex = 16
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SetupToolStripMenuItem
        '
        Me.SetupToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ZonesObjectsToolStripMenuItem, Me.SensorSerialNumbersToolStripMenuItem, Me.LinkZonesToolStripMenuItem, Me.ObjectDetailsToolStripMenuItem, Me.RulesToolStripMenuItem, Me.ServicesToolStripMenuItem})
        Me.SetupToolStripMenuItem.Name = "SetupToolStripMenuItem"
        Me.SetupToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.SetupToolStripMenuItem.Text = "Setup"
        '
        'ZonesObjectsToolStripMenuItem
        '
        Me.ZonesObjectsToolStripMenuItem.Name = "ZonesObjectsToolStripMenuItem"
        Me.ZonesObjectsToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
        Me.ZonesObjectsToolStripMenuItem.Text = "Zones/Objects"
        '
        'SensorSerialNumbersToolStripMenuItem
        '
        Me.SensorSerialNumbersToolStripMenuItem.Name = "SensorSerialNumbersToolStripMenuItem"
        Me.SensorSerialNumbersToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
        Me.SensorSerialNumbersToolStripMenuItem.Text = "Sensor Serial Numbers"
        '
        'LinkZonesToolStripMenuItem
        '
        Me.LinkZonesToolStripMenuItem.Name = "LinkZonesToolStripMenuItem"
        Me.LinkZonesToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
        Me.LinkZonesToolStripMenuItem.Text = "Link Zones/Man img locations"
        '
        'ObjectDetailsToolStripMenuItem
        '
        Me.ObjectDetailsToolStripMenuItem.Name = "ObjectDetailsToolStripMenuItem"
        Me.ObjectDetailsToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
        Me.ObjectDetailsToolStripMenuItem.Text = "Object Details"
        '
        'RulesToolStripMenuItem
        '
        Me.RulesToolStripMenuItem.Name = "RulesToolStripMenuItem"
        Me.RulesToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
        Me.RulesToolStripMenuItem.Text = "Rules"
        '
        'ServicesToolStripMenuItem
        '
        Me.ServicesToolStripMenuItem.Name = "ServicesToolStripMenuItem"
        Me.ServicesToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
        Me.ServicesToolStripMenuItem.Text = "Services"
        '
        'SimulationToolStripMenuItem
        '
        Me.SimulationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SendMessageToolStripMenuItem})
        Me.SimulationToolStripMenuItem.Name = "SimulationToolStripMenuItem"
        Me.SimulationToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.SimulationToolStripMenuItem.Text = "Simulation"
        '
        'SendMessageToolStripMenuItem
        '
        Me.SendMessageToolStripMenuItem.Name = "SendMessageToolStripMenuItem"
        Me.SendMessageToolStripMenuItem.Size = New System.Drawing.Size(131, 22)
        Me.SendMessageToolStripMenuItem.Text = "Simulation"
        '
        'MapToolStripMenuItem
        '
        Me.MapToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowMapToolStripMenuItem})
        Me.MapToolStripMenuItem.Name = "MapToolStripMenuItem"
        Me.MapToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.MapToolStripMenuItem.Text = "Map"
        '
        'ShowMapToolStripMenuItem
        '
        Me.ShowMapToolStripMenuItem.Name = "ShowMapToolStripMenuItem"
        Me.ShowMapToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.ShowMapToolStripMenuItem.Text = "Show Map"
        '
        'NodeStatusToolStripMenuItem
        '
        Me.NodeStatusToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NodeStatusToolStripMenuItem1})
        Me.NodeStatusToolStripMenuItem.Name = "NodeStatusToolStripMenuItem"
        Me.NodeStatusToolStripMenuItem.Size = New System.Drawing.Size(83, 20)
        Me.NodeStatusToolStripMenuItem.Text = "Node Status"
        '
        'NodeStatusToolStripMenuItem1
        '
        Me.NodeStatusToolStripMenuItem1.Name = "NodeStatusToolStripMenuItem1"
        Me.NodeStatusToolStripMenuItem1.Size = New System.Drawing.Size(138, 22)
        Me.NodeStatusToolStripMenuItem1.Text = "Node Status"
        '
        'sim_node_hardware_messages
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 373)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "sim_node_hardware_messages"
        Me.Text = "sim_node_hardware_messages"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents combo_serial As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents combo_send_data As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents label_sensor_type As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label_zoneobject As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SetupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ZonesObjectsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SensorSerialNumbersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LinkZonesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ObjectDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RulesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ServicesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SimulationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SendMessageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MapToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowMapToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NodeStatusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NodeStatusToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
End Class
