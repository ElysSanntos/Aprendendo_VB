Public Class Frm_TelaPrincipal_01
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

    End Sub

    Private Sub Btm_Principal_Click(sender As Object, e As EventArgs) Handles Btm_Principal.Click

        MsgBox("Olá Mundo !!!", MsgBoxStyle.Critical, "Mensagem")


    End Sub
End Class
