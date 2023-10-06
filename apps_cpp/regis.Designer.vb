<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class regis
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
        CheckBox1 = New CheckBox()
        TextBox1 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        Button2 = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(45, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 21)
        Label1.TabIndex = 0
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(45, 85)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 21)
        Label2.TabIndex = 1
        Label2.Text = "Password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(45, 164)
        Label3.Name = "Label3"
        Label3.Size = New Size(57, 21)
        Label3.TabIndex = 2
        Label3.Text = "Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(45, 201)
        Label4.Name = "Label4"
        Label4.Size = New Size(55, 21)
        Label4.TabIndex = 3
        Label4.Text = "Class"
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(164, 116)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(105, 24)
        CheckBox1.TabIndex = 4
        CheckBox1.Text = "Show/Hide"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(164, 43)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(137, 27)
        TextBox1.TabIndex = 5
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(164, 83)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(137, 27)
        TextBox3.TabIndex = 7
        TextBox3.UseSystemPasswordChar = True
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(164, 162)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(137, 27)
        TextBox4.TabIndex = 8
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(164, 202)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(137, 27)
        TextBox5.TabIndex = 9
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(352, 210)
        Button2.Name = "Button2"
        Button2.Size = New Size(114, 36)
        Button2.TabIndex = 11
        Button2.Text = "Back"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Location = New Point(352, 164)
        Button3.Name = "Button3"
        Button3.Size = New Size(114, 36)
        Button3.TabIndex = 12
        Button3.Text = "Register"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' regis
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(501, 276)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox1)
        Controls.Add(CheckBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "regis"
        Text = "Registration"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
