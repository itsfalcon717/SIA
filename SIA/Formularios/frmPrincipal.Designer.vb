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
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.PanelTitulo = New System.Windows.Forms.Panel()
        Me.pbMinized = New System.Windows.Forms.PictureBox()
        Me.pbmaximizar = New System.Windows.Forms.PictureBox()
        Me.pbRestaurar = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panelPricipal.SuspendLayout()
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
        Me.panelPricipal.Size = New System.Drawing.Size(854, 413)
        Me.panelPricipal.TabIndex = 0
        '
        'PanelVista
        '
        Me.PanelVista.BackColor = System.Drawing.Color.White
        Me.PanelVista.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelVista.Location = New System.Drawing.Point(250, 40)
        Me.PanelVista.Name = "PanelVista"
        Me.PanelVista.Size = New System.Drawing.Size(604, 373)
        Me.PanelVista.TabIndex = 2
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.SystemColors.Highlight
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 40)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(250, 373)
        Me.PanelMenu.TabIndex = 1
        '
        'PanelTitulo
        '
        Me.PanelTitulo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelTitulo.Controls.Add(Me.pbMinized)
        Me.PanelTitulo.Controls.Add(Me.pbmaximizar)
        Me.PanelTitulo.Controls.Add(Me.pbRestaurar)
        Me.PanelTitulo.Controls.Add(Me.PictureBox1)
        Me.PanelTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitulo.Name = "PanelTitulo"
        Me.PanelTitulo.Size = New System.Drawing.Size(854, 40)
        Me.PanelTitulo.TabIndex = 0
        '
        'pbMinized
        '
        Me.pbMinized.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbMinized.Image = CType(resources.GetObject("pbMinized.Image"), System.Drawing.Image)
        Me.pbMinized.Location = New System.Drawing.Point(782, 12)
        Me.pbMinized.Name = "pbMinized"
        Me.pbMinized.Size = New System.Drawing.Size(16, 15)
        Me.pbMinized.TabIndex = 3
        Me.pbMinized.TabStop = False
        '
        'pbmaximizar
        '
        Me.pbmaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbmaximizar.Image = CType(resources.GetObject("pbmaximizar.Image"), System.Drawing.Image)
        Me.pbmaximizar.Location = New System.Drawing.Point(804, 12)
        Me.pbmaximizar.Name = "pbmaximizar"
        Me.pbmaximizar.Size = New System.Drawing.Size(16, 15)
        Me.pbmaximizar.TabIndex = 2
        Me.pbmaximizar.TabStop = False
        '
        'pbRestaurar
        '
        Me.pbRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbRestaurar.Image = CType(resources.GetObject("pbRestaurar.Image"), System.Drawing.Image)
        Me.pbRestaurar.Location = New System.Drawing.Point(804, 12)
        Me.pbRestaurar.Name = "pbRestaurar"
        Me.pbRestaurar.Size = New System.Drawing.Size(16, 15)
        Me.pbRestaurar.TabIndex = 1
        Me.pbRestaurar.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(826, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 15)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 413)
        Me.Controls.Add(Me.panelPricipal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(550, 400)
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPrincipal"
        Me.panelPricipal.ResumeLayout(False)
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
End Class
