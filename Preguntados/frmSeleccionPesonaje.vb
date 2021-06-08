Public Class frmSeleccionPesonaje

    Private Sub frmSeleccionPesonaje_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = New Point(frmInicio.Location.X + 4, frmInicio.Location.Y + 30)
    End Sub

    Private Sub pctEntretenimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctEntretenimiento.Click
        Me.Visible = False
        frmInicio.GenerarPregunta(Entretenimiento)
    End Sub

    Private Sub pctArte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctArte.Click
        Me.Visible = False
        frmInicio.GenerarPregunta(Arte)
    End Sub

    Private Sub pctDeporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctDeporte.Click
        Me.Visible = False
        frmInicio.GenerarPregunta(Deporte)
    End Sub

    Private Sub pctHistoria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctHistoria.Click
        Me.Visible = False
        frmInicio.GenerarPregunta(Historia)
    End Sub

    Private Sub pctCiencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctCiencia.Click
        Me.Visible = False
        frmInicio.GenerarPregunta(Ciencia)
    End Sub

    Private Sub pctGeografia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pctGeografia.Click
        Me.Visible = False
        frmInicio.GenerarPregunta(Geografia)
    End Sub
End Class