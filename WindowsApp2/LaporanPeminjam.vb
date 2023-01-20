Imports System.ComponentModel
Imports System.Data.Odbc
Public Class LaporanPeminjam
    Const DSN = "DSN=inventaris"
    Dim koneksi, koneksi2 As OdbcConnection
    Dim status As String = ""

    Private Sub LaporanPeminjam_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi = New OdbcConnection(DSN)
        koneksi2 = New OdbcConnection(DSN)
        loaddata()
    End Sub

    Private Sub loaddata()
        DataGridView1.Rows.Clear()
        Dim s As String = "select detail_pinjam.*, peminjaman.id_pegawai, peminjaman.tanggal_pinjam, peminjaman.tanggal_kembali, inventaris.nama, jenis.nama_jenis,ruang.nama_ruang, pegawai.nama_pegawai from detail_pinjam join peminjaman on detail_pinjam.id_peminjaman = peminjaman.id_peminjaman join inventaris on detail_pinjam.id_inventaris = inventaris.id_inventaris join jenis on inventaris.id_jenis = jenis.id_jenis join ruang on inventaris.id_ruang = ruang.id_ruang join pegawai on peminjaman.id_pegawai = pegawai.id_pegawai where peminjaman.status_peminjaman = 'PINJAM'"
        Dim cmd As New OdbcCommand With {.CommandText = s, .Connection = koneksi}
        koneksi.Open()
        Dim dr As OdbcDataReader
        dr = cmd.ExecuteReader
        While dr.Read
            DataGridView1.Rows.Add(dr.Item("kode_peminjaman"), dr.Item("kode_inventaris"), dr.Item("nama"), dr.Item("jumlah"), Format(Convert.ToDateTime(dr.Item("tanggal_pinjam")), "dd MMMM yyyy"), Format(Convert.ToDateTime(dr.Item("tanggal_kembali")), "dd MMMM yyyy"), dr.Item("nama_jenis"), dr.Item("nama_ruang"), dr.Item("nama_pegawai"))
        End While
        koneksi.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        loaddata()
        PeminjamNav.Show()
        Me.Hide()
    End Sub

    Private Sub LaporanPeminjam_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        loaddata()
        PeminjamNav.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        On Error Resume Next
    End Sub
End Class