Public Class Form1

    Dim PixCm = 40 'pixel per cm
    Dim CmSec = (1 / 60) / 10 'cm al secondo
    Dim RadSec = (1 / 60) * 2 * Math.PI  'Radianti al secondo
    Dim DeltaTimLin As Single
    Dim DeltaTimCir As Single

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If PicCm.Width < 400 Then
            PicCm.Width += 2
            PixCm = PicCm.Width / 2.125
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If PicCm.Width > 40 Then
            PicCm.Width -= 2
            PixCm = PicCm.Width / 2.125
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        DeltaTimLin = Microsoft.VisualBasic.DateAndTime.Timer
        TimLin.Enabled = True
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        TimLin.Enabled = False
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        DeltaTimCir = Microsoft.VisualBasic.DateAndTime.Timer
        TimCir.Enabled = True
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        TimCir.Enabled = False
    End Sub

    Private Sub DomLin_SelectedItemChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DomLin.SelectedItemChanged
        Select Case DomLin.SelectedIndex
            Case 0 'mm/s
                CmSec = (1 / 1) / 10
            Case 1 'mm/min
                CmSec = (1 / 60) / 10
            Case 2 'mm/h
                CmSec = (1 / 3600) / 10
            Case 3 'cm/s
                CmSec = (1 / 1)
            Case 4 'cm/min
                CmSec = (1 / 60)
            Case 5 'cm/h
                CmSec = (1 / 3600)
            Case 6 'm/s
                CmSec = (1 / 1) * 100
            Case 7 'm/min
                CmSec = (1 / 60) * 100
            Case 8 'm/h
                CmSec = (1 / 3600) * 100
            Case 9 'km/s
                CmSec = (1 / 1) * 100000
            Case 10 'km/min
                CmSec = (1 / 60) * 100000
            Case 11 'km/h
                CmSec = (1 / 3600) * 100000
            Case Else

        End Select
    End Sub

    Private Sub DomCir_SelectedItemChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DomCir.SelectedItemChanged
        Select Case DomCir.SelectedIndex
            Case 0 'giri/s
                RadSec = 2 * Math.PI
            Case 1 'giri/min
                RadSec = (1 / 60) * 2 * Math.PI
            Case 2 'giri/h
                RadSec = (1 / 3600) * 2 * Math.PI
        End Select
    End Sub

    Private Sub TimLin_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimLin.Tick
        Dim Tempo = Microsoft.VisualBasic.DateAndTime.Timer
        Dim Dist As Long
        Dist = ((Tempo - DeltaTimLin) * CmSec * PixCm * NumLin.Value) Mod (PictureBox1.Width - 78)
        PictureBox2.Left = PictureBox1.Left + Dist
    End Sub

    Private Sub TimCir_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimCir.Tick
        Dim Tempo = Microsoft.VisualBasic.DateAndTime.Timer
        Dim Angolo As Single
        Dim Raggio = NumericUpDown1.Value * PixCm / 10
        Dim Destra = 540 + Raggio + 20
        Dim Alto = 105 + Raggio + 20

        Angolo = ((Tempo - DeltaTimCir) * RadSec * NumCir.Value) Mod 360

        PictureBox3.Left = Destra + Raggio * Math.Cos(Angolo)
        PictureBox3.Top = Alto - Raggio * Math.Sin(Angolo)
    End Sub


End Class
