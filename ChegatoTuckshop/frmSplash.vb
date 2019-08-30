Public NotInheritable Class frmSplash
    Dim value As Integer = 0
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        value = value + 10
        If value <= ProgressBar1.Maximum Then
            ProgressBar1.Value = value
            lblloading.Text = "Loading... " + value.ToString + "%"
        Else
            If value = 200 Then
                frmLogin.Show()
                Me.Close()
            End If
        End If
    End Sub
End Class
