<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_TelaPrincipal_02
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Btm_NumerosInteiros = New System.Windows.Forms.Button()
        Me.Lbl_NomeProjeto = New System.Windows.Forms.Label()
        Me.Btm_PontoFlutuante = New System.Windows.Forms.Button()
        Me.Btm_ConversaoNumeros = New System.Windows.Forms.Button()
        Me.Txt_Numerador = New System.Windows.Forms.TextBox()
        Me.Txt_Denominador = New System.Windows.Forms.TextBox()
        Me.Btm_Resultado = New System.Windows.Forms.Button()
        Me.Txt_ResultadoDecimal = New System.Windows.Forms.TextBox()
        Me.Txt_resultadoDouble = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Btm_NumerosInteiros
        '
        Me.Btm_NumerosInteiros.Location = New System.Drawing.Point(15, 58)
        Me.Btm_NumerosInteiros.Name = "Btm_NumerosInteiros"
        Me.Btm_NumerosInteiros.Size = New System.Drawing.Size(128, 54)
        Me.Btm_NumerosInteiros.TabIndex = 0
        Me.Btm_NumerosInteiros.Text = "Exemplos Números Inteiros"
        Me.Btm_NumerosInteiros.UseVisualStyleBackColor = True
        '
        'Lbl_NomeProjeto
        '
        Me.Lbl_NomeProjeto.AutoSize = True
        Me.Lbl_NomeProjeto.Location = New System.Drawing.Point(12, 20)
        Me.Lbl_NomeProjeto.Name = "Lbl_NomeProjeto"
        Me.Lbl_NomeProjeto.Size = New System.Drawing.Size(104, 13)
        Me.Lbl_NomeProjeto.TabIndex = 2
        Me.Lbl_NomeProjeto.Text = "2 - Criando Variáveis"
        '
        'Btm_PontoFlutuante
        '
        Me.Btm_PontoFlutuante.Location = New System.Drawing.Point(15, 118)
        Me.Btm_PontoFlutuante.Name = "Btm_PontoFlutuante"
        Me.Btm_PontoFlutuante.Size = New System.Drawing.Size(128, 54)
        Me.Btm_PontoFlutuante.TabIndex = 3
        Me.Btm_PontoFlutuante.Text = "Exemplos Números Ponto Flutuante"
        Me.Btm_PontoFlutuante.UseVisualStyleBackColor = True
        '
        'Btm_ConversaoNumeros
        '
        Me.Btm_ConversaoNumeros.Location = New System.Drawing.Point(15, 178)
        Me.Btm_ConversaoNumeros.Name = "Btm_ConversaoNumeros"
        Me.Btm_ConversaoNumeros.Size = New System.Drawing.Size(128, 54)
        Me.Btm_ConversaoNumeros.TabIndex = 4
        Me.Btm_ConversaoNumeros.Text = "Exemplos de Conversão de Números"
        Me.Btm_ConversaoNumeros.UseVisualStyleBackColor = True
        '
        'Txt_Numerador
        '
        Me.Txt_Numerador.Location = New System.Drawing.Point(231, 45)
        Me.Txt_Numerador.Name = "Txt_Numerador"
        Me.Txt_Numerador.Size = New System.Drawing.Size(174, 20)
        Me.Txt_Numerador.TabIndex = 5
        '
        'Txt_Denominador
        '
        Me.Txt_Denominador.Location = New System.Drawing.Point(231, 71)
        Me.Txt_Denominador.Name = "Txt_Denominador"
        Me.Txt_Denominador.Size = New System.Drawing.Size(174, 20)
        Me.Txt_Denominador.TabIndex = 6
        '
        'Btm_Resultado
        '
        Me.Btm_Resultado.Location = New System.Drawing.Point(231, 97)
        Me.Btm_Resultado.Name = "Btm_Resultado"
        Me.Btm_Resultado.Size = New System.Drawing.Size(174, 23)
        Me.Btm_Resultado.TabIndex = 7
        Me.Btm_Resultado.Text = "Resultado"
        Me.Btm_Resultado.UseVisualStyleBackColor = True
        '
        'Txt_ResultadoDecimal
        '
        Me.Txt_ResultadoDecimal.Location = New System.Drawing.Point(231, 152)
        Me.Txt_ResultadoDecimal.Name = "Txt_ResultadoDecimal"
        Me.Txt_ResultadoDecimal.Size = New System.Drawing.Size(340, 20)
        Me.Txt_ResultadoDecimal.TabIndex = 8
        '
        'Txt_resultadoDouble
        '
        Me.Txt_resultadoDouble.Location = New System.Drawing.Point(231, 178)
        Me.Txt_resultadoDouble.Name = "Txt_resultadoDouble"
        Me.Txt_resultadoDouble.Size = New System.Drawing.Size(340, 20)
        Me.Txt_resultadoDouble.TabIndex = 9
        '
        'Frm_TelaPrincipal_02
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(653, 289)
        Me.Controls.Add(Me.Txt_resultadoDouble)
        Me.Controls.Add(Me.Txt_ResultadoDecimal)
        Me.Controls.Add(Me.Btm_Resultado)
        Me.Controls.Add(Me.Txt_Denominador)
        Me.Controls.Add(Me.Txt_Numerador)
        Me.Controls.Add(Me.Btm_ConversaoNumeros)
        Me.Controls.Add(Me.Btm_PontoFlutuante)
        Me.Controls.Add(Me.Lbl_NomeProjeto)
        Me.Controls.Add(Me.Btm_NumerosInteiros)
        Me.Name = "Frm_TelaPrincipal_02"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplicação Alô Mundo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btm_NumerosInteiros As Button
    Friend WithEvents Lbl_NomeProjeto As Label
    Friend WithEvents Btm_PontoFlutuante As Button
    Friend WithEvents Btm_ConversaoNumeros As Button
    Friend WithEvents Txt_Numerador As TextBox
    Friend WithEvents Txt_Denominador As TextBox
    Friend WithEvents Btm_Resultado As Button
    Friend WithEvents Txt_ResultadoDecimal As TextBox
    Friend WithEvents Txt_resultadoDouble As TextBox
End Class
