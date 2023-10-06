Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Public Class regis
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox3.UseSystemPasswordChar = False
        Else
            TextBox3.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=app_cpp"
        Try
            conn.Open()
            Dim COMMAND As New MySqlCommand("INSERT INTO login (username, password, nama, kelas) VALUES (@username, @password, @nama, @kelas)", conn)
            COMMAND.Parameters.AddWithValue("@username", TextBox1.Text.Trim)
            COMMAND.Parameters.AddWithValue("@password", TextBox3.Text.Trim)
            COMMAND.Parameters.AddWithValue("@nama", TextBox4.Text.Trim)
            COMMAND.Parameters.AddWithValue("@kelas", TextBox5.Text.Trim)
            Dim rowsAffected As Integer = COMMAND.ExecuteNonQuery()

            If rowsAffected > 0 Then
                MessageBox.Show("Data inserted successfully!")
                Me.Hide()
                Form1.Show()
            Else
                MessageBox.Show("Failed to insert data.")
            End If

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
End Class