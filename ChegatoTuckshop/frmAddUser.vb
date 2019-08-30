Public Class frmAddUser

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If txtusername.Text = "" Or txtforename.Text = "" Or txtsurname.Text = "" Or txtpassword.Text = "" Then
            MsgBox("Please Enter Correct Information", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Try
            If txtpassword.Text = txtverify.Text Then
                Dim statement = "INSERT INTO tblusers VALUES('" & txtusername.Text & "','" & txtforename.Text & "','" & txtsurname.Text & "','" & cboaccesslevel.Text & "','" & txtpassword.Text & "')"
                If connection.query(statement) Then
                    MsgBox("User successfully added!", MsgBoxStyle.Information)
                    txtusername.Clear()
                    txtforename.Clear()
                    txtsurname.Clear()
                    txtpassword.Clear()
                    txtverify.Clear()
                    txtusername.Focus()
                Else
                    MsgBox("User could not be added!", vbExclamation)
                End If
            Else
                MsgBox("Password mismatch!", vbExclamation)
                txtverify.Focus()
            End If
        Catch ex As Exception
            MsgBox("Username has already been taken!", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub frmAddUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboaccesslevel.SelectedIndex = 0
    End Sub
End Class