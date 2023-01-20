Imports System.Data.Odbc
Public Class FormLogin
    Const DSN = "DSN=inventaris"
    Dim koneksi, koneksi2 As OdbcConnection

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi = New OdbcConnection(DSN)
        koneksi2 = New OdbcConnection(DSN)
        Awal()
        TextBox2.UseSystemPasswordChar = True
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = False Then
            TextBox2.UseSystemPasswordChar = True
        ElseIf CheckBox1.Checked = True Then
            TextBox2.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" And TextBox2.Text = "" Then
            Awal()
            MsgBox("Data tidak boleh kosong!", MsgBoxStyle.Critical)
        ElseIf TextBox1.Text = "" Or TextBox2.Text = "" Then
            Awal()
            MsgBox("Data tidak boleh kosong, pastikan semua form terisi!", MsgBoxStyle.Critical)
        Else
            Dim sql As String = "select * from petugas where username = '" + TextBox1.Text + "' and password = '" + TextBox2.Text + "'"
            Dim cmd As New OdbcCommand With {.CommandText = sql, .Connection = koneksi}
            koneksi.Open()
            Dim dr As OdbcDataReader
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                Select Case dr.Item("id_level")
                    Case 1
                        My.Settings.petugasid = dr.Item("id_petugas")
                        My.Settings.id_level = dr.Item("id_level")
                        My.Settings.nama = dr.Item("nama_petugas")
                        AdminNav.Label1.Text = "Welcome, " + My.Settings.nama
                        AdminNav.Show()
                        Me.Hide()
                        Awal()
                        MsgBox("Anda berhasil login!", MsgBoxStyle.Information)
                    Case 2
                        My.Settings.petugasid = dr.Item("id_petugas")
                        My.Settings.id_level = dr.Item("id_level")
                        My.Settings.nama = dr.Item("nama_petugas")
                        OperatorNav.Label1.Text = "Welcome, " + My.Settings.nama
                        OperatorNav.Show()
                        Me.Hide()
                        Awal()
                        MsgBox("Anda berhasil login!", MsgBoxStyle.Information)
                    Case 3
                        My.Settings.petugasid = dr.Item("id_petugas")
                        My.Settings.id_level = dr.Item("id_level")
                        My.Settings.nama = dr.Item("nama_petugas")
                        PeminjamNav.Label1.Text = "Welcome, " + My.Settings.nama
                        PeminjamNav.Show()
                        Me.Hide()
                        Awal()
                        MsgBox("Anda berhasil login!", MsgBoxStyle.Information)
                End Select
            Else
                MsgBox("Username / password salah!", MsgBoxStyle.Critical)
            End If
            koneksi.Close()
        End If
    End Sub

    Private Sub Awal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        CheckBox1.Checked = False
    End Sub
End Class
