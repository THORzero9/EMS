Imports System.Data.Odbc

Public Class Result
    Sub show_database()
        Dim cn As New OdbcConnection
        Dim Da As OdbcDataAdapter
        Dim dt As New DataTable
        cn = New OdbcConnection("dsn=EMS;user=root;pwd=root")
        cn.Open()
        Da = New OdbcDataAdapter("select * from result", cn)
        Da.Fill(dt)
        DataGridView1.DataSource = dt
        cn.Close()
    End Sub
    Sub stu_display()
        Dim cn As New OdbcConnection("dsn=EMS; user=root; pwd=root")
        Dim cmd As New OdbcCommand
        cn.Open()
        cmd = New OdbcCommand("select sid from student", cn)
        Dim dr As OdbcDataReader = cmd.ExecuteReader
        While dr.Read
            ComboBox1.Items.Add(dr(0))
        End While
        dr.Close()
        cn.Close()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cn As New OdbcConnection("dsn=EMS; user=root; pwd=root")
        Dim cmd As New OdbcCommand
        Try

            cn.Open()
            If ComboBox1.Text = "" And TextBox2.Text = "" Then
                MsgBox("Fields should not be empty", MsgBoxStyle.Exclamation)
            Else
                cmd = New OdbcCommand("Insert into result values  (' " & ComboBox1.Text & " ',' " & TextBox1.Text & " ',' " & TextBox2.Text & " ',' " & TextBox3.Text & " ',' " & TextBox4.Text & " ')", cn)
                cmd.ExecuteNonQuery()
                MsgBox("Record Saved Successfully")
            End If
        Catch ex As Exception
            MsgBox("ID already Exists")

        End Try
        cn.Close()
        show_database()
    End Sub

    Private Sub Result_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        show_database()
        stu_display()


    End Sub

    'Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)



    'End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim cn As New OdbcConnection("dsn=EMS; user=root; pwd=root")
        Dim cmd As New OdbcCommand


        cn.Open()
        If TextBox1.Text = "" Then
            MsgBox("Fields should not be empty", MsgBoxStyle.Exclamation)
        Else
            cmd = New OdbcCommand("update result set sid=' " & ComboBox1.Text & " ',sname=' " & TextBox1.Text & " ',ecode =' " & TextBox2.Text & " ',ename=' " & TextBox3.Text & " ',per=' " & TextBox4.Text & "  'where sid='" & ComboBox1.Text & " ' ", cn)
            cmd.ExecuteNonQuery()
            MsgBox("Record update Successfully")
        End If
        cn.Close()
        show_database()
    End Sub

    'Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
    '    Dim cn As New OdbcConnection("dsn=EMS; user=root; pwd=root")
    '    Dim da As New OdbcDataAdapter
    '    Dim dt As New DataTable
    '    Dim x As Integer
    '    'Try
    '    TextBox1.Clear()
    '    x = InputBox("Enter the student id")

    '    cn.Open()
    '    da = New OdbcDataAdapter("select * from result where sid='  " & x & " '", cn)
    '    da.Fill(dt)
    '    ComboBox1.Text = dt.Rows(0).Item(0)
    '    TextBox1.Text = dt.Rows(0).Item(1)
    '    TextBox2.Text = dt.Rows(0).Item(2)
    '    TextBox3.Text = dt.Rows(0).Item(3)
    '    TextBox4.Text = dt.Rows(0).Item(4)

    '    'Catch ex As Exception
    '    DataGridView1.DataSource = dt
    '    MsgBox("INVALID ENTRY", MsgBoxStyle.Critical)
    '    'Finally
    '    cn.Close()
    '    'End Try
    '    show_database()
    'End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim cn As New OdbcConnection
        Dim cmd As New OdbcCommand
        cn = New OdbcConnection("dsn=EMS;user=root;pwd=root") 'connection string
        cn.Open()
        cmd = New OdbcCommand("select * from student where sid=' " & ComboBox1.Text & " '", cn)
        Dim dr As OdbcDataReader = cmd.ExecuteReader

        While dr.Read
            TextBox1.Text = dr(1).ToString
            TextBox2.Text = dr(12).ToString
            TextBox3.Text = dr(13).ToString

        End While
        dr.Close()
        cn.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        ComboBox1.Text = String.Empty
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class