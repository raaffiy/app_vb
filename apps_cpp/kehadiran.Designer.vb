<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class kehadiran
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
        Button6 = New Button()
        ComboBox1 = New ComboBox()
        TextBox1 = New TextBox()
        DataGridView1 = New DataGridView()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        GroupBox1 = New GroupBox()
        TextBox2 = New TextBox()
        Label4 = New Label()
        Label1 = New Label()
        Label2 = New Label()
        ComboBox2 = New ComboBox()
        MySqlCommand1 = New MySql.Data.MySqlClient.MySqlCommand()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button6
        ' 
        Button6.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button6.Location = New Point(328, 81)
        Button6.Name = "Button6"
        Button6.Size = New Size(35, 29)
        Button6.TabIndex = 31
        Button6.Text = " "
        Button6.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"X TKJ 1", "X TKJ 2", "X TKJ 3", "X TKJ K.I", "X AK 1", "X AK 2", "X AK 3", "X RPL 1", "X RPL 2", "X RPL 3", "X RPL K.I", "X TEI 1", "X TEI 2", "X TEI 3", "X TEI K.I", "X TO 1", "X TO 2", "X TO 3", "X TO K.I", "X TET 1", "X TET 2", "X TET 3", "XI TKJ 1", "XI TKJ 2", "XI TKJ 3", "XI TKJ K.I", "XI AK 1", "XI AK 2", "XI AK 3", "XI RPL 1", "XI RPL 2", "XI RPL 3", "XI RPL K.I", "XI TEI 1", "XI TEI 2", "XI TEI 3", "XI TEI K.I", "XI TO 1", "XI TO 2", "XI TO 3", "XI TO K.I", "XI TET 1", "XI TET 2", "XI TET 3", "XII TKJ 1", "XII TKJ 2", "XII TKJ 3", "XII TKJ K.I", "XII AK 1", "XII AK 2", "XII AK 3", "XII RPL 1", "XII RPL 2", "XII RPL 3", "XII RPL K.I", "XII TEI 1", "XII TEI 2", "XII TEI 3", "XII TEI K.I", "XII TO 1", "XII TO 2", "XII TO 3", "XII TO K.I", "XII TET 1", "XII TET 2", "XII TET 3"})
        ComboBox1.Location = New Point(150, 82)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(163, 28)
        ComboBox1.TabIndex = 30
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(150, 40)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(163, 27)
        TextBox1.TabIndex = 28
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(49, 256)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(656, 210)
        DataGridView1.TabIndex = 26
        ' 
        ' Button5
        ' 
        Button5.Location = New Point(589, 194)
        Button5.Name = "Button5"
        Button5.Size = New Size(106, 32)
        Button5.TabIndex = 25
        Button5.Text = "Exit"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(462, 194)
        Button4.Name = "Button4"
        Button4.Size = New Size(106, 32)
        Button4.TabIndex = 24
        Button4.Text = "Batal"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(326, 194)
        Button3.Name = "Button3"
        Button3.Size = New Size(106, 32)
        Button3.TabIndex = 23
        Button3.Text = "Hapus"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(193, 194)
        Button2.Name = "Button2"
        Button2.Size = New Size(106, 32)
        Button2.TabIndex = 22
        Button2.Text = "Ubah"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(58, 192)
        Button1.Name = "Button1"
        Button1.Size = New Size(106, 32)
        Button1.TabIndex = 21
        Button1.Text = "Simpan"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Location = New Point(393, 40)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(291, 118)
        GroupBox1.TabIndex = 20
        GroupBox1.TabStop = False
        GroupBox1.Text = "Keterangan"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(15, 28)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(264, 74)
        TextBox2.TabIndex = 14
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(62, 85)
        Label4.Name = "Label4"
        Label4.Size = New Size(44, 20)
        Label4.TabIndex = 19
        Label4.Text = "Kelas"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(62, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 16
        Label1.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(62, 128)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 20)
        Label2.TabIndex = 32
        Label2.Text = "Kehadiran"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"Hadir", "Izin", "Sakit", "Alpha"})
        ComboBox2.Location = New Point(150, 125)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(163, 28)
        ComboBox2.TabIndex = 33
        ' 
        ' MySqlCommand1
        ' 
        MySqlCommand1.CacheAge = 0
        MySqlCommand1.Connection = Nothing
        MySqlCommand1.EnableCaching = False
        MySqlCommand1.Transaction = Nothing
        ' 
        ' kehadiran
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(755, 499)
        Controls.Add(ComboBox2)
        Controls.Add(Label2)
        Controls.Add(Button6)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox1)
        Controls.Add(DataGridView1)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(GroupBox1)
        Controls.Add(Label4)
        Controls.Add(Label1)
        Name = "kehadiran"
        Text = "kehadiran"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button6 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents MySqlCommand1 As MySql.Data.MySqlClient.MySqlCommand
End Class
