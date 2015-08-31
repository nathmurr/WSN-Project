<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class USER_GUI_3
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_man_remove = New System.Windows.Forms.Button()
        Me.combo_zone_link = New System.Windows.Forms.ComboBox()
        Me.btnlink = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.combo_zone_to = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.linked_zones = New System.Windows.Forms.ListView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.combo_man_location_direction = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_man_location_y = New System.Windows.Forms.TextBox()
        Me.tb_man_location_x = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tb_man_location_x_stairwell = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tb_man_location_y_stairwell = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.bb = New System.Windows.Forms.ListView()
        Me.Label6 = New System.Windows.Forms.Label()
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btn_man_remove)
        Me.GroupBox1.Controls.Add(Me.combo_zone_link)
        Me.GroupBox1.Controls.Add(Me.btnlink)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.combo_zone_to)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(345, 167)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Link Zones"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "With this Zone"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Link This zone"
        '
        'btn_man_remove
        '
        Me.btn_man_remove.Location = New System.Drawing.Point(193, 132)
        Me.btn_man_remove.Name = "btn_man_remove"
        Me.btn_man_remove.Size = New System.Drawing.Size(146, 23)
        Me.btn_man_remove.TabIndex = 34
        Me.btn_man_remove.Text = "Remove person image data"
        Me.btn_man_remove.UseVisualStyleBackColor = True
        '
        'combo_zone_link
        '
        Me.combo_zone_link.FormattingEnabled = True
        Me.combo_zone_link.Location = New System.Drawing.Point(6, 52)
        Me.combo_zone_link.Name = "combo_zone_link"
        Me.combo_zone_link.Size = New System.Drawing.Size(309, 21)
        Me.combo_zone_link.TabIndex = 9
        Me.combo_zone_link.Text = "Zone.."
        '
        'btnlink
        '
        Me.btnlink.Location = New System.Drawing.Point(7, 132)
        Me.btnlink.Name = "btnlink"
        Me.btnlink.Size = New System.Drawing.Size(75, 23)
        Me.btnlink.TabIndex = 13
        Me.btnlink.Text = "Link"
        Me.btnlink.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(88, 132)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Remove Link"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'combo_zone_to
        '
        Me.combo_zone_to.FormattingEnabled = True
        Me.combo_zone_to.Location = New System.Drawing.Point(9, 105)
        Me.combo_zone_to.Name = "combo_zone_to"
        Me.combo_zone_to.Size = New System.Drawing.Size(309, 21)
        Me.combo_zone_to.TabIndex = 10
        Me.combo_zone_to.Text = "Zone.."
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.linked_zones)
        Me.GroupBox2.Location = New System.Drawing.Point(424, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(584, 265)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Linked Zones"
        '
        'linked_zones
        '
        Me.linked_zones.AutoArrange = False
        Me.linked_zones.LabelWrap = False
        Me.linked_zones.Location = New System.Drawing.Point(6, 19)
        Me.linked_zones.Name = "linked_zones"
        Me.linked_zones.Size = New System.Drawing.Size(570, 240)
        Me.linked_zones.TabIndex = 0
        Me.linked_zones.UseCompatibleStateImageBehavior = False
        Me.linked_zones.View = System.Windows.Forms.View.List
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(872, 592)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(250, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Person Location Direction"
        '
        'combo_man_location_direction
        '
        Me.combo_man_location_direction.FormattingEnabled = True
        Me.combo_man_location_direction.Location = New System.Drawing.Point(253, 158)
        Me.combo_man_location_direction.Name = "combo_man_location_direction"
        Me.combo_man_location_direction.Size = New System.Drawing.Size(114, 21)
        Me.combo_man_location_direction.TabIndex = 28
        Me.combo_man_location_direction.Text = "Select.."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(143, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Person Location Y"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Person Location X"
        '
        'tb_man_location_y
        '
        Me.tb_man_location_y.Location = New System.Drawing.Point(146, 160)
        Me.tb_man_location_y.Name = "tb_man_location_y"
        Me.tb_man_location_y.Size = New System.Drawing.Size(100, 20)
        Me.tb_man_location_y.TabIndex = 25
        '
        'tb_man_location_x
        '
        Me.tb_man_location_x.Location = New System.Drawing.Point(40, 160)
        Me.tb_man_location_x.Name = "tb_man_location_x"
        Me.tb_man_location_x.Size = New System.Drawing.Size(100, 20)
        Me.tb_man_location_x.TabIndex = 24
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.tb_man_location_x_stairwell)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.tb_man_location_y_stairwell)
        Me.GroupBox3.Controls.Add(Me.tb_man_location_x)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.tb_man_location_y)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.combo_man_location_direction)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(18, 235)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(398, 349)
        Me.GroupBox3.TabIndex = 34
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Man Image Locations"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(5, 198)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(380, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Only fill below data in for person image at top of stairs if linked zone is a sta" & _
    "irwell"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(112, 280)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "Link"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(8, 32)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(239, 13)
        Me.Label16.TabIndex = 36
        Me.Label16.Text = "If not a stairwell then fill in for man image in zone1"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(8, 48)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(269, 13)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "If Linked zone is a stairwell then fill in for bottom of stairs"
        '
        'tb_man_location_x_stairwell
        '
        Me.tb_man_location_x_stairwell.Location = New System.Drawing.Point(5, 238)
        Me.tb_man_location_x_stairwell.Name = "tb_man_location_x_stairwell"
        Me.tb_man_location_x_stairwell.Size = New System.Drawing.Size(100, 20)
        Me.tb_man_location_x_stairwell.TabIndex = 24
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(284, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "This data will be associated with the above selected zones"
        '
        'tb_man_location_y_stairwell
        '
        Me.tb_man_location_y_stairwell.Location = New System.Drawing.Point(111, 238)
        Me.tb_man_location_y_stairwell.Name = "tb_man_location_y_stairwell"
        Me.tb_man_location_y_stairwell.Size = New System.Drawing.Size(100, 20)
        Me.tb_man_location_y_stairwell.TabIndex = 25
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(108, 222)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 13)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Person Location Y"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(5, 222)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(94, 13)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Person Location X"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.bb)
        Me.GroupBox4.Location = New System.Drawing.Point(426, 307)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(588, 272)
        Me.GroupBox4.TabIndex = 15
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Person Image Data"
        '
        'bb
        '
        Me.bb.AutoArrange = False
        Me.bb.LabelWrap = False
        Me.bb.Location = New System.Drawing.Point(8, 24)
        Me.bb.Name = "bb"
        Me.bb.Size = New System.Drawing.Size(576, 240)
        Me.bb.TabIndex = 0
        Me.bb.UseCompatibleStateImageBehavior = False
        Me.bb.View = System.Windows.Forms.View.List
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(361, 13)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "To enter person coordinates for non linked zones select the desired zone in"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetupToolStripMenuItem, Me.SimulationToolStripMenuItem, Me.MapToolStripMenuItem, Me.NodeStatusToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1021, 24)
        Me.MenuStrip1.TabIndex = 38
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(40, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(293, 13)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = """Link this zone"" box and ""not linked"" in ""With this zone"" box"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(96, 104)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(168, 13)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "and then enter Person Image data"
        '
        'USER_GUI_3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1021, 626)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "USER_GUI_3"
        Me.Text = "Linked Zones"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents combo_zone_to As System.Windows.Forms.ComboBox
    Friend WithEvents combo_zone_link As System.Windows.Forms.ComboBox
    Friend WithEvents btnlink As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents linked_zones As System.Windows.Forms.ListView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents combo_man_location_direction As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tb_man_location_y As System.Windows.Forms.TextBox
    Friend WithEvents tb_man_location_x As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents bb As System.Windows.Forms.ListView
    Friend WithEvents btn_man_remove As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tb_man_location_x_stairwell As System.Windows.Forms.TextBox
    Friend WithEvents tb_man_location_y_stairwell As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
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
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
