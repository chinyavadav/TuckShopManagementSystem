Public Class ChangePassword

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtoldpassword.Text = "" Or txtnewpassword.Text = "" Or txtconfirmpassword.Text = "" Then
            MsgBox("Provide Required Information", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Try
            If txtnewpassword.Text = txtconfirmpassword.Text Then
                Dim stmt As String = "UPDATE tblusers SET fldpassword='" & txtnewpassword.Text & "' WHERE fldpassword='" & txtoldpassword.Text & "' and fldusername='" & frmLogin.txtusername.Text & "'"
                If query(stmt) Then
                    MsgBox("Password Updated", MsgBoxStyle.Information)
                Else
                    MsgBox("Password could not be Updated", MsgBoxStyle.Exclamation)
                End If
                txtoldpassword.Clear()
                txtnewpassword.Clear()
                txtconfirmpassword.Clear()
            Else
                MsgBox("New Password Does'nt Match", MsgBoxStyle.Critical)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtoldpassword.UseSystemPasswordChar = True
        txtnewpassword.UseSystemPasswordChar = True
        txtconfirmpassword.UseSystemPasswordChar = True
        txtoldpassword.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
End Class