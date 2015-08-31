<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class USER_GUI
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Me.text_add_zone = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_add_zone = New System.Windows.Forms.Button()
        Me.combo_remove_zone = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_remove_zone = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_add_ambient = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tb_ambient_y = New System.Windows.Forms.TextBox()
        Me.tb_ambient_x = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lv_zones = New System.Windows.Forms.ListView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lv_objects = New System.Windows.Forms.ListView()
        Me.btn_remove_object = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btn_add_object = New System.Windows.Forms.Button()
        Me.combo_remove_object = New System.Windows.Forms.ComboBox()
        Me.text_add_object = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
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
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'text_add_zone
        '
        Me.text_add_zone.Location = New System.Drawing.Point(87, 31)
        Me.text_add_zone.Name = "text_add_zone"
        Me.text_add_zone.Size = New System.Drawing.Size(115, 20)
        Me.text_add_zone.TabIndex = 0
        Me.text_add_zone.Text = "Insert zone name here"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Add zone"
        '
        'btn_add_zone
        '
        Me.btn_add_zone.Location = New System.Drawing.Point(208, 31)
        Me.btn_add_zone.Name = "btn_add_zone"
        Me.btn_add_zone.Size = New System.Drawing.Size(75, 23)
        Me.btn_add_zone.TabIndex = 2
        Me.btn_add_zone.Text = "Add"
        Me.btn_add_zone.UseVisualStyleBackColor = True
        '
        'combo_remove_zone
        '
        Me.combo_remove_zone.FormattingEnabled = True
        Me.combo_remove_zone.Location = New System.Drawing.Point(87, 54)
        Me.combo_remove_zone.Name = "combo_remove_zone"
        Me.combo_remove_zone.Size = New System.Drawing.Size(115, 21)
        Me.combo_remove_zone.TabIndex = 3
        Me.combo_remove_zone.Text = "Select.."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Remove zone"
        '
        'btn_remove_zone
        '
        Me.btn_remove_zone.Location = New System.Drawing.Point(208, 52)
        Me.btn_remove_zone.Name = "btn_remove_zone"
        Me.btn_remove_zone.Size = New System.Drawing.Size(75, 23)
        Me.btn_remove_zone.TabIndex = 5
        Me.btn_remove_zone.Text = "Remove"
        Me.btn_remove_zone.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_add_ambient)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.tb_ambient_y)
        Me.GroupBox1.Controls.Add(Me.tb_ambient_x)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.btn_remove_zone)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btn_add_zone)
        Me.GroupBox1.Controls.Add(Me.combo_remove_zone)
        Me.GroupBox1.Controls.Add(Me.text_add_zone)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 83)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(293, 553)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Zones"
        '
        'btn_add_ambient
        '
        Me.btn_add_ambient.Location = New System.Drawing.Point(100, 145)
        Me.btn_add_ambient.Name = "btn_add_ambient"
        Me.btn_add_ambient.Size = New System.Drawing.Size(75, 23)
        Me.btn_add_ambient.TabIndex = 12
        Me.btn_add_ambient.Text = "Add"
        Me.btn_add_ambient.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(5, 122)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(143, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Add ambient panel location y"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 96)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(143, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Add ambient panel location x"
        '
        'tb_ambient_y
        '
        Me.tb_ambient_y.Location = New System.Drawing.Point(149, 119)
        Me.tb_ambient_y.Name = "tb_ambient_y"
        Me.tb_ambient_y.Size = New System.Drawing.Size(115, 20)
        Me.tb_ambient_y.TabIndex = 9
        Me.tb_ambient_y.Text = "Add location"
        '
        'tb_ambient_x
        '
        Me.tb_ambient_x.Location = New System.Drawing.Point(149, 93)
        Me.tb_ambient_x.Name = "tb_ambient_x"
        Me.tb_ambient_x.Size = New System.Drawing.Size(115, 20)
        Me.tb_ambient_x.TabIndex = 8
        Me.tb_ambient_x.Text = "Add location"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lv_zones)
        Me.Panel1.Location = New System.Drawing.Point(6, 193)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(272, 282)
        Me.Panel1.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Zone List"
        '
        'lv_zones
        '
        Me.lv_zones.AutoArrange = False
        Me.lv_zones.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        ListViewItem1.StateImageIndex = 0
        Me.lv_zones.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.lv_zones.LabelWrap = False
        Me.lv_zones.Location = New System.Drawing.Point(3, 28)
        Me.lv_zones.MultiSelect = False
        Me.lv_zones.Name = "lv_zones"
        Me.lv_zones.Size = New System.Drawing.Size(266, 251)
        Me.lv_zones.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lv_zones.TabIndex = 6
        Me.lv_zones.UseCompatibleStateImageBehavior = False
        Me.lv_zones.View = System.Windows.Forms.View.List
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 23)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Step 1: Set up the zones"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(310, 255)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 23)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "--->"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Panel2)
        Me.GroupBox2.Controls.Add(Me.btn_remove_object)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.btn_add_object)
        Me.GroupBox2.Controls.Add(Me.combo_remove_object)
        Me.GroupBox2.Controls.Add(Me.text_add_object)
        Me.GroupBox2.Location = New System.Drawing.Point(359, 83)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(293, 310)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Objects"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.lv_objects)
        Me.Panel2.Location = New System.Drawing.Point(11, 81)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(272, 221)
        Me.Panel2.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Object List"
        '
        'lv_objects
        '
        Me.lv_objects.AutoArrange = False
        Me.lv_objects.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lv_objects.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem2})
        Me.lv_objects.LabelWrap = False
        Me.lv_objects.Location = New System.Drawing.Point(3, 39)
        Me.lv_objects.MultiSelect = False
        Me.lv_objects.Name = "lv_objects"
        Me.lv_objects.Size = New System.Drawing.Size(266, 179)
        Me.lv_objects.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lv_objects.TabIndex = 6
        Me.lv_objects.UseCompatibleStateImageBehavior = False
        Me.lv_objects.View = System.Windows.Forms.View.List
        '
        'btn_remove_object
        '
        Me.btn_remove_object.Location = New System.Drawing.Point(208, 52)
        Me.btn_remove_object.Name = "btn_remove_object"
        Me.btn_remove_object.Size = New System.Drawing.Size(75, 23)
        Me.btn_remove_object.TabIndex = 5
        Me.btn_remove_object.Text = "Remove"
        Me.btn_remove_object.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Remove Object"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Add Object"
        '
        'btn_add_object
        '
        Me.btn_add_object.Location = New System.Drawing.Point(208, 31)
        Me.btn_add_object.Name = "btn_add_object"
        Me.btn_add_object.Size = New System.Drawing.Size(75, 23)
        Me.btn_add_object.TabIndex = 2
        Me.btn_add_object.Text = "Add"
        Me.btn_add_object.UseVisualStyleBackColor = True
        '
        'combo_remove_object
        '
        Me.combo_remove_object.FormattingEnabled = True
        Me.combo_remove_object.Location = New System.Drawing.Point(87, 54)
        Me.combo_remove_object.Name = "combo_remove_object"
        Me.combo_remove_object.Size = New System.Drawing.Size(115, 21)
        Me.combo_remove_object.TabIndex = 3
        Me.combo_remove_object.Text = "Select.."
        '
        'text_add_object
        '
        Me.text_add_object.Location = New System.Drawing.Point(87, 31)
        Me.text_add_object.Name = "text_add_object"
        Me.text_add_object.Size = New System.Drawing.Size(115, 20)
        Me.text_add_object.TabIndex = 0
        Me.text_add_object.Text = "Insert Object name here"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(355, 55)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(184, 23)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Step 2: Set up Objects"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetupToolStripMenuItem, Me.SimulationToolStripMenuItem, Me.MapToolStripMenuItem, Me.NodeStatusToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(839, 24)
        Me.MenuStrip1.TabIndex = 15
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
        Me.SendMessageToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
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
        Me.NodeStatusToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.NodeStatusToolStripMenuItem1.Text = "Node Status"
        '
        'USER_GUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 637)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "USER_GUI"
        Me.Text = "Zones & Objects"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents text_add_zone As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_add_zone As System.Windows.Forms.Button
    Friend WithEvents combo_remove_zone As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_remove_zone As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lv_zones As System.Windows.Forms.ListView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lv_objects As System.Windows.Forms.ListView
    Friend WithEvents btn_remove_object As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btn_add_object As System.Windows.Forms.Button
    Friend WithEvents combo_remove_object As System.Windows.Forms.ComboBox
    Friend WithEvents text_add_object As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SetupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ZonesObjectsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SensorSerialNumbersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LinkZonesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ObjectDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SimulationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SendMessageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_add_ambient As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tb_ambient_y As System.Windows.Forms.TextBox
    Friend WithEvents tb_ambient_x As System.Windows.Forms.TextBox
    Friend WithEvents MapToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowMapToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RulesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NodeStatusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NodeStatusToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ServicesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
