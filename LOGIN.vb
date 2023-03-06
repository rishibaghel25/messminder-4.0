Imports System.Drawing.Drawing2D
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class LOGIN

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim connectionString As String = "server=localhost;port=3306;database=messminder;username=root;password='';"
        Dim connection As New MySqlConnection(connectionString)
        connection.Open()
        Dim name As String = TextBox1.Text.Trim()
        Dim password As String = TextBox2.Text.Trim()
        Dim query As String = $"SELECT COUNT(*) FROM login WHERE name = '{name}' AND password = '{password}'"
        Dim command As New MySqlCommand(query, connection)
        Dim result As Integer = command.ExecuteScalar()

        If result > 0 Then
            ' Username and password are valid, show the Home form
            Me.Hide()
            MessageBox.Show("LOGIN SUCCESSFUL")
            HOME.Show()
        Else
            ' Username or password is invalid, show an error message
            MessageBox.Show("Invalid username or password")
        End If
        connection.Close()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        SIGNUP.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

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

    Private Sub LOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class
