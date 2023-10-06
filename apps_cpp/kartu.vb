Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Public Class kartu
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim dt As New DataTable
    Dim da As New MySqlDataAdapter
    Dim dr As MySqlDataReader
    Dim a As OpenFileDialog = New OpenFileDialog

    Sub kosong()
        PictureBox1.Image = Nothing
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        ComboBox1.Text = ""
        TextBox4.Clear()
        TextBox1.Focus()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
        menu.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call kosong()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim mstream As New System.IO.MemoryStream()
            PictureBox1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim arrImage() As Byte = mstream.GetBuffer
            mstream.Close()

            conn = New MySqlConnection("server=127.0.0.1;userid=root;password='';database=app_cpp")
            conn.Open()
            Dim query As String
            query = "insert into kartu(image, nisn, nama, lahir, kelamin, alamat)values(@image, @nisn, @nama, @lahir, @kelamin, @alamat)"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@image", arrImage)
            cmd.Parameters.AddWithValue("@nisn", TextBox1.Text)
            cmd.Parameters.AddWithValue("@nama", TextBox2.Text)
            cmd.Parameters.AddWithValue("@lahir", TextBox3.Text)
            cmd.Parameters.AddWithValue("@kelamin", ComboBox1.Text)
            cmd.Parameters.AddWithValue("@alamat", TextBox4.Text)
            cmd.ExecuteNonQuery()
            MsgBox("Successfully Save to Database", MsgBoxStyle.Information, "Success")
            PictureBox1.Image = Nothing
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
        loadData()
        kosong()
    End Sub

    Sub loadData()
        Try
            conn = New MySqlConnection("server=127.0.0.1;userid=root;password='';database=app_cpp")
            conn.Open()
            cmd = New MySqlCommand()
            cmd.Connection = conn
            cmd.CommandText = "select * from kartu"
            da.SelectCommand = cmd
            dt.Clear()
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim mstream As New System.IO.MemoryStream()
            PictureBox1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim arrImage() As Byte = mstream.GetBuffer()
            mstream.Close()

            conn = New MySqlConnection("server=127.0.0.1;userid=root;password='';database=app_cpp")
            conn.Open()
            Dim query As String = "UPDATE kartu SET image=@image, nama=@nama, lahir=@lahir, kelamin=@kelamin, alamat=@alamat WHERE nisn=@nisn"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@image", arrImage)
            cmd.Parameters.AddWithValue("@nisn", TextBox1.Text)
            cmd.Parameters.AddWithValue("@nama", TextBox2.Text)
            cmd.Parameters.AddWithValue("@lahir", TextBox3.Text)
            cmd.Parameters.AddWithValue("@kelamin", ComboBox1.Text)
            cmd.Parameters.AddWithValue("@alamat", TextBox4.Text)

            cmd.ExecuteNonQuery()
            MsgBox("Data Updated Successfully", MsgBoxStyle.Information, "Success")
            PictureBox1.Image = Nothing

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
        loadData()
        kosong()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            Try
                conn = New MySqlConnection("server=127.0.0.1;userid=root;password='';database=app_cpp")
                conn.Open()
                Dim query As String
                query = "DELETE FROM kartu WHERE nisn=@nisn"
                cmd = New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@nisn", TextBox1.Text)
                cmd.ExecuteNonQuery()
                MsgBox("Data Deleted Successfully", MsgBoxStyle.Information, "Success")
                PictureBox1.Image = Nothing
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                If conn.State = ConnectionState.Open Then
                    conn.Close()
                End If
            End Try
            loadData()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            conn = New MySqlConnection("server=127.0.0.1;userid=root;password='';database=app_cpp")
            conn.Open()
            Dim query As String
            query = "SELECT * FROM kartu WHERE nisn=@nisn"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@nisn", TextBox1.Text)

            da.SelectCommand = cmd
            dt.Clear()
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                DataGridView1.DataSource = dt
            Else
                MsgBox("Data not found", MsgBoxStyle.Information, "Not Found")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Try
            a.Filter = "JPEG(*.jpg;*.jpeg)|*.jpg|PNG(*.png)|*.png"
            If a.ShowDialog() = Windows.Forms.DialogResult.OK Then
                PictureBox1.Image = Image.FromFile(a.FileName)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class