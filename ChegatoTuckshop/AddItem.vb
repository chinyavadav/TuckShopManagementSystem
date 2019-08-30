Public Class AddItem

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        If txtbarcode.Text = "" Or txtitemname.Text = "" Or txtbuyprice.Text = "" Or txtsellprice.Text = "" Then
            MsgBox("Please Enter Correct Information", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Try
            Dim statement = "INSERT INTO tblitems VALUES('" & txtbarcode.Text & "','" & txtitemname.Text & "','" & txtbuyprice.Text & "','" & txtsellprice.Text & "','" & txtqty.Value & "')"
            If connection.query(statement) Then
                MsgBox("Item successfully added!", MsgBoxStyle.Information)
                status.Text = "One Item(s) Added"
                txtbarcode.Clear()
                txtitemname.Clear()
                txtbuyprice.Clear()
                txtsellprice.Clear()
                txtqty.Value = 0
                txtbarcode.Focus()
            Else
                MsgBox("Item could not be added!", vbExclamation)
            End If
        Catch ex As Exception
            MsgBox("Barcode already Exist !", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub AddItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        status.Text = ""
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtbarcode.TextChanged

    End Sub

    Private Sub TextBox2_Leave(sender As Object, e As EventArgs) Handles txtitemname.Leave
        status.Text = ""
    End Sub

    Private Sub TextBox2_MouseClick(sender As Object, e As MouseEventArgs) Handles txtitemname.MouseClick

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtitemname.TextChanged

    End Sub
End Class