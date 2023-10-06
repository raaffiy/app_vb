Imports MySql.Data.MySqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class kehadiran
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim dt As New DataTable
    Dim da As New MySqlDataAdapter

    Sub kosong()
        TextBox1.Clear()
        TextBox2.Clear()
        ComboBox1.Text = ""
        ComboBox2.Text = ""
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
            conn = New MySqlConnection("server=127.0.0.1;userid=root;password='';database=app_cpp")
            conn.Open()
            Dim query As String
            query = "insert into kehadiran(nama, kelas, kehadiran, keterangan)values(@nama, @kelas, @kehadiran, @keterangan)"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@nama", TextBox1.Text)
            cmd.Parameters.AddWithValue("@kelas", ComboBox1.Text)
            cmd.Parameters.AddWithValue("@kehadiran", ComboBox2.Text)
            cmd.Parameters.AddWithValue("@keterangan", TextBox2.Text)
            cmd.ExecuteNonQuery()
            MsgBox("Successfully Save to Database", MsgBoxStyle.Information, "Success")
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
            cmd.CommandText = "select * from kehadiran"
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
            conn = New MySqlConnection("server=127.0.0.1;userid=root;password='';database=app_cpp")
            conn.Open()
            Dim query As String
            query = "UPDATE kehadiran SET kelas=@kelas, kehadiran=@kehadiran, keterangan=@keterangan WHERE nama=@nama"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@nama", TextBox1.Text)
            cmd.Parameters.AddWithValue("@kelas", ComboBox1.Text)
            cmd.Parameters.AddWithValue("@kehadiran", ComboBox2.Text)
            cmd.Parameters.AddWithValue("@keterangan", TextBox2.Text)
            cmd.ExecuteNonQuery()
            MsgBox("Data Updated Successfully", MsgBoxStyle.Information, "Success")
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
                query = "DELETE FROM kehadiran WHERE nama=@nama"
                cmd = New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@nama", TextBox1.Text)
                cmd.ExecuteNonQuery()
                MsgBox("Data Deleted Successfully", MsgBoxStyle.Information, "Success")
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
            query = "SELECT * FROM kehadiran WHERE kelas=@kelas"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@kelas", ComboBox1.Text)

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

End Class