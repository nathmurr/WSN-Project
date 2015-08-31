<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class USER_GUI_4
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
        Me.btn_remove = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_man_add = New System.Windows.Forms.Button()
        Me.tb_objectname_active = New System.Windows.Forms.TextBox()
        Me.tb_objectname_inactive = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_object_y = New System.Windows.Forms.TextBox()
        Me.tb_object_x = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.combo_zone_link = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lv_Objects = New System.Windows.Forms.ListView()
        Me.ServiceController1 = New System.ServiceProcess.ServiceController()
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_remove)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btn_man_add)
        Me.GroupBox1.Controls.Add(Me.tb_objectname_active)
        Me.GroupBox1.Controls.Add(Me.tb_objectname_inactive)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.tb_object_y)
        Me.GroupBox1.Controls.Add(Me.tb_object_x)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.combo_zone_link)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(350, 265)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Object Location Details"
        '
        'btn_remove
        '
        Me.btn_remove.Location = New System.Drawing.Point(159, 216)
        Me.btn_remove.Name = "btn_remove"
        Me.btn_remove.Size = New System.Drawing.Size(108, 23)
        Me.btn_remove.TabIndex = 25
        Me.btn_remove.Text = "Remove Details"
        Me.btn_remove.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Object codename when Active"
        '
        'btn_man_add
        '
        Me.btn_man_add.Location = New System.Drawing.Point(6, 216)
        Me.btn_man_add.Name = "btn_man_add"
        Me.btn_man_add.Size = New System.Drawing.Size(126, 23)
        Me.btn_man_add.TabIndex = 23
        Me.btn_man_add.Text = "Update Details"
        Me.btn_man_add.UseVisualStyleBackColor = True
        '
        'tb_objectname_active
        '
        Me.tb_objectname_active.Location = New System.Drawing.Point(9, 179)
        Me.tb_objectname_active.Name = "tb_objectname_active"
        Me.tb_objectname_active.Size = New System.Drawing.Size(151, 20)
        Me.tb_objectname_active.TabIndex = 22
        '
        'tb_objectname_inactive
        '
        Me.tb_objectname_inactive.Location = New System.Drawing.Point(10, 140)
        Me.tb_objectname_inactive.Name = "tb_objectname_inactive"
        Me.tb_objectname_inactive.Size = New System.Drawing.Size(158, 20)
        Me.tb_objectname_inactive.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(161, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Object codename when Inactive"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(109, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Object Location Y"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Object Location X"
        '
        'tb_object_y
        '
        Me.tb_object_y.Location = New System.Drawing.Point(111, 92)
        Me.tb_object_y.Name = "tb_object_y"
        Me.tb_object_y.Size = New System.Drawing.Size(100, 20)
        Me.tb_object_y.TabIndex = 14
        '
        'tb_object_x
        '
        Me.tb_object_x.Location = New System.Drawing.Point(5, 92)
        Me.tb_object_x.Name = "tb_object_x"
        Me.tb_object_x.Size = New System.Drawing.Size(100, 20)
        Me.tb_object_x.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Objects"
        '
        'combo_zone_link
        '
        Me.combo_zone_link.FormattingEnabled = True
        Me.combo_zone_link.Location = New System.Drawing.Point(6, 52)
        Me.combo_zone_link.Name = "combo_zone_link"
        Me.combo_zone_link.Size = New System.Drawing.Size(309, 21)
        Me.combo_zone_link.TabIndex = 9
        Me.combo_zone_link.Text = "Select Object.."
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lv_Objects)
        Me.GroupBox2.Location = New System.Drawing.Point(383, 31)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(596, 265)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Object Details"
        '
        'lv_Objects
        '
        Me.lv_Objects.AutoArrange = False
        Me.lv_Objects.LabelWrap = False
        Me.lv_Objects.Location = New System.Drawing.Point(7, 19)
        Me.lv_Objects.Name = "lv_Objects"
        Me.lv_Objects.Size = New System.Drawing.Size(566, 240)
        Me.lv_Objects.TabIndex = 0
        Me.lv_Objects.UseCompatibleStateImageBehavior = False
        Me.lv_Objects.View = System.Windows.Forms.View.List
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(654, 294)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetupToolStripMenuItem, Me.SimulationToolStripMenuItem, Me.MapToolStripMenuItem, Me.NodeStatusToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(991, 24)
        Me.MenuStrip1.TabIndex = 17
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
        'USER_GUI_4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(991, 329)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "USER_GUI_4"
        Me.Text = "Object Location x y "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents combo_zone_link As System.Windows.Forms.ComboBox
    Friend WithEvents btn_man_add As System.Windows.Forms.Button
    Friend WithEvents tb_objectname_active As System.Windows.Forms.TextBox
    Friend WithEvents tb_objectname_inactive As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tb_object_y As System.Windows.Forms.TextBox
    Friend WithEvents tb_object_x As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lv_Objects As System.Windows.Forms.ListView
    Friend WithEvents ServiceController1 As System.ServiceProcess.ServiceController
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_remove As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
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
