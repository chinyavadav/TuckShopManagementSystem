Public Class frmLogin
    Private Sub chkPassword_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chkPassword.CheckedChanged
        If chkPassword.Checked = True Then
            txtpassword.PasswordChar = ""
            txtpassword.Font = New Font("Segoe UI", 12.0, FontStyle.Regular)
        Else
            txtpassword.PasswordChar = "l"
            txtpassword.Font = New Font("Wingdings", 12.0, FontStyle.Regular)
        End If
    End Sub
    Dim statement As String
    Private Sub btnLogin_Click(sender As System.Object, e As System.EventArgs) Handles btnLogin.Click
        If txtusername.Text <> "" And txtpassword.Text <> "" Then
            statement = "SELECT * FROM tblusers WHERE fldusername='" & txtusername.Text & "' and fldpassword='" & txtpassword.Text & "'"
            Dim response = connection.querySelect(statement, "tblusers")
            If response.ToString = "True" Then
                Dim index As Integer = 0
                If connection.dataset.Tables("tblusers").Rows.Count = 1 Then
                    'fldaccesslevel|Administrator|Till Operator
                    frmSales.Username = connection.dataset.Tables("tblusers").Rows(0).Item(0).ToString
                    frmSales.AccessLevel = connection.dataset.Tables("tblusers").Rows(0).Item(3).ToString
                    txtpassword.Clear()
                    frmSales.Show()
                    Me.Hide()
                Else
                    MsgBox("Username or Password is incorrect!", vbExclamation)
                End If
            Else
                MsgBox(response, vbExclamation)
            End If
        Else
            MsgBox("Username or Password cannot be empty!", vbExclamation)
        End If
        txtpassword.Clear()
        txtpassword.Select()
    End Sub

    Private Sub frmLogin_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If Not connection.connect() Then
            Me.Close()
        End If
    End Sub
End Class