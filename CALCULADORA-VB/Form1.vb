Public Class FormCalc
    'variables.
    Dim Operacion As String
    Dim ValorResultado As Nullable(Of Double) = Nothing
    Dim Valor2 As Nullable(Of Double) = Nothing
    Dim Bandera As Boolean

    'botones numericos.
    Private Sub bt1_Click(sender As Object, e As EventArgs) Handles bt1.Click
        DeterminarConcatenar()
        txtDisplay.Text &= "1"
    End Sub

    Private Sub bt2_Click(sender As Object, e As EventArgs) Handles bt2.Click
        DeterminarConcatenar()
        txtDisplay.Text &= "2"
    End Sub

    Private Sub bt3_Click(sender As Object, e As EventArgs) Handles bt3.Click
        DeterminarConcatenar()
        txtDisplay.Text &= "3"
    End Sub

    Private Sub bt4_Click(sender As Object, e As EventArgs) Handles bt4.Click
        DeterminarConcatenar()
        txtDisplay.Text &= "4"
    End Sub

    Private Sub bt5_Click(sender As Object, e As EventArgs) Handles bt5.Click
        DeterminarConcatenar()
        txtDisplay.Text &= "5"
    End Sub

    Private Sub bt6_Click(sender As Object, e As EventArgs) Handles bt6.Click
        DeterminarConcatenar()
        txtDisplay.Text &= "6"
    End Sub

    Private Sub bt7_Click(sender As Object, e As EventArgs) Handles bt7.Click
        DeterminarConcatenar()
        txtDisplay.Text &= "7"
    End Sub

    Private Sub bt8_Click(sender As Object, e As EventArgs) Handles bt8.Click
        DeterminarConcatenar()
        txtDisplay.Text &= "8"
    End Sub

    Private Sub bt9_Click(sender As Object, e As EventArgs) Handles bt9.Click
        DeterminarConcatenar()
        txtDisplay.Text &= "9"
    End Sub

    Private Sub bt0_Click(sender As Object, e As EventArgs) Handles bt0.Click
        DeterminarConcatenar()
        txtDisplay.Text &= "0"
    End Sub

    'botones de operaciones.

    Private Sub btSuma_Click(sender As Object, e As EventArgs) Handles btSuma.Click
        OperacionProceso()
        Operacion = "+"
    End Sub

    Private Sub btMultiplicacion_Click(sender As Object, e As EventArgs) Handles btMultiplicacion.Click
        OperacionProceso()
        Operacion = "x"
    End Sub

    Private Sub btResta_Click(sender As Object, e As EventArgs) Handles btResta.Click
        OperacionProceso()
        Operacion = "-"
    End Sub

    Private Sub btDivision_Click(sender As Object, e As EventArgs) Handles btDivision.Click
        OperacionProceso()
        Operacion = "/"
    End Sub

    'botones en general.

    Private Sub btComa_Click(sender As Object, e As EventArgs) Handles btComa.Click
        DeterminarConcatenar()
        If InStr(txtDisplay.Text, ".", CompareMethod.Text) = 0 Then
            txtDisplay.Text &= "."
        End If
    End Sub

    Private Sub btBorrar_Click(sender As Object, e As EventArgs) Handles btBorrar.Click
        txtDisplay.Text = "0"
        Valor2 = Nothing
        ValorResultado = Nothing
    End Sub

    Private Sub btResultado_Click(sender As Object, e As EventArgs) Handles btResultado.Click
        OperacionProceso()
        Operacion = ""
    End Sub

    ' funciones/ metodos.

    Public Sub DeterminarConcatenar()
        If Bandera = True Then
            txtDisplay.Text = ""
            Bandera = False
        ElseIf txtDisplay.Text = "0" Then
            txtDisplay.Text = ""
        End If
    End Sub

    Public Sub OperacionProceso()
        Bandera = True
        Valor2 = Val(txtDisplay.Text)
        If ValorResultado IsNot Nothing Then
            Select Case Operacion
                Case "+"
                    ValorResultado += Valor2
                Case "-"
                    ValorResultado -= Valor2
                Case "x"
                    ValorResultado *= Valor2
                Case "/"
                    ValorResultado /= Valor2
            End Select
            txtDisplay.Text = ValorResultado
        Else
            ValorResultado = Valor2
        End If
    End Sub

End Class
