Imports Microsoft.Win32


Public Class frmMain

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Dim S1 As frmMonitor
        S1 = New frmMonitor
        S1.symbol = txt1.Text
        S1.Show()
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Dim S2 As frmMonitor
        S2 = New frmMonitor
        S2.symbol = txt2.Text
        S2.Show()
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        Dim S3 As frmMonitor
        S3 = New frmMonitor
        S3.symbol = txt3.Text
        S3.Show()
    End Sub


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Private Declare Function SetEnvironmentVariable Lib "kernel32" Alias "SetEnvironmentVariableA" (ByVal lpName As String, ByVal lpValue As String) As Long

        'SetEnvironmentVariable("JAVA_PLUGIN_WEBCONTROL_ENABLE", "TRUE")
        'End Sub
    End Sub





#Region "IE Fix"
    Private Shared Sub SetBrowserFeatureControlKey(feature As String, appName As String, value As UInteger)
        If Environment.Is64BitOperatingSystem Then

            Using key = Registry.LocalMachine.CreateSubKey([String].Concat("Software\Wow6432Node\Microsoft\Internet Explorer\Main\FeatureControl\", feature), RegistryKeyPermissionCheck.ReadWriteSubTree)
                key.SetValue(appName, DirectCast(value, UInt32), RegistryValueKind.DWord)

            End Using
        End If


        Using key = Registry.CurrentUser.CreateSubKey([String].Concat("Software\Microsoft\Internet Explorer\Main\FeatureControl\", feature), RegistryKeyPermissionCheck.ReadWriteSubTree)
            key.SetValue(appName, DirectCast(value, UInt32), RegistryValueKind.DWord)
        End Using
    End Sub

    Private Sub SetBrowserFeatureControl()
        ' http://msdn.microsoft.com/en-us/library/ee330720(v=vs.85).aspx

        ' FeatureControl settings are per-process
        Dim fileName = System.IO.Path.GetFileName(Process.GetCurrentProcess().MainModule.FileName)

        ' make the control is not running inside Visual Studio Designer
        If [String].Compare(fileName, "devenv.exe", True) = 0 OrElse [String].Compare(fileName, "XDesProc.exe", True) = 0 Then
            Return
        End If

        SetBrowserFeatureControlKey("FEATURE_BROWSER_EMULATION", fileName, GetBrowserEmulationMode())
        ' Webpages containing standards-based !DOCTYPE directives are displayed in IE10 Standards mode.
        SetBrowserFeatureControlKey("FEATURE_AJAX_CONNECTIONEVENTS", fileName, 1)
        SetBrowserFeatureControlKey("FEATURE_ENABLE_CLIPCHILDREN_OPTIMIZATION", fileName, 1)
        SetBrowserFeatureControlKey("FEATURE_MANAGE_SCRIPT_CIRCULAR_REFS", fileName, 1)
        SetBrowserFeatureControlKey("FEATURE_DOMSTORAGE ", fileName, 1)
        SetBrowserFeatureControlKey("FEATURE_GPU_RENDERING ", fileName, 1)
        SetBrowserFeatureControlKey("FEATURE_IVIEWOBJECTDRAW_DMLT9_WITH_GDI  ", fileName, 0)
        SetBrowserFeatureControlKey("FEATURE_DISABLE_LEGACY_COMPRESSION", fileName, 1)
        SetBrowserFeatureControlKey("FEATURE_LOCALMACHINE_LOCKDOWN", fileName, 0)
        SetBrowserFeatureControlKey("FEATURE_BLOCK_LMZ_OBJECT", fileName, 0)
        SetBrowserFeatureControlKey("FEATURE_BLOCK_LMZ_SCRIPT", fileName, 0)
        SetBrowserFeatureControlKey("FEATURE_DISABLE_NAVIGATION_SOUNDS", fileName, 1)
        SetBrowserFeatureControlKey("FEATURE_SCRIPTURL_MITIGATION", fileName, 1)
        SetBrowserFeatureControlKey("FEATURE_SPELLCHECKING", fileName, 0)
        SetBrowserFeatureControlKey("FEATURE_STATUS_BAR_THROTTLING", fileName, 1)
        SetBrowserFeatureControlKey("FEATURE_TABBED_BROWSING", fileName, 1)
        SetBrowserFeatureControlKey("FEATURE_VALIDATE_NAVIGATE_URL", fileName, 1)
        SetBrowserFeatureControlKey("FEATURE_WEBOC_DOCUMENT_ZOOM", fileName, 1)
        SetBrowserFeatureControlKey("FEATURE_WEBOC_POPUPMANAGEMENT", fileName, 0)
        SetBrowserFeatureControlKey("FEATURE_WEBOC_MOVESIZECHILD", fileName, 1)
        SetBrowserFeatureControlKey("FEATURE_ADDON_MANAGEMENT", fileName, 0)
        SetBrowserFeatureControlKey("FEATURE_WEBSOCKET", fileName, 1)
        SetBrowserFeatureControlKey("FEATURE_WINDOW_RESTRICTIONS ", fileName, 0)
        SetBrowserFeatureControlKey("FEATURE_XMLHTTP", fileName, 1)
    End Sub

    Private Function GetBrowserEmulationMode() As UInt32
        Dim browserVersion As Integer = 7
        Using ieKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Internet Explorer", RegistryKeyPermissionCheck.ReadSubTree, System.Security.AccessControl.RegistryRights.QueryValues)
            Dim version = ieKey.GetValue("svcVersion")
            If Nothing = version Then
                version = ieKey.GetValue("Version")
                If Nothing = version Then
                    Throw New ApplicationException("Microsoft Internet Explorer is required!")
                End If
            End If
            Integer.TryParse(version.ToString().Split("."c)(0), browserVersion)
        End Using

        Dim mode As UInt32 = 10000
        ' Internet Explorer 10. Webpages containing standards-based !DOCTYPE directives are displayed in IE10 Standards mode. Default value for Internet Explorer 10.
        Select Case browserVersion
            Case 7
                mode = 7000
                ' Webpages containing standards-based !DOCTYPE directives are displayed in IE7 Standards mode. Default value for applications hosting the WebBrowser Control.
                Exit Select
            Case 8
                mode = 8000
                ' Webpages containing standards-based !DOCTYPE directives are displayed in IE8 mode. Default value for Internet Explorer 8
                Exit Select
            Case 9
                mode = 9000
                ' Internet Explorer 9. Webpages containing standards-based !DOCTYPE directives are displayed in IE9 mode. Default value for Internet Explorer 9.
                Exit Select
            Case 10
                mode = 10000
                ' Internet Explorer 10. Webpages containing standards-based !DOCTYPE directives are displayed in IE9 mode. Default value for Internet Explorer 9.
                Exit Select
            Case 11
                mode = 11001
                ' Internet Explorer 11. Webpages containing standards-based !DOCTYPE directives are displayed in IE9 mode. Default value for Internet Explorer 9.
                Exit Select
            Case Else
                ' use IE10 mode by default
                Exit Select
        End Select

        Return mode
    End Function




#End Region





End Class