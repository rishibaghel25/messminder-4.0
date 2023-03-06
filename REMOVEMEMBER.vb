Imports MySql.Data.MySqlClient

Public Class REMOVEMEMBER
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Members.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click

    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click

    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim memberID As Integer = Integer.Parse(TextBox1.Text)
        Dim connectionString As String = "server=localhost;port=3306;database=messminder;username=root;password='';"
        Dim connection As New MySqlConnection(connectionString)
        connection.Open()
        Dim transaction As MySqlTransaction = connection.BeginTransaction()

        Try
            Dim deleteQuery As String = "UPDATE member SET status = 0 WHERE memberid = @id"
            Dim command As New MySqlCommand(deleteQuery, connection, transaction)
            command.Parameters.AddWithValue("@id", memberID)
            Dim rowsAffected = command.ExecuteNonQuery()

            If rowsAffected = 1 Then
                transaction.Commit()
                MessageBox.Show("Member removed successfully")
            Else
                transaction.Rollback()
                MessageBox.Show("Member not found")
            End If

        Catch ex As Exception
            transaction.Rollback()
            MessageBox.Show("An error occurred: " & ex.Message)

        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Members.Show()

    End Sub
    Private Sub label7_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label7.MouseEnter
        Me.Label7.BackColor = Color.Red
        Me.Label7.ForeColor = Color.Black
    End Sub

    Private Sub label7_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Label7.MouseLeave
        Me.Label7.BackColor = Color.Tomato
        Me.Label7.ForeColor = Color.White
    End Sub
    Private Sub Button1_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Button1.MouseEnter
        Me.Button1.BackColor = Color.FromArgb(106, 242, 255)
        Me.Button1.ForeColor = Color.Black
    End Sub

    Private Sub Button1_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Button1.MouseLeave
        Me.Button1.BackColor = Color.FromArgb(0, 143, 204)
        Me.Button1.ForeColor = Color.White
    End Sub

    Private Sub Button2_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Button2.MouseEnter
        Me.Button2.BackColor = Color.FromArgb(106, 242, 255)
        Me.Button2.ForeColor = Color.Black
    End Sub

    Private Sub Button2_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Button2.MouseLeave
        Me.Button2.BackColor = Color.FromArgb(0, 143, 204)
        Me.Button2.ForeColor = Color.White
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Me.Close()

    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click

    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click

    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click

    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click

    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click

    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click

    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click

    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click

    End Sub
End Class