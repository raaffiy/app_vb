Imports MySql.Data.MySqlClient

Public Class mapel

    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim dt As New DataTable
    Dim da As New MySqlDataAdapter

    Sub kosong()
        TextBox1.Clear()
        ComboBox1.Text = ""
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
        TextBox11.Clear()
        TextBox12.Clear()
        TextBox13.Clear()
        TextBox1.Focus()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
        menu.Show()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Call kosong()
    End Sub

    Private Sub mapel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadData()
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label5)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label14)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label6)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label7)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label42)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label9)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label10)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label43)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label12)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label13)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label44)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label16)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label17)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label18)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label40)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label19)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label38)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label8)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label22)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label20)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label21)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label41)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label25)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label23)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label11)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label28)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label26)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label15)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label31)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label29)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label27)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label34)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label32)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label24)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label37)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label35)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label36)
    End Sub

    Sub loadData()
        Try
            conn = New MySqlConnection("server=127.0.0.1;userid=root;password='';database=app_cpp")
            conn.Open()
            cmd = New MySqlCommand()
            cmd.Connection = conn
            cmd.CommandText = "select * from mapel"
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            conn = New MySqlConnection("server=127.0.0.1;userid=root;password='';database=app_cpp")
            conn.Open()
            Dim query As String
            query = "insert into mapel(hari, kelas, satu, dua, tiga, empat, lima, enam, tujuh, delapan, sembilan, sepuluh, sebelas, duabelas)
                        values(@hari, @kelas, @satu, @dua, @tiga, @empat, @lima, @enam, @tujuh, @delapan, @sembilan, @sepuluh, @sebelas, @duabelas)"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@hari", TextBox1.Text)
            cmd.Parameters.AddWithValue("@kelas", ComboBox1.Text)
            cmd.Parameters.AddWithValue("@satu", TextBox2.Text)
            cmd.Parameters.AddWithValue("@dua", TextBox3.Text)
            cmd.Parameters.AddWithValue("@tiga", TextBox4.Text)
            cmd.Parameters.AddWithValue("@empat", TextBox5.Text)
            cmd.Parameters.AddWithValue("@lima", TextBox6.Text)
            cmd.Parameters.AddWithValue("@enam", TextBox7.Text)
            cmd.Parameters.AddWithValue("@tujuh", TextBox8.Text)
            cmd.Parameters.AddWithValue("@delapan", TextBox9.Text)
            cmd.Parameters.AddWithValue("@sembilan", TextBox10.Text)
            cmd.Parameters.AddWithValue("@sepuluh", TextBox11.Text)
            cmd.Parameters.AddWithValue("@sebelas", TextBox12.Text)
            cmd.Parameters.AddWithValue("@duabelas", TextBox13.Text)
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            conn = New MySqlConnection("server=127.0.0.1;userid=root;password='';database=app_cpp")
            conn.Open()
            Dim query As String
            query = "UPDATE mapel SET hari=@hari, satu=@satu, dua=@dua, tiga=@tiga, empat=@empat, lima=@lima, enam=@enam, 
                    tujuh=@tujuh, delapan=@delapan, sembilan=@sembilan, sepuluh=@sepuluh, sebelas=@sebelas, duabelas=@duabelas WHERE kelas=@kelas"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@hari", TextBox1.Text)
            cmd.Parameters.AddWithValue("@kelas", ComboBox1.Text)
            cmd.Parameters.AddWithValue("@satu", TextBox2.Text)
            cmd.Parameters.AddWithValue("@dua", TextBox3.Text)
            cmd.Parameters.AddWithValue("@tiga", TextBox4.Text)
            cmd.Parameters.AddWithValue("@empat", TextBox5.Text)
            cmd.Parameters.AddWithValue("@lima", TextBox6.Text)
            cmd.Parameters.AddWithValue("@enam", TextBox7.Text)
            cmd.Parameters.AddWithValue("@tujuh", TextBox8.Text)
            cmd.Parameters.AddWithValue("@delapan", TextBox9.Text)
            cmd.Parameters.AddWithValue("@sembilan", TextBox10.Text)
            cmd.Parameters.AddWithValue("@sepuluh", TextBox11.Text)
            cmd.Parameters.AddWithValue("@sebelas", TextBox12.Text)
            cmd.Parameters.AddWithValue("@duabelas", TextBox13.Text)
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
                query = "DELETE FROM mapel WHERE kelas=@kelas"
                cmd = New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@kelas", ComboBox1.Text)
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
            query = "SELECT * FROM mapel WHERE kelas=@kelas"
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