Imports MySql.Data.MySqlClient

Public Class SIGNUP
    Private Sub label7MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label7.MouseEnter
        Me.Label7.BackColor = Color.Red
        Me.Label7.ForeColor = Color.Black
    End Sub

    Private Sub label7MouseLeave(sender As System.Object, e As System.EventArgs) Handles Label7.MouseLeave
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
    Private Sub label7_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label7.MouseEnter
        Me.Label7.BackColor = Color.Red
        Me.Label7.ForeColor = Color.Black
    End Sub

    Private Sub label7_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Label7.MouseLeave
        Me.Label7.BackColor = Color.Tomato
        Me.Label7.ForeColor = Color.White
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connectionString As String = "server=localhost;port=3306;database=messminder;username=root;password='';"
        Dim connection As New MySqlConnection(connectionString)
        connection.Open()
        Dim transaction As MySqlTransaction = connection.BeginTransaction()

        Dim t1 As String = TextBox1.Text
        Dim t2 As String = TextBox2.Text
        Dim t3 As String = TextBox3.Text
        Dim t4 As String = TextBox4.Text

        If t1 = "" Or t3 = "" Or t2 = "" Then
            MessageBox.Show("All Fields are Mandatory!")
        End If

        If t4 = "" Or TextBox5.Text = "" Then
            MsgBox("All Fields are Mandatory!")
        ElseIf t4 = TextBox5.Text Then
            Try
                Dim insertQuery As String = "INSERT INTO login (name, email, phoneno, password) VALUES (@name, @email, @phone, @password)"
                Dim command As New MySqlCommand(insertQuery, connection, transaction)
                command.Parameters.AddWithValue("@name", TextBox1.Text)
                command.Parameters.AddWithValue("@email", TextBox2.Text)
                command.Parameters.AddWithValue("@phone", TextBox3.Text)
                command.Parameters.AddWithValue("@password", TextBox4.Text)
                command.ExecuteNonQuery()
                transaction.Commit()
                MessageBox.Show("Login Successful ! !")
                Me.Close()
                LOGIN.Show()
            Catch ex As Exception
                transaction.Rollback()
                MessageBox.Show("An error occurred: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        LOGIN.Show()
    End Sub


End Class