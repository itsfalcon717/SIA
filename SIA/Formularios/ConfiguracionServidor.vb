Public Class ConfiguracionServidor
    Private Sub btnConectar_Click_1(sender As Object, e As EventArgs) Handles btnConectar.Click
        If txtIpServidor.Text = "" Or txtPass.Text = "" Or txtBaseDatos.Text = "" Or txtUsuario.Text = "" Then
            MsgBox("Aviso", vbCritical, "Operacion cancelada")
        End If
    End Sub

    Private Sub btnCancelar_Click_1(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
        Me.Dispose()
    End Sub
End Class
