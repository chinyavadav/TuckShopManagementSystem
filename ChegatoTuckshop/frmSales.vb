Imports System.Drawing.Printing

Public Class frmSales
    Dim ReceiptImage As Bitmap
    Public AccessLevel, Username As String
    Private Sub frmSales_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Dim response = querySelect("SELECT * FROM tblitems", "tblitems")
        DataGridView1.Rows.Clear()
        If response.ToString = "True" Then
            Dim rowCount As Integer = connection.dataset.Tables("tblitems").Rows.Count
            Dim count As Integer = 0
            While (count < rowCount)
                DataGridView1.Rows.Add()
                DataGridView1.Rows(count).Cells(0).Value = connection.dataset.Tables("tblitems").Rows(count).Item(0)
                DataGridView1.Rows(count).Cells(1).Value = connection.dataset.Tables("tblitems").Rows(count).Item(1)
                DataGridView1.Rows(count).Cells(2).Value = "$" + connection.dataset.Tables("tblitems").Rows(count).Item(2)
                DataGridView1.Rows(count).Cells(3).Value = "$" + connection.dataset.Tables("tblitems").Rows(count).Item(3)
                DataGridView1.Rows(count).Cells(4).Value = connection.dataset.Tables("tblitems").Rows(count).Item(4)
                count = count + 1
            End While
        End If
    End Sub
    Private Sub frmSales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If AccessLevel <> "Administrator" Then
            ItemsToolStripMenuItem.Enabled = False
            AddUserToolStripMenuItem.Enabled = False
            UsersToolStripMenuItem.Enabled = False
        Else
            ItemsToolStripMenuItem.Enabled = True
            AddUserToolStripMenuItem.Enabled = True
            UsersToolStripMenuItem.Enabled = True
        End If
        txtPrinterName.Text = My.Settings.PrinterName
        Dim response = querySelect("SELECT * FROM tblprinter", "tblprinter")
        If response.ToString = "True" Then
            If connection.dataset.Tables("tblprinter").Rows.Count = 1 Then
                txtUnitWidth.Text = connection.dataset.Tables("tblprinter").Rows(0).Item(1)
                txtUnitHeight.Text = connection.dataset.Tables("tblprinter").Rows(0).Item(2)
                txtFontSize.Text = connection.dataset.Tables("tblprinter").Rows(0).Item(3)
                PictureBox1.Image = DrawReceipt(DataGridView3.Rows, 737, DateString, 123, txtUnitWidth.Text, txtUnitHeight.Text, txtFontSize.Text)
                txtBarCode.Focus()
            End If
        End If
    End Sub

    Public Function DrawReceipt(ByVal Rows As DataGridViewRowCollection, ReceiptNo As String, ReceiptDate As String, ReceiptTotal As Decimal, UnitWidth As Integer, UnitHeight As Integer, Fontize As Integer) As Bitmap

        Dim ReceiptWidth As Integer = 13 * UnitWidth
        Dim ReceiptDetailsHeight As Integer = Rows.Count * UnitHeight
        Dim ReceiptHeight As Integer = 6 * UnitWidth + ReceiptDetailsHeight
        Dim BMP As New Bitmap(ReceiptWidth + 1, ReceiptHeight)
        Dim GR As Graphics = Graphics.FromImage(BMP)
        ' GR.FillRectangle(Brushes.White, 0, 0, ReceiptWidth, ReceiptHeight)
        GR.Clear(Color.White)
        Dim LNHeaderYStart = 3 * UnitHeight
        Dim LNDetailsStart = LNHeaderYStart + UnitHeight
        GR.DrawRectangle(Pens.Black, UnitWidth * 0, LNHeaderYStart, UnitWidth, UnitHeight)
        GR.DrawRectangle(Pens.Black, UnitWidth * 1, LNHeaderYStart, UnitWidth * 5, UnitHeight)
        GR.DrawRectangle(Pens.Black, UnitWidth * 6, LNHeaderYStart, UnitWidth * 2, UnitHeight)
        GR.DrawRectangle(Pens.Black, UnitWidth * 8, LNHeaderYStart, UnitWidth * 2, UnitHeight)
        GR.DrawRectangle(Pens.Black, UnitWidth * 10, LNHeaderYStart, UnitWidth * 3, UnitHeight)

        GR.DrawRectangle(Pens.Black, UnitWidth * 0, LNDetailsStart, UnitWidth * 1, ReceiptDetailsHeight)
        GR.DrawRectangle(Pens.Black, UnitWidth * 1, LNDetailsStart, UnitWidth * 5, ReceiptDetailsHeight)
        GR.DrawRectangle(Pens.Black, UnitWidth * 6, LNDetailsStart, UnitWidth * 2, ReceiptDetailsHeight)
        GR.DrawRectangle(Pens.Black, UnitWidth * 8, LNDetailsStart, UnitWidth * 2, ReceiptDetailsHeight)
        GR.DrawRectangle(Pens.Black, UnitWidth * 10, LNDetailsStart, UnitWidth * 3, ReceiptDetailsHeight)

        Dim FNT As New Font("Times", Fontize, FontStyle.Bold)

        GR.DrawString("No", FNT, Brushes.Black, UnitWidth * 0, LNHeaderYStart)
        GR.DrawString("Item", FNT, Brushes.Black, UnitWidth * 1, LNHeaderYStart)
        GR.DrawString("Price: $", FNT, Brushes.Black, UnitWidth * 6, LNHeaderYStart)
        GR.DrawString("Count", FNT, Brushes.Black, UnitWidth * 8, LNHeaderYStart)
        GR.DrawString("Sum: $", FNT, Brushes.Black, UnitWidth * 10, LNHeaderYStart)

        Dim I As Integer
        For I = 0 To Rows.Count - 1
            Dim YLOC = UnitHeight * I + LNDetailsStart
            GR.DrawString(I, FNT, Brushes.Black, UnitWidth * 0, YLOC)

            GR.DrawString(Rows(I).Cells(1).Value, FNT, Brushes.Black, UnitWidth * 1, YLOC)
            GR.DrawString(Rows(I).Cells(3).Value, FNT, Brushes.Black, UnitWidth * 6, YLOC)
            GR.DrawString(Rows(I).Cells(4).Value, FNT, Brushes.Black, UnitWidth * 8, YLOC)
            GR.DrawString(Rows(I).Cells(5).Value, FNT, Brushes.Black, UnitWidth * 10, YLOC)

        Next
        GR.DrawString("Total: $" & ReceiptTotal, FNT, Brushes.Black, 0, LNDetailsStart + ReceiptDetailsHeight)

        GR.DrawString("Receipt No:" & ReceiptNo, FNT, Brushes.Black, 0, 0)
        GR.DrawString("Receipt Date:" & ReceiptDate, FNT, Brushes.Black, 0, UnitHeight)

        Return BMP
    End Function

    Private Sub PrintDoc_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDoc.PrintPage
        e.Graphics.DrawImage(ReceiptImage, 0, 0, ReceiptImage.Width, ReceiptImage.Height)
        e.HasMorePages = False
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Dim R As DataRow = btnAdd.Tag
        Dim ItemLoc As Integer = -1
        Dim I As Integer
        For I = 0 To DataGridView2.Rows.Count - 1
            If R.Item(0) = DataGridView2.Rows(I).Cells(0).Value Then
                ItemLoc = I
                Exit For
            End If
        Next
        If ItemLoc = -1 Then
            DataGridView2.Rows.Add(R.Item(0), R.Item(1), R.Item(2), R.Item(3), 1, R.Item(3))
        Else
            Dim Count As Long = DataGridView2.Rows(ItemLoc).Cells(4).Value
            Count += 1
            Dim NewPrice As Decimal = R.Item(3) * Count
            DataGridView2.Rows(ItemLoc).Cells(4).Value = Count
            DataGridView2.Rows(ItemLoc).Cells(5).Value = NewPrice
        End If
        txtBarCode.Text = ""
        txtBarCode.Focus()
        Dim sum As Decimal = 0
        For I = 0 To DataGridView2.Rows.Count - 1
            sum += DataGridView2.Rows(I).Cells(5).Value
        Next
        txtTotalPrice.Text = sum
    End Sub

    Private Sub btnRemove_Click(sender As System.Object, e As System.EventArgs) Handles btnRemove.Click
        Try
            If DataGridView2.Rows.Count = 0 AndAlso DataGridView2.SelectedCells.Count = 0 Then
                MsgBox("Please select an item to remove", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            Dim var As Double = DataGridView2.SelectedRows(0).Cells(5).Value
            txtTotalPrice.Text = txtTotalPrice.Text - var
            DataGridView2.Rows.Remove(DataGridView2.SelectedRows(0))
            txtBarCode.Focus()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub btnPrintReceipt_Click(sender As System.Object, e As System.EventArgs) Handles btnPrintReceipt.Click
        Try
            If DataGridView2.Rows.Count <= 0 Then
                MsgBox("Please add some items to print", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            Dim ReceiptId As Integer
            Dim receiptdate = Format(Now.Date, "yyyy-MM-dd")
            If query("Insert into tblreceipts (ReceiptDate,ReceiptTotal) Values('" & receiptdate & "','" & txtTotalPrice.Text & "')") Then
                querySelect("Select max(ReceiptID) as MAXID from tblreceipts", "max")
                ReceiptId = connection.dataset.Tables("max").Rows(0).Item(0)
            End If


            Dim i As Integer
            For i = 0 To DataGridView2.Rows.Count - 1
                Dim Barcode As String = DataGridView2.Rows(i).Cells(0).Value
                Dim BuyPrice As String = DataGridView2.Rows(i).Cells(2).Value
                Dim SellPrice As String = DataGridView2.Rows(i).Cells(3).Value
                Dim ItemCount As Integer = DataGridView2.Rows(i).Cells(4).Value
                query("Insert into tblreceiptdetails values('" & ReceiptId & "','" & Barcode & "','" & ItemCount & "','" & BuyPrice & "','" & SellPrice & "')")
                query("UPDATE tblitems SET qty=qty-" & ItemCount & " WHERE barcode='" & Barcode & "'")

            Next
            MsgBox("Transaction was successful!", vbInformation)
            If Not IsNothing(txtPrinterName.Text) Then
                ReceiptImage = DrawReceipt(DataGridView2.Rows, ReceiptId, Format(Now.Date, "yyyy-MM-dd"), txtTotalPrice.Text, txtUnitWidth.Text, txtUnitHeight.Text, txtFontSize.Text)
                If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                    PrintDoc.PrinterSettings = PrintDialog1.PrinterSettings
                    PrintDoc.Print()
                    DataGridView2.Rows.Clear()
                    txtTotalPrice.Clear()
                End If
            ElseIf PictureBox1.Image Is Nothing Then
                MsgBox("Can't Print receipt please check the settings", MsgBoxStyle.Critical)
            Else
                MsgBox("You did not setup the printer", MsgBoxStyle.Exclamation)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnClearAll_Click(sender As System.Object, e As System.EventArgs) Handles btnClearAll.Click
        Me.txtTotalPrice.Clear()
        DataGridView2.Rows.Clear()
    End Sub

    Private Sub btnSearchReports_Click(sender As System.Object, e As System.EventArgs) Handles btnSearchReports.Click
        Try
            If (cboSelectReport.Text = "Total Profit For All Time") Then
                PanelShort.Visible = True
                PanelLong.Visible = False
                PanelDate.Visible = False
                Dim response = connection.querySelect("Select SUM((ItemSellPrice-ItemBuyPrice)*ItemCount) from tblreceiptdetails", "sum")
                If response.ToString = "True" Then
                    If connection.dataset.Tables("sum").Rows.Count = 1 Then
                        profit.Text = connection.dataset.Tables("sum").Rows(0).Item(0) & " Dollars"
                        head.Text = "Total Profit For All Time"
                        head.Visible = True
                        profit.Visible = True
                    Else
                        MsgBox("Sales are not enough to generate report!", vbExclamation)
                    End If
                Else
                    MsgBox(response, vbExclamation)
                End If
            ElseIf (cboSelectReport.Text = "Receipts For All Time") Then
                PanelShort.Visible = False
                PanelLong.Visible = True
                PanelDate.Visible = False
                Dim response = connection.querySelect("Select * FROM qryreceiptdetails", "qryreceipts")
                If response.ToString = "True" Then
                    Dim rowCount As Integer = connection.dataset.Tables("qryreceipts").Rows.Count
                    Dim count As Integer = 0
                    headReport.Text = "Receipts For All Time"
                    DataGridView4.Rows.Clear()
                    While (count < rowCount)
                        DataGridView4.Rows.Add()
                        DataGridView4.Rows(count).Cells(0).Value = connection.dataset.Tables("qryreceipts").Rows(count).Item(0)
                        DataGridView4.Rows(count).Cells(1).Value = connection.dataset.Tables("qryreceipts").Rows(count).Item(1)
                        DataGridView4.Rows(count).Cells(2).Value = connection.dataset.Tables("qryreceipts").Rows(count).Item(2)
                        DataGridView4.Rows(count).Cells(3).Value = "$" + connection.dataset.Tables("qryreceipts").Rows(count).Item(3)
                        DataGridView4.Rows(count).Cells(4).Value = "$" + connection.dataset.Tables("qryreceipts").Rows(count).Item(4)
                        DataGridView4.Rows(count).Cells(5).Value = connection.dataset.Tables("qryreceipts").Rows(count).Item(5)
                        DataGridView4.Rows(count).Cells(6).Value = connection.dataset.Tables("qryreceipts").Rows(count).Item(6)
                        count = count + 1
                    End While
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnSelectPrinter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectPrinter.Click
        If PrintDialog1.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If
        Try
            txtPrinterName.Text = PrintDialog1.PrinterSettings.PrinterName
            My.Settings.PrinterName = txtPrinterName.Text
            My.Settings.Save()
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub btnRestoreDefaults_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestoreDefaults.Click
        If query("Update tblprinter Set UnitWidth=16,UnitHeight=14 ,FontSize=8 Where Sr=1") Then
            If querySelect("SELECT * FROM tblprinter", "tblprinter") Then
                txtUnitWidth.Text = connection.dataset.Tables("tblprinter").Rows(0).Item(1).ToString
                txtUnitHeight.Text = connection.dataset.Tables("tblprinter").Rows(0).Item(2).ToString
                txtFontSize.Text = connection.dataset.Tables("tblprinter").Rows(0).Table.Rows(0).Item(3).ToString
                PictureBox1.Image = DrawReceipt(DataGridView3.Rows, 737, DateString, 123, txtUnitWidth.Text, txtUnitHeight.Text, txtFontSize.Text)
                MsgBox("Restored", MsgBoxStyle.Information)
            End If
        End If
    End Sub

    Private Sub txtBarCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBarCode.TextChanged
        Dim response = querySelect("SELECT * FROM tblitems WHERE barcode='" + txtBarCode.Text + "'", "search_array")
        If response.ToString = "True" Then
            If connection.dataset.Tables("search_array").Rows.Count = 1 Then
                btnAdd.Enabled = True
                txtItem.Text = connection.dataset.Tables("search_array").Rows(0).Item(1)
                txtPrice.Text = connection.dataset.Tables("search_array").Rows(0).Item(3)
                btnAdd.Tag = connection.dataset.Tables("search_array").Rows(0)
            Else
                txtItem.Clear()
                txtPrice.Clear()
                txtBarCode.Focus()
                btnAdd.Enabled = False
            End If
        End If
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        ChangePassword.ShowDialog()
    End Sub

    Private Sub AddItemsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AddItemsToolStripMenuItem.Click
        AddItem.ShowDialog()
    End Sub

    Private Sub EditItemsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles EditItemsToolStripMenuItem.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            Exit Sub
        End If
        EditItem.barcode = DataGridView1.SelectedRows(0).Cells(0).Value
        EditItem.ShowDialog()
    End Sub

    Private Sub RemoveItemsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RemoveItemsToolStripMenuItem.Click
        If DataGridView1.SelectedRows.Count = 0 Then
            MsgBox("Please select an item to remove", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Dim Barcode = DataGridView1.SelectedRows(0).Cells(0).Value
        Dim stmt = "DELETE FROM tblitems WHERE barcode='" & Barcode & "'"
        If query(stmt) Then
            MsgBox("Item successfully removed!", vbInformation)
        Else
            MsgBox("Item cannot be removed!", vbExclamation)
        End If
    End Sub

    Private Sub AboutPOSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutPOSToolStripMenuItem.Click
        frmAbout.ShowDialog()
    End Sub

    Private Sub cboSelectReport_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSelectReport.SelectedIndexChanged
        If cboSelectReport.SelectedIndex = 1 Or cboSelectReport.SelectedIndex = 3 Then
            PanelDate.Visible = True
            btnSearchReports.Visible = False
        Else
            PanelDate.Visible = False
            btnSearchReports.Visible = True
        End If
    End Sub

    Private Sub btnSearchByDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchByDate.Click
        Try
            If (cboSelectReport.Text = "Total Profit Between Two Dates") Then
                PanelShort.Visible = True
                PanelLong.Visible = False
                PanelDate.Visible = True
                Dim response = connection.querySelect("Select SUM((ItemSellPrice-ItemBuyPrice)*ItemCount) FROM qryreceiptdetails WHERE receiptdate>='" & dtstart.Value.ToString("yyyy-MM-dd") & "' and receiptdate<='" & dtend.Value.ToString("yyyy-MM-dd") & "'", "qrysum")
                If response.ToString = "True" Then
                    If connection.dataset.Tables("qrysum").Rows.Count = 1 Then
                        profit.Text = connection.dataset.Tables("qrysum").Rows(0).Item(0) & " Dollars"
                        head.Text = "Total Profit Between Two Dates"
                        head.Visible = True
                        profit.Visible = True
                    Else
                        MsgBox("Sales are not enough to generate report!", vbExclamation)
                    End If
                Else
                    MsgBox(response, vbExclamation)
                End If
            ElseIf (cboSelectReport.Text = "Receipts Between Two Dates") Then
                PanelShort.Visible = False
                PanelLong.Visible = True
                PanelDate.Visible = True
                Dim response = connection.querySelect("Select * FROM qryreceiptdetails WHERE receiptdate>='" & dtstart.Value.ToString("yyyy-MM-dd") & "' and receiptdate<='" & dtend.Value.ToString("yyyy-MM-dd") & "'", "qryreceipts")
                If response.ToString = "True" Then
                    Dim rowCount As Integer = connection.dataset.Tables("qryreceipts").Rows.Count
                    Dim count As Integer = 0
                    headReport.Text = "Receipts For All Time"
                    DataGridView4.Rows.Clear()
                    While (count < rowCount)
                        DataGridView4.Rows.Add()
                        DataGridView4.Rows(count).Cells(0).Value = connection.dataset.Tables("qryreceipts").Rows(count).Item(0)
                        DataGridView4.Rows(count).Cells(1).Value = connection.dataset.Tables("qryreceipts").Rows(count).Item(1)
                        DataGridView4.Rows(count).Cells(2).Value = connection.dataset.Tables("qryreceipts").Rows(count).Item(2)
                        DataGridView4.Rows(count).Cells(3).Value = "$" + connection.dataset.Tables("qryreceipts").Rows(count).Item(3)
                        DataGridView4.Rows(count).Cells(4).Value = "$" + connection.dataset.Tables("qryreceipts").Rows(count).Item(4)
                        DataGridView4.Rows(count).Cells(5).Value = connection.dataset.Tables("qryreceipts").Rows(count).Item(5)
                        DataGridView4.Rows(count).Cells(6).Value = connection.dataset.Tables("qryreceipts").Rows(count).Item(6)
                        count = count + 1
                    End While
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Me.Close()
        frmLogin.Show()
    End Sub

    Private Sub AddUserToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddUserToolStripMenuItem.Click
        frmAddUser.ShowDialog()
    End Sub

    Private Sub UsersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsersToolStripMenuItem.Click
        frmUsers.ShowDialog()
    End Sub
End Class