Public Class Frm_TelaPrincipal_02
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

    End Sub

    Private Sub Btm_Principal_Click(sender As Object, e As EventArgs) Handles Btm_NumerosInteiros.Click

        Dim idade As Integer
        idade = 12
        MsgBox("O valor da idade é:  " + idade.ToString, MsgBoxStyle.Critical)

        idade *= 5
        MsgBox("O valor da idade multiplicado por 5 é:  " + idade.ToString, MsgBoxStyle.Exclamation)

        idade *= 5 + 10
        MsgBox("O valor da idade multiplicado por 5 e somado de 10 é:  " + idade.ToString, MsgBoxStyle.MsgBoxHelp)

    End Sub

    Private Sub Btm_PontoFlutuante_Click(sender As Object, e As EventArgs) Handles Btm_PontoFlutuante.Click

        Dim valor As Double
        valor = 9.2

        MsgBox("A variável valor é igual a:  " + valor.ToString, MsgBoxStyle.AbortRetryIgnore)

        valor /= 2

        MsgBox("O valor de 5 / 2 é: " + valor.ToString, MsgBoxStyle.Information)

        Dim numerador As Integer = 5
        Dim denominador As Integer = 2

        valor = numerador / denominador

        MsgBox("O valor de" + numerador.ToString + " / " + denominador.ToString + " é:  " + valor.ToString, MsgBoxStyle.YesNo)


    End Sub

    Private Sub Btm_ConversaoNumeros_Click(sender As Object, e As EventArgs) Handles Btm_ConversaoNumeros.Click

        Dim Salario As Double
        Salario = 1300.45

        Dim SalarioInteiro As Integer
        SalarioInteiro = Salario

        MsgBox("O valor do salário é " + Salario.ToString + " e do salário inteiro é " + SalarioInteiro.ToString, MsgBoxStyle.DefaultButton1)

        Dim salarioGrande As Long
        salarioGrande = 1000000000000000000
        MsgBox("O valor do salário longo é " + salarioGrande.ToString, MsgBoxStyle.DefaultButton2)

        Dim salarioPequeno As Short
        salarioPequeno = 1
        MsgBox("O valor do salário pequeno é " + salarioPequeno.ToString, MsgBoxStyle.DefaultButton3)

        Dim salarioMinusculo As SByte
        salarioMinusculo = 10
        MsgBox("O valor do salário minusculo é " + salarioMinusculo.ToString, MsgBoxStyle.MsgBoxHelp)

        Dim ValorDouble As Double
        ValorDouble = 9.238748234798
        MsgBox("O valor da variável double é " + ValorDouble.ToString, MsgBoxStyle.MsgBoxRtlReading)


        Dim ValorDecimal As Decimal
        ValorDecimal = 9.238748234798
        MsgBox("O valor da variável Decimal é " + ValorDecimal.ToString, MsgBoxStyle.MsgBoxSetForeground)


    End Sub

    Private Sub Btm_Resultado_Click(sender As Object, e As EventArgs) Handles Btm_Resultado.Click

        Dim numerador As Decimal
        Dim denominador As Decimal

        numerador = Txt_Numerador.Text
        denominador = Txt_Denominador.Text

        Dim resultadoDecimal As Decimal
        resultadoDecimal = numerador / denominador

        MsgBox("O resultado entre a divisão (Decimal) de " + numerador.ToString + " por " _
               + denominador.ToString + " é " + resultadoDecimal.ToString, MsgBoxStyle.RetryCancel)

        Dim resultadoDouble As Double
        resultadoDouble = numerador / denominador

        MsgBox("O resultado entre a divisão (Double) de " + numerador.ToString + " por " _
               + denominador.ToString + " é " + resultadoDouble.ToString, MsgBoxStyle.SystemModal)


        Txt_ResultadoDecimal.Text = resultadoDecimal.ToString
        Txt_resultadoDouble.Text = resultadoDouble.ToString

    End Sub
End Class
