Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer1.Start()
        Clipboard.Clear()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Clipboard.Clear()
        Catch ex As Exception
            'MsgBox("Ctrl + C é bloqueado! " & vbCrLf & ex.Message)
        End Try
    End Sub

End Class
