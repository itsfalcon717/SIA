'/* ------------------------------------------------------------------------*/
'/* SISTEMA : SIA(sistema inventariado de activos)
'/* SUBSISTEMA : SIA
'/* NOMBRE : configuracionServidor.vb
'/* DESCRIPCIÓN : fcodigo formulario de ConfiguracionServidor.vb
'/* AUTOR : Adler Matos
'/* FECHA CREACIÓN : 24-08--2019
'/* ------------------------------------------------------------------------*/
'/* FECHA MODIFICACIÓN     
'/* ------------------------------------------------------------------------*/
Imports System.IO

Public Class ConfiguracionServidor



    Private Sub ConfiguracionServidor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'carga automatica a los textos del txt
        Try
            If File.Exists(Application.StartupPath + "\IP.text") Then
                txtIpServidor.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\IP.text")
            End If
            If File.Exists(Application.StartupPath + "\USER.text") Then
                txtUsuario.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\USER.text")
            End If

            If File.Exists(Application.StartupPath + "\PASS.text") Then
                txtPass.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\PASS.text")
            End If

            If File.Exists(Application.StartupPath + "\DB.text") Then
                txtBaseDatos.Text = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\DB.text")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click
        If txtIpServidor.Text = "" Or txtPass.Text = "" Or txtBaseDatos.Text = "" Or txtUsuario.Text = "" Then
            MsgBox("Completar todo los campos", vbCritical, "Aviso")
        End If
        Dim archivo As StreamWriter                                           'inicializacion para conectar con el modulo conexionDB
        Try
            archivo = New StreamWriter(Application.StartupPath + "\IP.text")
            archivo.WriteLine(txtIpServidor.Text.Trim)                        'representa una linia
            archivo.Flush()                                                   'borra todo los buffers anteriores
            archivo.Close()                                                   'cerramos
            archivo = New StreamWriter(Application.StartupPath + "\USER.text")
            archivo.WriteLine(txtUsuario.Text.Trim)
            archivo.Flush()
            archivo.Close()
            archivo = New StreamWriter(Application.StartupPath + "\PASS.text")
            archivo.WriteLine(txtPass.Text.Trim)
            archivo.Flush()
            archivo.Close()

            archivo = New StreamWriter(Application.StartupPath + "\DB.text")
            archivo.WriteLine(txtBaseDatos.Text.Trim)
            archivo.Flush()
            archivo.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        btnCancelar.PerformClick()                                              'llamamos a evento cancelar

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Hide()
        frmLogin.Show()
    End Sub
End Class
