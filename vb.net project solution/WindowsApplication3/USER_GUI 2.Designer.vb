<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class USER_GUI_2
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
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("")
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lv_node_sn = New System.Windows.Forms.ListView()
        Me.combo_remove_node_sn = New System.Windows.Forms.ComboBox()
        Me.btn_add_node_zone = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btn_remove_node_sn = New System.Windows.Forms.Button()
        Me.combo_zone = New System.Windows.Forms.ComboBox()
        Me.text_add_node_sn = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.combo_objects = New System.Windows.Forms.ComboBox()
        Me.btn_add_object = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
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
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(367, 23)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Step 3: Associate sensors with zones/objects"
        '
        'lv_node_sn
        '
        Me.lv_node_sn.AutoArrange = False
        Me.lv_node_sn.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lv_node_sn.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem4})
        Me.lv_node_sn.LabelWrap = False
        Me.lv_node_sn.Location = New System.Drawing.Point(6, 17)
        Me.lv_node_sn.MultiSelect = False
        Me.lv_node_sn.Name = "lv_node_sn"
        Me.lv_node_sn.Size = New System.Drawing.Size(487, 404)
        Me.lv_node_sn.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lv_node_sn.TabIndex = 6
        Me.lv_node_sn.UseCompatibleStateImageBehavior = False
        Me.lv_node_sn.View = System.Windows.Forms.View.List
        '
        'combo_remove_node_sn
        '
        Me.combo_remove_node_sn.FormattingEnabled = True
        Me.combo_remove_node_sn.Location = New System.Drawing.Point(9, 148)
        Me.combo_remove_node_sn.Name = "combo_remove_node_sn"
        Me.combo_remove_node_sn.Size = New System.Drawing.Size(115, 21)
        Me.combo_remove_node_sn.TabIndex = 3
        Me.combo_remove_node_sn.Text = "Select.."
        '
        'btn_add_node_zone
        '
        Me.btn_add_node_zone.Location = New System.Drawing.Point(321, 79)
        Me.btn_add_node_zone.Name = "btn_add_node_zone"
        Me.btn_add_node_zone.Size = New System.Drawing.Size(116, 23)
        Me.btn_add_node_zone.TabIndex = 2
        Me.btn_add_node_zone.Text = "Add S/N to Zone"
        Me.btn_add_node_zone.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 132)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 13)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Remove Sensor"
        '
        'btn_remove_node_sn
        '
        Me.btn_remove_node_sn.Location = New System.Drawing.Point(9, 175)
        Me.btn_remove_node_sn.Name = "btn_remove_node_sn"
        Me.btn_remove_node_sn.Size = New System.Drawing.Size(75, 23)
        Me.btn_remove_node_sn.TabIndex = 5
        Me.btn_remove_node_sn.Text = "Remove"
        Me.btn_remove_node_sn.UseVisualStyleBackColor = True
        '
        'combo_zone
        '
        Me.combo_zone.FormattingEnabled = True
        Me.combo_zone.Location = New System.Drawing.Point(6, 81)
        Me.combo_zone.Name = "combo_zone"
        Me.combo_zone.Size = New System.Drawing.Size(309, 21)
        Me.combo_zone.TabIndex = 8
        Me.combo_zone.Text = "Zone.."
        '
        'text_add_node_sn
        '
        Me.text_add_node_sn.Location = New System.Drawing.Point(9, 33)
        Me.text_add_node_sn.Name = "text_add_node_sn"
        Me.text_add_node_sn.Size = New System.Drawing.Size(115, 20)
        Me.text_add_node_sn.TabIndex = 0
        Me.text_add_node_sn.Text = "Insert Serial no here"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 17)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(91, 13)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Add Sensor  S/N:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Select a zone or object"
        '
        'combo_objects
        '
        Me.combo_objects.FormattingEnabled = True
        Me.combo_objects.Location = New System.Drawing.Point(6, 108)
        Me.combo_objects.Name = "combo_objects"
        Me.combo_objects.Size = New System.Drawing.Size(309, 21)
        Me.combo_objects.TabIndex = 11
        Me.combo_objects.Text = "Object.."
        '
        'btn_add_object
        '
        Me.btn_add_object.Location = New System.Drawing.Point(321, 108)
        Me.btn_add_object.Name = "btn_add_object"
        Me.btn_add_object.Size = New System.Drawing.Size(116, 23)
        Me.btn_add_object.TabIndex = 12
        Me.btn_add_object.Text = "Add S/N to Object"
        Me.btn_add_object.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_add_object)
        Me.GroupBox3.Controls.Add(Me.combo_objects)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.text_add_node_sn)
        Me.GroupBox3.Controls.Add(Me.combo_zone)
        Me.GroupBox3.Controls.Add(Me.btn_remove_node_sn)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.btn_add_node_zone)
        Me.GroupBox3.Controls.Add(Me.combo_remove_node_sn)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 85)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(443, 205)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Sensors"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lv_node_sn)
        Me.GroupBox1.Location = New System.Drawing.Point(465, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(499, 427)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sensor Associations"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetupToolStripMenuItem, Me.SimulationToolStripMenuItem, Me.MapToolStripMenuItem, Me.NodeStatusToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(972, 24)
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
        'USER_GUI_2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(972, 523)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label4)
        Me.Name = "USER_GUI_2"
        Me.Text = "Sensor Serial Numbers"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lv_node_sn As System.Windows.Forms.ListView
    Friend WithEvents combo_remove_node_sn As System.Windows.Forms.ComboBox
    Friend WithEvents btn_add_node_zone As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btn_remove_node_sn As System.Windows.Forms.Button
    Friend WithEvents combo_zone As System.Windows.Forms.ComboBox
    Friend WithEvents text_add_node_sn As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents combo_objects As System.Windows.Forms.ComboBox
    Friend WithEvents btn_add_object As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
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
