Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Public Class UPDATE_PAYMENT
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        PAYMENT.Show()

    End Sub
    Private Sub label1_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label1.MouseEnter
        Me.Label1.BackColor = Color.Red
        Me.Label1.ForeColor = Color.Black
    End Sub

    Private Sub label1_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Label1.MouseLeave
        Me.Label1.BackColor = Color.Tomato
        Me.Label1.ForeColor = Color.White
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connectionString As String = "server=localhost;port=3306;database=messminder;username=root;password='';"
        Dim connection As New MySqlConnection(connectionString)
        connection.Open()
        Dim transaction As MySqlTransaction = connection.BeginTransaction()

        'Retrieve member ID from data source, either through user input or a related record
        Dim memberId As Integer = 1 'Replace with your code to retrieve member ID
        Dim t1 As String = TextBox1.Text
        Dim t2 As String = ComboBox1.Text
        Try

            Dim insertQuery As String = "INSERT INTO payment ( paymentstatus, paymentdate) VALUES ( @paymentstatus, @paymentdate)"
            Dim command As New MySqlCommand(insertQuery, connection, transaction)
            command.Parameters.AddWithValue("@paymentstatus", t1)
            command.Parameters.AddWithValue("@paymentdate", t2)
            command.ExecuteNonQuery()

            transaction.Commit()
            MessageBox.Show("Payment record added successfully")

        Catch ex As Exception
            transaction.Rollback()
            MessageBox.Show("An error occurred: " & ex.Message)

        Finally
            connection.Close()
        End Try
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

    Private Sub Button2_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Button2.MouseEnter
        Me.Button2.BackColor = Color.FromArgb(106, 242, 255)
        Me.Button2.ForeColor = Color.Black
    End Sub

    Private Sub Button2_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Button2.MouseLeave
        Me.Button2.BackColor = Color.FromArgb(0, 143, 204)
        Me.Button2.ForeColor = Color.White
    End Sub

    Private Sub UPDATE_PAYMENT_Load(sender As Object, e As EventArgs)
        ComboBox1.Items.Add("PAID")
        ComboBox1.Items.Add("UNPAID")
    End Sub

    Private Sub UPDATE_PAYMENT_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("PAID")
        ComboBox1.Items.Add("UNPAID")

    End Sub
End Class