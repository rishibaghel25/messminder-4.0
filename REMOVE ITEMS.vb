Imports MySql.Data.MySqlClient
Public Class REMOVE_ITEMS
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
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        PRODUCT.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connectionString As String = "server=localhost;port=3306;database=messminder;username=root;password='';"
        Dim connection As New MySqlConnection(connectionString)
        connection.Open()
        Dim transaction As MySqlTransaction = connection.BeginTransaction()

        Try
            Dim productId As Integer
            productId = Integer.Parse(TextBox1.Text) 'assuming product ID is entered by the user in a TextBox named "txtProductId"
            Dim deleteQuery As String = "DELETE FROM product WHERE productid = @id"
            Dim command As New MySqlCommand(deleteQuery, connection, transaction)
            command.Parameters.AddWithValue("@id", productId)
            Dim rowsAffected = command.ExecuteNonQuery()

            If rowsAffected = 1 Then
                transaction.Commit()
                MessageBox.Show("product removed successfully")
            Else
                transaction.Rollback()
                MessageBox.Show("product not found")
            End If

        Catch ex As Exception
            transaction.Rollback()
            MessageBox.Show("An error occurred: " & ex.Message)

        Finally
            connection.Close()
        End Try
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

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()

    End Sub

    Private Sub REMOVE_ITEMS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class