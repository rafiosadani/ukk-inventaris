Imports System.ComponentModel
Imports System.Data.Odbc
Public Class MasterPegawai
    Const DSN = "DSN=inventaris"
    Dim koneksi, koneksi2 As OdbcConnection
    Dim status As String = ""
    Dim id As Integer = 0

    Private Sub MasterPegawai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi = New OdbcConnection(DSN)
        koneksi2 = New OdbcConnection(DSN)
        Awal()
        loaddata()
    End Sub

    Private Sub loaddata()
        DataGridView1.Rows.Clear()
        Dim sql As String = "select * from pegawai"
        Dim cmd As New OdbcCommand With {.CommandText = sql, .Connection = koneksi}
        koneksi.Open()
        Dim dr As OdbcDataReader
        dr = cmd.ExecuteReader
        While dr.Read
            DataGridView1.Rows.Add(dr.Item("nama_pegawai"), dr.Item("nip"), dr.Item("alamat"))
        End While
        DataGridView1.Refresh()
        koneksi.Close()
    End Sub

    Private Sub Awal()
        TxtNama.Enabled = False
        TxtAlamat.Enabled = False
        TxtNIP.Enabled = False
        TxtNama.Text = ""
        TxtNIP.Text = ""
        TxtAlamat.Text = ""
        btntambah.Enabled = True
        btnedit.Enabled = False
        btnhapus.Enabled = False
        btnsimpan.Enabled = False
        btnbatal.Enabled = False
        btnkembali.Enabled = True
    End Sub

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        Awal()
    End Sub

    Private Sub tampilkan()
        TxtNama.Enabled = True
        TxtAlamat.Enabled = True
        TxtNIP.Enabled = True
        txtcari.Enabled = False
        btntambah.Enabled = False
        btnedit.Enabled = False
        btnhapus.Enabled = False
        btnsimpan.Enabled = True
        btnbatal.Enabled = True
        btnkembali.Enabled = False
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        tampilkan()
        status = "Tambah"
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If status = "Tambah" Then
            If TxtNama.Text = "" And TxtNIP.Text = "" And TxtAlamat.Text = "" Then
                Awal()
                MsgBox("Data tidak boleh kosong!", MsgBoxStyle.Critical)
            ElseIf TxtNama.Text = "" Or TxtNIP.Text = "" Or TxtAlamat.Text = "" Then
                Awal()
                MsgBox("Data tidak boleh kosong, pastikan semua file terisi!", MsgBoxStyle.Critical)
            Else
                Dim sql As String = "insert into pegawai values('" + TxtNama.Text + "', '" + TxtNIP.Text + "', '" + TxtAlamat.Text + "')"
                Dim cmd As New OdbcCommand With {.CommandText = sql, .Connection = koneksi}
                koneksi.Open()
                cmd.ExecuteNonQuery()
                koneksi.Close()

                Awal()
                loaddata()
                MsgBox("Data berhasil ditambahkan!", MsgBoxStyle.Information)
            End If
        ElseIf status = "Edit" Then
            If TxtNama.Text = "" And TxtNIP.Text = "" And TxtAlamat.Text = "" Then
                Awal()
                MsgBox("Data tidak boleh kosong!", MsgBoxStyle.Critical)
            ElseIf TxtNama.Text = "" Or TxtNIP.Text = "" Or TxtAlamat.Text = "" Then
                Awal()
                MsgBox("Data tidak boleh kosong, pastikan semua file terisi!", MsgBoxStyle.Critical)
            Else
                Dim sql As String = "update pegawai set nama_pegawai = '" + TxtNama.Text + "', nip = '" + TxtNIP.Text + "', alamat = '" + TxtAlamat.Text + "' where id_pegawai = '" + id.ToString + "'"
                Dim cmd As New OdbcCommand With {.CommandText = sql, .Connection = koneksi}
                koneksi.Open()
                cmd.ExecuteNonQuery()
                koneksi.Close()

                Awal()
                loaddata()
                MsgBox("Data berhasil diedit!", MsgBoxStyle.Information)
            End If
        End If
    End Sub

    Private Sub txtcari_TextChanged(sender As Object, e As EventArgs) Handles txtcari.TextChanged
        DataGridView1.Rows.Clear()
        Dim sql As String = "select * from pegawai where nama_pegawai like '%" + txtcari.Text + "%' or nip like '%" + txtcari.Text + "%' or alamat like '%" + txtcari.Text + "%'"
        Dim cmd As New OdbcCommand With {.CommandText = sql, .Connection = koneksi}
        koneksi.Open()
        Dim dr As OdbcDataReader
        dr = cmd.ExecuteReader
        While dr.Read
            DataGridView1.Rows.Add(dr.Item("nama_pegawai"), dr.Item("nip"), dr.Item("alamat"))
        End While
        DataGridView1.Refresh()
        koneksi.Close()
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        tampilkan()
        status = "Edit"
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        If MsgBox("Apakah anda yakin mau menghapus data ini?", MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            Dim sql As String = "delete from pegawai where id_pegawai = '" + id.ToString + "'"
            Dim cmd As New OdbcCommand With {.CommandText = sql, .Connection = koneksi}
            koneksi.Open()
            cmd.ExecuteNonQuery()
            koneksi.Close()

            Awal()
            loaddata()
            MsgBox("Data berhasil dihapus!", MsgBoxStyle.Information)
        Else
            Exit Sub
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        On Error Resume Next
        btntambah.Enabled = False
        btnedit.Enabled = True
        btnhapus.Enabled = True
        btnsimpan.Enabled = False
        btnbatal.Enabled = True
        btnkembali.Enabled = False

        Dim s As String = "select id_pegawai from pegawai where nama_pegawai = '" + DataGridView1.Rows(e.RowIndex).Cells(0).Value + "'"
        Dim c As New OdbcCommand With {.CommandText = s, .Connection = koneksi}
        koneksi.Open()
        Dim d As OdbcDataReader
        d = c.ExecuteReader
        d.Read()
        If d.HasRows Then
            id = d.Item("id_pegawai")
        End If
        koneksi.Close()

        TxtNama.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        TxtNIP.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        TxtAlamat.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
    End Sub

    Private Sub btnkembali_Click(sender As Object, e As EventArgs) Handles btnkembali.Click
        MasterData.Show()
        Me.Hide()
    End Sub

    Private Sub MasterPegawai_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        MasterData.Show()
        Me.Hide()
    End Sub
End Class