<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSales
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSales))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.colBarCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colBuyPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colSellPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colStockQty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BuyPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClearAll = New System.Windows.Forms.Button()
        Me.btnPrintReceipt = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtTotalPrice = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtItem = New System.Windows.Forms.TextBox()
        Me.txtBarCode = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PanelLong = New System.Windows.Forms.Panel()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.colXReceiptID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colXBarCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colXItemCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colXBuyPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colXSellPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colXReceiptDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colXReceiptTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.headReport = New System.Windows.Forms.Label()
        Me.PanelShort = New System.Windows.Forms.Panel()
        Me.profit = New System.Windows.Forms.TextBox()
        Me.head = New System.Windows.Forms.Label()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PanelDate = New System.Windows.Forms.Panel()
        Me.btnSearchByDate = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtend = New System.Windows.Forms.DateTimePicker()
        Me.dtstart = New System.Windows.Forms.DateTimePicker()
        Me.btnSearchReports = New System.Windows.Forms.Button()
        Me.cboSelectReport = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btnRestoreDefaults = New System.Windows.Forms.Button()
        Me.txtUnitHeight = New System.Windows.Forms.TextBox()
        Me.txtFontSize = New System.Windows.Forms.TextBox()
        Me.txtUnitWidth = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnSelectPrinter = New System.Windows.Forms.Button()
        Me.txtPrinterName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PrintDoc = New System.Drawing.Printing.PrintDocument()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintForm2 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutPOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.PanelLong.SuspendLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelShort.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.PanelDate.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdminToolStripMenuItem, Me.ItemsToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(924, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 24)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(924, 577)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 28)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.TabPage1.Size = New System.Drawing.Size(916, 545)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Items"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colBarCode, Me.colItemName, Me.colBuyPrice, Me.colSellPrice, Me.colStockQty})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 5)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(910, 535)
        Me.DataGridView1.TabIndex = 1
        '
        'colBarCode
        '
        Me.colBarCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colBarCode.HeaderText = "Bar Code"
        Me.colBarCode.Name = "colBarCode"
        Me.colBarCode.ReadOnly = True
        '
        'colItemName
        '
        Me.colItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colItemName.HeaderText = "Item Name"
        Me.colItemName.Name = "colItemName"
        Me.colItemName.ReadOnly = True
        '
        'colBuyPrice
        '
        Me.colBuyPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colBuyPrice.HeaderText = "Buy Price"
        Me.colBuyPrice.Name = "colBuyPrice"
        Me.colBuyPrice.ReadOnly = True
        '
        'colSellPrice
        '
        Me.colSellPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colSellPrice.HeaderText = "Sell Price"
        Me.colSellPrice.Name = "colSellPrice"
        Me.colSellPrice.ReadOnly = True
        '
        'colStockQty
        '
        Me.colStockQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colStockQty.HeaderText = "Stock Qty"
        Me.colStockQty.Name = "colStockQty"
        Me.colStockQty.ReadOnly = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGridView2)
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 28)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(916, 545)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Execute Sale"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToOrderColumns = True
        Me.DataGridView2.AllowUserToResizeColumns = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.BuyPrice, Me.Column3, Me.Column4, Me.Column5})
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(241, 0)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(675, 545)
        Me.DataGridView2.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "Barcode"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Item"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'BuyPrice
        '
        Me.BuyPrice.HeaderText = "BuyPrice"
        Me.BuyPrice.Name = "BuyPrice"
        Me.BuyPrice.ReadOnly = True
        Me.BuyPrice.Visible = False
        '
        'Column3
        '
        Me.Column3.HeaderText = "Price"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Quantity"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Total Price"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnClearAll)
        Me.Panel1.Controls.Add(Me.btnPrintReceipt)
        Me.Panel1.Controls.Add(Me.btnRemove)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Me.txtTotalPrice)
        Me.Panel1.Controls.Add(Me.txtPrice)
        Me.Panel1.Controls.Add(Me.txtItem)
        Me.Panel1.Controls.Add(Me.txtBarCode)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(241, 545)
        Me.Panel1.TabIndex = 0
        '
        'btnClearAll
        '
        Me.btnClearAll.BackColor = System.Drawing.Color.DimGray
        Me.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearAll.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearAll.ForeColor = System.Drawing.Color.White
        Me.btnClearAll.Location = New System.Drawing.Point(8, 282)
        Me.btnClearAll.Name = "btnClearAll"
        Me.btnClearAll.Size = New System.Drawing.Size(218, 29)
        Me.btnClearAll.TabIndex = 4
        Me.btnClearAll.Text = "Clear All"
        Me.btnClearAll.UseVisualStyleBackColor = False
        '
        'btnPrintReceipt
        '
        Me.btnPrintReceipt.BackColor = System.Drawing.Color.DimGray
        Me.btnPrintReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintReceipt.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintReceipt.ForeColor = System.Drawing.Color.White
        Me.btnPrintReceipt.Location = New System.Drawing.Point(8, 247)
        Me.btnPrintReceipt.Name = "btnPrintReceipt"
        Me.btnPrintReceipt.Size = New System.Drawing.Size(218, 29)
        Me.btnPrintReceipt.TabIndex = 4
        Me.btnPrintReceipt.Text = "Complete Sale"
        Me.btnPrintReceipt.UseVisualStyleBackColor = False
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.DimGray
        Me.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemove.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.White
        Me.btnRemove.Location = New System.Drawing.Point(8, 212)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(218, 29)
        Me.btnRemove.TabIndex = 3
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.DimGray
        Me.btnAdd.Enabled = False
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.Location = New System.Drawing.Point(9, 177)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(218, 29)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPrice.Location = New System.Drawing.Point(87, 97)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.ReadOnly = True
        Me.txtTotalPrice.Size = New System.Drawing.Size(121, 20)
        Me.txtTotalPrice.TabIndex = 7
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(87, 70)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.ReadOnly = True
        Me.txtPrice.Size = New System.Drawing.Size(121, 20)
        Me.txtPrice.TabIndex = 6
        '
        'txtItem
        '
        Me.txtItem.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItem.Location = New System.Drawing.Point(87, 43)
        Me.txtItem.Name = "txtItem"
        Me.txtItem.ReadOnly = True
        Me.txtItem.Size = New System.Drawing.Size(121, 20)
        Me.txtItem.TabIndex = 5
        '
        'txtBarCode
        '
        Me.txtBarCode.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarCode.Location = New System.Drawing.Point(87, 16)
        Me.txtBarCode.Name = "txtBarCode"
        Me.txtBarCode.Size = New System.Drawing.Size(121, 20)
        Me.txtBarCode.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 19)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Total Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Price"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Item"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Barcode "
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox2)
        Me.TabPage3.Controls.Add(Me.GroupBox1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 28)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(916, 545)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Reports"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.PanelLong)
        Me.GroupBox2.Controls.Add(Me.PanelShort)
        Me.GroupBox2.Controls.Add(Me.BindingNavigator1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 131)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(896, 396)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Report Details"
        '
        'PanelLong
        '
        Me.PanelLong.BackColor = System.Drawing.Color.White
        Me.PanelLong.Controls.Add(Me.DataGridView4)
        Me.PanelLong.Controls.Add(Me.headReport)
        Me.PanelLong.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelLong.Location = New System.Drawing.Point(3, 165)
        Me.PanelLong.Name = "PanelLong"
        Me.PanelLong.Size = New System.Drawing.Size(890, 228)
        Me.PanelLong.TabIndex = 3
        Me.PanelLong.Visible = False
        '
        'DataGridView4
        '
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colXReceiptID, Me.colXBarCode, Me.colXItemCount, Me.colXBuyPrice, Me.colXSellPrice, Me.colXReceiptDate, Me.colXReceiptTotal})
        Me.DataGridView4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView4.Location = New System.Drawing.Point(0, 23)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.Size = New System.Drawing.Size(890, 205)
        Me.DataGridView4.TabIndex = 4
        '
        'colXReceiptID
        '
        Me.colXReceiptID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colXReceiptID.HeaderText = "Receipt ID"
        Me.colXReceiptID.Name = "colXReceiptID"
        Me.colXReceiptID.ReadOnly = True
        '
        'colXBarCode
        '
        Me.colXBarCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colXBarCode.HeaderText = "Bar Code"
        Me.colXBarCode.Name = "colXBarCode"
        Me.colXBarCode.ReadOnly = True
        '
        'colXItemCount
        '
        Me.colXItemCount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colXItemCount.HeaderText = "Item Count"
        Me.colXItemCount.Name = "colXItemCount"
        Me.colXItemCount.ReadOnly = True
        '
        'colXBuyPrice
        '
        Me.colXBuyPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colXBuyPrice.HeaderText = "Buy Price"
        Me.colXBuyPrice.Name = "colXBuyPrice"
        Me.colXBuyPrice.ReadOnly = True
        '
        'colXSellPrice
        '
        Me.colXSellPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colXSellPrice.HeaderText = "Sell Price"
        Me.colXSellPrice.Name = "colXSellPrice"
        Me.colXSellPrice.ReadOnly = True
        '
        'colXReceiptDate
        '
        Me.colXReceiptDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colXReceiptDate.HeaderText = "Receipt Date"
        Me.colXReceiptDate.Name = "colXReceiptDate"
        Me.colXReceiptDate.ReadOnly = True
        '
        'colXReceiptTotal
        '
        Me.colXReceiptTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colXReceiptTotal.HeaderText = "Receipt Total"
        Me.colXReceiptTotal.Name = "colXReceiptTotal"
        Me.colXReceiptTotal.ReadOnly = True
        '
        'headReport
        '
        Me.headReport.AutoSize = True
        Me.headReport.Dock = System.Windows.Forms.DockStyle.Top
        Me.headReport.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.headReport.ForeColor = System.Drawing.SystemColors.Highlight
        Me.headReport.Location = New System.Drawing.Point(0, 0)
        Me.headReport.Name = "headReport"
        Me.headReport.Size = New System.Drawing.Size(178, 23)
        Me.headReport.TabIndex = 3
        Me.headReport.Text = "Receipts For All Time"
        Me.headReport.Visible = False
        '
        'PanelShort
        '
        Me.PanelShort.BackColor = System.Drawing.Color.White
        Me.PanelShort.Controls.Add(Me.profit)
        Me.PanelShort.Controls.Add(Me.head)
        Me.PanelShort.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelShort.Location = New System.Drawing.Point(3, 48)
        Me.PanelShort.Name = "PanelShort"
        Me.PanelShort.Size = New System.Drawing.Size(890, 117)
        Me.PanelShort.TabIndex = 2
        Me.PanelShort.Visible = False
        '
        'profit
        '
        Me.profit.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.profit.Location = New System.Drawing.Point(16, 40)
        Me.profit.Name = "profit"
        Me.profit.Size = New System.Drawing.Size(296, 20)
        Me.profit.TabIndex = 4
        '
        'head
        '
        Me.head.AutoSize = True
        Me.head.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.head.ForeColor = System.Drawing.SystemColors.Highlight
        Me.head.Location = New System.Drawing.Point(12, 14)
        Me.head.Name = "head"
        Me.head.Size = New System.Drawing.Size(182, 23)
        Me.head.TabIndex = 3
        Me.head.Text = "Total Sales Of all Time"
        Me.head.Visible = False
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.CountItem = Nothing
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3, Me.ToolStripButton2})
        Me.BindingNavigator1.Location = New System.Drawing.Point(3, 23)
        Me.BindingNavigator1.MoveFirstItem = Nothing
        Me.BindingNavigator1.MoveLastItem = Nothing
        Me.BindingNavigator1.MoveNextItem = Nothing
        Me.BindingNavigator1.MovePreviousItem = Nothing
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Nothing
        Me.BindingNavigator1.Size = New System.Drawing.Size(890, 25)
        Me.BindingNavigator1.TabIndex = 1
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.PanelDate)
        Me.GroupBox1.Controls.Add(Me.btnSearchReports)
        Me.GroupBox1.Controls.Add(Me.cboSelectReport)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(896, 112)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search"
        '
        'PanelDate
        '
        Me.PanelDate.Controls.Add(Me.btnSearchByDate)
        Me.PanelDate.Controls.Add(Me.Label11)
        Me.PanelDate.Controls.Add(Me.Label10)
        Me.PanelDate.Controls.Add(Me.dtend)
        Me.PanelDate.Controls.Add(Me.dtstart)
        Me.PanelDate.Location = New System.Drawing.Point(388, 26)
        Me.PanelDate.Name = "PanelDate"
        Me.PanelDate.Size = New System.Drawing.Size(502, 80)
        Me.PanelDate.TabIndex = 2
        Me.PanelDate.Visible = False
        '
        'btnSearchByDate
        '
        Me.btnSearchByDate.Location = New System.Drawing.Point(362, 9)
        Me.btnSearchByDate.Name = "btnSearchByDate"
        Me.btnSearchByDate.Size = New System.Drawing.Size(137, 56)
        Me.btnSearchByDate.TabIndex = 4
        Me.btnSearchByDate.Text = "Search Reports"
        Me.btnSearchByDate.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(24, 44)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 19)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "End Date:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(24, 15)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 19)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Start Date:"
        '
        'dtend
        '
        Me.dtend.CustomFormat = "yyyy-MM-dd"
        Me.dtend.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtend.Location = New System.Drawing.Point(121, 38)
        Me.dtend.Name = "dtend"
        Me.dtend.Size = New System.Drawing.Size(235, 27)
        Me.dtend.TabIndex = 1
        '
        'dtstart
        '
        Me.dtstart.CustomFormat = "yyyy-MM-dd"
        Me.dtstart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtstart.Location = New System.Drawing.Point(121, 9)
        Me.dtstart.Name = "dtstart"
        Me.dtstart.Size = New System.Drawing.Size(235, 27)
        Me.dtstart.TabIndex = 0
        '
        'btnSearchReports
        '
        Me.btnSearchReports.Location = New System.Drawing.Point(124, 64)
        Me.btnSearchReports.Name = "btnSearchReports"
        Me.btnSearchReports.Size = New System.Drawing.Size(243, 31)
        Me.btnSearchReports.TabIndex = 1
        Me.btnSearchReports.Text = "Search Reports"
        Me.btnSearchReports.UseVisualStyleBackColor = True
        '
        'cboSelectReport
        '
        Me.cboSelectReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSelectReport.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSelectReport.FormattingEnabled = True
        Me.cboSelectReport.Items.AddRange(New Object() {"Total Profit For All Time", "Total Profit Between Two Dates", "Receipts For All Time", "Receipts Between Two Dates"})
        Me.cboSelectReport.Location = New System.Drawing.Point(124, 35)
        Me.cboSelectReport.Name = "cboSelectReport"
        Me.cboSelectReport.Size = New System.Drawing.Size(243, 23)
        Me.cboSelectReport.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 19)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Select Report :"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.GroupBox6)
        Me.TabPage4.Controls.Add(Me.GroupBox5)
        Me.TabPage4.Controls.Add(Me.GroupBox4)
        Me.TabPage4.Controls.Add(Me.GroupBox3)
        Me.TabPage4.Location = New System.Drawing.Point(4, 28)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(916, 545)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Settings"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox6.Controls.Add(Me.btnRestoreDefaults)
        Me.GroupBox6.Controls.Add(Me.txtUnitHeight)
        Me.GroupBox6.Controls.Add(Me.txtFontSize)
        Me.GroupBox6.Controls.Add(Me.txtUnitWidth)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Controls.Add(Me.Label6)
        Me.GroupBox6.Location = New System.Drawing.Point(369, 13)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(266, 93)
        Me.GroupBox6.TabIndex = 3
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Receipt Settings"
        '
        'btnRestoreDefaults
        '
        Me.btnRestoreDefaults.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestoreDefaults.Location = New System.Drawing.Point(140, 58)
        Me.btnRestoreDefaults.Name = "btnRestoreDefaults"
        Me.btnRestoreDefaults.Size = New System.Drawing.Size(120, 28)
        Me.btnRestoreDefaults.TabIndex = 4
        Me.btnRestoreDefaults.Text = "&Restore Defaults"
        Me.btnRestoreDefaults.UseVisualStyleBackColor = True
        '
        'txtUnitHeight
        '
        Me.txtUnitHeight.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnitHeight.Location = New System.Drawing.Point(222, 28)
        Me.txtUnitHeight.Name = "txtUnitHeight"
        Me.txtUnitHeight.Size = New System.Drawing.Size(38, 22)
        Me.txtUnitHeight.TabIndex = 2
        '
        'txtFontSize
        '
        Me.txtFontSize.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFontSize.Location = New System.Drawing.Point(92, 59)
        Me.txtFontSize.Name = "txtFontSize"
        Me.txtFontSize.Size = New System.Drawing.Size(38, 22)
        Me.txtFontSize.TabIndex = 3
        '
        'txtUnitWidth
        '
        Me.txtUnitWidth.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnitWidth.Location = New System.Drawing.Point(92, 28)
        Me.txtUnitWidth.Name = "txtUnitWidth"
        Me.txtUnitWidth.Size = New System.Drawing.Size(38, 22)
        Me.txtUnitWidth.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 62)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 19)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Font Size"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(136, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 19)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Unit Height"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 19)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Unit Width"
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.PictureBox1)
        Me.GroupBox5.Location = New System.Drawing.Point(368, 112)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(273, 234)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Receipt Preview"
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.DataGridView3)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 112)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(354, 234)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Sample Data"
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.AllowUserToOrderColumns = True
        Me.DataGridView3.AllowUserToResizeColumns = False
        Me.DataGridView3.AllowUserToResizeRows = False
        Me.DataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView3.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.DataGridView3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView3.Location = New System.Drawing.Point(3, 23)
        Me.DataGridView3.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.RowHeadersVisible = False
        Me.DataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView3.Size = New System.Drawing.Size(348, 208)
        Me.DataGridView3.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Barcode"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Item"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "BuyPrice"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Total Price"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnSelectPrinter)
        Me.GroupBox3.Controls.Add(Me.txtPrinterName)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 13)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(354, 93)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Receipts Printer"
        '
        'btnSelectPrinter
        '
        Me.btnSelectPrinter.Location = New System.Drawing.Point(115, 54)
        Me.btnSelectPrinter.Name = "btnSelectPrinter"
        Me.btnSelectPrinter.Size = New System.Drawing.Size(229, 27)
        Me.btnSelectPrinter.TabIndex = 2
        Me.btnSelectPrinter.Text = "&Select Printer"
        Me.btnSelectPrinter.UseVisualStyleBackColor = True
        '
        'txtPrinterName
        '
        Me.txtPrinterName.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrinterName.Location = New System.Drawing.Point(115, 24)
        Me.txtPrinterName.Name = "txtPrinterName"
        Me.txtPrinterName.ReadOnly = True
        Me.txtPrinterName.Size = New System.Drawing.Size(229, 24)
        Me.txtPrinterName.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 19)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Printer Name :"
        '
        'PrintDoc
        '
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintForm2
        '
        Me.PrintForm2.DocumentName = "document"
        Me.PrintForm2.Form = Me
        Me.PrintForm2.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm2.PrinterSettings = CType(resources.GetObject("PrintForm2.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm2.PrintFileName = Nothing
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Refresh"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Print"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(3, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(267, 208)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangePasswordToolStripMenuItem, Me.AddUserToolStripMenuItem, Me.UsersToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.AdminToolStripMenuItem.Image = CType(resources.GetObject("AdminToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.AdminToolStripMenuItem.Text = "Settings"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Image = CType(resources.GetObject("ChangePasswordToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ChangePasswordToolStripMenuItem.Text = "Change Password"
        '
        'AddUserToolStripMenuItem
        '
        Me.AddUserToolStripMenuItem.Name = "AddUserToolStripMenuItem"
        Me.AddUserToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.AddUserToolStripMenuItem.Text = "Add User"
        '
        'UsersToolStripMenuItem
        '
        Me.UsersToolStripMenuItem.Name = "UsersToolStripMenuItem"
        Me.UsersToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.UsersToolStripMenuItem.Text = "Users"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ItemsToolStripMenuItem
        '
        Me.ItemsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddItemsToolStripMenuItem, Me.EditItemsToolStripMenuItem, Me.RemoveItemsToolStripMenuItem})
        Me.ItemsToolStripMenuItem.Image = CType(resources.GetObject("ItemsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ItemsToolStripMenuItem.Name = "ItemsToolStripMenuItem"
        Me.ItemsToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.ItemsToolStripMenuItem.Text = "Items"
        '
        'AddItemsToolStripMenuItem
        '
        Me.AddItemsToolStripMenuItem.Image = CType(resources.GetObject("AddItemsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AddItemsToolStripMenuItem.Name = "AddItemsToolStripMenuItem"
        Me.AddItemsToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.AddItemsToolStripMenuItem.Text = "Add Items"
        '
        'EditItemsToolStripMenuItem
        '
        Me.EditItemsToolStripMenuItem.Image = CType(resources.GetObject("EditItemsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EditItemsToolStripMenuItem.Name = "EditItemsToolStripMenuItem"
        Me.EditItemsToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.EditItemsToolStripMenuItem.Text = "Edit Items"
        '
        'RemoveItemsToolStripMenuItem
        '
        Me.RemoveItemsToolStripMenuItem.Image = CType(resources.GetObject("RemoveItemsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RemoveItemsToolStripMenuItem.Name = "RemoveItemsToolStripMenuItem"
        Me.RemoveItemsToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.RemoveItemsToolStripMenuItem.Text = "Remove Items"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutPOSToolStripMenuItem})
        Me.AboutToolStripMenuItem.Image = CType(resources.GetObject("AboutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.AboutToolStripMenuItem.Text = "Help"
        '
        'AboutPOSToolStripMenuItem
        '
        Me.AboutPOSToolStripMenuItem.Image = CType(resources.GetObject("AboutPOSToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AboutPOSToolStripMenuItem.Name = "AboutPOSToolStripMenuItem"
        Me.AboutPOSToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.AboutPOSToolStripMenuItem.Text = "About POS"
        '
        'frmSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 601)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.PanelLong.ResumeLayout(False)
        Me.PanelLong.PerformLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelShort.ResumeLayout(False)
        Me.PanelShort.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PanelDate.ResumeLayout(False)
        Me.PanelDate.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AdminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ItemsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddItemsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditItemsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveItemsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutPOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BuyPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnClearAll As System.Windows.Forms.Button
    Friend WithEvents btnPrintReceipt As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtTotalPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtItem As System.Windows.Forms.TextBox
    Friend WithEvents txtBarCode As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BindingNavigator1 As System.Windows.Forms.BindingNavigator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSearchReports As System.Windows.Forms.Button
    Friend WithEvents cboSelectReport As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents btnRestoreDefaults As System.Windows.Forms.Button
    Friend WithEvents txtUnitHeight As System.Windows.Forms.TextBox
    Friend WithEvents txtFontSize As System.Windows.Forms.TextBox
    Friend WithEvents txtUnitWidth As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSelectPrinter As System.Windows.Forms.Button
    Friend WithEvents txtPrinterName As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents PrintDoc As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintForm2 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PanelDate As System.Windows.Forms.Panel
    Friend WithEvents dtend As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtstart As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnSearchByDate As System.Windows.Forms.Button
    Friend WithEvents PanelShort As System.Windows.Forms.Panel
    Friend WithEvents profit As System.Windows.Forms.TextBox
    Friend WithEvents head As System.Windows.Forms.Label
    Friend WithEvents PanelLong As System.Windows.Forms.Panel
    Friend WithEvents headReport As System.Windows.Forms.Label
    Friend WithEvents DataGridView4 As System.Windows.Forms.DataGridView
    Friend WithEvents colXReceiptID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colXBarCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colXItemCount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colXBuyPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colXSellPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colXReceiptDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colXReceiptTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colBarCode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colItemName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colBuyPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSellPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colStockQty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
