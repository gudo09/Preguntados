Public Class frmPortada

    Private Sub frmPortada_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = New Point(frmInicio.Location.X + 4, frmInicio.Location.Y + 30)
    End Sub

End Class