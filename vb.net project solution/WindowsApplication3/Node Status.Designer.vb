<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Node_Status
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
        Me.rtb_nodestatus = New System.Windows.Forms.RichTextBox()
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
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rtb_nodestatus
        '
        Me.rtb_nodestatus.Location = New System.Drawing.Point(48, 72)
        Me.rtb_nodestatus.Name = "rtb_nodestatus"
        Me.rtb_nodestatus.Size = New System.Drawing.Size(688, 576)
        Me.rtb_nodestatus.TabIndex = 0
        Me.rtb_nodestatus.Text = ""
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetupToolStripMenuItem, Me.SimulationToolStripMenuItem, Me.MapToolStripMenuItem, Me.NodeStatusToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(788, 24)
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
        'Node_Status
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 688)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.rtb_nodestatus)
        Me.Name = "Node_Status"
        Me.Text = "Node_Status"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rtb_nodestatus As System.Windows.Forms.RichTextBox
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
