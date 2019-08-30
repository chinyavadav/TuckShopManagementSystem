Public Class frmUsers

    Private Sub frmUsers_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Dim response = querySelect("SELECT * FROM tblusers", "tblusers")
        DataGridView1.Rows.Clear()
        If response.ToString = "True" Then
            Dim rowCount As Integer = connection.dataset.Tables("tblusers").Rows.Count
            Dim count As Integer = 0
            While (count < rowCount)
                DataGridView1.Rows.Add()
                DataGridView1.Rows(count).Cells(0).Value = connection.dataset.Tables("tblusers").Rows(count).Item(0)
                DataGridView1.Rows(count).Cells(1).Value = connection.dataset.Tables("tblusers").Rows(count).Item(1)
                DataGridView1.Rows(count).Cells(2).Value = connection.dataset.Tables("tblusers").Rows(count).Item(2)
                DataGridView1.Rows(count).Cells(3).Value = connection.dataset.Tables("tblusers").Rows(count).Item(3)
                count = count + 1
            End While
        End If
    End Sub
    Private Sub DataGridView1_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles DataGridView1.RowsRemoved

    End Sub

    Private Sub ToolStripLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel1.Click
        Dim username As String = InputBox("Username: ")
        If username = "" Then
            MsgBox("Please enter 'username' to be deleted select an item to remove", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Dim stmt = "DELETE FROM tblusers WHERE fldusername='" & username & "'"
        If query(stmt) Then
            MsgBox("User successfully removed!", vbInformation)
            If username = frmSales.Username Then
                Me.Close()
                frmSales.Close()
                frmLogin.Show()
            End If
        Else
            MsgBox("User cannot be removed!", vbExclamation)
        End If

    End Sub
End Class