<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MESSREPORT
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Label2 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Panel1 = New Panel()
        Label7 = New Label()
        Button1 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.BorderStyle = BorderStyle.Fixed3D
        Label1.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(165, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(298, 38)
        Label1.TabIndex = 0
        Label1.Text = "MONTHLY RECORD"' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 108)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(605, 389)
        DataGridView1.TabIndex = 24
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(106), CByte(242), CByte(255))
        TextBox1.Location = New Point(243, 231)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(209, 27)
        TextBox1.TabIndex = 25
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = Color.FromArgb(CByte(106), CByte(242), CByte(255))
        TextBox2.Location = New Point(866, 285)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(209, 27)
        TextBox2.TabIndex = 26
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = Color.FromArgb(CByte(106), CByte(242), CByte(255))
        TextBox3.Location = New Point(243, 340)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(209, 27)
        TextBox3.TabIndex = 27
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.BorderStyle = BorderStyle.FixedSingle
        Label2.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(94, 227)
        Label2.Name = "Label2"
        Label2.Size = New Size(130, 31)
        Label2.TabIndex = 28
        Label2.Text = "EXPENSE"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.White
        Label4.BorderStyle = BorderStyle.FixedSingle
        Label4.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(94, 336)
        Label4.Name = "Label4"
        Label4.Padding = New Padding(12, 0, 12, 0)
        Label4.Size = New Size(128, 31)
        Label4.TabIndex = 30
        Label4.Text = "PROFIT"' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.White
        Label5.BorderStyle = BorderStyle.FixedSingle
        Label5.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(109, 281)
        Label5.Name = "Label5"
        Label5.Padding = New Padding(12, 0, 12, 0)
        Label5.Size = New Size(115, 31)
        Label5.TabIndex = 31
        Label5.Text = "SALES"' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(Label4)
        Panel1.Location = New Point(623, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(531, 559)
        Panel1.TabIndex = 32
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Tomato
        Label7.BorderStyle = BorderStyle.Fixed3D
        Label7.Font = New Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(473, 9)
        Label7.Name = "Label7"
        Label7.Size = New Size(36, 40)
        Label7.TabIndex = 63
        Label7.Text = "X"' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(0), CByte(143), CByte(204))
        Button1.Cursor = Cursors.Hand
        Button1.Font = New Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(12, 9)
        Button1.Name = "Button1"
        Button1.Size = New Size(120, 40)
        Button1.TabIndex = 33
        Button1.Text = "BACK"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' MESSREPORT
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DeepSkyBlue
        ClientSize = New Size(1144, 555)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(DataGridView1)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "MESSREPORT"
        Text = "MESSREPORT"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
End Class
