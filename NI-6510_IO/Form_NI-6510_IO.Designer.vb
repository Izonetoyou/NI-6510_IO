<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_main
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
        Me.components = New System.ComponentModel.Container()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripStatusIO = New System.Windows.Forms.ToolStripLabel()
        Me.TimerIO = New System.Windows.Forms.Timer(Me.components)
        Me.BtCon_IO = New System.Windows.Forms.Button()
        Me.line0 = New System.Windows.Forms.Button()
        Me.line1 = New System.Windows.Forms.Button()
        Me.line2 = New System.Windows.Forms.Button()
        Me.line3 = New System.Windows.Forms.Button()
        Me.line4 = New System.Windows.Forms.Button()
        Me.line5 = New System.Windows.Forms.Button()
        Me.line6 = New System.Windows.Forms.Button()
        Me.line7 = New System.Windows.Forms.Button()
        Me.cb_port_Input = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LED7 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.LED6 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.LED5 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.LED4 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.LED3 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.LED2 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.LED1 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.LED0 = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cb_device_Input = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cb_device_Output = New System.Windows.Forms.ComboBox()
        Me.cb_port_Output = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToolStrip.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip
        '
        Me.ToolStrip.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusIO})
        Me.ToolStrip.Location = New System.Drawing.Point(9, 360)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(110, 25)
        Me.ToolStrip.TabIndex = 0
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'ToolStripStatusIO
        '
        Me.ToolStripStatusIO.Name = "ToolStripStatusIO"
        Me.ToolStripStatusIO.Size = New System.Drawing.Size(98, 22)
        Me.ToolStripStatusIO.Text = "ToolStripStatusIO"
        '
        'TimerIO
        '
        '
        'BtCon_IO
        '
        Me.BtCon_IO.Location = New System.Drawing.Point(261, 333)
        Me.BtCon_IO.Name = "BtCon_IO"
        Me.BtCon_IO.Size = New System.Drawing.Size(155, 49)
        Me.BtCon_IO.TabIndex = 1
        Me.BtCon_IO.Text = "Connect"
        Me.BtCon_IO.UseVisualStyleBackColor = True
        '
        'line0
        '
        Me.line0.Location = New System.Drawing.Point(4, 100)
        Me.line0.Name = "line0"
        Me.line0.Size = New System.Drawing.Size(75, 23)
        Me.line0.TabIndex = 2
        Me.line0.Tag = "0"
        Me.line0.Text = "line0"
        Me.line0.UseVisualStyleBackColor = True
        '
        'line1
        '
        Me.line1.Location = New System.Drawing.Point(85, 100)
        Me.line1.Name = "line1"
        Me.line1.Size = New System.Drawing.Size(75, 23)
        Me.line1.TabIndex = 3
        Me.line1.Tag = "1"
        Me.line1.Text = "line1"
        Me.line1.UseVisualStyleBackColor = True
        '
        'line2
        '
        Me.line2.Location = New System.Drawing.Point(166, 100)
        Me.line2.Name = "line2"
        Me.line2.Size = New System.Drawing.Size(75, 23)
        Me.line2.TabIndex = 4
        Me.line2.Tag = "2"
        Me.line2.Text = "line2"
        Me.line2.UseVisualStyleBackColor = True
        '
        'line3
        '
        Me.line3.Location = New System.Drawing.Point(247, 100)
        Me.line3.Name = "line3"
        Me.line3.Size = New System.Drawing.Size(75, 23)
        Me.line3.TabIndex = 4
        Me.line3.Tag = "3"
        Me.line3.Text = "line3"
        Me.line3.UseVisualStyleBackColor = True
        '
        'line4
        '
        Me.line4.Location = New System.Drawing.Point(328, 100)
        Me.line4.Name = "line4"
        Me.line4.Size = New System.Drawing.Size(75, 23)
        Me.line4.TabIndex = 4
        Me.line4.Tag = "4"
        Me.line4.Text = "line4"
        Me.line4.UseVisualStyleBackColor = True
        '
        'line5
        '
        Me.line5.Location = New System.Drawing.Point(409, 100)
        Me.line5.Name = "line5"
        Me.line5.Size = New System.Drawing.Size(75, 23)
        Me.line5.TabIndex = 4
        Me.line5.Tag = "5"
        Me.line5.Text = "line5"
        Me.line5.UseVisualStyleBackColor = True
        '
        'line6
        '
        Me.line6.Location = New System.Drawing.Point(490, 100)
        Me.line6.Name = "line6"
        Me.line6.Size = New System.Drawing.Size(75, 23)
        Me.line6.TabIndex = 4
        Me.line6.Tag = "6"
        Me.line6.Text = "line6"
        Me.line6.UseVisualStyleBackColor = True
        '
        'line7
        '
        Me.line7.Location = New System.Drawing.Point(571, 100)
        Me.line7.Name = "line7"
        Me.line7.Size = New System.Drawing.Size(75, 23)
        Me.line7.TabIndex = 4
        Me.line7.Tag = "7"
        Me.line7.Text = "line7"
        Me.line7.UseVisualStyleBackColor = True
        '
        'cb_port_Input
        '
        Me.cb_port_Input.FormattingEnabled = True
        Me.cb_port_Input.Items.AddRange(New Object() {"port0", "port1", "port2"})
        Me.cb_port_Input.Location = New System.Drawing.Point(163, 47)
        Me.cb_port_Input.Name = "cb_port_Input"
        Me.cb_port_Input.Size = New System.Drawing.Size(121, 24)
        Me.cb_port_Input.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(160, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "2. SELECT PORT"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.cb_device_Input)
        Me.GroupBox7.Controls.Add(Me.cb_port_Input)
        Me.GroupBox7.Controls.Add(Me.Label1)
        Me.GroupBox7.Controls.Add(Me.Label2)
        Me.GroupBox7.Controls.Add(Me.ShapeContainer2)
        Me.GroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(32, 12)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(664, 142)
        Me.GroupBox7.TabIndex = 95
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "INPUT"
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(3, 18)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LED7, Me.LED6, Me.LED5, Me.LED4, Me.LED3, Me.LED2, Me.LED1, Me.LED0})
        Me.ShapeContainer2.Size = New System.Drawing.Size(658, 121)
        Me.ShapeContainer2.TabIndex = 0
        Me.ShapeContainer2.TabStop = False
        '
        'LED7
        '
        Me.LED7.BackColor = System.Drawing.Color.DarkGray
        Me.LED7.BorderColor = System.Drawing.Color.White
        Me.LED7.FillColor = System.Drawing.Color.Silver
        Me.LED7.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.LED7.Location = New System.Drawing.Point(588, 73)
        Me.LED7.Name = "LED7"
        Me.LED7.Size = New System.Drawing.Size(19, 19)
        Me.LED7.Tag = "7"
        '
        'LED6
        '
        Me.LED6.BackColor = System.Drawing.Color.DarkGray
        Me.LED6.BorderColor = System.Drawing.Color.White
        Me.LED6.FillColor = System.Drawing.Color.Silver
        Me.LED6.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.LED6.Location = New System.Drawing.Point(507, 73)
        Me.LED6.Name = "LED6"
        Me.LED6.Size = New System.Drawing.Size(19, 19)
        Me.LED6.Tag = "6"
        '
        'LED5
        '
        Me.LED5.BackColor = System.Drawing.Color.DarkGray
        Me.LED5.BorderColor = System.Drawing.Color.White
        Me.LED5.FillColor = System.Drawing.Color.Silver
        Me.LED5.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.LED5.Location = New System.Drawing.Point(426, 73)
        Me.LED5.Name = "LED5"
        Me.LED5.Size = New System.Drawing.Size(19, 19)
        Me.LED5.Tag = "5"
        '
        'LED4
        '
        Me.LED4.BackColor = System.Drawing.Color.DarkGray
        Me.LED4.BorderColor = System.Drawing.Color.White
        Me.LED4.FillColor = System.Drawing.Color.Silver
        Me.LED4.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.LED4.Location = New System.Drawing.Point(345, 73)
        Me.LED4.Name = "LED4"
        Me.LED4.Size = New System.Drawing.Size(19, 19)
        Me.LED4.Tag = "4"
        '
        'LED3
        '
        Me.LED3.BackColor = System.Drawing.Color.DarkGray
        Me.LED3.BorderColor = System.Drawing.Color.White
        Me.LED3.FillColor = System.Drawing.Color.Silver
        Me.LED3.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.LED3.Location = New System.Drawing.Point(264, 73)
        Me.LED3.Name = "LED3"
        Me.LED3.Size = New System.Drawing.Size(19, 19)
        Me.LED3.Tag = "3"
        '
        'LED2
        '
        Me.LED2.BackColor = System.Drawing.Color.DarkGray
        Me.LED2.BorderColor = System.Drawing.Color.White
        Me.LED2.FillColor = System.Drawing.Color.Silver
        Me.LED2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.LED2.Location = New System.Drawing.Point(183, 73)
        Me.LED2.Name = "LED2"
        Me.LED2.Size = New System.Drawing.Size(19, 19)
        Me.LED2.Tag = "2"
        '
        'LED1
        '
        Me.LED1.BackColor = System.Drawing.Color.DarkGray
        Me.LED1.BorderColor = System.Drawing.Color.White
        Me.LED1.FillColor = System.Drawing.Color.Silver
        Me.LED1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.LED1.Location = New System.Drawing.Point(102, 73)
        Me.LED1.Name = "LED1"
        Me.LED1.Size = New System.Drawing.Size(19, 19)
        Me.LED1.Tag = "1"
        '
        'LED0
        '
        Me.LED0.BackColor = System.Drawing.Color.DarkGray
        Me.LED0.BorderColor = System.Drawing.Color.White
        Me.LED0.FillColor = System.Drawing.Color.Silver
        Me.LED0.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.LED0.Location = New System.Drawing.Point(21, 73)
        Me.LED0.Name = "LED0"
        Me.LED0.Size = New System.Drawing.Size(19, 19)
        Me.LED0.Tag = "0"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cb_device_Output)
        Me.GroupBox1.Controls.Add(Me.cb_port_Output)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.line7)
        Me.GroupBox1.Controls.Add(Me.line0)
        Me.GroupBox1.Controls.Add(Me.line1)
        Me.GroupBox1.Controls.Add(Me.line2)
        Me.GroupBox1.Controls.Add(Me.line3)
        Me.GroupBox1.Controls.Add(Me.line6)
        Me.GroupBox1.Controls.Add(Me.line4)
        Me.GroupBox1.Controls.Add(Me.line5)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(29, 160)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(667, 157)
        Me.GroupBox1.TabIndex = 96
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "OUTPUT"
        '
        'cb_device_Input
        '
        Me.cb_device_Input.FormattingEnabled = True
        Me.cb_device_Input.Items.AddRange(New Object() {"Dev1", "Dev2", "Dev3"})
        Me.cb_device_Input.Location = New System.Drawing.Point(18, 47)
        Me.cb_device_Input.Name = "cb_device_Input"
        Me.cb_device_Input.Size = New System.Drawing.Size(121, 24)
        Me.cb_device_Input.TabIndex = 97
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(15, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "1. SELECT DEVICE"
        '
        'cb_device_Output
        '
        Me.cb_device_Output.FormattingEnabled = True
        Me.cb_device_Output.Items.AddRange(New Object() {"Dev1", "Dev2", "Dev3"})
        Me.cb_device_Output.Location = New System.Drawing.Point(21, 56)
        Me.cb_device_Output.Name = "cb_device_Output"
        Me.cb_device_Output.Size = New System.Drawing.Size(121, 24)
        Me.cb_device_Output.TabIndex = 101
        '
        'cb_port_Output
        '
        Me.cb_port_Output.FormattingEnabled = True
        Me.cb_port_Output.Items.AddRange(New Object() {"port0", "port1", "port2"})
        Me.cb_port_Output.Location = New System.Drawing.Point(166, 56)
        Me.cb_port_Output.Name = "cb_port_Output"
        Me.cb_port_Output.Size = New System.Drawing.Size(121, 24)
        Me.cb_port_Output.TabIndex = 98
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(163, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 16)
        Me.Label3.TabIndex = 99
        Me.Label3.Text = "2. SELECT PORT"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(18, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 16)
        Me.Label4.TabIndex = 100
        Me.Label4.Text = "1. SELECT DEVICE"
        '
        'Form_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 394)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.BtCon_IO)
        Me.Controls.Add(Me.ToolStrip)
        Me.Name = "Form_main"
        Me.Text = "NI-6510_IO"
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip As ToolStrip
    Friend WithEvents TimerIO As Timer
    Friend WithEvents ToolStripStatusIO As ToolStripLabel
    Friend WithEvents BtCon_IO As Button
    Friend WithEvents line0 As Button
    Friend WithEvents line1 As Button
    Friend WithEvents line2 As Button
    Friend WithEvents line3 As Button
    Friend WithEvents line4 As Button
    Friend WithEvents line5 As Button
    Friend WithEvents line6 As Button
    Friend WithEvents line7 As Button
    Friend WithEvents cb_port_Input As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
    Friend WithEvents LED7 As PowerPacks.OvalShape
    Friend WithEvents LED6 As PowerPacks.OvalShape
    Friend WithEvents LED5 As PowerPacks.OvalShape
    Friend WithEvents LED4 As PowerPacks.OvalShape
    Friend WithEvents LED3 As PowerPacks.OvalShape
    Friend WithEvents LED2 As PowerPacks.OvalShape
    Friend WithEvents LED1 As PowerPacks.OvalShape
    Friend WithEvents LED0 As PowerPacks.OvalShape
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cb_device_Input As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cb_device_Output As ComboBox
    Friend WithEvents cb_port_Output As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
