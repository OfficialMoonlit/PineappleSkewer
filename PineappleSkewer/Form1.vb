Imports NativeWifi

Public Class frmMain

    Dim pineapplePresent As Boolean

    Private Sub cmdScan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdScan.Click
        If tmrScan.Enabled Then
            tmrScan.Enabled = False
            lblStatusText.Text = "Idle"
            cmdScan.Text = "Start Scan"
            Me.Text = "Pineapple Skewer"
            imgStatus.BackColor = Color.White
        Else
            tmrScan.Enabled = True
            lblStatusText.Text = "Scanning..."
            cmdScan.Text = "Stop Scan"
        End If

    End Sub


    Private Sub cmdProfiles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdProfileAdd.Click

    End Sub

    Private Sub tmrScan_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrScan.Tick
        Dim wifiMAC As String = ""
        Dim wifiSSID As String = ""
        Dim wifiSSIDColon As Integer
        Dim wifiMACColon As Integer
        Dim wifiAPCount As Integer = 0



        lstMAC.Items.Clear()
        lstSSID.Items.Clear()

        Dim netshRunProcess As New Process()
        Dim netshProcess As New ProcessStartInfo()
        netshProcess.FileName = "cmd.exe"
        netshProcess.UseShellExecute = False
        netshProcess.CreateNoWindow = True
        netshProcess.Arguments = "/c netsh wlan show networks mode=bssid"
        netshProcess.RedirectStandardOutput = True
        netshRunProcess.EnableRaisingEvents = True
        netshRunProcess.StartInfo = netshProcess
        netshRunProcess.Start()
        Dim output As String
        Dim readerStdOut As IO.StreamReader = netshRunProcess.StandardOutput
        Do While readerStdOut.EndOfStream = False
            output = readerStdOut.ReadLine()
            If InStr(output, "BSSID ") Then
                wifiMAC = Strings.Replace(output, " ", "")
                wifiMACColon = Strings.InStr(wifiMAC, ":")
                wifiMAC = Strings.Right(wifiMAC, Len(wifiMAC) - wifiMACColon)
                lstMAC.Items.Add(wifiMAC)
            ElseIf InStr(output, "SSID ") Then
                wifiSSID = output 'Strings.Replace(output, " ", "")
                wifiSSIDColon = Strings.InStr(wifiSSID, ":")
                wifiSSID = Strings.Trim(Strings.Right(wifiSSID, Len(wifiSSID) - wifiSSIDColon))
                lstSSID.Items.Add(wifiSSID)
                If Strings.InStr(wifiSSID, "Pineapple Skewer AP") Then
                    wifiAPCount = wifiAPCount + 1
                End If
            End If
        Loop

        If wifiAPCount > 0 Then
            imgStatus.BackColor = Color.Red
            Me.Text = "Pineapple Skewer: Warning: Vegetarians present!"
            cmdTray.BalloonTipTitle = "Warning:"
            cmdTray.BalloonTipText = "Vegetarians present! Your connection may be unsafe!"
            If pineapplePresent = False Then cmdTray.ShowBalloonTip(15000)
            pineapplePresent = True
        Else
            imgStatus.BackColor = Color.Green
            Me.Text = "Pineapple Skewer: Carnivores only."
            pineapplePresent = False
            'cmdTray.BalloonTipTitle = "Notice:"
            'cmdTray.BalloonTipText = "The coast is clear, it's carnivores only..."
            'cmdTray.ShowBalloonTip(15000)
        End If

    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        For profileNumber = 0 To 2
            Shell("netsh wlan delete profile name=" & Chr(34) & "Pineapple Skewer AP " & profileNumber & Chr(34))
        Next
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For profileNumber = 0 To 2

            Dim nextFile As Integer = FreeFile()

            Dim wifiSSIDName As String = "Pineapple Skewer AP " & profileNumber
            Dim wifiSSIDHex As String = ""

            For stringPos = 1 To Len(wifiSSIDName)
                wifiSSIDHex = wifiSSIDHex & Hex(AscW(Strings.GetChar(wifiSSIDName, stringPos)))
            Next

            FileSystem.FileOpen(nextFile, ".\testprofile" & profileNumber & ".xml", OpenMode.Output)
            PrintLine(nextFile, "<?xml version=" & Chr(34) & "1.0" & Chr(34) & "?>")
            PrintLine(nextFile, "<WLANProfile xmlns=" & Chr(34) & "http://www.microsoft.com/networking/WLAN/profile/v1" & Chr(34) & ">")
            PrintLine(nextFile, "	<name>" & wifiSSIDName & "</name>")
            PrintLine(nextFile, "	<SSIDConfig>")
            PrintLine(nextFile, "		<SSID>")
            PrintLine(nextFile, "			<hex>" & wifiSSIDHex & "</hex>")
            PrintLine(nextFile, "			<name>" & wifiSSIDName & "</name>")
            PrintLine(nextFile, "		</SSID>")
            PrintLine(nextFile, "		<nonBroadcast>true</nonBroadcast>")
            PrintLine(nextFile, "	</SSIDConfig>")
            PrintLine(nextFile, "	<connectionType>ESS</connectionType>")
            PrintLine(nextFile, "	<connectionMode>manual</connectionMode>")
            PrintLine(nextFile, "	<MSM>")
            PrintLine(nextFile, "		<security>")
            PrintLine(nextFile, "			<authEncryption>")
            PrintLine(nextFile, "				<authentication>open</authentication>")
            PrintLine(nextFile, "				<encryption>none</encryption>")
            PrintLine(nextFile, "				<useOneX>false</useOneX>")
            PrintLine(nextFile, "			</authEncryption>")
            'PrintLine(nextFile, "			<sharedKey>")
            'PrintLine(nextFile, "				<keyType>passPhrase</keyType>")
            'PrintLine(nextFile, "				<protected>true</protected>")
            'PrintLine(nextFile, "				<keyMaterial>00000000</keyMaterial>")
            'PrintLine(nextFile, "			</sharedKey>")
            PrintLine(nextFile, "		</security>")
            PrintLine(nextFile, "	</MSM>")
            PrintLine(nextFile, "</WLANProfile>")
            PrintLine(nextFile, "")
            PrintLine(nextFile, "")
            FileSystem.FileClose(nextFile)

            Shell("netsh wlan add profile filename=" & Chr(34) & ".\testprofile" & profileNumber & ".xml" & Chr(34) & " user=all")

        Next

        cmdTray.Icon = Me.Icon
        'Me.Show()
        'Me.Hide()

    End Sub

    Private Sub cmdTray_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmdTray.MouseDoubleClick
        'Me.Show()
    End Sub

    Private Sub mnuExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        For profileNumber = 0 To 2
            Shell("netsh wlan delete profile name=" & Chr(34) & "Pineapple Skewer AP " & profileNumber & Chr(34))
        Next
        End
    End Sub
End Class
