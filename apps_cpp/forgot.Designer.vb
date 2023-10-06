<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class forgot
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
        TextBox1 = New TextBox()
        Button2 = New Button()
        Label2 = New Label()
        TextBox2 = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(139, 57)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 21)
        Label1.TabIndex = 0
        Label1.Text = "Username"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(262, 55)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(158, 27)
        TextBox1.TabIndex = 1
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(295, 118)
        Button2.Name = "Button2"
        Button2.Size = New Size(105, 38)
        Button2.TabIndex = 3
        Button2.Text = "Find"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(117, 189)
        Label2.Name = "Label2"
        Label2.Size = New Size(130, 21)
        Label2.TabIndex = 4
        Label2.Text = "Your Password"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(278, 187)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(158, 27)
        TextBox2.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Arial Narrow", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(155, 118)
        Button1.Name = "Button1"
        Button1.Size = New Size(105, 38)
        Button1.TabIndex = 6
        Button1.Text = "Back"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' forgot
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(558, 268)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(Label2)
        Controls.Add(Button2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Name = "forgot"
        Text = "Find"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
End Class
