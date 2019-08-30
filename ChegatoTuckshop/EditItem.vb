Public Class EditItem
    Public barcode As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnUpdateItem.Click
        If txtbarcode.Text = "" Or txtitemname.Text = "" Or txtbuyprice.Text = "" Or txtsellprice.Text = "" Then
            MsgBox("Please Enter Correct Information", MsgBoxStyle.Critical)
            Exit Sub
        Else
            Dim stmt = "UPDATE tblitems SET itemname='" & txtitemname.Text & "', buyprice='" & txtbuyprice.Text & "', sellprice='" & txtsellprice.Text & "', qty='" & txtqty.Value & "' where barcode='" & barcode & "'"
            If (query(stmt)) Then
                MsgBox("Item successfully updated", vbInformation)
            Else
                MsgBox("Item could not be updated!", vbExclamation)
            End If
        End If
    End Sub
    Public Sub FillInfo(ByVal Barcode As String)
        Dim stmt = "SELECT * FROM tblitems WHERE barcode='" & Barcode & "'"
        If querySelect(stmt, "item") Then
            txtbarcode.Text = Barcode
            txtbuyprice.Text = connection.dataset.Tables("item").Rows(0).Item(0)
            txtitemname.Text = connection.dataset.Tables("item").Rows(0).Item(1)
            txtbuyprice.Text = connection.dataset.Tables("item").Rows(0).Item(2)
            txtsellprice.Text = connection.dataset.Tables("item").Rows(0).Item(3)
            txtqty.Value = connection.dataset.Tables("item").Rows(0).Item(4)
        End If
    End Sub
    Private Sub EditItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillInfo(barcode)
    End Sub
End Class