<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btn1 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.txt3 = New System.Windows.Forms.TextBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(12, 26)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(67, 23)
        Me.btn1.TabIndex = 0
        Me.btn1.Text = "Set 1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(12, 55)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(67, 23)
        Me.btn2.TabIndex = 1
        Me.btn2.Text = "Set 2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(12, 84)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(67, 23)
        Me.btn3.TabIndex = 2
        Me.btn3.Text = "Set 3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(90, 29)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(59, 20)
        Me.txt1.TabIndex = 3
        Me.txt1.Text = "VRX"
        '
        'txt3
        '
        Me.txt3.Location = New System.Drawing.Point(90, 85)
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(59, 20)
        Me.txt3.TabIndex = 4
        Me.txt3.Text = "TD"
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(90, 57)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(59, 20)
        Me.txt2.TabIndex = 5
        Me.txt2.Text = "CXR"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 435)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.txt3)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Name = "frmMain"
        Me.Text = "Dashboard"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents btn2 As System.Windows.Forms.Button
    Friend WithEvents btn3 As System.Windows.Forms.Button
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents txt3 As System.Windows.Forms.TextBox
    Friend WithEvents txt2 As System.Windows.Forms.TextBox
End Class
