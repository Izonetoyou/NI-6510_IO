Imports NationalInstruments.DAQmx

Public Class Class_NI_IO

    Public Shared Function IsDeviceConnected(ByVal deviceName As String) As Boolean
        Try
            ' Check if the device exists in the DAQ system
            If DaqSystem.Local.Devices.Contains(deviceName) Then
                Class_Var.IO.IOConnect = True
                Return True
            Else
                Class_Var.IO.IOConnect = False
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Device check error: " & ex.Message)
            Class_Var.IO.IOConnect = False
            Return False
        End Try
    End Function


    Public Shared Function ReadDigitalInputs(ByVal channelName As String) As Boolean()

        Try
            Using myTask As New Task()
                myTask.DIChannels.CreateChannel(channelName, "", ChannelLineGrouping.OneChannelForAllLines)
                Dim reader As New DigitalSingleChannelReader(myTask.Stream)
                Dim data As Boolean() = reader.ReadSingleSampleMultiLine()
                Return data
            End Using
        Catch ex As DaqException
            MessageBox.Show("Read Error: " & ex.Message)
            Return Nothing
        End Try

    End Function

    Public Shared Sub WriteDigitalOutputs(ByVal channelName As String, ByVal values As Boolean())

        Try
            Using myTask As New Task()
                myTask.DOChannels.CreateChannel(channelName, "", ChannelLineGrouping.OneChannelForAllLines)
                Dim writer As New DigitalSingleChannelWriter(myTask.Stream)
                writer.WriteSingleSampleMultiLine(True, values)
                'MessageBox.Show("Digital output values set.")
            End Using
        Catch ex As DaqException
            MessageBox.Show("Write Error: " & ex.Message)
        End Try

    End Sub

    Public Shared Sub WriteDigitalOutput(ByVal channelName As String, ByVal value As Boolean)

        Try
            Using myTask As New Task()
                myTask.DOChannels.CreateChannel(channelName, "", ChannelLineGrouping.OneChannelForAllLines)
                Dim writer As New DigitalSingleChannelWriter(myTask.Stream)
                writer.WriteSingleSampleSingleLine(True, value)
                'MessageBox.Show("Digital output value set to: " & value.ToString())
            End Using
        Catch ex As DaqException
            MessageBox.Show("Write Error: " & ex.Message)
        End Try

    End Sub


End Class
