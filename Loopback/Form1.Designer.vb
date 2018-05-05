<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits MaterialSkin.Controls.MaterialForm

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Enable = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialDivider1 = New MaterialSkin.Controls.MaterialDivider()
        Me.Disable = New MaterialSkin.Controls.MaterialFlatButton()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 12
        Me.ListBox1.Location = New System.Drawing.Point(12, 77)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(444, 240)
        Me.ListBox1.TabIndex = 3
        '
        'Enable
        '
        Me.Enable.Depth = 0
        Me.Enable.Location = New System.Drawing.Point(12, 336)
        Me.Enable.MouseState = MaterialSkin.MouseState.HOVER
        Me.Enable.Name = "Enable"
        Me.Enable.Primary = True
        Me.Enable.Size = New System.Drawing.Size(179, 30)
        Me.Enable.TabIndex = 4
        Me.Enable.Text = "Enable"
        Me.Enable.UseVisualStyleBackColor = True
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Location = New System.Drawing.Point(0, 329)
        Me.MaterialDivider1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(492, 1)
        Me.MaterialDivider1.TabIndex = 7
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'Disable
        '
        Me.Disable.AutoSize = True
        Me.Disable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Disable.BackColor = System.Drawing.Color.White
        Me.Disable.Depth = 0
        Me.Disable.ForeColor = System.Drawing.Color.White
        Me.Disable.Location = New System.Drawing.Point(390, 334)
        Me.Disable.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Disable.MouseState = MaterialSkin.MouseState.HOVER
        Me.Disable.Name = "Disable"
        Me.Disable.Primary = True
        Me.Disable.Size = New System.Drawing.Size(66, 36)
        Me.Disable.TabIndex = 8
        Me.Disable.Text = "Disable"
        Me.Disable.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 376)
        Me.Controls.Add(Me.Disable)
        Me.Controls.Add(Me.MaterialDivider1)
        Me.Controls.Add(Me.Enable)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form1"
        Me.Text = "Status:Ready"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Enable As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialDivider1 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents Disable As MaterialSkin.Controls.MaterialFlatButton
End Class
