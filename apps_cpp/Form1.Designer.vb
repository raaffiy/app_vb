﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(220, 88)
        Label1.Name = "Label1"
        Label1.Size = New Size(337, 27)
        Label1.TabIndex = 0
        Label1.Text = "SMK NEGERI 2 KOTA BEKASI"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(140, 118)
        Label2.Name = "Label2"
        Label2.Size = New Size(505, 22)
        Label2.TabIndex = 1
        Label2.Text = "UNGGUL BERKARAKTER DAN BERWAWASAN GLOBAL"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(184, 187)
        Button1.Name = "Button1"
        Button1.Size = New Size(147, 57)
        Button1.TabIndex = 2
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(443, 187)
        Button2.Name = "Button2"
        Button2.Size = New Size(147, 57)
        Button2.TabIndex = 3
        Button2.Text = "Register"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Location = New Point(184, 271)
        Button3.Name = "Button3"
        Button3.Size = New Size(147, 57)
        Button3.TabIndex = 4
        Button3.Text = "Find Password"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.Location = New Point(443, 271)
        Button4.Name = "Button4"
        Button4.Size = New Size(147, 57)
        Button4.TabIndex = 5
        Button4.Text = "Exit"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Apps_cpp"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
