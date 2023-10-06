<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu
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
        Button1 = New Button()
        Label1 = New Label()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Button6 = New Button()
        Button7 = New Button()
        Button8 = New Button()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(93, 89)
        Button1.Name = "Button1"
        Button1.Size = New Size(166, 85)
        Button1.TabIndex = 0
        Button1.Text = "Jadwal Mata Pelajaran"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Narrow", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(60, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 35)
        Label1.TabIndex = 8
        Label1.Text = "Menu"
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(293, 89)
        Button2.Name = "Button2"
        Button2.Size = New Size(166, 85)
        Button2.TabIndex = 9
        Button2.Text = "Kartu Pelajar Siswa"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Location = New Point(487, 89)
        Button3.Name = "Button3"
        Button3.Size = New Size(166, 85)
        Button3.TabIndex = 10
        Button3.Text = "Kehadiran Siswa"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.Location = New Point(93, 197)
        Button4.Name = "Button4"
        Button4.Size = New Size(166, 85)
        Button4.TabIndex = 11
        Button4.Text = "Calculator"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button5.Location = New Point(293, 197)
        Button5.Name = "Button5"
        Button5.Size = New Size(166, 85)
        Button5.TabIndex = 12
        Button5.Text = "Shoope"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Font = New Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button6.Location = New Point(487, 197)
        Button6.Name = "Button6"
        Button6.Size = New Size(166, 85)
        Button6.TabIndex = 13
        Button6.Text = "Calender"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button7
        ' 
        Button7.Font = New Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button7.Location = New Point(93, 302)
        Button7.Name = "Button7"
        Button7.Size = New Size(166, 85)
        Button7.TabIndex = 14
        Button7.Text = "Game"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button8
        ' 
        Button8.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Button8.Font = New Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button8.ForeColor = SystemColors.ControlLightLight
        Button8.Location = New Point(293, 302)
        Button8.Name = "Button8"
        Button8.Size = New Size(360, 85)
        Button8.TabIndex = 15
        Button8.Text = "Exit"
        Button8.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(17, 21)
        Label2.Name = "Label2"
        Label2.Size = New Size(39, 20)
        Label2.TabIndex = 16
        Label2.Text = "_____"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(150, 22)
        Label3.Name = "Label3"
        Label3.Size = New Size(39, 20)
        Label3.TabIndex = 17
        Label3.Text = "_____"
        ' 
        ' menu
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(737, 426)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button8)
        Controls.Add(Button7)
        Controls.Add(Button6)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Name = "menu"
        Text = "menu"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
