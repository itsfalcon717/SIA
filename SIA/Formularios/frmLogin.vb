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


    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        establecerconexion()
    End Sub

    Private Sub pbCerrar_Click(sender As Object, e As EventArgs) Handles pbCerrar.Click
        Application.Exit()

    End Sub

    Private Sub UsernameTextBox_Enter(sender As Object, e As EventArgs) Handles UsernameTextBox.Enter
        If UsernameTextBox.Text = "Usuario" Then
            UsernameTextBox.Text = ""
            UsernameTextBox.ForeColor = Color.LightGray

        End If

    End Sub

    Private Sub UsernameTextBox_Leave(sender As Object, e As EventArgs) Handles UsernameTextBox.Leave
        If UsernameTextBox.Text = "" Then
            UsernameTextBox.Text = "Usuario"
            UsernameTextBox.ForeColor = Color.DimGray
        End If

    End Sub

    Private Sub PasswordTextBox_Enter(sender As Object, e As EventArgs) Handles PasswordTextBox.Enter
        If PasswordTextBox.Text = "Contraseña" Then
            PasswordTextBox.Text = ""
            PasswordTextBox.ForeColor = Color.LightGray
            PasswordTextBox.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub PasswordTextBox_Leave(sender As Object, e As EventArgs) Handles PasswordTextBox.Leave
        If PasswordTextBox.Text = "" Then
            PasswordTextBox.Text = "Contraseña"
            PasswordTextBox.ForeColor = Color.DimGray
            PasswordTextBox.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub pbMinimizar_Click(sender As Object, e As EventArgs) Handles pbMinimizar.Click
        WindowState = FormWindowState.Minimized

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
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
                    Dim fila As DataRow = tabla.Rows(0)
                    nombre = Trim(fila("cNombre").ToString)
                    tipousuario = Trim(fila("pTipoUser").ToString)

                    frmPrincipal.nombrecompleto.Text = nombre
                    frmPrincipal.tipocompleto.Text = tipousuario
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

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        ConfiguracionServidor.Show()
        Me.Hide()
    End Sub
End Class
