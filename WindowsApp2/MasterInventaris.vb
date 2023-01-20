Imports System.ComponentModel
Imports System.Data.Odbc
Public Class MasterInventaris
    Const DSN = "DSN=inventaris"
    Dim koneksi, koneksi2 As OdbcConnection
    Dim status As String = ""
    Dim id As Integer = 0

    Private Sub MasterInventaris_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi = New OdbcConnection(DSN)
        koneksi2 = New OdbcConnection(DSN)
        Awal()
        kode()
        jenis()
        ruang()
        loaddata()
    End Sub

    Private Sub jenis()
        koneksi.Open()
        Dim da As New OdbcDataAdapter("select * from jenis", koneksi)
        Dim dt As New DataTable
        da.Fill(dt)
        Combojenis.DataSource = dt
        Combojenis.ValueMember = "id_jenis"
        Combojenis.DisplayMember = "nama_jenis"
        koneksi.Close()
    End Sub

    Private Sub ruang()
        koneksi.Open()
        Dim da As New OdbcDataAdapter("select * from ruang", koneksi)
        Dim dt As New DataTable
        da.Fill(dt)
        Comboruang.DataSource = dt
        Comboruang.ValueMember = "id_ruang"
        Comboruang.DisplayMember = "nama_ruang"
        koneksi.Close()
    End Sub

    Private Sub loaddata()
        DataGridView1.Rows.Clear()
        Dim sql As String = "select inventaris.*, jenis.nama_jenis, ruang.nama_ruang from inventaris join jenis on inventaris.id_jenis = jenis.id_jenis join ruang on inventaris.id_ruang = ruang.id_ruang"
        Dim cmd As New OdbcCommand With {.CommandText = sql, .Connection = koneksi}
        koneksi.Open()
        Dim dr As OdbcDataReader
        dr = cmd.ExecuteReader
        While dr.Read
            DataGridView1.Rows.Add(dr.Item("kode_inventaris"), dr.Item("nama"), dr.Item("kondisi"), dr.Item("keterangan"), dr.Item("jumlah"), dr.Item("nama_jenis"), dr.Item("nama_ruang"))
        End While
        DataGridView1.Refresh()
        koneksi.Close()
    End Sub

    Private Sub Awal()
        txtkode.Enabled = False
        txtnama.Enabled = False
        txtkondisi.Enabled = False
        txtketerangan.Enabled = False
        txtjumlah.Enabled = False
        Combojenis.Enabled = False
        Comboruang.Enabled = False
        txtcari.Enabled = True
        txtnama.Text = ""
        txtkondisi.Text = ""
        txtketerangan.Text = ""
        txtjumlah.Text = ""
        btntambah.Enabled = True
        btnedit.Enabled = False
        btnhapus.Enabled = False
        btnsimpan.Enabled = False
        btnbatal.Enabled = False
        btnkembali.Enabled = True
    End Sub

    Private Sub kode()
        Dim s As String = "select kode_inventaris from inventaris order by kode_inventaris desc"
        Dim cmd As New OdbcCommand With {.CommandText = s, .Connection = koneksi}
        koneksi.Open()
        Dim dr As OdbcDataReader
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            txtkode.Text = "INV0001"
        Else
            Dim angka As Integer = Microsoft.VisualBasic.Right(dr.Item("kode_inventaris"), 4) + 1
            Dim kode As String = "INV" + Microsoft.VisualBasic.Right("0000" & angka, 4)
            txtkode.Text = kode
        End If
        koneksi.Close()
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        tampilkan()
        status = "Tambah"
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        tampilkan()
        status = "Edit"
    End Sub

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        Awal()
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If status = "Tambah" Then
            If txtkode.Text = "" And txtnama.Text = "" And txtkondisi.Text = "" And txtketerangan.Text = "" And txtjumlah.Text = "" And Combojenis.Text = "" And Comboruang.Text = "" Then
                Awal()
                MsgBox("Data tidak boleh kosong!", MsgBoxStyle.Critical)
            ElseIf txtkode.Text = "" Or txtnama.Text = "" Or txtkondisi.Text = "" Or txtketerangan.Text = "" Or txtjumlah.Text = "" Or Combojenis.Text = "" Or Comboruang.Text = "" Then
                Awal()
                MsgBox("Data tidak boleh kosong, pastikan semua file terisi!", MsgBoxStyle.Critical)
            Else
                Dim sql As String = "insert into inventaris values('" + txtkode.Text + "', '" + txtnama.Text + "', '" + txtkondisi.Text + "', '" + txtketerangan.Text + "', '" + txtjumlah.Text + "', '" + Combojenis.SelectedValue.ToString + "', '" + Format(Now, "yyyy-MM-dd") + "', '" + Comboruang.SelectedValue.ToString + "', '" + My.Settings.petugasid.ToString + "')"
                Dim cmd As New OdbcCommand With {.CommandText = sql, .Connection = koneksi}
                koneksi.Open()
                cmd.ExecuteNonQuery()
                koneksi.Close()

                Awal()
                loaddata()
                kode()
                jenis()
                ruang()
                MsgBox("Data berhasil ditambahkan!", MsgBoxStyle.Information)
            End If
        ElseIf status = "Edit" Then
            If txtkode.Text = "" And txtnama.Text = "" And txtkondisi.Text = "" And txtketerangan.Text = "" And txtjumlah.Text = "" And Combojenis.Text = "" And Comboruang.Text = "" Then
                Awal()
                MsgBox("Data tidak boleh kosong!", MsgBoxStyle.Critical)
            ElseIf txtkode.Text = "" Or txtnama.Text = "" Or txtkondisi.Text = "" Or txtketerangan.Text = "" Or txtjumlah.Text = "" Or Combojenis.Text = "" Or Comboruang.Text = "" Then
                Awal()
                MsgBox("Data tidak boleh kosong, pastikan semua file terisi!", MsgBoxStyle.Critical)
            Else
                Dim sql As String = "update inventaris set kode_inventaris = '" + txtkode.Text + "', nama = '" + txtnama.Text + "', kondisi = '" + txtkondisi.Text + "', keterangan = '" + txtketerangan.Text + "', jumlah = '" + txtjumlah.Text + "', id_jenis = '" + Combojenis.SelectedValue.ToString + "',id_ruang = '" + Comboruang.SelectedValue.ToString + "' where kode_inventaris = '" + txtkode.Text + "'"
                Dim cmd As New OdbcCommand With {.CommandText = sql, .Connection = koneksi}
                koneksi.Open()
                cmd.ExecuteNonQuery()
                koneksi.Close()

                Awal()
                loaddata()
                kode()
                jenis()
                ruang()
                MsgBox("Data berhasil diedit!", MsgBoxStyle.Information)
            End If
        End If
    End Sub

    Private Sub tampilkan()
        txtkode.Enabled = True
        txtnama.Enabled = True
        txtkondisi.Enabled = True
        txtketerangan.Enabled = True
        txtjumlah.Enabled = True
        Combojenis.Enabled = True
        Comboruang.Enabled = True
        txtcari.Enabled = False
        btntambah.Enabled = False
        btnedit.Enabled = False
        btnhapus.Enabled = False
        btnsimpan.Enabled = True
        btnbatal.Enabled = True
        btnkembali.Enabled = False
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        If MsgBox("Apakah anda yakin mau menghapus data ini?", MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            Dim sql As String = "delete from inventaris where kode_inventaris = '" + txtkode.Text + "'"
            Dim cmd As New OdbcCommand With {.CommandText = sql, .Connection = koneksi}
            koneksi.Open()
            cmd.ExecuteNonQuery()
            koneksi.Close()

            Awal()
            loaddata()
            kode()
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

        txtkode.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        txtnama.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        txtkondisi.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        txtketerangan.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        txtjumlah.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        Combojenis.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
        Comboruang.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value
    End Sub

    Private Sub txtcari_TextChanged(sender As Object, e As EventArgs) Handles txtcari.TextChanged
        DataGridView1.Rows.Clear()
        Dim sql As String = "select inventaris.*, jenis.nama_jenis, ruang.nama_ruang from inventaris join jenis on inventaris.id_jenis = jenis.id_jenis join ruang on inventaris.id_ruang = ruang.id_ruang where kode_inventaris like '%" + txtcari.Text + "%' or nama like '%" + txtcari.Text + "%' or kondisi like '%" + txtcari.Text + "%' or jumlah like '%" + txtcari.Text + "%' or nama_jenis like '%" + txtcari.Text + "%' or nama_ruang like '%" + txtcari.Text + "%'"
        Dim cmd As New OdbcCommand With {.CommandText = sql, .Connection = koneksi}
        koneksi.Open()
        Dim dr As OdbcDataReader
        dr = cmd.ExecuteReader
        While dr.Read
            DataGridView1.Rows.Add(dr.Item("kode_inventaris"), dr.Item("nama"), dr.Item("kondisi"), dr.Item("keterangan"), dr.Item("jumlah"), dr.Item("nama_jenis"), dr.Item("nama_ruang"))
        End While
        DataGridView1.Refresh()
        koneksi.Close()
    End Sub

    Private Sub btnkembali_Click(sender As Object, e As EventArgs) Handles btnkembali.Click
        AdminNav.Show()
        Me.Hide()
    End Sub

    Private Sub txtjumlah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtjumlah.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
            MsgBox("Yang diinputkan harus angka!", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub MasterInventaris_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        AdminNav.Show()
        Me.Hide()
    End Sub

    Private Sub Comboruang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Comboruang.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsNumber(e.KeyChar) Then
            e.Handled = True
            MsgBox("Tidak bisa diketik, harus memilih data!", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Combojenis_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Combojenis.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsNumber(e.KeyChar) Then
            e.Handled = True
            MsgBox("Tidak bisa diketik, harus memilih data!", MsgBoxStyle.Critical)
        End If
    End Sub
End Class