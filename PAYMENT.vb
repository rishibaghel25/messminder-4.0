Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class PAYMENT
    Dim sCommand As SqlCommand
    Dim sAdapter As SqlDataAdapter
    Dim sBuilder As SqlCommandBuilder
    Dim sDs As DataSet
    Dim sTable As DataTable
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        UPDATE_PAYMENT.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        HOME.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub PAYMENT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = "server=localhost;port=3306;database=messminder;username=root;password='';"
        Dim connection As New MySqlConnection(connectionString)
        connection.Open()


        Dim adapter As New MySqlDataAdapter("SELECT PAY_ID, PAY_AMT, paymentstatus, method FROM payment ", connection)

        Dim data As New DataSet()
        adapter.Fill(data)

        DataGridView1.DataSource = data.Tables(0)

        connection.Close()
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
End Class