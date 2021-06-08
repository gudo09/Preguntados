Public Class frmInicio
    Dim Contdown As Integer
    Dim Aciertos As Integer
    Dim GanarFigura As Boolean = False
    Private Sub frmInicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'GenerarPregunta()
    End Sub

    Private Sub Correcto(ByVal n As Integer)

        Timer1.Enabled = False



        Select Case n
            Case 1
                cmdResp1.BackColor = Color.SpringGreen

            Case 2
                cmdResp2.BackColor = Color.SpringGreen

            Case 3
                cmdResp3.BackColor = Color.SpringGreen

            Case 4
                cmdResp4.BackColor = Color.SpringGreen

        End Select

        'MsgBox("¡CORRECTO!")
        cmdVolverJugar.Enabled = True
        cmdResp1.Enabled = False
        cmdResp2.Enabled = False
        cmdResp3.Enabled = False
        cmdResp4.Enabled = False


        Aciertos = Aciertos + 1

        If GanarFigura = True Then
            Aciertos = 0

            Select Case lblTipoPreg.Text

                Case Historia(1)
                    pctHistoria.Visible = True
                    frmSeleccionPesonaje.pctHistoria.Hide()
                Case Geografia(1)
                    pctGeografia.Visible = True
                    frmSeleccionPesonaje.pctGeografia.Hide()
                Case Arte(1)
                    pctArte.Visible = True
                    frmSeleccionPesonaje.pctArte.Hide()
                Case Deporte(1)
                    pctDeporte.Visible = True
                    frmSeleccionPesonaje.pctDeporte.Hide()
                Case Entretenimiento(1)
                    pctEntretenimiento.Visible = True
                    frmSeleccionPesonaje.pctEntretenimiento.Hide()
                Case Ciencia(1)
                    pctCiencia.Visible = True
                    frmSeleccionPesonaje.pctCiencia.Hide()
            End Select

            GanarFigura = False
        End If

        DibujarEstrellas()

    End Sub

    Private Sub Incorrecto(ByVal n As Integer)
        Timer1.Enabled = False

        GanarFigura = False

        Select Case n
            Case 1
                cmdResp1.BackColor = Color.Red
            Case 2
                cmdResp2.BackColor = Color.Red
            Case 3
                cmdResp3.BackColor = Color.Red
            Case 4
                cmdResp4.BackColor = Color.Red
        End Select

        Select Case Vec(5)

            Case 1
                cmdResp1.BackColor = Color.SpringGreen
            Case 2
                cmdResp2.BackColor = Color.SpringGreen
            Case 3
                cmdResp3.BackColor = Color.SpringGreen
            Case 4
                cmdResp4.BackColor = Color.SpringGreen

        End Select


        'MsgBox("INCORRECTO")
        cmdVolverJugar.Enabled = True
        cmdResp1.Enabled = False
        cmdResp2.Enabled = False
        cmdResp3.Enabled = False
        cmdResp4.Enabled = False

        Aciertos = 0
        DibujarEstrellas()
    End Sub

    Private Sub TiempoAgotado()
        GanarFigura = False
        lblTiempoAgotado.Visible = True

        cmdVolverJugar.Enabled = True
        cmdResp1.Visible = False
        cmdResp2.Visible = False
        cmdResp3.Visible = False
        cmdResp4.Visible = False

    End Sub

    Private Sub GenerarPregunta()

        lblTiempoAgotado.Visible = False
        cmdResp1.Visible = True
        cmdResp2.Visible = True
        cmdResp3.Visible = True
        cmdResp4.Visible = True

        cmdResp1.BackColor = Color.White
        cmdResp2.BackColor = Color.White
        cmdResp3.BackColor = Color.White
        cmdResp4.BackColor = Color.White

        Dim r As New Random
        Dim n As Integer = r.Next(1, 11)
        Dim k As Integer = r.Next(1, 7)

        Select Case k

            Case 1
                ArchPreg = Historia(0)
                lblTipoPreg.Text = Historia(1)
                lblTipoPreg.BackColor = Color.Goldenrod
            Case 2
                ArchPreg = Geografia(0)
                lblTipoPreg.Text = Geografia(1)
                lblTipoPreg.BackColor = Color.DodgerBlue
            Case 3
                ArchPreg = Arte(0)
                lblTipoPreg.Text = Arte(1)
                lblTipoPreg.BackColor = Color.Red
            Case 4
                ArchPreg = Deporte(0)
                lblTipoPreg.Text = Deporte(1)
                lblTipoPreg.BackColor = Color.DarkOrange
            Case 5
                ArchPreg = Entretenimiento(0)
                lblTipoPreg.Text = Entretenimiento(1)
                lblTipoPreg.BackColor = Color.HotPink
            Case 6
                ArchPreg = Ciencia(0)
                lblTipoPreg.Text = Ciencia(1)
                lblTipoPreg.BackColor = Color.Green

        End Select

        Dim ad As New System.IO.StreamReader(ArchPreg)
        Dim Cadena As String

        For c As Integer = 0 To n - 1
            Cadena = ad.ReadLine()
        Next

        Vec = Cadena.Split(";")

        lblPregunta.Text = Vec(0)

        cmdResp1.Text = Vec(1)
        cmdResp2.Text = Vec(2)
        cmdResp3.Text = Vec(3)
        cmdResp4.Text = Vec(4)

        ad.Close()


        Contdown = 30
        lblTiempo.ForeColor = Color.White
        lblTiempo.Text = Contdown & "'"
        Timer1.Enabled = True
    End Sub

    Public Sub GenerarPregunta(ByVal tipo() As String)

        GanarFigura = True

        lblTiempoAgotado.Visible = False
        cmdResp1.Visible = True
        cmdResp2.Visible = True
        cmdResp3.Visible = True
        cmdResp4.Visible = True

        cmdResp1.BackColor = Color.White
        cmdResp2.BackColor = Color.White
        cmdResp3.BackColor = Color.White
        cmdResp4.BackColor = Color.White

        Dim r As New Random
        Dim n As Integer = r.Next(1, 11)

        Select Case tipo(1)

            Case Historia(1)
                ArchPreg = Historia(0)
                lblTipoPreg.Text = Historia(1)
                lblTipoPreg.BackColor = Color.Goldenrod
            Case Geografia(1)
                ArchPreg = Geografia(0)
                lblTipoPreg.Text = Geografia(1)
                lblTipoPreg.BackColor = Color.DodgerBlue
            Case Arte(1)
                ArchPreg = Arte(0)
                lblTipoPreg.Text = Arte(1)
                lblTipoPreg.BackColor = Color.Red
            Case Deporte(1)
                ArchPreg = Deporte(0)
                lblTipoPreg.Text = Deporte(1)
                lblTipoPreg.BackColor = Color.DarkOrange
            Case Entretenimiento(1)
                ArchPreg = Entretenimiento(0)
                lblTipoPreg.Text = Entretenimiento(1)
                lblTipoPreg.BackColor = Color.HotPink
            Case Ciencia(1)
                ArchPreg = Ciencia(0)
                lblTipoPreg.Text = Ciencia(1)
                lblTipoPreg.BackColor = Color.Green

        End Select

        Dim ad As New System.IO.StreamReader(ArchPreg)
        Dim Cadena As String

        For c As Integer = 0 To n - 1
            Cadena = ad.ReadLine()
        Next

        Vec = Cadena.Split(";")

        lblPregunta.Text = Vec(0)

        cmdResp1.Text = Vec(1)
        cmdResp2.Text = Vec(2)
        cmdResp3.Text = Vec(3)
        cmdResp4.Text = Vec(4)

        ad.Close()


        Contdown = 30
        lblTiempo.ForeColor = Color.White
        lblTiempo.Text = Contdown & "'"
        Timer1.Enabled = True
    End Sub

    Private Sub DibujarEstrellas()
        Select Case Aciertos
            Case 0
                pctEstrella1.Visible = False
                pctEstrella2.Visible = False
                pctEstrella3.Visible = False
            Case 1
                pctEstrella1.Visible = True
                pctEstrella2.Visible = False
                pctEstrella3.Visible = False
            Case 2
                pctEstrella1.Visible = True
                pctEstrella2.Visible = True
                pctEstrella3.Visible = False
            Case 3
                pctEstrella1.Visible = True
                pctEstrella2.Visible = True
                pctEstrella3.Visible = True
        End Select
    End Sub

    Private Sub cmdResp1_Click(sender As System.Object, e As System.EventArgs) Handles cmdResp1.Click
        If Vec(5) = 1 Then
            Correcto(1)
        Else
            Incorrecto(1)
        End If
    End Sub

    Private Sub cmdResp2_Click(sender As System.Object, e As System.EventArgs) Handles cmdResp2.Click
        If Vec(5) = 2 Then
            Correcto(2)
        Else
            Incorrecto(2)
        End If
    End Sub

    Private Sub cmdResp3_Click(sender As System.Object, e As System.EventArgs) Handles cmdResp3.Click
        If Vec(5) = 3 Then
            Correcto(3)
        Else
            Incorrecto(3)

        End If
    End Sub

    Private Sub cmdResp4_Click(sender As System.Object, e As System.EventArgs) Handles cmdResp4.Click
        If Vec(5) = 4 Then
            Correcto(4)
        Else
            Incorrecto(4)
        End If
    End Sub

    Private Sub cmdVolverJugar_Click(sender As System.Object, e As System.EventArgs) Handles cmdVolverJugar.Click


        cmdVolverJugar.Enabled = False
        cmdResp1.Enabled = True
        cmdResp2.Enabled = True
        cmdResp3.Enabled = True
        cmdResp4.Enabled = True

        If cmdVolverJugar.Text = "Comenzar" Then
            cmdVolverJugar.Text = "Continuar"
            GenerarPregunta()
            frmPortada.Hide()
        End If

        If cmdVolverJugar.Text = "Continuar" Then
            GenerarPregunta()
        End If

        If cmdVolverJugar.Text = "Volver a jugar" Then
            frmPortada.Show()
            cmdVolverJugar.Text = "Comenzar"
            cmdVolverJugar.Enabled = True
            frmPortada.PictureBox1.Image = My.Resources.Preguntados_logo
            frmPortada.lblTitulo.Text = "PREGUNTADOS"

        End If

        If pctArte.Visible = True And pctCiencia.Visible = True And pctDeporte.Visible = True And pctEntretenimiento.Visible = True And pctGeografia.Visible = True And pctHistoria.Visible = True Then

            pctArte.Visible = False
            pctCiencia.Visible = False
            pctDeporte.Visible = False
            pctEntretenimiento.Visible = False
            pctGeografia.Visible = False
            pctHistoria.Visible = False



            frmPortada.PictureBox1.Image = My.Resources.Festejo
            frmPortada.lblTitulo.Text = "¡GANASTE!"
            cmdVolverJugar.Text = "Volver a jugar"
            cmdVolverJugar.Enabled = True
            frmPortada.Show()
        End If


        If Aciertos = 3 Then
            frmSeleccionPesonaje.Show()
        End If






        



    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Contdown = Contdown - 1
        lblTiempo.Text = Contdown & "'"

        If Contdown = 10 Then
            lblTiempo.ForeColor = Color.Red
        End If

        If Contdown = 0 Then
            Timer1.Enabled = False
            TiempoAgotado()
        End If
    End Sub

    Private Sub frmInicio_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        frmPortada.Show()
    End Sub
End Class
