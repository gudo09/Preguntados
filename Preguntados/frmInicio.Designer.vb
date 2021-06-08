<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInicio
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
        Me.components = New System.ComponentModel.Container()
        Me.lblPregunta = New System.Windows.Forms.Label()
        Me.cmdResp1 = New System.Windows.Forms.Button()
        Me.cmdResp2 = New System.Windows.Forms.Button()
        Me.cmdResp3 = New System.Windows.Forms.Button()
        Me.cmdResp4 = New System.Windows.Forms.Button()
        Me.cmdVolverJugar = New System.Windows.Forms.Button()
        Me.lblTipoPreg = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblTiempo = New System.Windows.Forms.Label()
        Me.lblTiempoAgotado = New System.Windows.Forms.Label()
        Me.pctEstrella3 = New System.Windows.Forms.PictureBox()
        Me.pctEstrella2 = New System.Windows.Forms.PictureBox()
        Me.pctEstrella1 = New System.Windows.Forms.PictureBox()
        Me.pctGeografia = New System.Windows.Forms.PictureBox()
        Me.pctCiencia = New System.Windows.Forms.PictureBox()
        Me.pctHistoria = New System.Windows.Forms.PictureBox()
        Me.pctDeporte = New System.Windows.Forms.PictureBox()
        Me.pctArte = New System.Windows.Forms.PictureBox()
        Me.pctEntretenimiento = New System.Windows.Forms.PictureBox()
        CType(Me.pctEstrella3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctEstrella2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctEstrella1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctGeografia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctCiencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctHistoria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctDeporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctArte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctEntretenimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPregunta
        '
        Me.lblPregunta.BackColor = System.Drawing.Color.White
        Me.lblPregunta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPregunta.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPregunta.Location = New System.Drawing.Point(12, 204)
        Me.lblPregunta.Name = "lblPregunta"
        Me.lblPregunta.Size = New System.Drawing.Size(353, 109)
        Me.lblPregunta.TabIndex = 0
        Me.lblPregunta.Text = "Label1"
        Me.lblPregunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdResp1
        '
        Me.cmdResp1.BackColor = System.Drawing.Color.White
        Me.cmdResp1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdResp1.Location = New System.Drawing.Point(12, 365)
        Me.cmdResp1.Name = "cmdResp1"
        Me.cmdResp1.Size = New System.Drawing.Size(353, 40)
        Me.cmdResp1.TabIndex = 1
        Me.cmdResp1.Text = "Button1"
        Me.cmdResp1.UseVisualStyleBackColor = False
        '
        'cmdResp2
        '
        Me.cmdResp2.BackColor = System.Drawing.Color.White
        Me.cmdResp2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdResp2.Location = New System.Drawing.Point(12, 411)
        Me.cmdResp2.Name = "cmdResp2"
        Me.cmdResp2.Size = New System.Drawing.Size(353, 40)
        Me.cmdResp2.TabIndex = 2
        Me.cmdResp2.Text = "Button2"
        Me.cmdResp2.UseVisualStyleBackColor = False
        '
        'cmdResp3
        '
        Me.cmdResp3.BackColor = System.Drawing.Color.White
        Me.cmdResp3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdResp3.Location = New System.Drawing.Point(12, 457)
        Me.cmdResp3.Name = "cmdResp3"
        Me.cmdResp3.Size = New System.Drawing.Size(353, 40)
        Me.cmdResp3.TabIndex = 3
        Me.cmdResp3.Text = "Button3"
        Me.cmdResp3.UseVisualStyleBackColor = False
        '
        'cmdResp4
        '
        Me.cmdResp4.BackColor = System.Drawing.Color.White
        Me.cmdResp4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdResp4.Location = New System.Drawing.Point(12, 503)
        Me.cmdResp4.Name = "cmdResp4"
        Me.cmdResp4.Size = New System.Drawing.Size(353, 40)
        Me.cmdResp4.TabIndex = 4
        Me.cmdResp4.Text = "Button4"
        Me.cmdResp4.UseVisualStyleBackColor = False
        '
        'cmdVolverJugar
        '
        Me.cmdVolverJugar.BackColor = System.Drawing.Color.LightSeaGreen
        Me.cmdVolverJugar.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVolverJugar.ForeColor = System.Drawing.Color.White
        Me.cmdVolverJugar.Location = New System.Drawing.Point(12, 582)
        Me.cmdVolverJugar.Name = "cmdVolverJugar"
        Me.cmdVolverJugar.Size = New System.Drawing.Size(353, 40)
        Me.cmdVolverJugar.TabIndex = 5
        Me.cmdVolverJugar.Text = "Comenzar"
        Me.cmdVolverJugar.UseVisualStyleBackColor = False
        '
        'lblTipoPreg
        '
        Me.lblTipoPreg.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.lblTipoPreg.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoPreg.ForeColor = System.Drawing.Color.White
        Me.lblTipoPreg.Location = New System.Drawing.Point(12, 134)
        Me.lblTipoPreg.Name = "lblTipoPreg"
        Me.lblTipoPreg.Size = New System.Drawing.Size(353, 55)
        Me.lblTipoPreg.TabIndex = 12
        Me.lblTipoPreg.Text = "Label1"
        Me.lblTipoPreg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'lblTiempo
        '
        Me.lblTiempo.BackColor = System.Drawing.Color.Transparent
        Me.lblTiempo.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTiempo.ForeColor = System.Drawing.Color.White
        Me.lblTiempo.Location = New System.Drawing.Point(255, 69)
        Me.lblTiempo.Name = "lblTiempo"
        Me.lblTiempo.Size = New System.Drawing.Size(110, 55)
        Me.lblTiempo.TabIndex = 13
        Me.lblTiempo.Text = "Label1"
        Me.lblTiempo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTiempoAgotado
        '
        Me.lblTiempoAgotado.BackColor = System.Drawing.Color.White
        Me.lblTiempoAgotado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTiempoAgotado.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTiempoAgotado.ForeColor = System.Drawing.Color.Red
        Me.lblTiempoAgotado.Location = New System.Drawing.Point(12, 204)
        Me.lblTiempoAgotado.Name = "lblTiempoAgotado"
        Me.lblTiempoAgotado.Size = New System.Drawing.Size(353, 109)
        Me.lblTiempoAgotado.TabIndex = 14
        Me.lblTiempoAgotado.Text = "¡Tiempo agotado!"
        Me.lblTiempoAgotado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblTiempoAgotado.Visible = False
        '
        'pctEstrella3
        '
        Me.pctEstrella3.Image = Global.WindowsApplication1.My.Resources.Resources.Estrella
        Me.pctEstrella3.Location = New System.Drawing.Point(72, 79)
        Me.pctEstrella3.Name = "pctEstrella3"
        Me.pctEstrella3.Size = New System.Drawing.Size(25, 25)
        Me.pctEstrella3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctEstrella3.TabIndex = 17
        Me.pctEstrella3.TabStop = False
        Me.pctEstrella3.Visible = False
        '
        'pctEstrella2
        '
        Me.pctEstrella2.Image = Global.WindowsApplication1.My.Resources.Resources.Estrella
        Me.pctEstrella2.Location = New System.Drawing.Point(42, 79)
        Me.pctEstrella2.Name = "pctEstrella2"
        Me.pctEstrella2.Size = New System.Drawing.Size(25, 25)
        Me.pctEstrella2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctEstrella2.TabIndex = 16
        Me.pctEstrella2.TabStop = False
        Me.pctEstrella2.Visible = False
        '
        'pctEstrella1
        '
        Me.pctEstrella1.Image = Global.WindowsApplication1.My.Resources.Resources.Estrella
        Me.pctEstrella1.Location = New System.Drawing.Point(12, 79)
        Me.pctEstrella1.Name = "pctEstrella1"
        Me.pctEstrella1.Size = New System.Drawing.Size(25, 25)
        Me.pctEstrella1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctEstrella1.TabIndex = 15
        Me.pctEstrella1.TabStop = False
        Me.pctEstrella1.Visible = False
        '
        'pctGeografia
        '
        Me.pctGeografia.Image = Global.WindowsApplication1.My.Resources.Resources.GeoPreg
        Me.pctGeografia.Location = New System.Drawing.Point(315, 12)
        Me.pctGeografia.Name = "pctGeografia"
        Me.pctGeografia.Size = New System.Drawing.Size(50, 50)
        Me.pctGeografia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctGeografia.TabIndex = 11
        Me.pctGeografia.TabStop = False
        Me.pctGeografia.Visible = False
        '
        'pctCiencia
        '
        Me.pctCiencia.Image = Global.WindowsApplication1.My.Resources.Resources.CienPreg
        Me.pctCiencia.Location = New System.Drawing.Point(254, 12)
        Me.pctCiencia.Name = "pctCiencia"
        Me.pctCiencia.Size = New System.Drawing.Size(50, 50)
        Me.pctCiencia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctCiencia.TabIndex = 10
        Me.pctCiencia.TabStop = False
        Me.pctCiencia.Visible = False
        '
        'pctHistoria
        '
        Me.pctHistoria.Image = Global.WindowsApplication1.My.Resources.Resources.HistPreg
        Me.pctHistoria.Location = New System.Drawing.Point(193, 12)
        Me.pctHistoria.Name = "pctHistoria"
        Me.pctHistoria.Size = New System.Drawing.Size(50, 50)
        Me.pctHistoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctHistoria.TabIndex = 9
        Me.pctHistoria.TabStop = False
        Me.pctHistoria.Visible = False
        '
        'pctDeporte
        '
        Me.pctDeporte.Image = Global.WindowsApplication1.My.Resources.Resources.DepPreg
        Me.pctDeporte.Location = New System.Drawing.Point(132, 12)
        Me.pctDeporte.Name = "pctDeporte"
        Me.pctDeporte.Size = New System.Drawing.Size(50, 50)
        Me.pctDeporte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctDeporte.TabIndex = 8
        Me.pctDeporte.TabStop = False
        Me.pctDeporte.Visible = False
        '
        'pctArte
        '
        Me.pctArte.Image = Global.WindowsApplication1.My.Resources.Resources.ArtPreg
        Me.pctArte.Location = New System.Drawing.Point(72, 12)
        Me.pctArte.Name = "pctArte"
        Me.pctArte.Size = New System.Drawing.Size(50, 50)
        Me.pctArte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctArte.TabIndex = 7
        Me.pctArte.TabStop = False
        Me.pctArte.Visible = False
        '
        'pctEntretenimiento
        '
        Me.pctEntretenimiento.Image = Global.WindowsApplication1.My.Resources.Resources.EntrPreg
        Me.pctEntretenimiento.Location = New System.Drawing.Point(12, 12)
        Me.pctEntretenimiento.Name = "pctEntretenimiento"
        Me.pctEntretenimiento.Size = New System.Drawing.Size(50, 50)
        Me.pctEntretenimiento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctEntretenimiento.TabIndex = 6
        Me.pctEntretenimiento.TabStop = False
        Me.pctEntretenimiento.Visible = False
        '
        'frmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(377, 650)
        Me.Controls.Add(Me.pctEstrella3)
        Me.Controls.Add(Me.pctEstrella2)
        Me.Controls.Add(Me.pctEstrella1)
        Me.Controls.Add(Me.lblTiempoAgotado)
        Me.Controls.Add(Me.lblTiempo)
        Me.Controls.Add(Me.lblTipoPreg)
        Me.Controls.Add(Me.pctGeografia)
        Me.Controls.Add(Me.pctCiencia)
        Me.Controls.Add(Me.pctHistoria)
        Me.Controls.Add(Me.pctDeporte)
        Me.Controls.Add(Me.pctArte)
        Me.Controls.Add(Me.pctEntretenimiento)
        Me.Controls.Add(Me.cmdVolverJugar)
        Me.Controls.Add(Me.cmdResp4)
        Me.Controls.Add(Me.cmdResp3)
        Me.Controls.Add(Me.cmdResp2)
        Me.Controls.Add(Me.cmdResp1)
        Me.Controls.Add(Me.lblPregunta)
        Me.Name = "frmInicio"
        Me.Text = "Form1"
        CType(Me.pctEstrella3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctEstrella2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctEstrella1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctGeografia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctCiencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctHistoria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctDeporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctArte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctEntretenimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblPregunta As System.Windows.Forms.Label
    Friend WithEvents cmdResp1 As System.Windows.Forms.Button
    Friend WithEvents cmdResp2 As System.Windows.Forms.Button
    Friend WithEvents cmdResp3 As System.Windows.Forms.Button
    Friend WithEvents cmdResp4 As System.Windows.Forms.Button
    Friend WithEvents cmdVolverJugar As System.Windows.Forms.Button
    Friend WithEvents pctEntretenimiento As System.Windows.Forms.PictureBox
    Friend WithEvents pctArte As System.Windows.Forms.PictureBox
    Friend WithEvents pctDeporte As System.Windows.Forms.PictureBox
    Friend WithEvents pctHistoria As System.Windows.Forms.PictureBox
    Friend WithEvents pctCiencia As System.Windows.Forms.PictureBox
    Friend WithEvents pctGeografia As System.Windows.Forms.PictureBox
    Friend WithEvents lblTipoPreg As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblTiempo As System.Windows.Forms.Label
    Friend WithEvents lblTiempoAgotado As System.Windows.Forms.Label
    Friend WithEvents pctEstrella1 As System.Windows.Forms.PictureBox
    Friend WithEvents pctEstrella2 As System.Windows.Forms.PictureBox
    Friend WithEvents pctEstrella3 As System.Windows.Forms.PictureBox

End Class
