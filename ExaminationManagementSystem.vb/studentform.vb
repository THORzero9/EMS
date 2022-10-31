Imports System.Data.Odbc


Public Class studentform
    Sub show_database()
        Dim cn As New OdbcConnection
        Dim Da As OdbcDataAdapter
        Dim dt As New DataTable
        cn = New OdbcConnection("dsn=EMS;user=root;pwd=root")
        cn.Open()
        Da = New OdbcDataAdapter("select * from student", cn)
        Da.Fill(dt)
        DataGridView1.DataSource = dt
        cn.Close()
    End Sub
    'Sub student_display()
    '    Dim cn As New OdbcConnection("dsn=EMS; user=root; pwd=root")
    '    Dim cmd As New OdbcCommand
    '    cn.Open()
    '    cmd = New OdbcCommand("select sid from student", cn)
    '    Dim dr As OdbcDataReader = cmd.ExecuteReader
    '    While dr.Read
    '        'TextBox13.Text.(dr(0))
    '    End While
    '    dr.Close()
    '    cn.Close()
    'End Sub

    Sub seat_show()
        Dim cn As New OdbcConnection("dsn=EMS; user=root; pwd=root")
        Dim cmd As New OdbcCommand
        cn.Open()
        cmd = New OdbcCommand("select sroom from seat", cn)
        Dim dr As OdbcDataReader = cmd.ExecuteReader
        While dr.Read
            ComboBox5.Items.Add(dr(0))
        End While
        dr.Close()
        cn.Close()
        ' Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub
    Sub exam_display()
        Dim cn As New OdbcConnection("dsn=EMS; user=root; pwd=root")
        Dim cmd As New OdbcCommand
        cn.Open()
        cmd = New OdbcCommand("select ecode from exam", cn)
        Dim dr As OdbcDataReader = cmd.ExecuteReader
        While dr.Read
            ComboBox4.Items.Add(dr(0))
        End While
        dr.Close()
        cn.Close()
        'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim cn As New OdbcConnection("dsn=EMS; user=root; pwd=root")
        Dim cmd As New OdbcCommand
        cn.Open()
        cmd = New OdbcCommand("select  sid,sname,fn,mn,quali,sgen,sdob,sphn,sadd from student where sid=' " & TextBox13.Text & " '", cn)
        Dim dr As OdbcDataReader = cmd.ExecuteReader
        While dr.Read
            TextBox10.Text = dr(0)
            TextBox1.Text = dr(1)
            TextBox2.Text = dr(2)
            ComboBox1.Text = dr(3)
            ComboBox2.Text = dr(4)
            DateTimePicker1.Value = dr(5)
            TextBox3.Text = dr(6)
            TextBox4.Text = dr(7)
        End While
        dr.Close()
        cn.Close()
    End Sub

    Private Sub studentform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'student_display()
        show_database()
        TextBox13.Focus()
        seat_show()
        exam_display()


    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox5.SelectedIndexChanged
        Dim cn As New OdbcConnection("dsn=EMS; user=root; pwd=root")
        Dim cmd As New OdbcCommand
        cn.Open()
        cmd = New OdbcCommand("select  slocation,sfloor from seat where sroom =' " & ComboBox5.Text & " '", cn)
        Dim dr As OdbcDataReader = cmd.ExecuteReader
        While dr.Read
            TextBox5.Text = dr(0)
            TextBox6.Text = dr(1)
        End While
        dr.Close()
        cn.Close()
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged
        Dim cn As New OdbcConnection("dsn=EMS; user=root; pwd=root")
        Dim cmd As New OdbcCommand
        cn.Open()
        cmd = New OdbcCommand("select  ename,etype,epaper,eadd from exam where ecode =' " & ComboBox4.Text & " '", cn)
        Dim dr As OdbcDataReader = cmd.ExecuteReader
        While dr.Read
            TextBox7.Text = dr(0)
            TextBox8.Text = dr(1)
            TextBox9.Text = dr(2)
            TextBox14.Text = dr(3)
        End While
        dr.Close()
        cn.Close()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cn As New OdbcConnection("dsn=EMS; user=root; pwd=root")
        Dim cmd As New OdbcCommand
        Try

            cn.Open()
            If TextBox13.Text = "" And TextBox2.Text = "" Then
                MsgBox("Fields should not be empty", MsgBoxStyle.Exclamation)
            Else
                cmd = New OdbcCommand("Insert into student values ( ' " & TextBox13.Text & " ',' " & TextBox10.Text & " ',' " & TextBox1.Text & " ',' " & TextBox2.Text & "', ' " & ComboBox1.Text & "',' " & ComboBox2.Text & " ',' " & Format(DateTimePicker1.Value, "yyyy-MM-dd") & " ',' " & TextBox3.Text & "',' " & TextBox4.Text & " ','" & ComboBox5.SelectedItem & " ',' " & TextBox5.Text & " ',' " & TextBox6.Text & " ','" & ComboBox4.SelectedItem & " ',' " & TextBox7.Text & " ',' " & TextBox8.Text & " ',' " & TextBox9.Text & " ',' " & TextBox14.Text & " ')", cn)
                cmd.ExecuteNonQuery()
                MsgBox("Record Saved Successfully")
            End If
        Catch ex As Exception
            MsgBox("ID already Exists")

        End Try
        cn.Close()
        show_database()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim cn As New OdbcConnection("dsn=EMS; user=root; pwd=root")
        Dim da As New OdbcDataAdapter
        Dim dt As New DataTable
        Dim x As Integer
        Try
            TextBox1.Clear()
            x = InputBox("Enter the student id")

            cn.Open()
            da = New OdbcDataAdapter("select * from student where sid='  " & x & " '", cn)
            da.Fill(dt)
            TextBox13.Text = dt.Rows(0).Item(0)
            TextBox10.Text = dt.Rows(0).Item(1)
            TextBox1.Text = dt.Rows(0).Item(2)
            TextBox2.Text = dt.Rows(0).Item(3)
            ComboBox1.Text = dt.Rows(0).Item(4)
            ComboBox2.Text = dt.Rows(0).Item(5)
            DateTimePicker1.Value = dt.Rows(0).Item(6)
            TextBox3.Text = dt.Rows(0).Item(7)
            TextBox4.Text = dt.Rows(0).Item(8)
            ComboBox5.Text = dt.Rows(0).Item(9)
            TextBox5.Text = dt.Rows(0).Item(10)
            TextBox6.Text = dt.Rows(0).Item(11)
            ComboBox4.Text = dt.Rows(0).Item(12)
            TextBox7.Text = dt.Rows(0).Item(13)
            TextBox8.Text = dt.Rows(0).Item(14)
            TextBox9.Text = dt.Rows(0).Item(15)
            TextBox14.Text = dt.Rows(0).Item(16)

        Catch ex As Exception
            DataGridView1.DataSource = dt
            MsgBox("INVALID ENTRY", MsgBoxStyle.Critical)
        Finally
            cn.Close()
        End Try
        show_database()
    End Sub

    'Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    
    'End Sub

    'Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    
    'End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        TextBox13.Clear()
        TextBox10.Clear()
        TextBox1.Clear()
        TextBox2.Clear()
        ComboBox1.Text = String.Empty
        ComboBox2.Text = String.Empty
        TextBox3.Clear()
        TextBox4.Clear()
        ComboBox5.Text = String.Empty
        TextBox5.Clear()
        TextBox6.Clear()
        ComboBox4.Text = String.Empty
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox14.Clear()
    End Sub

    'Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    
    'End Sub

    'Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

    'End Sub

    Private Sub TextBox13_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox13.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Dim cn As New OdbcConnection("dsn=EMS; user=root; pwd=root")
        'Dim cmd As New OdbcCommand


        'cn.Open()
        'If TextBox1.Text = "" And TextBox2.Text = "" Then
        '    MsgBox("Fields should not be empty", MsgBoxStyle.Exclamation)
        'Else
        '    cmd = New OdbcCommand("update from student where sid=' " & TextBox1.Text & " ' ", cn)
        '    cmd.ExecuteNonQuery()
        '    MsgBox("Record updated Successfully")
        '    ComboBox1.Text = String.Empty
        '    TextBox10.Clear()
        '    TextBox1.Clear()
        '    TextBox2.Clear()
        '    ComboBox1.Text = String.Empty
        '    ComboBox2.Text = String.Empty
        '    TextBox3.Clear()
        '    TextBox4.Clear()
        '    ComboBox5.Text = String.Empty
        '    TextBox5.Clear()
        '    TextBox6.Clear()
        '    ComboBox4.Text = String.Empty
        '    TextBox7.Clear()
        '    TextBox8.Clear()
        '    TextBox9.Clear()
        '    TextBox14.Clear()

        'End If
        'cn.Close()
        'show_database()
        Dim cn As New OdbcConnection("dsn=EMS; user=root; pwd=root")
        Dim cmd As New OdbcCommand


        cn.Open()
        If TextBox1.Text = "" Then
            MsgBox("Fields should not be empty", MsgBoxStyle.Exclamation)
        Else
            cmd = New OdbcCommand("update student set sid=' " & TextBox13.Text & " ',sname=' " & TextBox10.Text & " ', fn=' " & TextBox1.Text & " ',mn=' " & TextBox2.Text & " ',quali=' " & ComboBox1.Text & "  ',sgen=' " & ComboBox2.Text & " ',sdob=' " & Format(DateTimePicker1.Value, "yyyy-MM-dd") & " ',sphn=' " & TextBox3.Text & " ',sadd=' " & TextBox4.Text & " ',sroom=' " & ComboBox5.Text & " ',slocation=' " & TextBox5.Text & " ',sfloor=' " & TextBox6.Text & " ',ecode=' " & ComboBox4.Text & " ',ename=' " & TextBox7.Text & " ',etype=' " & TextBox8.Text & " ',epaper=' " & TextBox9.Text & " ',eadd=' " & TextBox14.Text & " 'Where sid='" & TextBox13.Text & "'", cn)
            cmd.ExecuteNonQuery()
            MsgBox("Record update Successfully")
        End If
        cn.Close()
        show_database()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim cn As New OdbcConnection("dsn=EMS; user=root; pwd=root")
        Dim cmd As New OdbcCommand


        cn.Open()
        If TextBox1.Text = "" And TextBox2.Text = "" Then
            MsgBox("Fields should not be empty", MsgBoxStyle.Exclamation)
        Else
            cmd = New OdbcCommand("delete from student where sid=' " & TextBox13.Text & " ' ", cn)
            cmd.ExecuteNonQuery()
            MsgBox("Record delete Successfully")
            ComboBox1.Text = String.Empty
            TextBox10.Clear()
            TextBox1.Clear()
            TextBox2.Clear()
            ComboBox1.Text = String.Empty
            ComboBox2.Text = String.Empty
            TextBox3.Clear()
            TextBox4.Clear()
            ComboBox5.Text = String.Empty
            TextBox5.Clear()
            TextBox6.Clear()
            ComboBox4.Text = String.Empty
            TextBox7.Clear()
            TextBox8.Clear()
            TextBox9.Clear()
            TextBox14.Clear()

        End If
        cn.Close()
        show_database()
    End Sub
End Class