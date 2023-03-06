Imports MySql.Data.MySqlClient

Public Class MESSREPORT
    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Me.Hide()
        REPORT.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Dim connectionString As String = "server=localhost;port=3306;database=messminder;username=root;password='';"
        Dim connection As New MySqlConnection(connectionString)
        connection.Open()

        Dim adapter As New MySqlDataAdapter("SELECT MESS_RID, PROFIT,SALES, EXPENSE FROM mess_report ", connection)

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        REPORT.Show()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Me.Close()
        REPORT.Show()
    End Sub
End Class