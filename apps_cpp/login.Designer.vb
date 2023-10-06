<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        CheckBox1 = New CheckBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(133, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 21)
        Label1.TabIndex = 0
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(133, 97)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 21)
        Label2.TabIndex = 1
        Label2.Text = "Password"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(293, 50)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 2
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(293, 95)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(125, 27)
        TextBox2.TabIndex = 3
        TextBox2.UseSystemPasswordChar = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(280, 175)
        Button1.Name = "Button1"
        Button1.Size = New Size(103, 43)
        Button1.TabIndex = 4
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(152, 175)
        Button2.Name = "Button2"
        Button2.Size = New Size(103, 43)
        Button2.TabIndex = 5
        Button2.Text = "Back"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(293, 128)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(105, 24)
        CheckBox1.TabIndex = 6
        CheckBox1.Text = "Show/Hide"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(547, 251)
        Controls.Add(CheckBox1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "login"
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents CheckBox1 As CheckBox
End Class
