Imports System.ComponentModel
Imports System.Data.Odbc
Public Class Pengembalian
    Const DSN = "DSN=inventaris"
    Dim koneksi, koneksi2 As OdbcConnection
    Dim status As String = ""
    Dim jumlah_update As Integer = 0
    Dim total As Integer

    Private Sub Pengembalian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi = New OdbcConnection(DSN)
        koneksi2 = New OdbcConnection(DSN)
        awal()
        kodpeminjaman()
    End Sub

    Private Sub kodpeminjaman()
        Combokode.Items.Clear()
        Dim sql As String = "select kode_peminjaman from peminjaman where status_peminjaman = 'PINJAM'"
        Dim cmd As New OdbcCommand With {
            .CommandText = sql,
            .Connection = koneksi
        }
        koneksi.Open()
        Dim dr As OdbcDataReader
        dr = cmd.ExecuteReader
        While dr.Read
            Combokode.Items.Add(dr.Item("kode_peminjaman"))
        End While
        koneksi.Close()
    End Sub

    Private Sub awal()
        Combokode.Enabled = True
        dtp1.Enabled = True
        dtp2.Enabled = True
        txtnama.Enabled = True
        lbltotal.Text = "0"
        DGV.Rows.Clear()
        btnsimpan.Enabled = False
        btnbatal.Enabled = True
        btnkembali.Enabled = True
        Combokode.Text = ""
        dtp1.Value = Format(Now, "dd MMMM yyyy")
        dtp2.Value = Format(Now, "dd MMMM yyyy")
    End Sub


    Private Sub totalbarang()
        Dim hitung As Integer = 0
        For baris As Integer = 0 To DGV.Rows.Count - 1
            hitung = hitung + DGV.Rows(baris).Cells(2).Value
            lbltotal.Text = hitung
        Next
        lbltotal.Text = hitung
    End Sub

    Private Sub Combokode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combokode.SelectedIndexChanged
        Dim sql As String = "select peminjaman.*, pegawai.nama_pegawai from peminjaman join pegawai on peminjaman.id_pegawai = pegawai.id_pegawai where kode_peminjaman = '" + Combokode.Text + "'"
        Dim cmd As New OdbcCommand With {
            .CommandText = sql,
            .Connection = koneksi
        }
        koneksi.Open()
        Dim dr As OdbcDataReader
        dr = cmd.ExecuteReader
        While dr.Read
            dtp1.Value = Format(Convert.ToDateTime(dr.Item("tanggal_pinjam")), "dd MMMM yyyy")
            dtp2.Value = Format(Convert.ToDateTime(dr.Item("tanggal_kembali")), "dd MMMM yyyy")
            txtnama.Text = dr.Item("nama_pegawai")
        End While
        koneksi.Close()

        DGV.Rows.Clear()

        Dim s As String = "select detail_pinjam.jumlah as jml, inventaris.* from detail_pinjam join inventaris on detail_pinjam.id_inventaris = inventaris.id_inventaris where kode_peminjaman = '" + Combokode.Text + "'"
        Dim c As New OdbcCommand With {
            .CommandText = s,
            .Connection = koneksi
        }
        koneksi.Open()
        Dim drr As OdbcDataReader
        drr = c.ExecuteReader
        While drr.Read
            DGV.Rows.Add(drr.Item("kode_inventaris"), drr.Item("nama"), drr.Item("jml"))
        End While
        koneksi.Close()
        totalbarang()
    End Sub

    Private Sub Combokode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Combokode.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsNumber(e.KeyChar) Then
            e.Handled = True
            MsgBox("Tidak bisa diketik harus memilih data!", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If Combokode.Text = "" And txtnama.Text = "" Then
            awal()
            MsgBox("Data tidak boleh kosong!", MsgBoxStyle.Critical)
        ElseIf Combokode.Text = "" Or txtnama.Text = "" Then
            awal()
            MsgBox("Data tidak boleh kosong, pastikan semua form diisi!", MsgBoxStyle.Critical)
        Else
            Dim sql As String = "update peminjaman set status_peminjaman = 'TUNTAS', tanggal_kembali = '" + Format(Now, "yyyy-MM-dd") + "' WHERE kode_peminjaman = '" + Combokode.Text + "'"
            Dim cmd As New OdbcCommand With {.CommandText = sql, .Connection = koneksi}
            koneksi.Open()
            cmd.ExecuteNonQuery()
            koneksi.Close()

            For baris2 As Integer = 0 To DGV.Rows.Count - 2
                Dim s As String = "select jumlah from inventaris where kode_inventaris = '" + DGV.Rows(baris2).Cells(0).Value + "'"
                Dim c As New OdbcCommand With {.CommandText = s, .Connection = koneksi}
                koneksi.Open()
                Dim dr As OdbcDataReader
                dr = c.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    jumlah_update = dr.Item("jumlah") + Convert.ToInt32(DGV.Rows(baris2).Cells(2).Value)
                End If
                koneksi.Close()

                Dim update As String = "update inventaris set jumlah = '" + jumlah_update.ToString + "' where kode_inventaris = '" + DGV.Rows(baris2).Cells(0).Value + "'"
                Dim cupdate As New OdbcCommand With {.CommandText = update, .Connection = koneksi}
                koneksi.Open()
                cupdate.ExecuteNonQuery()
                koneksi.Close()
            Next

            awal()
            Combokode.Items.Clear()
            Combokode.Text = ""
            kodpeminjaman()
            totalbarang()
            MsgBox("Pengembalian barang berhasil dilakukan!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub DGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellClick
        On Error Resume Next
    End Sub

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        awal()
    End Sub

    Private Sub DGV_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DGV.KeyPress
        If e.KeyChar = Chr(13) Then
            btnsimpan.Enabled = True
            btnsimpan.Select()
        End If
    End Sub

    Private Sub btnkembali_Click(sender As Object, e As EventArgs) Handles btnkembali.Click
        If My.Settings.id_level = 1 Then
            awal()
            AdminNav.Show()
            Me.Hide()
        ElseIf My.Settings.id_level = 2 Then
            awal()
            OperatorNav.Show()
            Me.Hide()
        ElseIf My.Settings.id_level = 3 Then
            awal()
            PeminjamNav.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Pengembalian_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If My.Settings.id_level = 1 Then
            awal()
            AdminNav.Show()
            Me.Hide()
        ElseIf My.Settings.id_level = 2 Then
            awal()
            OperatorNav.Show()
            Me.Hide()
        ElseIf My.Settings.id_level = 3 Then
            awal()
            PeminjamNav.Show()
            Me.Hide()
        End If
    End Sub
End Class