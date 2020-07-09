Imports LinxLib.DataLib
Imports LinxLib.CommonLib
Imports LinxLib.LinxmasterLib
Imports System.Configuration

Public Class frmMain

    Private TextBoxOrder As New Dictionary(Of TextBox, TextBox)()

    Public sExeVersion As String = "1.2"

    Dim xMDAQ As New MDaqClass
    Dim xBoxRecord As New BoxRecordClass

    Dim bTimerFlag As Boolean

    Public Structure FluidJobData
        Public sUnique_id As String
        Public sBatchnumber As String
        Public sProduct As String
        Public sLang_option As String
        Public sCustomer As String
        Public sCustomer_name As String
        Public sScanned_ok As Integer
        Public sBoxes_remaining As Integer
        Public sScanned_not_ok As Integer
        Public sOrder_qty As Integer
        Public sCounter As Integer
    End Structure

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        xMDAQ.InitialiseMDAQ()

        If xMDAQ.GetMDAQon() Then
            lblMDAQ.Text = "MDAQ ON"
            exportDigital(0)
            txtGreen.Visible = True
            txtOrange.Visible = True
            txtRed.Visible = True
            btnMDAQ_test.Visible = True
        Else
            lblMDAQ.Text = "MDAQ OFF"
            txtGreen.Visible = False
            txtOrange.Visible = False
            txtRed.Visible = False
            btnMDAQ_test.Visible = False
        End If

        txtBoxId.Tag = 1
        btnLoad.Tag = 3

        AddHandler txtBoxId.KeyDown, AddressOf BarcodeInputKeyDown

        lblEXEVersion.Text = "Exe:" & sExeVersion
        lblLinxLibVersion.Text = "Lib:" & sLinxLibVersion
        lblSectionE.Text = "Ready"

        Dim sTest As String = "0"
        If ConfigurationManager.AppSettings("MDAQTest") = "1" Then
            pnlTest.Visible = True
        Else
            pnlTest.Visible = False
        End If

        txtBoxId.Select()

    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        txtBoxId.Select()
    End Sub


    Private Sub BarcodeInputKeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter AndAlso ActiveControl.[GetType]() = GetType(TextBox) Then
            e.Handled = True
            e.SuppressKeyPress = True
            Load_Click()
        End If
    End Sub

    Private Sub BarcodeInputLeave(sender As Object, e As EventArgs)
        If sender.[GetType]() = GetType(TextBox) Then
            Dim textBox As TextBox = DirectCast(sender, TextBox)
            If textBox.Tag.[GetType]() = GetType(Integer) Then
                BarcodeScanned(textBox.Text, CInt(textBox.Tag))
            End If
        End If
    End Sub


    Private Sub BarcodeScanned(barcode As String, order As Integer)

        txtBoxId.Text = Convert.ToString(order.ToString() + ": ") & barcode

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        End

    End Sub

    Private Sub Load_Click()

        Dim xBindingsource As BindingSource = Nothing

        xBoxRecord.ClearBoxRecord()
        xBoxRecord.SetBoxId = txtBoxId.Text
        xBoxRecord.LoadBoxIdLike()

        Try

            If Trim(xBoxRecord.GetBatchNumber) <> "" Then
                txtBoxId.BackColor = Color.Orange
                WaitHere(10)

                If xBoxRecord.GetBoxStatus = "M" Or xBoxRecord.GetBoxStatus = "B" Then  ' Manufactured or BatchSpares
                    lblSectionE.Text = "Accept"
                    txtBoxId.BackColor = Color.LimeGreen
                    xBoxRecord.Update_Box_Status("S")
                    PortOpen()
                    WaitHere(10)
                    Application.DoEvents()
                    ProcessBoxRecord(xBoxRecord.GetBatchNumber)


                ElseIf xBoxRecord.GetBoxStatus = "S" Then
                    txtBoxId.BackColor = Color.LightSalmon
                    lblSectionE.Text = "Scanned"
                    ProcessBoxRecord(xBoxRecord.GetBatchNumber)
                    BeepAlarm()
                    WaitHere(10)
                    txtBoxId.Text = ""

                Else
                    txtBoxId.BackColor = Color.Red
                    lblSectionE.Text = "Reject:(" & Trim(xBoxRecord.GetBoxStatus) & ")"
                    BeepAlarm()
                    WaitHere(10)
                    TriggerAlarm()
                    WaitHere(10)
                    txtBoxId.Text = ""

                End If

                WaitHere(10)
                lblSectionE.Text = "Ready"

                txtBoxId.Text = ""
                txtBoxId.BackColor = Color.White

            Else
                lblSectionE.Text = "Reject"
                txtBoxId.BackColor = Color.Red
                WaitHere(20)
                TriggerAlarm()
                txtBoxId.Text = ""
                txtBoxId.BackColor = Color.White
                lblSectionE.Text = "Ready"
            End If

        Catch

            MsgBox("Unable to accept scanned input : " & txtBoxId.Text & vbCrLf & "Error: " & Err.Description)

        End Try

        txtBoxId.Select()
        Application.DoEvents()


    End Sub


    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click

        Load_Click()
        txtBoxId.Select()
        Application.DoEvents()

    End Sub


    Private Sub LED_Display(ByVal counter As Integer)

        Dim bStr As String = CStr(xMDAQ.ToBinary(counter))
        bStr = bStr.ToString().PadLeft(3, "0")

        If Mid(bStr, 1, 1) = "0" Then
            txtRed.BackColor = Color.Silver
        Else
            txtRed.BackColor = Color.Red
        End If

        If Mid(bStr, 2, 1) = "0" Then
            txtOrange.BackColor = Color.Silver
        Else
            txtOrange.BackColor = Color.Orange
        End If

        If Mid(bStr, 3, 1) = "0" Then
            txtGreen.BackColor = Color.Silver
        Else
            txtGreen.BackColor = Color.Lime
        End If


    End Sub

    Private Sub exportDigital(ByRef iData As Integer)

        xMDAQ.Send_Digital(iData)
        LED_Display(iData)

    End Sub


    Private Sub WaitHere(ByRef iTenthSeconds As Integer)

        Timer1.Interval = iTenthSeconds * 100
        Timer1.Enabled = True

        Do While Timer1.Enabled
            Application.DoEvents()
        Loop

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Timer1.Enabled = False

    End Sub

    Private Function ProcessBoxRecord(ByRef sBatchnumber As String) As String
        ProcessBoxRecord = ""
        Dim xFluidJobData As FluidJobData
        xFluidJobData = FluidJob_Status(sBatchnumber)
        lblSectionF.Text = xFluidJobData.sProduct
        lblSectionD.Text = xFluidJobData.sCustomer_name
        lblSectionB.Text = "Box " & CStr(xFluidJobData.sScanned_ok) & "/" & CStr(xFluidJobData.sOrder_qty)
        lblSectionC.Text = xFluidJobData.sLang_option
        lblSectionA.Text = xFluidJobData.sUnique_id

    End Function


    Public Function FluidJob_Status(ByRef sBatchnumber As String) As FluidJobData

        Dim tDatafetch(0) As DataIn
        Dim xDataAccess As New DataAccess

        Dim xFluidJobData As New FluidJobData
        FluidJob_Status = Nothing

        Try
            xDataAccess.Initialise()
            xDataAccess.SetScheme = "dbo"
            xDataAccess.SetTableName = "vw_Fluid_Job_list"
            If xDataAccess.GetConnectionErr <> "" Then
                MsgBox(xDataAccess.GetConnectionErr)
                Exit Function
            End If

            xDataAccess.SetDBWhere = "batchnumber = '" & Trim(sBatchnumber) & "'"
            xDataAccess.SetOrder = ""

            ReDim tDatafetch(10)
            tDatafetch(0).ColName = "unique_id"
            tDatafetch(1).ColName = "batchnumber"
            tDatafetch(2).ColName = "product"
            tDatafetch(3).ColName = "lang_option"
            tDatafetch(4).ColName = "customer"
            tDatafetch(5).ColName = "customer_name"
            tDatafetch(6).ColName = "scanned_ok"
            tDatafetch(7).ColName = "boxes_remaining"
            tDatafetch(8).ColName = "scanned_not_ok"
            tDatafetch(9).ColName = "order_qty"
            tDatafetch(10).ColName = "counter"

            Dim oBindingSource As BindingSource
            oBindingSource = xDataAccess.GetRecordsDataByID(tDatafetch)

            If oBindingSource.Count > 1 Then
                With xFluidJobData
                    .sUnique_id = CType(oBindingSource.List(0), DataRowView).Item(0).ToString()
                    .sBatchnumber = CType(oBindingSource.List(0), DataRowView).Item(1).ToString()
                    .sProduct = CType(oBindingSource.List(0), DataRowView).Item(2).ToString()
                    .sLang_option = CType(oBindingSource.List(0), DataRowView).Item(3).ToString()
                    .sCustomer = CType(oBindingSource.List(0), DataRowView).Item(4).ToString()
                    .sCustomer_name = CType(oBindingSource.List(0), DataRowView).Item(5).ToString()
                    .sScanned_ok = CInt(CType(oBindingSource.List(0), DataRowView).Item(6).ToString())
                    .sBoxes_remaining = CInt(CType(oBindingSource.List(0), DataRowView).Item(7).ToString())
                    .sScanned_not_ok = CInt(CType(oBindingSource.List(0), DataRowView).Item(8).ToString())
                    .sOrder_qty = CInt(CType(oBindingSource.List(0), DataRowView).Item(9).ToString())
                    .sCounter = CInt(CType(oBindingSource.List(0), DataRowView).Item(10).ToString())
                End With

            Else
                With xFluidJobData
                    .sUnique_id = ""
                    .sBatchnumber = ""
                    .sProduct = ""
                    .sLang_option = ""
                    .sCustomer = ""
                    .sCustomer_name = ""
                    .sScanned_ok = 0
                    .sBoxes_remaining = 0
                    .sScanned_not_ok = 0
                    .sOrder_qty = 0
                    .sCounter = 0
                End With
                Exit Function

            End If

            Application.DoEvents()

        Catch



        End Try

        xDataAccess.Dispose()

        FluidJob_Status = xFluidJobData


    End Function

    Private Sub cmdAlarm_Click(sender As Object, e As EventArgs) Handles cmdAlarm.Click

        TriggerAlarm()

    End Sub

    Private Sub cmdPort_Click(sender As Object, e As EventArgs) Handles cmdPort.Click

        PortOpen()

    End Sub

    Private Sub cmdBeep_Click(sender As Object, e As EventArgs) Handles cmdBeep.Click

        BeepAlarm()

    End Sub

    Private Sub BeepAlarm()

        If xMDAQ.GetMDAQon() Then
            cmdBeep.BackColor = Color.Red
            exportDigital(11)
            WaitHere(10)
            exportDigital(0)
            cmdBeep.BackColor = frmMain.DefaultBackColor
        End If

    End Sub

    Private Sub TriggerAlarm()

        If xMDAQ.GetMDAQon() Then
            cmdAlarm.BackColor = Color.Red
            exportDigital(12)
            WaitHere(10)
            exportDigital(0)
            cmdAlarm.BackColor = frmMain.DefaultBackColor
        End If

    End Sub

    Private Sub PortOpen()

        If xMDAQ.GetMDAQon() Then
            cmdPort.BackColor = Color.LightGreen
            exportDigital(10)
            WaitHere(10)
            exportDigital(0)
            cmdPort.BackColor = frmMain.DefaultBackColor
        End If

    End Sub

    Private Sub btnMDAQ_test_Click(sender As Object, e As EventArgs) Handles btnMDAQ_test.Click

        If xMDAQ.GetMDAQon() Then

            exportDigital(1)
            WaitHere(10)
            exportDigital(2)
            WaitHere(10)
            exportDigital(3)
            WaitHere(10)
            exportDigital(4)
            WaitHere(10)
            exportDigital(5)
            WaitHere(10)
            exportDigital(6)
            WaitHere(10)
            exportDigital(7)
            WaitHere(10)
            exportDigital(0)

        End If

        txtBoxId.Select()

    End Sub



End Class
