Public Class frmClock

    Public Sub New()
        InitializeComponent()
        Timer1.Start()
        OnTimerTick(Nothing, Nothing)
    End Sub
    'Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
    '    If disposing Then
    '        lockTimerCounter += 1
    '        If Timer1 IsNot Nothing Then
    '            Timer1.Stop()
    '            Timer1.Dispose()
    '            Timer1 = Nothing
    '        End If
    '    End If
    '    MyBase.Dispose(disposing)
    'End Sub

    Private Function GetStringLength(ByVal str As String) As Integer
        Dim counter As Integer = 0
        Dim pos As Integer = 0
        Do While pos < str.Length
            If str.Chars(pos) <> ":"c Then
                counter += 1
            End If
            pos += 1
        Loop
        Return counter
    End Function

    Private lockTimerCounter As Integer = 0
    Private Sub OnTimerTick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If lockTimerCounter = 0 Then
            lockTimerCounter += 1
            UpdateTime()
            lockTimerCounter -= 1
        End If
    End Sub
    Private Sub UpdateTime()
        Dim time As String = DateTime.Now.ToLongTimeString()
        If GetStringLength(time) > DigitalGauge1.DigitCount Then
            DigitalGauge1.DigitCount = GetStringLength(time)
        End If
        DigitalGauge1.Text = time
    End Sub


    Private Sub SimpleButton1_Click(sender As System.Object, e As System.EventArgs)
        Me.Dispose()
    End Sub
End Class