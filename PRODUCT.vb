Imports MySql.Data.MySqlClient
Public Class PRODUCT
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.Visible = True
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        LoadProductData("BREAKFAST")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PictureBox2.Visible = True
        PictureBox1.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        LoadProductData("LUNCH")

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PictureBox3.Visible = True
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox4.Visible = False
        LoadProductData("DINNER")

    End Sub
    Private Sub Button1_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Button1.MouseEnter
        Me.Button1.BackColor = Color.FromArgb(106, 242, 255)
        Me.Button1.ForeColor = Color.Black
    End Sub

    Private Sub Button1_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Button1.MouseLeave
        Me.Button1.BackColor = Color.FromArgb(0, 143, 204)
        Me.Button1.ForeColor = Color.White
    End Sub

    Private Sub Button4_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Button5.MouseEnter
        Me.Button5.BackColor = Color.FromArgb(106, 242, 255)
        Me.Button5.ForeColor = Color.Black
    End Sub

    Private Sub Button4_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Button5.MouseLeave
        Me.Button5.BackColor = Color.FromArgb(0, 143, 204)
        Me.Button5.ForeColor = Color.White
    End Sub
    Private Sub Button3_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Button3.MouseEnter
        Me.Button3.BackColor = Color.FromArgb(106, 242, 255)
        Me.Button3.ForeColor = Color.Black
    End Sub

    Private Sub Button3_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Button3.MouseLeave
        Me.Button3.BackColor = Color.FromArgb(0, 143, 204)
        Me.Button3.ForeColor = Color.White
    End Sub
    Private Sub Button8_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Button8.MouseEnter
        Me.Button8.BackColor = Color.FromArgb(106, 242, 255)
        Me.Button8.ForeColor = Color.Black
    End Sub

    Private Sub Button8_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Button8.MouseLeave
        Me.Button8.BackColor = Color.FromArgb(0, 143, 204)
        Me.Button8.ForeColor = Color.White
    End Sub

    Private Sub Button2_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Button2.MouseEnter
        Me.Button2.BackColor = Color.FromArgb(106, 242, 255)
        Me.Button2.ForeColor = Color.Black
    End Sub

    Private Sub Button2_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Button2.MouseLeave
        Me.Button2.BackColor = Color.FromArgb(0, 143, 204)
        Me.Button2.ForeColor = Color.White
    End Sub
    Private Sub Button5_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Button4.MouseEnter
        Me.Button4.BackColor = Color.FromArgb(106, 242, 255)
        Me.Button4.ForeColor = Color.Black
    End Sub

    Private Sub Button5_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Button4.MouseLeave
        Me.Button4.BackColor = Color.FromArgb(0, 143, 204)
        Me.Button4.ForeColor = Color.White
    End Sub
    Private Sub Button6_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Button6.MouseEnter
        Me.Button6.BackColor = Color.FromArgb(106, 242, 255)
        Me.Button6.ForeColor = Color.Black
    End Sub

    Private Sub Button6_MouseLeave(sender As System.Object, e As System.EventArgs) Handles Button6.MouseLeave
        Me.Button6.BackColor = Color.FromArgb(0, 143, 204)
        Me.Button6.ForeColor = Color.White
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PictureBox4.Visible = True
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        LoadProductData("EXTRAS")
    End Sub

    Private Sub LoadProductData(ByVal productType As String)
        Dim connectionString As String = "server=localhost;port=3306;database=messminder;username=root;password='';"
        Dim connection As New MySqlConnection(connectionString)
        connection.Open()
        Dim adapter As New MySqlDataAdapter("SELECT PRODUCTID,PRODUCTNAME FROM product WHERE ptype='" & productType & "'", connection)
        Dim data As New DataSet()
        adapter.Fill(data)

        DataGridView1.DataSource = data.Tables(0)

        connection.Close()
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

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Me.Close()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Close()
        REMOVE_ITEMS.Show()

    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        ADD_ITEMS.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        Me.Close()
        MODIFY_ITEMS.Show()
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
        HOME.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class