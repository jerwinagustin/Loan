Public Class Form1
    Dim ALL, IRR, YPP, MP, LN, result, TI, TLPP, TAPP As Double
    Dim currentValue, Value As String
    Dim NumValue As Integer

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        currentValue = LFN.Text
        NumValue = Integer.Parse(currentValue)
        NumValue += 1

        Value = NumValue.ToString("D4")

        LFN.Text = Value
        AL.Clear()
        AL2.Clear()
        AN.Clear()
        Name.Clear()
        Address.Clear()
        IR.Clear()
        YP.Clear()
        Name2.Clear()
        AN2.Clear()
        Address2.Clear()
        IR2.Clear()
        Monthly.Clear()
        YP2.Clear()
        TII.Clear()
        TAP.Clear()
        TLP.Clear()
        LFN2.Clear()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            YPP = YPP * 12
            LFN2.Text = LFN.Text
            AN2.Text = AN.Text
            Name2.Text = Name.Text
            Address2.Text = Address.Text
            AL2.Text = "₱" & Format(CDbl(AL.Text), "#,##.00")
            IR2.Text = IR.Text & "%"
            YP2.Text = YP.Text & "(" & CDbl(YP.Text) * 12 & "Months" & ")"

            ALL = CDbl(AL.Text)
            IRR = CDbl(IR.Text) / 100
            YPP = CDbl(YP.Text) * 12

            TI = ALL * IRR * YPP

            TII.Text = Format(TI, "₱#,##.00")

            TLPP = TI + ALL

            TLP.Text = Format(TLPP, "₱#,##.00")

            YPP = YPP / 12
            TAPP = TLPP / YPP

            TAP.Text = Format(TAPP, "₱#,##.00")

            YPP = YPP * 12

            MP = TLPP / YPP

            Monthly.Text = Format(MP, "₱#,##.00")

            YPP = YPP / 12
        Catch ex As Exception

        End Try


    End Sub
End Class
