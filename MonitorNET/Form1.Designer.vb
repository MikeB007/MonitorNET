<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tab1min = New System.Windows.Forms.TabPage()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.tab10min = New System.Windows.Forms.TabPage()
        Me.WebBrowser3 = New System.Windows.Forms.WebBrowser()
        Me.tab15min = New System.Windows.Forms.TabPage()
        Me.tab1hr = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.lblSymbol = New System.Windows.Forms.Label()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.WebBrowser2 = New System.Windows.Forms.WebBrowser()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.WebBrowser4 = New System.Windows.Forms.WebBrowser()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.WebBrowser5 = New System.Windows.Forms.WebBrowser()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.WebBrowser6 = New System.Windows.Forms.WebBrowser()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.tab1min.SuspendLayout()
        Me.tab10min.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tab1min)
        Me.TabControl1.Controls.Add(Me.tab10min)
        Me.TabControl1.Controls.Add(Me.tab15min)
        Me.TabControl1.Controls.Add(Me.tab1hr)
        Me.TabControl1.Location = New System.Drawing.Point(12, 39)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(541, 744)
        Me.TabControl1.TabIndex = 0
        '
        'tab1min
        '
        Me.tab1min.Controls.Add(Me.WebBrowser1)
        Me.tab1min.Location = New System.Drawing.Point(4, 22)
        Me.tab1min.Name = "tab1min"
        Me.tab1min.Padding = New System.Windows.Forms.Padding(3)
        Me.tab1min.Size = New System.Drawing.Size(533, 718)
        Me.tab1min.TabIndex = 0
        Me.tab1min.Text = "1 min"
        Me.tab1min.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(3, 3)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(527, 712)
        Me.WebBrowser1.TabIndex = 0
        Me.WebBrowser1.Url = New System.Uri("http://ca.advfn.com/stock-market/TSX/VRX/chart/streaming?mode=html", System.UriKind.Absolute)
        '
        'tab10min
        '
        Me.tab10min.Controls.Add(Me.WebBrowser3)
        Me.tab10min.Location = New System.Drawing.Point(4, 22)
        Me.tab10min.Name = "tab10min"
        Me.tab10min.Size = New System.Drawing.Size(439, 552)
        Me.tab10min.TabIndex = 3
        Me.tab10min.Text = "10 min"
        Me.tab10min.UseVisualStyleBackColor = True
        '
        'WebBrowser3
        '
        Me.WebBrowser3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser3.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser3.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser3.Name = "WebBrowser3"
        Me.WebBrowser3.ScriptErrorsSuppressed = True
        Me.WebBrowser3.Size = New System.Drawing.Size(439, 552)
        Me.WebBrowser3.TabIndex = 0
        Me.WebBrowser3.Url = New System.Uri("http://ca.advfn.com/stock-market/TSX/VRX/chart/streaming?mode=html", System.UriKind.Absolute)
        '
        'tab15min
        '
        Me.tab15min.Location = New System.Drawing.Point(4, 22)
        Me.tab15min.Name = "tab15min"
        Me.tab15min.Padding = New System.Windows.Forms.Padding(3)
        Me.tab15min.Size = New System.Drawing.Size(439, 552)
        Me.tab15min.TabIndex = 2
        Me.tab15min.Text = "15 min"
        Me.tab15min.UseVisualStyleBackColor = True
        '
        'tab1hr
        '
        Me.tab1hr.Location = New System.Drawing.Point(4, 22)
        Me.tab1hr.Name = "tab1hr"
        Me.tab1hr.Size = New System.Drawing.Size(439, 552)
        Me.tab1hr.TabIndex = 4
        Me.tab1hr.Text = "1 HR"
        Me.tab1hr.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(66, 13)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(114, 20)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = "vrx"
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(195, 12)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(57, 20)
        Me.btnGo.TabIndex = 3
        Me.btnGo.Text = "go."
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'lblSymbol
        '
        Me.lblSymbol.AutoSize = True
        Me.lblSymbol.Location = New System.Drawing.Point(20, 19)
        Me.lblSymbol.Name = "lblSymbol"
        Me.lblSymbol.Size = New System.Drawing.Size(40, 13)
        Me.lblSymbol.TabIndex = 4
        Me.lblSymbol.Text = "Ticker:"
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage1)
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Location = New System.Drawing.Point(552, 39)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(516, 744)
        Me.TabControl2.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.WebBrowser2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(508, 718)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "1 min"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'WebBrowser2
        '
        Me.WebBrowser2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser2.Location = New System.Drawing.Point(3, 3)
        Me.WebBrowser2.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser2.Name = "WebBrowser2"
        Me.WebBrowser2.ScriptErrorsSuppressed = True
        Me.WebBrowser2.Size = New System.Drawing.Size(502, 712)
        Me.WebBrowser2.TabIndex = 0
        Me.WebBrowser2.Url = New System.Uri("http://ca.advfn.com/stock-market/TSX/VRX/chart/streaming?mode=html", System.UriKind.Absolute)
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.WebBrowser4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(439, 552)
        Me.TabPage2.TabIndex = 3
        Me.TabPage2.Text = "10 min"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'WebBrowser4
        '
        Me.WebBrowser4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser4.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser4.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser4.Name = "WebBrowser4"
        Me.WebBrowser4.ScriptErrorsSuppressed = True
        Me.WebBrowser4.Size = New System.Drawing.Size(439, 552)
        Me.WebBrowser4.TabIndex = 0
        Me.WebBrowser4.Url = New System.Uri("http://ca.advfn.com/stock-market/TSX/VRX/chart/streaming?mode=html", System.UriKind.Absolute)
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(439, 552)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "15 min"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(439, 552)
        Me.TabPage4.TabIndex = 4
        Me.TabPage4.Text = "1 HR"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TabControl3
        '
        Me.TabControl3.Controls.Add(Me.TabPage5)
        Me.TabControl3.Controls.Add(Me.TabPage6)
        Me.TabControl3.Controls.Add(Me.TabPage7)
        Me.TabControl3.Controls.Add(Me.TabPage8)
        Me.TabControl3.Location = New System.Drawing.Point(1070, 39)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(541, 744)
        Me.TabControl3.TabIndex = 6
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.WebBrowser5)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(533, 718)
        Me.TabPage5.TabIndex = 0
        Me.TabPage5.Text = "1 min"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'WebBrowser5
        '
        Me.WebBrowser5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser5.Location = New System.Drawing.Point(3, 3)
        Me.WebBrowser5.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser5.Name = "WebBrowser5"
        Me.WebBrowser5.ScriptErrorsSuppressed = True
        Me.WebBrowser5.Size = New System.Drawing.Size(527, 712)
        Me.WebBrowser5.TabIndex = 0
        Me.WebBrowser5.Url = New System.Uri("http://ca.advfn.com/stock-market/TSX/VRX/chart/streaming?mode=html", System.UriKind.Absolute)
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.WebBrowser6)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(439, 552)
        Me.TabPage6.TabIndex = 3
        Me.TabPage6.Text = "10 min"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'WebBrowser6
        '
        Me.WebBrowser6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser6.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser6.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser6.Name = "WebBrowser6"
        Me.WebBrowser6.ScriptErrorsSuppressed = True
        Me.WebBrowser6.Size = New System.Drawing.Size(439, 552)
        Me.WebBrowser6.TabIndex = 0
        Me.WebBrowser6.Url = New System.Uri("http://ca.advfn.com/stock-market/TSX/VRX/chart/streaming?mode=html", System.UriKind.Absolute)
        '
        'TabPage7
        '
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(439, 552)
        Me.TabPage7.TabIndex = 2
        Me.TabPage7.Text = "15 min"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'TabPage8
        '
        Me.TabPage8.Location = New System.Drawing.Point(4, 22)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Size = New System.Drawing.Size(439, 552)
        Me.TabPage8.TabIndex = 4
        Me.TabPage8.Text = "1 HR"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1614, 795)
        Me.Controls.Add(Me.TabControl3)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.lblSymbol)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.tab1min.ResumeLayout(False)
        Me.tab10min.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabControl3.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tab1min As System.Windows.Forms.TabPage
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents tab15min As System.Windows.Forms.TabPage
    Friend WithEvents tab10min As System.Windows.Forms.TabPage
    Friend WithEvents WebBrowser3 As System.Windows.Forms.WebBrowser
    Friend WithEvents tab1hr As System.Windows.Forms.TabPage
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents lblSymbol As System.Windows.Forms.Label
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents WebBrowser2 As System.Windows.Forms.WebBrowser
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents WebBrowser4 As System.Windows.Forms.WebBrowser
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabControl3 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents WebBrowser5 As System.Windows.Forms.WebBrowser
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents WebBrowser6 As System.Windows.Forms.WebBrowser
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage8 As System.Windows.Forms.TabPage

End Class
