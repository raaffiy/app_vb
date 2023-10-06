Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class forgot
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        conn = New MySqlConnection
        conn.ConnectionString = "server=127.0.0.1;userid=root;password='';database=app_cpp"

        Try
            conn.Open()
            Dim command As New MySqlCommand("SELECT * FROM login WHERE username=@username", conn)
            command.Parameters.AddWithValue("@username", TextBox1.Text.Trim)
            Dim reader As MySqlDataReader = command.ExecuteReader

            If reader.Read Then
                Dim password As String = reader("password").ToString()

                TextBox2.Text = password
            Else
                MsgBox("Error Username !!")
            End If

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
End Class