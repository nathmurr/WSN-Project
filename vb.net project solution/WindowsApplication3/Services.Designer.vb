<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Services
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lv_onoff = New System.Windows.Forms.ListView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.combo_onoff = New System.Windows.Forms.ComboBox()
        Me.Service = New System.Windows.Forms.Label()
        Me.lv_services = New System.Windows.Forms.ListView()
        Me.combo_services = New System.Windows.Forms.ComboBox()
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lv_onoff)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.combo_onoff)
        Me.GroupBox1.Controls.Add(Me.Service)
        Me.GroupBox1.Controls.Add(Me.lv_services)
        Me.GroupBox1.Controls.Add(Me.combo_services)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(574, 399)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Services"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(456, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "On/Off"
        '
        'lv_onoff
        '
        Me.lv_onoff.Location = New System.Drawing.Point(448, 80)
        Me.lv_onoff.Name = "lv_onoff"
        Me.lv_onoff.Size = New System.Drawing.Size(72, 324)
        Me.lv_onoff.TabIndex = 9
        Me.lv_onoff.UseCompatibleStateImageBehavior = False
        Me.lv_onoff.View = System.Windows.Forms.View.List
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(352, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Services"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(7, 111)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(184, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "On/Off"
        '
        'combo_onoff
        '
        Me.combo_onoff.FormattingEnabled = True
        Me.combo_onoff.Location = New System.Drawing.Point(184, 69)
        Me.combo_onoff.Name = "combo_onoff"
        Me.combo_onoff.Size = New System.Drawing.Size(86, 21)
        Me.combo_onoff.TabIndex = 3
        Me.combo_onoff.Text = "Select.."
        '
        'Service
        '
        Me.Service.AutoSize = True
        Me.Service.Location = New System.Drawing.Point(7, 53)
        Me.Service.Name = "Service"
        Me.Service.Size = New System.Drawing.Size(43, 13)
        Me.Service.TabIndex = 2
        Me.Service.Text = "Service"
        '
        'lv_services
        '
        Me.lv_services.Location = New System.Drawing.Point(304, 80)
        Me.lv_services.Name = "lv_services"
        Me.lv_services.Size = New System.Drawing.Size(144, 324)
        Me.lv_services.TabIndex = 1
        Me.lv_services.UseCompatibleStateImageBehavior = False
        Me.lv_services.View = System.Windows.Forms.View.List
        '
        'combo_services
        '
        Me.combo_services.FormattingEnabled = True
        Me.combo_services.Location = New System.Drawing.Point(10, 69)
        Me.combo_services.Name = "combo_services"
        Me.combo_services.Size = New System.Drawing.Size(158, 21)
        Me.combo_services.TabIndex = 0
        Me.combo_services.Text = "Select.."
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetupToolStripMenuItem, Me.SimulationToolStripMenuItem, Me.MapToolStripMenuItem, Me.NodeStatusToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(645, 24)
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
        'Services
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 541)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Services"
        Me.Text = "Services"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents combo_onoff As System.Windows.Forms.ComboBox
    Friend WithEvents Service As System.Windows.Forms.Label
    Friend WithEvents lv_services As System.Windows.Forms.ListView
    Friend WithEvents combo_services As System.Windows.Forms.ComboBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lv_onoff As System.Windows.Forms.ListView
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
