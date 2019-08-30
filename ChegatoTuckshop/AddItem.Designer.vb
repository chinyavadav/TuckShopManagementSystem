<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddItem
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
        Me.status = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.txtsellprice = New System.Windows.Forms.TextBox()
        Me.txtbuyprice = New System.Windows.Forms.TextBox()
        Me.txtitemname = New System.Windows.Forms.TextBox()
        Me.txtbarcode = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtqty = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.txtqty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'status
        '
        Me.status.AutoSize = True
        Me.status.Location = New System.Drawing.Point(92, 217)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(0, 17)
        Me.status.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 217)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 17)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Status :"
        '
        'btnAddItem
        '
        Me.btnAddItem.Location = New System.Drawing.Point(9, 253)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(273, 38)
        Me.btnAddItem.TabIndex = 5
        Me.btnAddItem.Text = "Add Item"
        Me.btnAddItem.UseVisualStyleBackColor = True
        '
        'txtsellprice
        '
        Me.txtsellprice.Location = New System.Drawing.Point(95, 126)
        Me.txtsellprice.Name = "txtsellprice"
        Me.txtsellprice.Size = New System.Drawing.Size(187, 24)
        Me.txtsellprice.TabIndex = 4
        '
        'txtbuyprice
        '
        Me.txtbuyprice.Location = New System.Drawing.Point(95, 87)
        Me.txtbuyprice.Name = "txtbuyprice"
        Me.txtbuyprice.Size = New System.Drawing.Size(187, 24)
        Me.txtbuyprice.TabIndex = 3
        '
        'txtitemname
        '
        Me.txtitemname.Location = New System.Drawing.Point(95, 53)
        Me.txtitemname.Name = "txtitemname"
        Me.txtitemname.Size = New System.Drawing.Size(187, 24)
        Me.txtitemname.TabIndex = 2
        '
        'txtbarcode
        '
        Me.txtbarcode.Location = New System.Drawing.Point(95, 16)
        Me.txtbarcode.Name = "txtbarcode"
        Me.txtbarcode.Size = New System.Drawing.Size(187, 24)
        Me.txtbarcode.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 129)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Sell Price"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 94)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Buy Price"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 56)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 17)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Item Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 19)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Barcode "
        '
        'txtqty
        '
        Me.txtqty.Location = New System.Drawing.Point(95, 162)
        Me.txtqty.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.txtqty.Name = "txtqty"
        Me.txtqty.Size = New System.Drawing.Size(189, 24)
        Me.txtqty.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 164)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 17)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Stock Qty"
        '
        'AddItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(296, 302)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtqty)
        Me.Controls.Add(Me.status)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnAddItem)
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
        Me.Name = "AddItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Add Item(s)"
        CType(Me.txtqty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents status As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnAddItem As System.Windows.Forms.Button
    Friend WithEvents txtsellprice As System.Windows.Forms.TextBox
    Friend WithEvents txtbuyprice As System.Windows.Forms.TextBox
    Friend WithEvents txtitemname As System.Windows.Forms.TextBox
    Friend WithEvents txtbarcode As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtqty As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
