<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.panelPricipal = New System.Windows.Forms.Panel()
        Me.PanelVista = New System.Windows.Forms.Panel()
        Me.pinfo = New System.Windows.Forms.PictureBox()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PanelTitulo = New System.Windows.Forms.Panel()
        Me.btnUser = New System.Windows.Forms.Button()
        Me.tipo = New System.Windows.Forms.Label()
        Me.pbMinized = New System.Windows.Forms.PictureBox()
        Me.nombre = New System.Windows.Forms.Label()
        Me.pbmaximizar = New System.Windows.Forms.PictureBox()
        Me.tipocompleto = New System.Windows.Forms.Label()
        Me.pbRestaurar = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.nombrecompleto = New System.Windows.Forms.Label()
        Me.btnUser1 = New System.Windows.Forms.Button()
        Me.panelPricipal.SuspendLayout()
        Me.PanelVista.SuspendLayout()
        CType(Me.pinfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMenu.SuspendLayout()
        Me.PanelTitulo.SuspendLayout()
        CType(Me.pbMinized, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbmaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbRestaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelPricipal
        '
        Me.panelPricipal.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.panelPricipal.Controls.Add(Me.PanelVista)
        Me.panelPricipal.Controls.Add(Me.PanelMenu)
        Me.panelPricipal.Controls.Add(Me.PanelTitulo)
        Me.panelPricipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelPricipal.Location = New System.Drawing.Point(0, 0)
        Me.panelPricipal.Name = "panelPricipal"
        Me.panelPricipal.Size = New System.Drawing.Size(1020, 502)
        Me.panelPricipal.TabIndex = 0
        '
        'PanelVista
        '
        Me.PanelVista.BackColor = System.Drawing.Color.White
        Me.PanelVista.Controls.Add(Me.nombre)
        Me.PanelVista.Controls.Add(Me.tipocompleto)
        Me.PanelVista.Controls.Add(Me.nombrecompleto)
        Me.PanelVista.Controls.Add(Me.tipo)
        Me.PanelVista.Controls.Add(Me.pinfo)
        Me.PanelVista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelVista.Location = New System.Drawing.Point(250, 40)
        Me.PanelVista.Name = "PanelVista"
        Me.PanelVista.Size = New System.Drawing.Size(770, 462)
        Me.PanelVista.TabIndex = 2
        '
        'pinfo
        '
        Me.pinfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pinfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pinfo.Location = New System.Drawing.Point(442, -6)
        Me.pinfo.Name = "pinfo"
        Me.pinfo.Size = New System.Drawing.Size(250, 90)
        Me.pinfo.TabIndex = 8
        Me.pinfo.TabStop = False
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.Button4)
        Me.PanelMenu.Controls.Add(Me.Button3)
        Me.PanelMenu.Controls.Add(Me.Button2)
        Me.PanelMenu.Controls.Add(Me.Button1)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 40)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(250, 462)
        Me.PanelMenu.TabIndex = 1
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(-5, 161)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(261, 34)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Button4"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(-5, 108)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(261, 34)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(-5, 62)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(261, 34)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Bahnschrift Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(-2, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(261, 34)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Configuracion"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PanelTitulo
        '
        Me.PanelTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.PanelTitulo.Controls.Add(Me.btnUser1)
        Me.PanelTitulo.Controls.Add(Me.btnUser)
        Me.PanelTitulo.Controls.Add(Me.pbMinized)
        Me.PanelTitulo.Controls.Add(Me.pbmaximizar)
        Me.PanelTitulo.Controls.Add(Me.pbRestaurar)
        Me.PanelTitulo.Controls.Add(Me.PictureBox1)
        Me.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitulo.Name = "PanelTitulo"
        Me.PanelTitulo.Size = New System.Drawing.Size(1020, 40)
        Me.PanelTitulo.TabIndex = 0
        '
        'btnUser
        '
        Me.btnUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnUser.FlatAppearance.BorderSize = 0
        Me.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUser.ForeColor = System.Drawing.Color.Snow
        Me.btnUser.Image = CType(resources.GetObject("btnUser.Image"), System.Drawing.Image)
        Me.btnUser.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnUser.Location = New System.Drawing.Point(891, 0)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Size = New System.Drawing.Size(51, 48)
        Me.btnUser.TabIndex = 8
        Me.btnUser.UseVisualStyleBackColor = False
        '
        'tipo
        '
        Me.tipo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tipo.AutoSize = True
        Me.tipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tipo.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tipo.ForeColor = System.Drawing.Color.White
        Me.tipo.Location = New System.Drawing.Point(464, 48)
        Me.tipo.Name = "tipo"
        Me.tipo.Size = New System.Drawing.Size(86, 17)
        Me.tipo.TabIndex = 7
        Me.tipo.Text = "Tipo usuario  :"
        '
        'pbMinized
        '
        Me.pbMinized.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbMinized.Image = CType(resources.GetObject("pbMinized.Image"), System.Drawing.Image)
        Me.pbMinized.Location = New System.Drawing.Point(948, 12)
        Me.pbMinized.Name = "pbMinized"
        Me.pbMinized.Size = New System.Drawing.Size(16, 15)
        Me.pbMinized.TabIndex = 3
        Me.pbMinized.TabStop = False
        '
        'nombre
        '
        Me.nombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nombre.AutoSize = True
        Me.nombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.nombre.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre.ForeColor = System.Drawing.Color.White
        Me.nombre.Location = New System.Drawing.Point(464, 15)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(65, 17)
        Me.nombre.TabIndex = 4
        Me.nombre.Text = "Nombre  :"
        '
        'pbmaximizar
        '
        Me.pbmaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbmaximizar.Image = CType(resources.GetObject("pbmaximizar.Image"), System.Drawing.Image)
        Me.pbmaximizar.Location = New System.Drawing.Point(970, 12)
        Me.pbmaximizar.Name = "pbmaximizar"
        Me.pbmaximizar.Size = New System.Drawing.Size(16, 15)
        Me.pbmaximizar.TabIndex = 2
        Me.pbmaximizar.TabStop = False
        '
        'tipocompleto
        '
        Me.tipocompleto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tipocompleto.AutoSize = True
        Me.tipocompleto.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.tipocompleto.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tipocompleto.ForeColor = System.Drawing.Color.White
        Me.tipocompleto.Location = New System.Drawing.Point(555, 48)
        Me.tipocompleto.Name = "tipocompleto"
        Me.tipocompleto.Size = New System.Drawing.Size(77, 17)
        Me.tipocompleto.TabIndex = 5
        Me.tipocompleto.Text = "Tipo usuario"
        '
        'pbRestaurar
        '
        Me.pbRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbRestaurar.Image = CType(resources.GetObject("pbRestaurar.Image"), System.Drawing.Image)
        Me.pbRestaurar.Location = New System.Drawing.Point(970, 12)
        Me.pbRestaurar.Name = "pbRestaurar"
        Me.pbRestaurar.Size = New System.Drawing.Size(16, 15)
        Me.pbRestaurar.TabIndex = 1
        Me.pbRestaurar.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(992, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 15)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'nombrecompleto
        '
        Me.nombrecompleto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nombrecompleto.AutoSize = True
        Me.nombrecompleto.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.nombrecompleto.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombrecompleto.ForeColor = System.Drawing.Color.White
        Me.nombrecompleto.Location = New System.Drawing.Point(528, 15)
        Me.nombrecompleto.Name = "nombrecompleto"
        Me.nombrecompleto.Size = New System.Drawing.Size(77, 17)
        Me.nombrecompleto.TabIndex = 9
        Me.nombrecompleto.Text = "Tipo usuario"
        '
        'btnUser1
        '
        Me.btnUser1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUser1.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnUser1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.btnUser1.FlatAppearance.BorderSize = 0
        Me.btnUser1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUser1.ForeColor = System.Drawing.Color.Snow
        Me.btnUser1.Image = CType(resources.GetObject("btnUser1.Image"), System.Drawing.Image)
        Me.btnUser1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnUser1.Location = New System.Drawing.Point(891, 0)
        Me.btnUser1.Name = "btnUser1"
        Me.btnUser1.Size = New System.Drawing.Size(51, 48)
        Me.btnUser1.TabIndex = 9
        Me.btnUser1.UseVisualStyleBackColor = False
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 502)
        Me.Controls.Add(Me.panelPricipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(550, 400)
        Me.Name = "frmPrincipal"
        Me.Opacity = 0.8R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPrincipal"
        Me.panelPricipal.ResumeLayout(False)
        Me.PanelVista.ResumeLayout(False)
        Me.PanelVista.PerformLayout()
        CType(Me.pinfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelTitulo.ResumeLayout(False)
        CType(Me.pbMinized, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbmaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbRestaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelPricipal As Panel
    Friend WithEvents PanelTitulo As Panel
    Friend WithEvents PanelVista As Panel
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents pbmaximizar As PictureBox
    Friend WithEvents pbRestaurar As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents pbMinized As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents tipo As Label
    Friend WithEvents nombre As Label
    Friend WithEvents pinfo As PictureBox
    Friend WithEvents btnUser As Button
    Friend WithEvents btnUser1 As Button
    Public WithEvents tipocompleto As Label
    Public WithEvents nombrecompleto As Label
End Class
