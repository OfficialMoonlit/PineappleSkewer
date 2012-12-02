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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdProfileAdd = New System.Windows.Forms.Button()
        Me.lstSSID = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.imgStatus = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmdScan = New System.Windows.Forms.Button()
        Me.lstMAC = New System.Windows.Forms.ListBox()
        Me.tmrScan = New System.Windows.Forms.Timer(Me.components)
        Me.lblStatusText = New System.Windows.Forms.Label()
        Me.cmdProfileDel = New System.Windows.Forms.Button()
        Me.cmdTray = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.mnuTray = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnuTray.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(360, 193)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(156, 130)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(345, 266)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Pineapple" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Skewer"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(434, 287)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "1.0"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cmdProfileAdd
        '
        Me.cmdProfileAdd.Location = New System.Drawing.Point(378, 28)
        Me.cmdProfileAdd.Name = "cmdProfileAdd"
        Me.cmdProfileAdd.Size = New System.Drawing.Size(96, 23)
        Me.cmdProfileAdd.TabIndex = 3
        Me.cmdProfileAdd.Text = "Install Profiles"
        Me.cmdProfileAdd.UseVisualStyleBackColor = True
        '
        'lstSSID
        '
        Me.lstSSID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstSSID.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSSID.FormattingEnabled = True
        Me.lstSSID.ItemHeight = 15
        Me.lstSSID.Location = New System.Drawing.Point(12, 30)
        Me.lstSSID.Name = "lstSSID"
        Me.lstSSID.Size = New System.Drawing.Size(192, 257)
        Me.lstSSID.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Scanning SSIDs:"
        '
        'imgStatus
        '
        Me.imgStatus.BackColor = System.Drawing.Color.White
        Me.imgStatus.Location = New System.Drawing.Point(210, 293)
        Me.imgStatus.Name = "imgStatus"
        Me.imgStatus.Size = New System.Drawing.Size(119, 17)
        Me.imgStatus.TabIndex = 7
        Me.imgStatus.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 293)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Status:"
        '
        'cmdScan
        '
        Me.cmdScan.Location = New System.Drawing.Point(378, 164)
        Me.cmdScan.Name = "cmdScan"
        Me.cmdScan.Size = New System.Drawing.Size(96, 23)
        Me.cmdScan.TabIndex = 9
        Me.cmdScan.Text = "Start Scan"
        Me.cmdScan.UseVisualStyleBackColor = True
        '
        'lstMAC
        '
        Me.lstMAC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstMAC.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstMAC.FormattingEnabled = True
        Me.lstMAC.ItemHeight = 15
        Me.lstMAC.Location = New System.Drawing.Point(210, 30)
        Me.lstMAC.Name = "lstMAC"
        Me.lstMAC.Size = New System.Drawing.Size(119, 257)
        Me.lstMAC.TabIndex = 10
        '
        'tmrScan
        '
        Me.tmrScan.Enabled = True
        Me.tmrScan.Interval = 5000
        '
        'lblStatusText
        '
        Me.lblStatusText.AutoSize = True
        Me.lblStatusText.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatusText.Location = New System.Drawing.Point(61, 293)
        Me.lblStatusText.Name = "lblStatusText"
        Me.lblStatusText.Size = New System.Drawing.Size(29, 17)
        Me.lblStatusText.TabIndex = 11
        Me.lblStatusText.Text = "Idle"
        '
        'cmdProfileDel
        '
        Me.cmdProfileDel.Location = New System.Drawing.Point(378, 57)
        Me.cmdProfileDel.Name = "cmdProfileDel"
        Me.cmdProfileDel.Size = New System.Drawing.Size(96, 23)
        Me.cmdProfileDel.TabIndex = 12
        Me.cmdProfileDel.Text = "Uninstall Profiles"
        Me.cmdProfileDel.UseVisualStyleBackColor = True
        '
        'cmdTray
        '
        Me.cmdTray.ContextMenuStrip = Me.mnuTray
        Me.cmdTray.Text = "Pineapple Skewer"
        Me.cmdTray.Visible = True
        '
        'mnuTray
        '
        Me.mnuTray.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExit})
        Me.mnuTray.Name = "mnuTray"
        Me.mnuTray.Size = New System.Drawing.Size(93, 26)
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(152, 22)
        Me.mnuExit.Text = "Exit"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(484, 319)
        Me.Controls.Add(Me.cmdProfileDel)
        Me.Controls.Add(Me.lblStatusText)
        Me.Controls.Add(Me.lstMAC)
        Me.Controls.Add(Me.cmdScan)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.imgStatus)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstSSID)
        Me.Controls.Add(Me.cmdProfileAdd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.ShowInTaskbar = False
        Me.Text = "Pineapple Skewer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnuTray.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdProfileAdd As System.Windows.Forms.Button
    Friend WithEvents lstSSID As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents imgStatus As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmdScan As System.Windows.Forms.Button
    Friend WithEvents lstMAC As System.Windows.Forms.ListBox
    Friend WithEvents tmrScan As System.Windows.Forms.Timer
    Friend WithEvents lblStatusText As System.Windows.Forms.Label
    Friend WithEvents cmdProfileDel As System.Windows.Forms.Button
    Friend WithEvents cmdTray As System.Windows.Forms.NotifyIcon
    Friend WithEvents mnuTray As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem

End Class
