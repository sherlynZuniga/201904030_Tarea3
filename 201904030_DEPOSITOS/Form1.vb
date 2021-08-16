Public Class Form1
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Seleccionó ahorro'

        SaldoNuevo.Text = Str(Saldo_Nuevo)
        If RadioButton3.Checked = True Then


            Select Case Saldo_Nuevo
                Case 1 To 1000
                    interes = 1.5 / 100
                Case 1001 To 5000
                    interes = 2.5 / 100
                Case 5001 To 15000.99
                    interes = 7.5 / 100
                Case Is >= 15001
                    interes = 10 / 100
            End Select

            txtinteres.Text = Str(interes * 100) + "%"
            Saldo_Nuevo = Val(MontoCP.Text) + Val(MontoCOB.Text) + Val(MontoE.Text) + Val(SaldoAnterior.Text)
            Saldo_Nuevo = Saldo_Nuevo + Saldo_Nuevo * interes
            SaldoNuevo.Text = Str(Saldo_Nuevo)


        End If

        'seleccionó monetario premier'

        If RadioButton2.Checked = True Then
            Select Case Val(SaldoAnterior.Text)
                Case 1 To 10000
                    interes = 2.5 / 100
                Case 10001 To 15000
                    interes = 3 / 100
                Case Is >= 15001
                    interes = 4.5 / 100

            End Select
        End If

        Saldo_Nuevo = Val(MontoCP.Text) + Val(MontoCOB.Text) + Val(MontoE.Text) + Val(SaldoAnterior.Text) * interes

        'seleccionó monetario'

        If RadioButton1.Checked = True Then
            Saldo_Nuevo = Val(MontoCP.Text) + Val(MontoCOB.Text) + Val(MontoE.Text) + Val(SaldoAnterior.Text)
            SaldoNuevo.Text = Str(Saldo_Nuevo)
        End If

        txtinteres.Text = Str(interes * 100) + "%"
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        MessageBox.Show("You are in the CheckBox.CheckedChanged event.")
        If RadioButton1.Checked = True Then
            TipoDeSeleccionado = True

        ElseIf RadioButton2.Checked = True Then
            TipoDeSeleccionado = True

        ElseIf RadioButton3.Checked = True Then
            TipoDeSeleccionado = True

        End If

        If TipoDeSeleccionado = True Then

        ElseIf CheckBox1.Checked = True Then
            MontoCP.Text = True

        End If

        If TipoDeSeleccionado = False Then

        ElseIf CheckBox1.Checked = False Then
            MontoCP.Text = False


        End If


    End Sub
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

        MessageBox.Show("You are in the CheckBox.CheckedChanged event.")
        If RadioButton1.Checked = True Then
            TipoDeSeleccionado = True

        ElseIf RadioButton2.Checked = True Then
            TipoDeSeleccionado = True

        ElseIf RadioButton3.Checked = True Then
            TipoDeSeleccionado = True

        End If

        If TipoDeSeleccionado = True Then

        ElseIf CheckBox2.Checked = True Then
            MontoCOB.Text = True

        End If

        If TipoDeSeleccionado = False Then

        ElseIf CheckBox2.Checked = False Then
            MontoCOB.Text = False


        End If


    End Sub
    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged

        MessageBox.Show("You are in the CheckBox.CheckedChanged event.")
        If RadioButton1.Checked = True Then
            TipoDeSeleccionado = True

        ElseIf RadioButton2.Checked = True Then
            TipoDeSeleccionado = True

        ElseIf RadioButton3.Checked = True Then
            TipoDeSeleccionado = True

        End If

        If TipoDeSeleccionado = True Then

        ElseIf CheckBox3.Checked = True Then
            MontoE.Text = True

        End If

        If TipoDeSeleccionado = False Then

        ElseIf CheckBox3.Checked = False Then
            MontoE.Text = False


        End If


    End Sub

End Class
