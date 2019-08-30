<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddUser))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.txtforename = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtsurname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboaccesslevel = New System.Windows.Forms.ComboBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtverify = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'txtusername
        '
        Me.txtusername.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.Location = New System.Drawing.Point(145, 18)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(169, 26)
        Me.txtusername.TabIndex = 1
        '
        'txtforename
        '
        Me.txtforename.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtforename.Location = New System.Drawing.Point(145, 52)
        Me.txtforename.Name = "txtforename"
        Me.txtforename.Size = New System.Drawing.Size(169, 26)
        Me.txtforename.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Forename"
        '
        'txtsurname
        '
        Me.txtsurname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsurname.Location = New System.Drawing.Point(145, 85)
        Me.txtsurname.Name = "txtsurname"
        Me.txtsurname.Size = New System.Drawing.Size(169, 26)
        Me.txtsurname.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Surname"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Access Level"
        '
        'cboaccesslevel
        '
        Me.cboaccesslevel.DisplayMember = "Administrator"
        Me.cboaccesslevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboaccesslevel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboaccesslevel.FormattingEnabled = True
        Me.cboaccesslevel.Items.AddRange(New Object() {"Administrator", "Till Operator"})
        Me.cboaccesslevel.Location = New System.Drawing.Point(145, 123)
        Me.cboaccesslevel.Name = "cboaccesslevel"
        Me.cboaccesslevel.Size = New System.Drawing.Size(169, 27)
        Me.cboaccesslevel.TabIndex = 7
        '
        'txtpassword
        '
        Me.txtpassword.Font = New System.Drawing.Font("Wingdings", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.txtpassword.Location = New System.Drawing.Point(145, 160)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(108)
        Me.txtpassword.Size = New System.Drawing.Size(169, 25)
        Me.txtpassword.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Password"
        '
        'txtverify
        '
        Me.txtverify.Font = New System.Drawing.Font("Wingdings", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.txtverify.Location = New System.Drawing.Point(145, 196)
        Me.txtverify.Name = "txtverify"
        Me.txtverify.PasswordChar = Global.Microsoft.VisualBasic.ChrW(108)
        Me.txtverify.Size = New System.Drawing.Size(169, 25)
        Me.txtverify.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 199)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 19)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Verify Password"
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(145, 228)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(169, 54)
        Me.btnAdd.TabIndex = 12
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'frmAddUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 290)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtverify)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboaccesslevel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtsurname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtforename)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAddUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add User"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents txtforename As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtsurname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboaccesslevel As System.Windows.Forms.ComboBox
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtverify As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
End Class
