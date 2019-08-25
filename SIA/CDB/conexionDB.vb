'/* ------------------------------------------------------------------------*/
'/* SISTEMA : SIA(sistema inventariado de activos)
'/* SUBSISTEMA : SIA
'/* NOMBRE : conexionDB.vb
'/* DESCRIPCIÓN : Conexion a sqlserver
'/* AUTOR : Adler Matos
'/* FECHA CREACIÓN : 24-08--2019
'/* ------------------------------------------------------------------------*/
'/* FECHA MODIFICACIÓN     
'/* ------------------------------------------------------------------------*/

Imports System.Data
Imports System.Data.SqlClient
Imports System.IO

Module conexionDB

    Public ip As String = "", user As String = "", pass As String = "", bd As String = ""
    Public conexion As SqlConnection
    Public adaptador As SqlDataAdapter
    Public tabla As New DataTable

    Public nombre As String
    Public usuario As String
    Public tipousuario As String

    Public Sub establecerconexion()
        Try
            If File.Exists(Application.StartupPath + "\IP.text") Then
                ip = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\IP.text")
            End If
            If File.Exists(Application.StartupPath + "\USER.text") Then
                user = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\USER.text")
            End If

            If File.Exists(Application.StartupPath + "\PASS.text") Then
                pass = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\PASS.text")
            End If

            If File.Exists(Application.StartupPath + "\DB.text") Then
                bd = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\DB.text")
            End If
            If ip.Length = 0 Or user.Length = 0 Or pass.Length = 0 Or bd.Length = 0 Then
                MsgBox("Faltan parametros de conexion", vbCritical, "Aviso")
            Else
                conexion = New SqlConnection("Data Source=" & ip.Trim & "; Initial Catalog=" & bd.Trim & "; User Id=" & user.Trim & "; Password=" & pass.Trim & ";  ")
                conexion.Close()

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Public Function ObtenerConexion()
        Dim miconexion As String = ""
        Try
            If File.Exists(Application.StartupPath + "\IP.text") Then
                ip = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\IP.text")
            End If
            If File.Exists(Application.StartupPath + "\USER.text") Then
                user = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\USER.text")
            End If

            If File.Exists(Application.StartupPath + "\PASS.text") Then
                pass = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\PASS.text")
            End If

            If File.Exists(Application.StartupPath + "\DB.text") Then
                bd = My.Computer.FileSystem.ReadAllText(Application.StartupPath + "\DB.text")
            End If
            If ip.Length = 0 Or user.Length = 0 Or pass.Length = 0 Or bd.Length = 0 Then
                MsgBox("Faltan parametros de conexion", vbCritical, "Aviso")
            Else
                miconexion = ("Data Source=" & ip.Trim & "; Initial Catalog=" & bd.Trim & "; User Id=" & user.Trim & "; Password=" & pass.Trim & ";  ")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        Return miconexion
    End Function
End Module
