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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblSectionA = New System.Windows.Forms.Label()
        Me.txtBoxId = New System.Windows.Forms.TextBox()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblEXEVersion = New System.Windows.Forms.Label()
        Me.lblLinxLibVersion = New System.Windows.Forms.Label()
        Me.cmdAlarm = New System.Windows.Forms.Button()
        Me.lblSectionB = New System.Windows.Forms.Label()
        Me.lblSectionC = New System.Windows.Forms.Label()
        Me.lblSectionD = New System.Windows.Forms.Label()
        Me.lblSectionE = New System.Windows.Forms.Label()
        Me.cmdPort = New System.Windows.Forms.Button()
        Me.cmdBeep = New System.Windows.Forms.Button()
        Me.lblSectionF = New System.Windows.Forms.Label()
        Me.pnlTest = New System.Windows.Forms.Panel()
        Me.txtRed = New System.Windows.Forms.TextBox()
        Me.txtOrange = New System.Windows.Forms.TextBox()
        Me.txtGreen = New System.Windows.Forms.TextBox()
        Me.lblMDAQ = New System.Windows.Forms.Label()
        Me.btnMDAQ_test = New System.Windows.Forms.Button()
        Me.pnlTest.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(954, 471)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(120, 50)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblSectionA
        '
        Me.lblSectionA.AutoSize = True
        Me.lblSectionA.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSectionA.Location = New System.Drawing.Point(9, 64)
        Me.lblSectionA.Name = "lblSectionA"
        Me.lblSectionA.Size = New System.Drawing.Size(523, 108)
        Me.lblSectionA.TabIndex = 1
        Me.lblSectionA.Text = "lblSectionA"
        Me.lblSectionA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtBoxId
        '
        Me.txtBoxId.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxId.Location = New System.Drawing.Point(15, 12)
        Me.txtBoxId.Name = "txtBoxId"
        Me.txtBoxId.Size = New System.Drawing.Size(775, 49)
        Me.txtBoxId.TabIndex = 3
        '
        'btnLoad
        '
        Me.btnLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad.Location = New System.Drawing.Point(800, 471)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(120, 50)
        Me.btnLoad.TabIndex = 5
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'lblEXEVersion
        '
        Me.lblEXEVersion.AutoSize = True
        Me.lblEXEVersion.Location = New System.Drawing.Point(12, 510)
        Me.lblEXEVersion.Name = "lblEXEVersion"
        Me.lblEXEVersion.Size = New System.Drawing.Size(28, 13)
        Me.lblEXEVersion.TabIndex = 17
        Me.lblEXEVersion.Text = "v1.0"
        '
        'lblLinxLibVersion
        '
        Me.lblLinxLibVersion.AutoSize = True
        Me.lblLinxLibVersion.Location = New System.Drawing.Point(59, 510)
        Me.lblLinxLibVersion.Name = "lblLinxLibVersion"
        Me.lblLinxLibVersion.Size = New System.Drawing.Size(28, 13)
        Me.lblLinxLibVersion.TabIndex = 18
        Me.lblLinxLibVersion.Text = "v1.0"
        '
        'cmdAlarm
        '
        Me.cmdAlarm.Location = New System.Drawing.Point(12, 472)
        Me.cmdAlarm.Name = "cmdAlarm"
        Me.cmdAlarm.Size = New System.Drawing.Size(75, 32)
        Me.cmdAlarm.TabIndex = 83
        Me.cmdAlarm.Text = "Reject"
        Me.cmdAlarm.UseVisualStyleBackColor = True
        '
        'lblSectionB
        '
        Me.lblSectionB.AutoSize = True
        Me.lblSectionB.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSectionB.Location = New System.Drawing.Point(529, 64)
        Me.lblSectionB.Name = "lblSectionB"
        Me.lblSectionB.Size = New System.Drawing.Size(523, 108)
        Me.lblSectionB.TabIndex = 84
        Me.lblSectionB.Text = "lblSectionB"
        Me.lblSectionB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSectionC
        '
        Me.lblSectionC.AutoSize = True
        Me.lblSectionC.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSectionC.Location = New System.Drawing.Point(652, 342)
        Me.lblSectionC.Name = "lblSectionC"
        Me.lblSectionC.Size = New System.Drawing.Size(266, 55)
        Me.lblSectionC.TabIndex = 85
        Me.lblSectionC.Text = "lblSectionC"
        '
        'lblSectionD
        '
        Me.lblSectionD.AutoSize = True
        Me.lblSectionD.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSectionD.Location = New System.Drawing.Point(18, 342)
        Me.lblSectionD.Name = "lblSectionD"
        Me.lblSectionD.Size = New System.Drawing.Size(266, 55)
        Me.lblSectionD.TabIndex = 86
        Me.lblSectionD.Text = "lblSectionD"
        '
        'lblSectionE
        '
        Me.lblSectionE.AutoSize = True
        Me.lblSectionE.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSectionE.Location = New System.Drawing.Point(796, 6)
        Me.lblSectionE.Name = "lblSectionE"
        Me.lblSectionE.Size = New System.Drawing.Size(263, 55)
        Me.lblSectionE.TabIndex = 87
        Me.lblSectionE.Text = "lblSectionE"
        '
        'cmdPort
        '
        Me.cmdPort.Location = New System.Drawing.Point(93, 472)
        Me.cmdPort.Name = "cmdPort"
        Me.cmdPort.Size = New System.Drawing.Size(75, 32)
        Me.cmdPort.TabIndex = 88
        Me.cmdPort.Text = "Accept"
        Me.cmdPort.UseVisualStyleBackColor = True
        '
        'cmdBeep
        '
        Me.cmdBeep.Location = New System.Drawing.Point(174, 472)
        Me.cmdBeep.Name = "cmdBeep"
        Me.cmdBeep.Size = New System.Drawing.Size(75, 32)
        Me.cmdBeep.TabIndex = 89
        Me.cmdBeep.Text = "Beep"
        Me.cmdBeep.UseVisualStyleBackColor = True
        '
        'lblSectionF
        '
        Me.lblSectionF.AutoSize = True
        Me.lblSectionF.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSectionF.Location = New System.Drawing.Point(9, 193)
        Me.lblSectionF.Name = "lblSectionF"
        Me.lblSectionF.Size = New System.Drawing.Size(518, 108)
        Me.lblSectionF.TabIndex = 90
        Me.lblSectionF.Text = "lblSectionF"
        '
        'pnlTest
        '
        Me.pnlTest.Controls.Add(Me.txtRed)
        Me.pnlTest.Controls.Add(Me.txtOrange)
        Me.pnlTest.Controls.Add(Me.txtGreen)
        Me.pnlTest.Controls.Add(Me.lblMDAQ)
        Me.pnlTest.Controls.Add(Me.btnMDAQ_test)
        Me.pnlTest.Location = New System.Drawing.Point(492, 471)
        Me.pnlTest.Name = "pnlTest"
        Me.pnlTest.Size = New System.Drawing.Size(203, 39)
        Me.pnlTest.TabIndex = 91
        '
        'txtRed
        '
        Me.txtRed.BackColor = System.Drawing.Color.Red
        Me.txtRed.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRed.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtRed.Location = New System.Drawing.Point(145, 11)
        Me.txtRed.Name = "txtRed"
        Me.txtRed.Size = New System.Drawing.Size(10, 20)
        Me.txtRed.TabIndex = 86
        '
        'txtOrange
        '
        Me.txtOrange.BackColor = System.Drawing.Color.DarkOrange
        Me.txtOrange.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrange.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtOrange.Location = New System.Drawing.Point(163, 11)
        Me.txtOrange.Name = "txtOrange"
        Me.txtOrange.Size = New System.Drawing.Size(10, 20)
        Me.txtOrange.TabIndex = 85
        '
        'txtGreen
        '
        Me.txtGreen.BackColor = System.Drawing.Color.Lime
        Me.txtGreen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGreen.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtGreen.Location = New System.Drawing.Point(181, 11)
        Me.txtGreen.Name = "txtGreen"
        Me.txtGreen.Size = New System.Drawing.Size(10, 20)
        Me.txtGreen.TabIndex = 84
        '
        'lblMDAQ
        '
        Me.lblMDAQ.AutoSize = True
        Me.lblMDAQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMDAQ.Location = New System.Drawing.Point(57, 12)
        Me.lblMDAQ.Name = "lblMDAQ"
        Me.lblMDAQ.Size = New System.Drawing.Size(43, 15)
        Me.lblMDAQ.TabIndex = 83
        Me.lblMDAQ.Text = "MDAQ"
        '
        'btnMDAQ_test
        '
        Me.btnMDAQ_test.Location = New System.Drawing.Point(3, 4)
        Me.btnMDAQ_test.Name = "btnMDAQ_test"
        Me.btnMDAQ_test.Size = New System.Drawing.Size(48, 32)
        Me.btnMDAQ_test.TabIndex = 79
        Me.btnMDAQ_test.Text = "Test"
        Me.btnMDAQ_test.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1096, 532)
        Me.Controls.Add(Me.pnlTest)
        Me.Controls.Add(Me.lblSectionF)
        Me.Controls.Add(Me.cmdBeep)
        Me.Controls.Add(Me.cmdPort)
        Me.Controls.Add(Me.lblSectionE)
        Me.Controls.Add(Me.lblSectionD)
        Me.Controls.Add(Me.lblSectionC)
        Me.Controls.Add(Me.lblSectionB)
        Me.Controls.Add(Me.cmdAlarm)
        Me.Controls.Add(Me.lblLinxLibVersion)
        Me.Controls.Add(Me.lblEXEVersion)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.txtBoxId)
        Me.Controls.Add(Me.lblSectionA)
        Me.Controls.Add(Me.btnExit)
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.Text = "PROD047"
        Me.pnlTest.ResumeLayout(False)
        Me.pnlTest.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents lblSectionA As Label
    Friend WithEvents txtBoxId As TextBox
    Friend WithEvents btnLoad As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblEXEVersion As Label
    Friend WithEvents lblLinxLibVersion As Label
    Friend WithEvents cmdAlarm As Button
    Friend WithEvents lblSectionB As Label
    Friend WithEvents lblSectionC As Label
    Friend WithEvents lblSectionD As Label
    Friend WithEvents lblSectionE As Label
    Friend WithEvents cmdPort As Button
    Friend WithEvents cmdBeep As Button
    Friend WithEvents lblSectionF As Label
    Friend WithEvents pnlTest As Panel
    Friend WithEvents txtRed As TextBox
    Friend WithEvents txtOrange As TextBox
    Friend WithEvents txtGreen As TextBox
    Friend WithEvents lblMDAQ As Label
    Friend WithEvents btnMDAQ_test As Button
End Class
