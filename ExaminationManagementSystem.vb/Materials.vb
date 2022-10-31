Imports System.Data.Odbc
Public Class Materials
    Sub show_database()
        Dim cn As New OdbcConnection
        Dim Da As OdbcDataAdapter
        Dim dt As New DataTable
        cn = New OdbcConnection("dsn=EMS;user=root;pwd=root")
        cn.Open()
        Da = New OdbcDataAdapter("select * from material", cn)
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
            cmd = New OdbcCommand("update material set mcode=' " & TextBox1.Text & " ',mname=' " & TextBox2.Text & " 'Where mcode=' " & TextBox1.Text & " ' ", cn)
            cmd.ExecuteNonQuery()
            MsgBox("Record update Successfully")
        End If
        cn.Close()
        show_database()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cn As New OdbcConnection("dsn=EMS; user=root; pwd=root")
        Dim cmd As New OdbcCommand

        Try

            cn.Open()
            If TextBox1.Text = "" And TextBox2.Text = "" Then
                MsgBox("Fields should not be empty", MsgBoxStyle.Exclamation)
            Else
                cmd = New OdbcCommand("Insert into material values(' " & TextBox1.Text & " ',' " & TextBox2.Text & " ')", cn)
                cmd.ExecuteNonQuery()
                MsgBox("Record Saved Successfully")
            End If
        Catch ex As Exception
            MsgBox("ID already Exists")

        End Try
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
            cmd = New OdbcCommand("delete from material where mcode=' " & TextBox1.Text & " ' ", cn)
            cmd.ExecuteNonQuery()
            MsgBox("Record delete Successfully")
            TextBox1.Clear()
            TextBox2.Clear()
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
            x = InputBox("Enter the material code")
            cn.Open()
            da = New OdbcDataAdapter("select * from material where mcode='  " & x & " '", cn)
            da.Fill(dt)
            TextBox1.Text = dt.Rows(0).Item(0)
            TextBox2.Text = dt.Rows(0).Item(1)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            DataGridView1.DataSource = dt
            MsgBox("INVALID ENTRY", MsgBoxStyle.Critical)
        Finally
            cn.Close()
        End Try
        'show_database()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox1.Focus()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Materials_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        show_database()

    End Sub
End Class