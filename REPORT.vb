Public Class REPORT
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        MEMBERREPORT.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        MESSREPORT.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        HOME.Show()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
    Private Sub Button1_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Button1.MouseEnter
        Me.Button1.BackColor = Color.FromArgb(106, 242, 255)
        Me.Button1.ForeColor = Color.Black
    End Sub

    Private Sub Button1_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Button1.MouseLeave
        Me.Button1.BackColor = Color.FromArgb(0, 143, 204)
        Me.Button1.ForeColor = Color.White
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Me.Close()

    End Sub
    Private Sub Button3_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Button3.MouseEnter
        Me.Button3.BackColor = Color.FromArgb(106, 242, 255)
        Me.Button3.ForeColor = Color.Black
        Panel1.BackColor = Color.DeepSkyBlue
        Panel2.BackColor = Color.White
    End Sub

    Private Sub Button3_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Button3.MouseLeave
        Me.Button3.BackColor = Color.FromArgb(0, 143, 204)
        Me.Button3.ForeColor = Color.White
        Panel2.BackColor = Color.DeepSkyBlue
        Panel1.BackColor = Color.White
    End Sub
    Private Sub label7_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label7.MouseEnter
        Me.Label7.BackColor = Color.Red
        Me.Label7.ForeColor = Color.Black
    End Sub

    Private Sub label7_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Label7.MouseLeave
        Me.Label7.BackColor = Color.Tomato
        Me.Label7.ForeColor = Color.White

    End Sub
    Private Sub Button2_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Button2.MouseEnter
        Panel1.BackColor = Color.White
        Panel2.BackColor = Color.DeepSkyBlue
        Me.Button2.BackColor = Color.FromArgb(106, 242, 255)
        Me.Button2.ForeColor = Color.Black
    End Sub

    Private Sub Button2_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Button2.MouseLeave
        Panel2.BackColor = Color.White
        Panel1.BackColor = Color.DeepSkyBlue
        Me.Button2.BackColor = Color.FromArgb(0, 143, 204)
        Me.Button2.ForeColor = Color.White
        Panel1.BackColor = Color.DeepSkyBlue
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click

    End Sub
End Class