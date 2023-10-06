<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class kartu
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
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        GroupBox1 = New GroupBox()
        TextBox4 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        DataGridView1 = New DataGridView()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        ComboBox1 = New ComboBox()
        Button6 = New Button()
        PictureBox1 = New PictureBox()
        Button7 = New Button()
        GroupBox1.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(318, 89)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 0
        Label1.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(318, 40)
        Label2.Name = "Label2"
        Label2.Size = New Size(43, 20)
        Label2.TabIndex = 1
        Label2.Text = "NISN"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(318, 145)
        Label3.Name = "Label3"
        Label3.Size = New Size(32, 20)
        Label3.TabIndex = 2
        Label3.Text = "TTL"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(636, 36)
        Label4.Name = "Label4"
        Label4.Size = New Size(98, 20)
        Label4.TabIndex = 3
        Label4.Text = "Jenis Kelamin"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(TextBox4)
        GroupBox1.Location = New Point(636, 82)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(291, 118)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        GroupBox1.Text = "Alamat"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(15, 28)
        TextBox4.Multiline = True
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(264, 74)
        TextBox4.TabIndex = 14
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(310, 220)
        Button1.Name = "Button1"
        Button1.Size = New Size(106, 32)
        Button1.TabIndex = 5
        Button1.Text = "Simpan"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(445, 222)
        Button2.Name = "Button2"
        Button2.Size = New Size(106, 32)
        Button2.TabIndex = 6
        Button2.Text = "Ubah"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(578, 222)
        Button3.Name = "Button3"
        Button3.Size = New Size(106, 32)
        Button3.TabIndex = 7
        Button3.Text = "Hapus"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(714, 222)
        Button4.Name = "Button4"
        Button4.Size = New Size(106, 32)
        Button4.TabIndex = 8
        Button4.Text = "Batal"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(841, 222)
        Button5.Name = "Button5"
        Button5.Size = New Size(106, 32)
        Button5.TabIndex = 9
        Button5.Text = "Exit"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(39, 294)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(917, 216)
        DataGridView1.TabIndex = 10
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(403, 37)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(159, 27)
        TextBox1.TabIndex = 11
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(403, 86)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(159, 27)
        TextBox2.TabIndex = 12
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(403, 142)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(159, 27)
        TextBox3.TabIndex = 13
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"L", "P"})
        ComboBox1.Location = New Point(764, 36)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(151, 28)
        ComboBox1.TabIndex = 14
        ' 
        ' Button6
        ' 
        Button6.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button6.Location = New Point(578, 37)
        Button6.Name = "Button6"
        Button6.Size = New Size(35, 29)
        Button6.TabIndex = 15
        Button6.Text = " "
        Button6.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Location = New Point(58, 36)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(217, 197)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 16
        PictureBox1.TabStop = False
        ' 
        ' Button7
        ' 
        Button7.Location = New Point(87, 241)
        Button7.Name = "Button7"
        Button7.Size = New Size(156, 29)
        Button7.TabIndex = 17
        Button7.Text = "Uploud Image"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' kartu
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1001, 539)
        Controls.Add(Button7)
        Controls.Add(PictureBox1)
        Controls.Add(Button6)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(DataGridView1)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(GroupBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "kartu"
        Text = "kartu"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button6 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button7 As Button
End Class
