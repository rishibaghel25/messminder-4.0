Imports MySql.Data.MySqlClient

Public Class MEMBERREPORT
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Me.Hide()
        REPORT.Show()

    End Sub


    Private Sub label7_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label7.MouseEnter
        Me.Label7.BackColor = Color.Red
        Me.Label7.ForeColor = Color.Black
    End Sub

    Private Sub label7_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Label7.MouseLeave
        Me.Label7.BackColor = Color.Tomato
        Me.Label7.ForeColor = Color.White

    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub MEMBERREPORT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = "server=localhost;port=3306;database=messminder;username=root;password='';"
        Dim connection As New MySqlConnection(connectionString)
        connection.Open()

        Dim adapter As New MySqlDataAdapter("SELECT * FROM mem_report ", connection)

        Dim data As New DataSet()
        adapter.Fill(data)

        DataGridView1.DataSource = data.Tables(0)

        connection.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        REPORT.Show()

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Me.Close()
        REPORT.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class