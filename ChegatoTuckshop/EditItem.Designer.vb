<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditItem
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
        Me.btnUpdateItem = New System.Windows.Forms.Button()
        Me.txtsellprice = New System.Windows.Forms.TextBox()
        Me.txtbuyprice = New System.Windows.Forms.TextBox()
        Me.txtitemname = New System.Windows.Forms.TextBox()
        Me.txtbarcode = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.POSDataSet = New ChegatoTuckshop.POSDataSet()
        Me.ItemsTA = New ChegatoTuckshop.POSDataSetTableAdapters.ItemsTableAdapter()
        Me.TableAdapterManager1 = New ChegatoTuckshop.POSDataSetTableAdapters.TableAdapterManager()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtqty = New System.Windows.Forms.NumericUpDown()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.POSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtqty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnUpdateItem
        '
        Me.btnUpdateItem.Location = New System.Drawing.Point(12, 211)
        Me.btnUpdateItem.Name = "btnUpdateItem"
        Me.btnUpdateItem.Size = New System.Drawing.Size(289, 38)
        Me.btnUpdateItem.TabIndex = 26
        Me.btnUpdateItem.Text = "Update Item(s)"
        Me.btnUpdateItem.UseVisualStyleBackColor = True
        '
        'txtsellprice
        '
        Me.txtsellprice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "SellPrice", True))
        Me.txtsellprice.Location = New System.Drawing.Point(90, 129)
        Me.txtsellprice.Name = "txtsellprice"
        Me.txtsellprice.Size = New System.Drawing.Size(211, 24)
        Me.txtsellprice.TabIndex = 25
        '
        'txtbuyprice
        '
        Me.txtbuyprice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "BuyPrice", True))
        Me.txtbuyprice.Location = New System.Drawing.Point(90, 92)
        Me.txtbuyprice.Name = "txtbuyprice"
        Me.txtbuyprice.Size = New System.Drawing.Size(211, 24)
        Me.txtbuyprice.TabIndex = 24
        '
        'txtitemname
        '
        Me.txtitemname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "ItemName", True))
        Me.txtitemname.Location = New System.Drawing.Point(90, 55)
        Me.txtitemname.Name = "txtitemname"
        Me.txtitemname.Size = New System.Drawing.Size(211, 24)
        Me.txtitemname.TabIndex = 23
        '
        'txtbarcode
        '
        Me.txtbarcode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "Barcode", True))
        Me.txtbarcode.Location = New System.Drawing.Point(90, 18)
        Me.txtbarcode.Name = "txtbarcode"
        Me.txtbarcode.ReadOnly = True
        Me.txtbarcode.Size = New System.Drawing.Size(211, 24)
        Me.txtbarcode.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 132)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 17)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Sell Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 99)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 17)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Buy Price"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 58)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 17)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Item Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Barcode "
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "Items"
        Me.BindingSource1.DataSource = Me.POSDataSet
        '
        'POSDataSet
        '
        Me.POSDataSet.DataSetName = "POSDataSet"
        Me.POSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ItemsTA
        '
        Me.ItemsTA.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.ItemsTableAdapter = Me.ItemsTA
        Me.TableAdapterManager1.LoginTableAdapter = Nothing
        Me.TableAdapterManager1.PrinterTableAdapter = Nothing
        Me.TableAdapterManager1.ReceiptDetailsTableAdapter = Nothing
        Me.TableAdapterManager1.ReceiptsTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = ChegatoTuckshop.POSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 173)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 17)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Stock Qty"
        '
        'txtqty
        '
        Me.txtqty.Location = New System.Drawing.Point(90, 171)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(211, 24)
        Me.txtqty.TabIndex = 28
        '
        'EditItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 258)
        Me.Controls.Add(Me.txtqty)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnUpdateItem)
        Me.Controls.Add(Me.txtsellprice)
        Me.Controls.Add(Me.txtbuyprice)
        Me.Controls.Add(Me.txtitemname)
        Me.Controls.Add(Me.txtbarcode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "EditItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Item(s)"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.POSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtqty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnUpdateItem As System.Windows.Forms.Button
    Friend WithEvents txtsellprice As System.Windows.Forms.TextBox
    Friend WithEvents txtbuyprice As System.Windows.Forms.TextBox
    Friend WithEvents txtitemname As System.Windows.Forms.TextBox
    Friend WithEvents txtbarcode As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents POSDataSet As ChegatoTuckshop.POSDataSet
    Friend WithEvents ItemsTA As ChegatoTuckshop.POSDataSetTableAdapters.ItemsTableAdapter
    Friend WithEvents TableAdapterManager1 As ChegatoTuckshop.POSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtqty As System.Windows.Forms.NumericUpDown
End Class
