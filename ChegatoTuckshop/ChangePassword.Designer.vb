<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChangePassword))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtoldpassword = New System.Windows.Forms.TextBox()
        Me.txtnewpassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtconfirmpassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Location = New System.Drawing.Point(186, 107)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(164, 34)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Change Password"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtoldpassword
        '
        Me.txtoldpassword.Location = New System.Drawing.Point(139, 17)
        Me.txtoldpassword.Name = "txtoldpassword"
        Me.txtoldpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtoldpassword.Size = New System.Drawing.Size(212, 24)
        Me.txtoldpassword.TabIndex = 1
        '
        'txtnewpassword
        '
        Me.txtnewpassword.Location = New System.Drawing.Point(139, 47)
        Me.txtnewpassword.Name = "txtnewpassword"
        Me.txtnewpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtnewpassword.Size = New System.Drawing.Size(212, 24)
        Me.txtnewpassword.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Confirm Password"
        '
        'txtconfirmpassword
        '
        Me.txtconfirmpassword.Location = New System.Drawing.Point(139, 77)
        Me.txtconfirmpassword.Name = "txtconfirmpassword"
        Me.txtconfirmpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtconfirmpassword.Size = New System.Drawing.Size(212, 24)
        Me.txtconfirmpassword.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "New Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 17)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Old Password "
        '
        'ChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 150)
        Me.Controls.Add(Me.txtoldpassword)
        Me.Controls.Add(Me.txtnewpassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtconfirmpassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ChangePassword"
        Me.Opacity = 0.97R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtoldpassword As System.Windows.Forms.TextBox
    Friend WithEvents txtnewpassword As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtconfirmpassword As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
