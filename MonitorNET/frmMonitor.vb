Public Class frmMonitor
    Public symbol As String
    Private urlTemplate As String

    Private Sub frmMonitor_Activated(sender As Object, e As EventArgs) Handles Me.Activated

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        urlTemplate = "http://ca.advfn.com/stock-market/<X>/<S>/chart/streaming?mode=html5"
        'urlTemplate = "http://www.google.ca"
        'urlTemplate = ""
        cmbMarket.SelectedIndex = 0

        txtSymbol.Text = symbol
        InitTabs()

    End Sub

    Property _ururlTemplatelT() As String
        Get
            Return urlTemplate
        End Get
        Set(ByVal Value As String)
            urlTemplate = Value
        End Set
    End Property


    Property _symbol() As String
        Get
            Return symbol
        End Get
        Set(ByVal Value As String)
            symbol = Value
        End Set
    End Property

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Dim baseTop As Integer
        Dim widthT As Integer
        Dim W1 As Double
        Dim W5 As Double
        Dim W15 As Double

        ' a 27 34 36 50 60  qp3 

        W1 = 0.5
        W5 = 0.3
        W15 = 0.19

        baseTop = lbl.Top + lbl.Height
        widthT = Me.Width

        p.Top = baseTop + 3
        p.Left = 0
        p.Width = Me.Width
        p.Height = Me.Height - 50 - 300

        T1.Top = p.Top - 20
        T1.Left = p.Left + 2
        T1.Height = p.Height - 20
        T1.Width = widthT * W1

        wb1.Top = p.Top - 30
        wb1.Left = p.Left
        wb1.Height = T1.Height - 30
        wb1.Width = widthT * W1 - 15

        'second panel
        T5.Top = p.Top - 20
        T5.Left = T1.Width + 2
        T5.Height = p.Height - 20
        T5.Width = widthT * W5

        wb5.Top = p.Top - 30
        wb5.Height = T1.Height - 30
        wb5.Width = widthT * W5 - 15

        'third panel
        T15.Top = p.Top - 20
        T15.Left = T1.Width + T5.Width + 4
        T15.Height = p.Height - 20
        T15.Width = widthT * W15 - 2

        wb15.Top = p.Top - 30
        wb15.Height = T1.Height - 30
        wb15.Width = widthT * W15 - 17


        'monitor
        TM.Top = p.Height
        TM.Left = p.Left
        TM.Height = 280
        TM.Width = Me.Width - 50

        wbm.Top = 5
        'wbm.Left = TM.Left + 2
        wbm.Height = 280 - 40
        wbm.Width = Me.Width - 60


        AdjustScreen()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        symbol = txtSymbol.Text
        InitTabs()

    End Sub

    Private Sub wb2_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles wb2.DocumentCompleted

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AdjustScreen()
        'wbMon.Document.Window.ScrollTo(100, 100)
    End Sub
    Private Sub InitTabs()
        initTab(wb1)
        initTab(wb5)
        initTab(wb15)
        initTab(wbm, "http://ca.advfn.com")
    End Sub

    Sub initTab(wb As WebBrowser, Optional newUrl As String = "")
        Dim url As String

        If newUrl = "" Then
            url = Replace(urlTemplate, "<S>", symbol)
            url = Replace(url, "<X>", cmbMarket.Text)
        Else
            url = newUrl
        End If

        wb.ScriptErrorsSuppressed = True
        wb.ScrollBarsEnabled = True
        wb.Url = New Uri(url)


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        wb1.Document.Window.ScrollTo(0, 320)
        wb5.Document.Window.ScrollTo(0, 320)
        wb15.Document.Window.ScrollTo(0, 320)
        wbm.Document.Window.ScrollTo(0, 0)
    End Sub
    Private Sub AdjustScreen()
        Dim MULTI As Double
        MULTI = (320 * 966) / (320 * Me.Height)
        lblm.Text = "" & MULTI
        wb1.Document.Window.ScrollTo(1000, 320 * MULTI)
        wb5.Document.Window.ScrollTo(1000, 320 * MULTI)
        wb15.Document.Window.ScrollTo(1000, 320 * MULTI)
        wbm.Document.Window.ScrollTo(0, 330)
    End Sub

    Private Sub wb1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles wb1.DocumentCompleted
        AdjustScreen()
    End Sub

    Private Sub wbm_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles wbm.DocumentCompleted

    End Sub
End Class
