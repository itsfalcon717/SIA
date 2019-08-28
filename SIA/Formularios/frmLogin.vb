'/* ------------------------------------------------------------------------*/
'/* SISTEMA : SIA(sistema inventariado de activos)
'/* SUBSISTEMA : SIA
'/* NOMBRE : frmLogin.vb
'/* DESCRIPCIÓN : formulario de frmLogin.vb
'/* AUTOR : Adler Matos
'/* FECHA CREACIÓN : 25-08--2019
'/* ------------------------------------------------------------------------*/
'/* FECHA MODIFICACIÓN     
'/* ------------------------------------------------------------------------*/

Imports System.Data.SqlClient
Public Class frmLogin
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        'validaciones
        If UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Then
            MsgBox("Existen datos vacios", vbCritical, "Aviso")                     'cuando usuario y contraseña es vacio 
        Else
            Try
                conexion.Open()                                                         'abrimos la conexion
                adaptador = New SqlDataAdapter("SELECT * FROM usuarios WHERE cUser='" & UsernameTextBox.Text & "' AND cPassword='" & PasswordTextBox.Text & "'", conexion)
                tabla.Clear()
                adaptador.Fill(tabla)
                If tabla.Rows.Count = 1 Then
                    'MsgBox("Datos verificados", vbInformation, "Aviso")
                    UsernameTextBox.Text = ""
                    PasswordTextBox.Text = ""
                    Me.Hide()
                    frmPrincipal.Show()
                Else
                    MsgBox("Nombre de usurio o contraseña no validos.", vbInformation, "Aviso")
                End If
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Aviso")
            End Try


        End If
    End Sub
    Private Sub LogoPictureBox_Click(sender As Object, e As EventArgs) Handles LogoPictureBox.Click
        ConfiguracionServidor.Show()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        establecerconexion()
        UsernameTextBox.Focus()
        UsernameTextBox.Text = ""
    End Sub

    Private Sub Cancel_Click_1(sender As Object, e As EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
