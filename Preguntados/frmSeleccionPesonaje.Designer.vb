<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSeleccionPesonaje
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
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pctGeografia = New System.Windows.Forms.PictureBox()
        Me.pctCiencia = New System.Windows.Forms.PictureBox()
        Me.pctHistoria = New System.Windows.Forms.PictureBox()
        Me.pctDeporte = New System.Windows.Forms.PictureBox()
        Me.pctArte = New System.Windows.Forms.PictureBox()
        Me.pctEntretenimiento = New System.Windows.Forms.PictureBox()
        CType(Me.pctGeografia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctCiencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctHistoria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctDeporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctArte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctEntretenimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.BackColor = System.Drawing.Color.Transparent
        Me.lblTitulo.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(12, 105)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(353, 55)
        Me.lblTitulo.TabIndex = 13
        Me.lblTitulo.Text = "Elegí un personaje"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pctGeografia
        '
        Me.pctGeografia.BackColor = System.Drawing.Color.Gray
        Me.pctGeografia.Image = Global.WindowsApplication1.My.Resources.Resources.GeoPreg
        Me.pctGeografia.Location = New System.Drawing.Point(263, 342)
        Me.pctGeografia.Name = "pctGeografia"
        Me.pctGeografia.Size = New System.Drawing.Size(99, 138)
        Me.pctGeografia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctGeografia.TabIndex = 19
        Me.pctGeografia.TabStop = False
        '
        'pctCiencia
        '
        Me.pctCiencia.BackColor = System.Drawing.Color.Gray
        Me.pctCiencia.Image = Global.WindowsApplication1.My.Resources.Resources.CienPreg
        Me.pctCiencia.Location = New System.Drawing.Point(138, 342)
        Me.pctCiencia.Name = "pctCiencia"
        Me.pctCiencia.Size = New System.Drawing.Size(99, 138)
        Me.pctCiencia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctCiencia.TabIndex = 18
        Me.pctCiencia.TabStop = False
        '
        'pctHistoria
        '
        Me.pctHistoria.BackColor = System.Drawing.Color.Gray
        Me.pctHistoria.Image = Global.WindowsApplication1.My.Resources.Resources.HistPreg
        Me.pctHistoria.Location = New System.Drawing.Point(14, 342)
        Me.pctHistoria.Name = "pctHistoria"
        Me.pctHistoria.Size = New System.Drawing.Size(99, 138)
        Me.pctHistoria.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctHistoria.TabIndex = 17
        Me.pctHistoria.TabStop = False
        '
        'pctDeporte
        '
        Me.pctDeporte.BackColor = System.Drawing.Color.Gray
        Me.pctDeporte.Image = Global.WindowsApplication1.My.Resources.Resources.DepPreg
        Me.pctDeporte.Location = New System.Drawing.Point(263, 182)
        Me.pctDeporte.Name = "pctDeporte"
        Me.pctDeporte.Size = New System.Drawing.Size(99, 138)
        Me.pctDeporte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctDeporte.TabIndex = 16
        Me.pctDeporte.TabStop = False
        '
        'pctArte
        '
        Me.pctArte.BackColor = System.Drawing.Color.Gray
        Me.pctArte.Image = Global.WindowsApplication1.My.Resources.Resources.ArtPreg
        Me.pctArte.Location = New System.Drawing.Point(138, 182)
        Me.pctArte.Name = "pctArte"
        Me.pctArte.Size = New System.Drawing.Size(99, 138)
        Me.pctArte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctArte.TabIndex = 15
        Me.pctArte.TabStop = False
        '
        'pctEntretenimiento
        '
        Me.pctEntretenimiento.BackColor = System.Drawing.Color.Gray
        Me.pctEntretenimiento.Image = Global.WindowsApplication1.My.Resources.Resources.EntrPreg
        Me.pctEntretenimiento.Location = New System.Drawing.Point(14, 182)
        Me.pctEntretenimiento.Name = "pctEntretenimiento"
        Me.pctEntretenimiento.Size = New System.Drawing.Size(99, 138)
        Me.pctEntretenimiento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctEntretenimiento.TabIndex = 14
        Me.pctEntretenimiento.TabStop = False
        '
        'frmSeleccionPesonaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(377, 630)
        Me.ControlBox = False
        Me.Controls.Add(Me.pctGeografia)
        Me.Controls.Add(Me.pctCiencia)
        Me.Controls.Add(Me.pctHistoria)
        Me.Controls.Add(Me.pctDeporte)
        Me.Controls.Add(Me.pctArte)
        Me.Controls.Add(Me.pctEntretenimiento)
        Me.Controls.Add(Me.lblTitulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSeleccionPesonaje"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form1"
        CType(Me.pctGeografia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctCiencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctHistoria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctDeporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctArte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctEntretenimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents pctGeografia As System.Windows.Forms.PictureBox
    Friend WithEvents pctCiencia As System.Windows.Forms.PictureBox
    Friend WithEvents pctHistoria As System.Windows.Forms.PictureBox
    Friend WithEvents pctDeporte As System.Windows.Forms.PictureBox
    Friend WithEvents pctArte As System.Windows.Forms.PictureBox
    Friend WithEvents pctEntretenimiento As System.Windows.Forms.PictureBox
End Class
