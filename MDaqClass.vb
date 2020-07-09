Public Class MDaqClass

    Private DaqBoard As MccDaq.MccBoard = New MccDaq.MccBoard(0)

    Private bMDAQConnected As Boolean = False



    ' Digital out
    Private PortType As Integer
    Private PortNum As MccDaq.DigitalPortType
    Private NumPorts, NumBits, MaxPortVal As Integer
    Private ProgAbility As Integer

    ' Analogue in
    Private Range As MccDaq.Range
    Private ADResolution, NumAIChans, HighChan As Integer

    Private Direction As MccDaq.DigitalPortDirection


    ReadOnly Property GetMDAQon() As Boolean
        Get
            GetMDAQon = bMDAQConnected
        End Get

    End Property


    Public Sub InitUL()

        Dim ULStat As MccDaq.ErrorInfo

        ULStat = MccDaq.MccService.DeclareRevision(MccDaq.MccService.CurrentRevNum)

        ReportError = MccDaq.ErrorReporting.PrintAll
        HandleError = MccDaq.ErrorHandling.StopAll
        ULStat = MccDaq.MccService.ErrHandling(ReportError, HandleError)
        If ULStat.Value <> MccDaq.ErrorInfo.ErrorCode.NoErrors Then
            Stop
        End If

    End Sub


    Public Sub Send_Digital(ByVal output As Integer)

        Dim ULStat As MccDaq.ErrorInfo
        Dim DataValue As UInt16

        DataValue = Convert.ToUInt16(output)
        ULStat = DaqBoard.DOut(PortNum, DataValue)

        If ULStat.Value <> MccDaq.ErrorInfo.ErrorCode.NoErrors Then
            Stop
        End If



    End Sub

    Public Function ToBinary(dec As Integer) As String
        Dim bin As Integer
        Dim output As String = ""
        While dec <> 0
            If dec Mod 2 = 0 Then
                bin = 0
            Else
                bin = 1
            End If
            dec = dec \ 2
            output = Convert.ToString(bin) & output
        End While
        If output Is Nothing Then
            Return "0"
        Else
            Return output
        End If
    End Function

    Public Sub InitialiseMDAQ()

        Dim PortName As String
        Dim FirstBit As Integer
        Dim ULStat As MccDaq.ErrorInfo

        InitUL()    'initiate error handling, etc

        PortType = PORTOUT
        NumPorts = FindPortsOfType(DaqBoard, PortType, ProgAbility, PortNum, NumBits, FirstBit)

        ' Digital out
        If NumPorts < 1 Then
            bMDAQConnected = False
        Else
            bMDAQConnected = True
            If ProgAbility = DigitalIO.PROGPORT Then
                Direction = MccDaq.DigitalPortDirection.DigitalOut
                ULStat = DaqBoard.DConfigPort(PortNum, Direction)
                If ULStat.Value <> MccDaq.ErrorInfo.ErrorCode.NoErrors Then Stop
            End If
            PortName = PortNum.ToString
        End If


        '        If bMDAQConnected Then
        ' Analogue in
        '        Dim LowChan As Integer
        '        Dim ChannelType As Integer
        '        Dim DefaultTrig As MccDaq.TriggerType

        '        ChannelType = ANALOGINPUT
        '        NumAIChans = FindAnalogChansOfType(DaqBoard, ChannelType,
        '        ADResolution, Range, LowChan, DefaultTrig)
        '
        '        If (NumAIChans = 0) Then
        '        MsgBox("Board " & DaqBoard.BoardNum.ToString() & " does not have analog input channels")
        '        Else
        '        Dim CurFunc As String
        '        CurFunc = "MccBoard.AIn"
        '        If (ADResolution > 16) Then CurFunc = "MccBoard.AIn32"
        '        HighChan = LowChan + NumAIChans - 1
        '        End If
        '        End If



    End Sub


End Class
