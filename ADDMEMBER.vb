Imports System.Diagnostics.Eventing.Reader
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Public Class ADDMEMBER

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
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

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Me.Close()

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim connectionString As String = "server=localhost;port=3306;database=messminder;username=root;password='';"
        Dim connection As New MySqlConnection(connectionString)
        connection.Open()
        Dim transaction As MySqlTransaction = connection.BeginTransaction()

        Dim t1 As String = TextBox1.Text
        Dim t2 As String = TextBox2.Text
        Dim t3 As String = TextBox3.Text
        Dim t4 As String = ComboBox1.Text
        Dim t5 As String = ComboBox2.Text
        Dim t6 As Date = DateTimePicker1.Value
        Try
            Dim insertQuery As String = "INSERT INTO member (name, email, phoneno, gender, meal, joindate,status) VALUES (@name, @email, @phone, @gender, @meal, @joindate,1)"
            Dim command As New MySqlCommand(insertQuery, connection, transaction)
            command.Parameters.AddWithValue("@name", t1)
            command.Parameters.AddWithValue("@email", t2)
            command.Parameters.AddWithValue("@phone", t3)
            command.Parameters.AddWithValue("@gender", t4)
            command.Parameters.AddWithValue("@meal", t5)
            command.Parameters.AddWithValue("@joindate", t6)
            command.ExecuteNonQuery()
            transaction.Commit()
            MessageBox.Show("Member added successfully!")
        Catch ex As Exception
            transaction.Rollback()
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub
    Private Sub ADDMEMBER_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("MALE")
        ComboBox1.Items.Add("FEMALE")
        ComboBox1.Items.Add("OTHERS")
        ComboBox2.Items.Add("1 TIME")
        ComboBox2.Items.Add("2 TIME")
        ComboBox2.Items.Add("3 TIME")

    End Sub
End Class