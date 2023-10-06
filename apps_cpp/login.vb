Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Public Class login
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=app_cpp"
        Try
            conn.Open()
            Dim command As New MySqlCommand("SELECT * FROM login WHERE username=@username AND password=@password", conn)
            command.Parameters.AddWithValue("username", TextBox1.Text.Trim)
            command.Parameters.AddWithValue("password", TextBox2.Text.Trim)
            Dim reader As MySqlDataReader = command.ExecuteReader

            If reader.Read Then
                Dim nama As String = reader("nama").ToString()
                Dim kelas As String = reader("kelas").ToString()

                MessageBox.Show($"Nama: {nama}" & vbCrLf & $"Kelas: {kelas}" & vbCrLf & $"successful login")
                menu.Show()
                Me.Hide()
            Else
                MsgBox("Error Username or Password !!")
            End If

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub
End Class