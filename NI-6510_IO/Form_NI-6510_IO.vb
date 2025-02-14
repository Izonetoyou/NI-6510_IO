Imports System.Threading.Tasks

Public Class Form_main
    Private Sub Form_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Friend Sub Show_Label_ToolStrip(StripStatusLable As String, Code As String, Colorr As Color)
        If StripStatusLable = "IO" Then
            ToolStripStatusIO.Text = Code
            ToolStripStatusIO.BackColor = Colorr
        End If
    End Sub



#Region "IO"
    Public Function IO_conect() As Boolean
        If Class_NI_IO.IsDeviceConnected(Class_Var.IO.NIdeviceNameOutput) Then
            Show_Label_ToolStrip("IO", "IO Status : Device " & Class_Var.IO.NIdeviceNameOutput & " is connected.", Color.Green)
            TimerIO.Enabled = True
            Class_Var.IO.IOConnect = True
        Else
            Show_Label_ToolStrip("IO", "IO Status : Device " & Class_Var.IO.NIdeviceNameOutput & " is not connected.", Color.Red)
            Class_Var.IO.IOConnect = False
        End If
        Return Class_Var.IO.IOConnect
    End Function

    Public Function IO_disconect() As Boolean
        Class_Var.IO.IOConnect = False
        Show_Label_ToolStrip("IO", "IO Status : Device " & Class_Var.IO.NIdeviceNameOutput & " is disconnected.", Color.Red)
        TimerIO.Enabled = False
        Return False
    End Function

    Public Async Function ToggleOutput(outputMethodOn As Func(Of Task), outputMethodOff As Func(Of Task), button As Button) As Task
        If Class_Var.IO.IOConnect Then
            If button.BackColor = Color.LimeGreen Then
                Await outputMethodOff.Invoke()
                button.BackColor = SystemColors.Control
            Else
                Await outputMethodOn.Invoke()
                button.BackColor = Color.LimeGreen
            End If
        Else
            MessageBox.Show("IO Disconnect")
        End If
    End Function

    Public Function port_line_On(portNumber As String, lineNumber As String) As Task
        Return Task.Run(Sub()
                            Class_NI_IO.WriteDigitalOutput(Class_Var.IO.NIdeviceNameOutput & "/" & portNumber & "/line" & lineNumber, False)
                        End Sub)
    End Function

    Public Function port_line_Off(portNumber As String, lineNumber As String) As Task
        Return Task.Run(Sub()
                            Class_NI_IO.WriteDigitalOutput(Class_Var.IO.NIdeviceNameOutput & "/" & portNumber & "/line" & lineNumber, True)
                        End Sub)
    End Function

    Private Sub BtCon_IO_Click(sender As Object, e As EventArgs) Handles BtCon_IO.Click
        If BtCon_IO.Text = "Connect" Then
            If IO_conect() Then
                TimerIO.Enabled = True
                BtCon_IO.Text = "Disconnect"
            End If
        Else
            If Not IO_disconect() Then
                BtCon_IO.Text = "Connect"
            End If
        End If
    End Sub
    Private Async Sub port0_line0_Click(sender As Object, e As EventArgs) Handles line0.Click, line1.Click, line2.Click, line3.Click, line4.Click, line5.Click, line6.Click, line7.Click
        Dim portNumber As String = cb_port_Output.Text

        ' แปลง sender ให้เป็น Button
        Dim button As Button = CType(sender, Button)

        ' อ่านค่า Tag เพื่อกำหนดหมายเลขพอร์ต
        Dim lineNumber As String = button.Tag.ToString()

        ' เรียกใช้ ToggleOutput สำหรับพอร์ตที่กด
        Await ToggleOutput(
        Function() port_line_On(portNumber, lineNumber),
        Function() port_line_Off(portNumber, lineNumber),
        button
    )
    End Sub

    Private Sub TimerIO_Tick(sender As Object, e As EventArgs) Handles TimerIO.Tick
        TimerIO.Enabled = False

        ' อ่านค่าดิจิทัลอินพุตจากพอร์ตที่กำหนด
        Dim inputStates As Boolean() = Class_NI_IO.ReadDigitalInputs(Class_Var.IO.NIdeviceNameInput & "/" & cb_port_Input.Text & "/line0:7")

        ' ตรวจสอบว่าอ่านค่ามาได้จริง (ป้องกันข้อผิดพลาด)
        If inputStates IsNot Nothing AndAlso inputStates.Length = 8 Then
            UpdateLED(inputStates) ' ส่งค่า Boolean() ไปที่ UpdateLED
        Else
            MessageBox.Show("Error: Failed to read digital inputs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        TimerIO.Enabled = True
    End Sub


    ' ฟังก์ชันอัปเดต LED ตามค่าที่อ่านได้จาก Digital Input
    Private Sub UpdateLED(inputValues As Boolean())
        Dim ledList As List(Of PowerPacks.OvalShape) = New List(Of PowerPacks.OvalShape) From {LED0, LED1, LED2, LED3, LED4, LED5, LED6, LED7}

        For i As Integer = 0 To Math.Min(inputValues.Length - 1, ledList.Count - 1)
            ledList(i).FillColor = If(inputValues(i), Color.LimeGreen, Color.DarkGray)
        Next
    End Sub

    Private Sub cb_device_Input_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_device_Input.SelectedIndexChanged
        Class_Var.IO.NIdeviceNameInput = cb_device_Input.Text
    End Sub

    Private Sub cb_device_Output_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_device_Output.SelectedIndexChanged
        Class_Var.IO.NIdeviceNameOutput = cb_device_Output.Text
    End Sub




#End Region





End Class
