Imports System.Runtime.InteropServices

Public Class frmPrincipal
#Region "FUNCIONALIDAD DEL FORMULARIO"
    'RESIZE DEL FORMULARIO- CAMBIAR TAMAÑO
    Dim lx, ly, sw, sh As Integer
    Dim cGrip As Integer = 10

    Protected Overrides Sub WndProc(ByRef m As Message)
        If (m.Msg = 132) Then
            Dim pos As Point = New Point((m.LParam.ToInt32 And 65535), (m.LParam.ToInt32 + 16))
            pos = Me.PointToClient(pos)
            If ((pos.X _
                        >= (Me.ClientSize.Width - cGrip)) _
                        AndAlso (pos.Y _
                        >= (Me.ClientSize.Height - cGrip))) Then
                m.Result = CType(17, IntPtr)
                Return
            End If
        End If
        MyBase.WndProc(m)
    End Sub
    '----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
    Dim sizeGripRectangle As Rectangle
    Dim tolerance As Integer = 15

    Protected Overrides Sub OnSizeChanged(ByVal e As EventArgs)
        MyBase.OnSizeChanged(e)
        Dim region = New Region(New Rectangle(0, 0, Me.ClientRectangle.Width, Me.ClientRectangle.Height))
        sizeGripRectangle = New Rectangle((Me.ClientRectangle.Width - tolerance), (Me.ClientRectangle.Height - tolerance), tolerance, tolerance)
        region.Exclude(sizeGripRectangle)
        Me.panelPricipal.Region = region
        Me.Invalidate()
    End Sub

    '----------------COLOR Y GRIP DE RECTANGULO INFERIOR
    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        Dim blueBrush As SolidBrush = New SolidBrush(Color.FromArgb(64, 64, 64))
        e.Graphics.FillRectangle(blueBrush, sizeGripRectangle)
        MyBase.OnPaint(e)
        ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle)
    End Sub
    'ARRASTRAR FORMULARIO
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    Private Sub pbmaximizar_Click(sender As Object, e As EventArgs) Handles pbmaximizar.Click
        lx = Me.Location.X
        ly = Me.Location.Y
        sw = Me.Size.Width
        sh = Me.Size.Height

        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location
        pbRestaurar.Visible = True
        pbmaximizar.Visible = False
    End Sub

    Private Sub pbRestaurar_Click(sender As Object, e As EventArgs) Handles pbRestaurar.Click
        Me.Size = New Size(sw, sh)
        Me.Location = New Point(lx, ly)
        pbRestaurar.Visible = False
        pbmaximizar.Visible = True
    End Sub

    Private Sub pbMinized_Click(sender As Object, e As EventArgs) Handles pbMinized.Click
        WindowState = FormWindowState.Minimized
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

#End Region

#Region "Abrir panel"
    Private Sub abrirPanel(Of Myform As {Form, New})()
        Dim formulario As Form
        formulario = PanelVista.Controls.OfType(Of Myform)().FirstOrDefault()  'busca el formulario


        If formulario Is Nothing Then
            formulario = New Myform()
            formulario.TopLevel = False

            formulario.FormBorderStyle = FormBorderStyle.None
            formulario.Dock = DockStyle.Fill

            PanelVista.Controls.Add(formulario)
            PanelVista.Tag = formulario
            formulario.Show()
            formulario.BringToFront()

        Else
            formulario.BringToFront()


        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        abrirPanel(Of frmVista1)()
    End Sub

    Private Sub btnUser_Click(sender As Object, e As EventArgs) Handles btnUser.Click
        pinfo.Visible = False
        btnUser1.Visible = True
        btnUser.Visible = False

        nombre.Visible = False
        nombrecompleto.Visible = False
        tipo.Visible = False
        tipocompleto.Visible = False
    End Sub

    Private Sub btnUser1_Click(sender As Object, e As EventArgs) Handles btnUser1.Click
        pinfo.Visible = True
        btnUser.Visible = True
        btnUser1.Visible = False
        nombre.Visible = True
        nombrecompleto.Visible = True
        tipo.Visible = True
        tipocompleto.Visible = True
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        pinfo.Visible = False
        nombre.Visible = False
        nombrecompleto.Visible = False
        tipo.Visible = False
        tipocompleto.Visible = False
    End Sub

    Private Sub PanelTitulo_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelTitulo.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Application.Exit()

    End Sub

#End Region

End Class