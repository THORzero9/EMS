Imports System.Data.Odbc

Public Class Faculty

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cn As New OdbcConnection("dsn=EMS; user=root; pwd=root")
        Dim cmd As New OdbcCommand

        Try

            cn.Open()
            If TextBox1.Text = "" And TextBox2.Text = "" Then
                MsgBox("Fields should not be empty", MsgBoxStyle.Exclamation)
            Else
                cmd = New OdbcCommand("Insert into faculty values(' " & TextBox1.Text & " ',' " & TextBox2.Text & " ', ' " & ComboBox1.Text & " ',' " & TextBox3.Text & " ',' " & TextBox4.Text & " ',' " & TextBox5.Text & " ' )", cn)
                cmd.ExecuteNonQuery()
                MsgBox("Record Saved Successfully")
            End If
        Catch ex As Exception
            MsgBox("ID already Exists")

        End Try
        cn.Close()
        show_database()
    End Sub
    Sub show_database()
        Dim cn As New OdbcConnection
        Dim Da As OdbcDataAdapter
        Dim dt As New DataTable
        cn = New OdbcConnection("dsn=EMS;user=root;pwd=root")
        cn.Open()
        Da = New OdbcDataAdapter("select * from faculty", cn)
        Da.Fill(dt)
        DataGridView1.DataSource = dt
        cn.Close()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        ComboBox1.Text = String.Empty
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim cn As New OdbcConnection("dsn=EMS; user=root; pwd=root")
        Dim cmd As New OdbcCommand


        cn.Open()
        If TextBox1.Text = "" Then
            MsgBox("Fields should not be empty", MsgBoxStyle.Exclamation)
        Else
            cmd = New OdbcCommand("update faculty set fid=' " & TextBox1.Text & " ',fname=' " & TextBox2.Text & " ', fgender=' " & ComboBox1.Text & " ',femail=' " & TextBox3.Text & " ',fadd=' " & TextBox4.Text & " ',fphn=' " & TextBox5.Text & " ' where fid=' " & TextBox1.Text & " '", cn)
            cmd.ExecuteNonQuery()
            MsgBox("Record update Successfully")
        End If
        cn.Close()
        show_database()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim cn As New OdbcConnection("dsn=EMS; user=root; pwd=root")
        Dim cmd As New OdbcCommand


        cn.Open()
        If TextBox1.Text = "" And TextBox2.Text = "" And TextBox3.Text = "" And ComboBox1.Text = "" And TextBox4.Text = "" And TextBox5.Text = "" Then
            MsgBox("Fields should not be empty", MsgBoxStyle.Exclamation)
        Else
            cmd = New OdbcCommand("delete from faculty where fid=' " & TextBox1.Text & " ' ", cn)
            cmd.ExecuteNonQuery()
            MsgBox("Record delete Successfully")
            TextBox1.Clear()
            TextBox2.Clear()
            ComboBox1.Text = String.Empty
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
        End If
        cn.Close()
        show_database()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim cn As New OdbcConnection("dsn=EMS; user=root; pwd=root")
        Dim da As New OdbcDataAdapter
        Dim dt As New DataTable
        Dim x As Integer
        Try
            TextBox1.Clear()
            x = InputBox("Enter the faculty id")

            cn.Open()
            da = New OdbcDataAdapter("select * from faculty where fid='  " & x & " '", cn)
            da.Fill(dt)
            TextBox1.Text = dt.Rows(0).Item(0)
            TextBox2.Text = dt.Rows(0).Item(1)
            ComboBox1.Text = dt.Rows(0).Item(2)
            TextBox3.Text = dt.Rows(0).Item(3)
            TextBox4.Text = dt.Rows(0).Item(4)
            TextBox5.Text = dt.Rows(0).Item(5)
            DataGridView1.DataSource = dt

        Catch ex As Exception
            MsgBox("INVALID ENTRY", MsgBoxStyle.Critical)
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub Faculty_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        show_database()

    End Sub
End Class