<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonitor
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
        Me.txtSymbol = New System.Windows.Forms.TextBox()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.lbl = New System.Windows.Forms.Label()
        Me.p = New System.Windows.Forms.Panel()
        Me.T15 = New System.Windows.Forms.TabControl()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.wb15 = New System.Windows.Forms.WebBrowser()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.T5 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.wb5 = New System.Windows.Forms.WebBrowser()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.T1 = New System.Windows.Forms.TabControl()
        Me.tab1min = New System.Windows.Forms.TabPage()
        Me.wb1 = New System.Windows.Forms.WebBrowser()
        Me.tab10min = New System.Windows.Forms.TabPage()
        Me.wb2 = New System.Windows.Forms.WebBrowser()
        Me.tab15min = New System.Windows.Forms.TabPage()
        Me.tab1hr = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmbMarket = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lblm = New System.Windows.Forms.Label()
        Me.TM = New System.Windows.Forms.TabControl()
        Me.TabPage9 = New System.Windows.Forms.TabPage()
        Me.wbm = New System.Windows.Forms.WebBrowser()
        Me.TabPage10 = New System.Windows.Forms.TabPage()
        Me.WebBrowser2 = New System.Windows.Forms.WebBrowser()
        Me.TabPage11 = New System.Windows.Forms.TabPage()
        Me.TabPage12 = New System.Windows.Forms.TabPage()
        Me.p.SuspendLayout()
        Me.T15.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.T5.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.T1.SuspendLayout()
        Me.tab1min.SuspendLayout()
        Me.tab10min.SuspendLayout()
        Me.TM.SuspendLayout()
        Me.TabPage9.SuspendLayout()
        Me.TabPage10.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSymbol
        '
        Me.txtSymbol.Location = New System.Drawing.Point(75, 2)
        Me.txtSymbol.Name = "txtSymbol"
        Me.txtSymbol.Size = New System.Drawing.Size(114, 20)
        Me.txtSymbol.TabIndex = 2
        Me.txtSymbol.Text = "vrx"
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(482, 1)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(57, 23)
        Me.btnGo.TabIndex = 3
        Me.btnGo.Text = "go."
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Location = New System.Drawing.Point(29, 8)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(40, 13)
        Me.lbl.TabIndex = 4
        Me.lbl.Text = "Ticker:"
        '
        'p
        '
        Me.p.Controls.Add(Me.T15)
        Me.p.Controls.Add(Me.T5)
        Me.p.Controls.Add(Me.T1)
        Me.p.Location = New System.Drawing.Point(32, 31)
        Me.p.Name = "p"
        Me.p.Size = New System.Drawing.Size(1852, 686)
        Me.p.TabIndex = 8
        '
        'T15
        '
        Me.T15.Controls.Add(Me.TabPage5)
        Me.T15.Controls.Add(Me.TabPage6)
        Me.T15.Controls.Add(Me.TabPage7)
        Me.T15.Controls.Add(Me.TabPage8)
        Me.T15.Location = New System.Drawing.Point(1204, 0)
        Me.T15.Name = "T15"
        Me.T15.SelectedIndex = 0
        Me.T15.Size = New System.Drawing.Size(445, 674)
        Me.T15.TabIndex = 3
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.wb15)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(437, 648)
        Me.TabPage5.TabIndex = 0
        Me.TabPage5.Text = "1 min"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'wb15
        '
        Me.wb15.Location = New System.Drawing.Point(3, 6)
        Me.wb15.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wb15.Name = "wb15"
        Me.wb15.ScriptErrorsSuppressed = True
        Me.wb15.Size = New System.Drawing.Size(411, 642)
        Me.wb15.TabIndex = 0
        Me.wb15.Url = New System.Uri("", System.UriKind.Relative)
        '
        'TabPage6
        '
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(437, 648)
        Me.TabPage6.TabIndex = 3
        Me.TabPage6.Text = "10 min"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'TabPage7
        '
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(437, 648)
        Me.TabPage7.TabIndex = 2
        Me.TabPage7.Text = "15 min"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'TabPage8
        '
        Me.TabPage8.Location = New System.Drawing.Point(4, 22)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Size = New System.Drawing.Size(437, 648)
        Me.TabPage8.TabIndex = 4
        Me.TabPage8.Text = "1 HR"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'T5
        '
        Me.T5.Controls.Add(Me.TabPage1)
        Me.T5.Controls.Add(Me.TabPage2)
        Me.T5.Controls.Add(Me.TabPage3)
        Me.T5.Controls.Add(Me.TabPage4)
        Me.T5.Location = New System.Drawing.Point(689, 13)
        Me.T5.Name = "T5"
        Me.T5.SelectedIndex = 0
        Me.T5.Size = New System.Drawing.Size(513, 661)
        Me.T5.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.wb5)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(505, 635)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "1 min"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'wb5
        '
        Me.wb5.Location = New System.Drawing.Point(0, 9)
        Me.wb5.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wb5.Name = "wb5"
        Me.wb5.ScriptErrorsSuppressed = True
        Me.wb5.Size = New System.Drawing.Size(496, 614)
        Me.wb5.TabIndex = 0
        Me.wb5.Url = New System.Uri("", System.UriKind.Relative)
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(505, 635)
        Me.TabPage2.TabIndex = 3
        Me.TabPage2.Text = "10 min"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(505, 635)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "15 min"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(505, 635)
        Me.TabPage4.TabIndex = 4
        Me.TabPage4.Text = "1 HR"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'T1
        '
        Me.T1.Controls.Add(Me.tab1min)
        Me.T1.Controls.Add(Me.tab10min)
        Me.T1.Controls.Add(Me.tab15min)
        Me.T1.Controls.Add(Me.tab1hr)
        Me.T1.Location = New System.Drawing.Point(5, 3)
        Me.T1.Name = "T1"
        Me.T1.SelectedIndex = 0
        Me.T1.Size = New System.Drawing.Size(678, 687)
        Me.T1.TabIndex = 1
        '
        'tab1min
        '
        Me.tab1min.Controls.Add(Me.wb1)
        Me.tab1min.Location = New System.Drawing.Point(4, 22)
        Me.tab1min.Name = "tab1min"
        Me.tab1min.Padding = New System.Windows.Forms.Padding(3)
        Me.tab1min.Size = New System.Drawing.Size(670, 661)
        Me.tab1min.TabIndex = 0
        Me.tab1min.Text = "1 min"
        Me.tab1min.UseVisualStyleBackColor = True
        '
        'wb1
        '
        Me.wb1.Location = New System.Drawing.Point(3, 11)
        Me.wb1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wb1.Name = "wb1"
        Me.wb1.ScriptErrorsSuppressed = True
        Me.wb1.Size = New System.Drawing.Size(661, 638)
        Me.wb1.TabIndex = 1
        Me.wb1.Url = New System.Uri("", System.UriKind.Relative)
        '
        'tab10min
        '
        Me.tab10min.Controls.Add(Me.wb2)
        Me.tab10min.Location = New System.Drawing.Point(4, 22)
        Me.tab10min.Name = "tab10min"
        Me.tab10min.Size = New System.Drawing.Size(670, 661)
        Me.tab10min.TabIndex = 3
        Me.tab10min.Text = "10 min"
        Me.tab10min.UseVisualStyleBackColor = True
        '
        'wb2
        '
        Me.wb2.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.wb2.Location = New System.Drawing.Point(0, 0)
        Me.wb2.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wb2.Name = "wb2"
        Me.wb2.Size = New System.Drawing.Size(657, 836)
        Me.wb2.TabIndex = 0
        Me.wb2.Url = New System.Uri("", System.UriKind.Relative)
        '
        'tab15min
        '
        Me.tab15min.Location = New System.Drawing.Point(4, 22)
        Me.tab15min.Name = "tab15min"
        Me.tab15min.Padding = New System.Windows.Forms.Padding(3)
        Me.tab15min.Size = New System.Drawing.Size(670, 661)
        Me.tab15min.TabIndex = 2
        Me.tab15min.Text = "15 min"
        Me.tab15min.UseVisualStyleBackColor = True
        '
        'tab1hr
        '
        Me.tab1hr.Location = New System.Drawing.Point(4, 22)
        Me.tab1hr.Name = "tab1hr"
        Me.tab1hr.Size = New System.Drawing.Size(670, 661)
        Me.tab1hr.TabIndex = 4
        Me.tab1hr.Text = "1 HR"
        Me.tab1hr.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Location = New System.Drawing.Point(569, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(57, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "&Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmbMarket
        '
        Me.cmbMarket.FormattingEnabled = True
        Me.cmbMarket.Items.AddRange(New Object() {"TSX", "TSXV", "NYSE"})
        Me.cmbMarket.Location = New System.Drawing.Point(263, 0)
        Me.cmbMarket.Name = "cmbMarket"
        Me.cmbMarket.Size = New System.Drawing.Size(54, 21)
        Me.cmbMarket.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(202, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Exchange"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(660, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(57, 23)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtLog
        '
        Me.txtLog.Location = New System.Drawing.Point(820, 1)
        Me.txtLog.Name = "txtLog"
        Me.txtLog.Size = New System.Drawing.Size(309, 20)
        Me.txtLog.TabIndex = 13
        Me.txtLog.Text = "320"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(732, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(57, 23)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'lblm
        '
        Me.lblm.AutoSize = True
        Me.lblm.Location = New System.Drawing.Point(395, 15)
        Me.lblm.Name = "lblm"
        Me.lblm.Size = New System.Drawing.Size(55, 13)
        Me.lblm.TabIndex = 15
        Me.lblm.Text = "Exchange"
        '
        'TM
        '
        Me.TM.Controls.Add(Me.TabPage9)
        Me.TM.Controls.Add(Me.TabPage10)
        Me.TM.Controls.Add(Me.TabPage11)
        Me.TM.Controls.Add(Me.TabPage12)
        Me.TM.Location = New System.Drawing.Point(1, 723)
        Me.TM.Name = "TM"
        Me.TM.SelectedIndex = 0
        Me.TM.Size = New System.Drawing.Size(1609, 160)
        Me.TM.TabIndex = 16
        '
        'TabPage9
        '
        Me.TabPage9.Controls.Add(Me.wbm)
        Me.TabPage9.Location = New System.Drawing.Point(4, 22)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage9.Size = New System.Drawing.Size(1601, 134)
        Me.TabPage9.TabIndex = 0
        Me.TabPage9.Text = "1 min"
        Me.TabPage9.UseVisualStyleBackColor = True
        '
        'wbm
        '
        Me.wbm.Location = New System.Drawing.Point(7, 9)
        Me.wbm.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbm.Name = "wbm"
        Me.wbm.ScriptErrorsSuppressed = True
        Me.wbm.Size = New System.Drawing.Size(1588, 119)
        Me.wbm.TabIndex = 1
        Me.wbm.Url = New System.Uri("", System.UriKind.Relative)
        '
        'TabPage10
        '
        Me.TabPage10.Controls.Add(Me.WebBrowser2)
        Me.TabPage10.Location = New System.Drawing.Point(4, 22)
        Me.TabPage10.Name = "TabPage10"
        Me.TabPage10.Size = New System.Drawing.Size(1246, 134)
        Me.TabPage10.TabIndex = 3
        Me.TabPage10.Text = "10 min"
        Me.TabPage10.UseVisualStyleBackColor = True
        '
        'WebBrowser2
        '
        Me.WebBrowser2.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar
        Me.WebBrowser2.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser2.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser2.Name = "WebBrowser2"
        Me.WebBrowser2.Size = New System.Drawing.Size(657, 836)
        Me.WebBrowser2.TabIndex = 0
        Me.WebBrowser2.Url = New System.Uri("", System.UriKind.Relative)
        '
        'TabPage11
        '
        Me.TabPage11.Location = New System.Drawing.Point(4, 22)
        Me.TabPage11.Name = "TabPage11"
        Me.TabPage11.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage11.Size = New System.Drawing.Size(1246, 134)
        Me.TabPage11.TabIndex = 2
        Me.TabPage11.Text = "15 min"
        Me.TabPage11.UseVisualStyleBackColor = True
        '
        'TabPage12
        '
        Me.TabPage12.Location = New System.Drawing.Point(4, 22)
        Me.TabPage12.Name = "TabPage12"
        Me.TabPage12.Size = New System.Drawing.Size(1246, 134)
        Me.TabPage12.TabIndex = 4
        Me.TabPage12.Text = "1 HR"
        Me.TabPage12.UseVisualStyleBackColor = True
        '
        'frmMonitor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Button1
        Me.ClientSize = New System.Drawing.Size(1855, 927)
        Me.Controls.Add(Me.TM)
        Me.Controls.Add(Me.lblm)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtLog)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbMarket)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.p)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.txtSymbol)
        Me.Name = "frmMonitor"
        Me.ShowIcon = False
        Me.Text = "Monitor"
        Me.p.ResumeLayout(False)
        Me.T15.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.T5.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.T1.ResumeLayout(False)
        Me.tab1min.ResumeLayout(False)
        Me.tab10min.ResumeLayout(False)
        Me.TM.ResumeLayout(False)
        Me.TabPage9.ResumeLayout(False)
        Me.TabPage10.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSymbol As System.Windows.Forms.TextBox
    Friend WithEvents btnGo As System.Windows.Forms.Button
    Friend WithEvents lbl As System.Windows.Forms.Label
    Friend WithEvents p As System.Windows.Forms.Panel
    Friend WithEvents T1 As System.Windows.Forms.TabControl
    Friend WithEvents tab1min As System.Windows.Forms.TabPage
    Friend WithEvents tab10min As System.Windows.Forms.TabPage
    Friend WithEvents wb2 As System.Windows.Forms.WebBrowser
    Friend WithEvents tab15min As System.Windows.Forms.TabPage
    Friend WithEvents tab1hr As System.Windows.Forms.TabPage
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmbMarket As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents T15 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents wb15 As System.Windows.Forms.WebBrowser
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage8 As System.Windows.Forms.TabPage
    Friend WithEvents T5 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents wb5 As System.Windows.Forms.WebBrowser
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtLog As System.Windows.Forms.TextBox
    Friend WithEvents wb1 As System.Windows.Forms.WebBrowser
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents lblm As System.Windows.Forms.Label
    Friend WithEvents TM As System.Windows.Forms.TabControl
    Friend WithEvents TabPage9 As System.Windows.Forms.TabPage
    Friend WithEvents wbm As System.Windows.Forms.WebBrowser
    Friend WithEvents TabPage10 As System.Windows.Forms.TabPage
    Friend WithEvents WebBrowser2 As System.Windows.Forms.WebBrowser
    Friend WithEvents TabPage11 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage12 As System.Windows.Forms.TabPage

End Class
