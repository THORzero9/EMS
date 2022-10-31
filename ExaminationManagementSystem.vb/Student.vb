Imports System.Data.Odbc


Public Class Student

    'Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    'End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cn As New OdbcConnection("dsn=EMS; user=root; pwd=root")
        Dim cmd As New OdbcCommand
        Try

            cn.Open()
            If TextBox1.Text = "" And TextBox2.Text = "" Then
                MsgBox("Fields should not be empty", MsgBoxStyle.Exclamation)
            Else
                cmd = New OdbcCommand("Insert into student values(' " & TextBox1.Text & " ',' " & TextBox2.Text & " ',' " & TextBox3.Text & "', ' " & TextBox6.Text & "',' " & ComboBox2.Text & "',' " & ComboBox3.Text & "',' " & Format(DateTimePicker1.Value, "yyyy-MM-dd") & " ',' " & TextBox4.Text & " ',' " & TextBox5.Text & " ' )", cn)
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
        Da = New OdbcDataAdapter("select * from student", cn)
        Da.Fill(dt)
        DataGridView1.DataSource = dt
        cn.Close()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim cn As New OdbcConnection("dsn=EMS; user=root; pwd=root")
        Dim cmd As New OdbcCommand


        cn.Open()
        If TextBox1.Text = "" Then
            MsgBox("Fields should not be empty", MsgBoxStyle.Exclamation)
        Else
            cmd = New OdbcCommand("update student set sid=' " & TextBox1.Text & " ',sname=' " & TextBox2.Text & " ', fn=' " & TextBox3.Text & " ',mn=' " & TextBox6.Text & " ',quali=' " & ComboBox2.Text & " ',sgen=' " & ComboBox3.Text & " ',sdob =' " & Format(DateTimePicker1.Value, "yyyy-MM-dd") & " ',sphn=' " & TextBox4.Text & " ',sadd=' " & TextBox5.Text & " 'Where sid=' " & TextBox1.Text & " ' ", cn)
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
            cmd = New OdbcCommand("delete from student where sid=' " & TextBox1.Text & " ' ", cn)
            cmd.ExecuteNonQuery()
            MsgBox("Record delete Successfully")
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox6.Clear()
            ComboBox2.Text = String.Empty
            ComboBox3.Text = String.Empty
            TextBox4.Clear()
            TextBox5.Clear()
        End If
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
            TextBox1.Text = dt.Rows(0).Item(0)
            TextBox2.Text = dt.Rows(0).Item(1)
            TextBox3.Text = dt.Rows(0).Item(2)
            TextBox6.Text = dt.Rows(0).Item(3)
            ComboBox2.Text = dt.Rows(0).Item(4)
            ComboBox3.Text = dt.Rows(0).Item(5)
            DateTimePicker1.Value = dt.Rows(0).Item(6)
            TextBox4.Text = dt.Rows(0).Item(7)
            TextBox5.Text = dt.Rows(0).Item(8)

        Catch ex As Exception
            DataGridView1.DataSource = dt
            MsgBox("INVALID ENTRY", MsgBoxStyle.Critical)
        Finally
            cn.Close()
        End Try
        show_database()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox6.Clear()
        ComboBox2.Text = String.Empty
        ComboBox3.Text = String.Empty
        TextBox4.Clear()
        TextBox5.Clear()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()
    End Sub
End Class