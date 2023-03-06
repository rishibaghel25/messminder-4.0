<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MEMBERREPORT
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
        Label5 = New Label()
        Label4 = New Label()
        TextBox2 = New TextBox()
        DataGridView1 = New DataGridView()
        ListBox1 = New ListBox()
        Panel1 = New Panel()
        TextBox3 = New TextBox()
        TextBox1 = New TextBox()
        Label7 = New Label()
        Button1 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.DeepSkyBlue
        Label1.BorderStyle = BorderStyle.Fixed3D
        Label1.Font = New Font("Microsoft Sans Serif", 25F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ButtonHighlight
        Label1.Location = New Point(334, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(454, 50)
        Label1.TabIndex = 1
        Label1.Text = "MEMBERS RECORDS"' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.White
        Label5.BorderStyle = BorderStyle.Fixed3D
        Label5.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.Black
        Label5.Location = New Point(633, 221)
        Label5.Name = "Label5"
        Label5.Padding = New Padding(14, 0, 12, 0)
        Label5.Size = New Size(240, 31)
        Label5.TabIndex = 38
        Label5.Text = "NEW JOININGS    "' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.White
        Label4.BorderStyle = BorderStyle.Fixed3D
        Label4.Font = New Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(226, 221)
        Label4.Name = "Label4"
        Label4.Padding = New Padding(10, 0, 10, 0)
        Label4.Size = New Size(241, 31)
        Label4.TabIndex = 37
        Label4.Text = "TOTAL MEMBERS"' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(226, 257)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(241, 27)
        TextBox2.TabIndex = 34
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.White
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(219, 101)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(648, 372)
        DataGridView1.TabIndex = 32
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 20
        ListBox1.Location = New Point(873, 394)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(226, 44)
        ListBox1.TabIndex = 39
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.DeepSkyBlue
        Panel1.Controls.Add(TextBox3)
        Panel1.Controls.Add(TextBox1)
        Panel1.Controls.Add(TextBox2)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(ListBox1)
        Panel1.Location = New Point(-7, 255)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1151, 301)
        Panel1.TabIndex = 40
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(633, 255)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(241, 27)
        TextBox3.TabIndex = 41
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(467, 137)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(216, 27)
        TextBox1.TabIndex = 40
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Tomato
        Label7.BorderStyle = BorderStyle.Fixed3D
        Label7.Font = New Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.ForeColor = Color.White
        Label7.Location = New Point(1096, 9)
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
        Button1.TabIndex = 64
        Button1.Text = "BACK"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' MEMBERREPORT
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(1144, 555)
        Controls.Add(Button1)
        Controls.Add(Label7)
        Controls.Add(DataGridView1)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "MEMBERREPORT"
        Text = "MEMBERREPORT"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
End Class
