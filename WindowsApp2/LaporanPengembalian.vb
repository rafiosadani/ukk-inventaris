Imports System.ComponentModel
Imports System.Data.Odbc
Imports Microsoft.Reporting.WinForms
Public Class LaporanPengembalian
    Const DSN = "DSN=inventaris"
    Dim koneksi, koneksi2 As OdbcConnection
    Dim status As String = ""
    Private Sub LaporanPengembalian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi = New OdbcConnection(DSN)
        koneksi2 = New OdbcConnection(DSN)
        loadkode()
        Me.ReportViewer1.RefreshReport
    End Sub

    'Private Sub loaddata()
    '    DataGridView1.Rows.Clear()
    '    Dim s As String = "select detail_pinjam.*, peminjaman.id_pegawai, peminjaman.tanggal_pinjam, peminjaman.status_peminjaman, peminjaman.tanggal_kembali, inventaris.nama, jenis.nama_jenis,ruang.nama_ruang, pegawai.nama_pegawai from detail_pinjam join peminjaman on detail_pinjam.id_peminjaman = peminjaman.id_peminjaman join inventaris on detail_pinjam.id_inventaris = inventaris.id_inventaris join jenis on inventaris.id_jenis = jenis.id_jenis join ruang on inventaris.id_ruang = ruang.id_ruang join pegawai on peminjaman.id_pegawai = pegawai.id_pegawai where detail_pinjam.kode_peminjaman = '" + ComboPin.Text + "' and peminjaman.status_peminjaman = 'TUNTAS'"
    '    Dim cmd As New OdbcCommand With {.CommandText = s, .Connection = koneksi}
    '    koneksi.Open()
    '    Dim dr As OdbcDataReader
    '    dr = cmd.ExecuteReader
    '    While dr.Read
    '        DataGridView1.Rows.Add(dr.Item("kode_peminjaman"), dr.Item("kode_inventaris"), dr.Item("nama"), dr.Item("jumlah"), Format(Convert.ToDateTime(dr.Item("tanggal_pinjam")), "dd MMMM yyyy"), Format(Convert.ToDateTime(dr.Item("tanggal_kembali")), "dd MMMM yyyy"), dr.Item("nama_jenis"), dr.Item("nama_ruang"), dr.Item("nama_pegawai"))
    '    End While
    '    koneksi.Close()
    'End Sub

    'Private Sub loaddata2()
    '    DataGridView1.Rows.Clear()
    '    Dim s As String = "select detail_pinjam.*, peminjaman.id_pegawai, peminjaman.tanggal_pinjam, peminjaman.status_peminjaman,peminjaman.tanggal_kembali, inventaris.nama, jenis.nama_jenis,ruang.nama_ruang, pegawai.nama_pegawai from detail_pinjam join peminjaman on detail_pinjam.id_peminjaman = peminjaman.id_peminjaman join inventaris on detail_pinjam.id_inventaris = inventaris.id_inventaris join jenis on inventaris.id_jenis = jenis.id_jenis join ruang on inventaris.id_ruang = ruang.id_ruang join pegawai on peminjaman.id_pegawai = pegawai.id_pegawai where peminjaman.tanggal_pinjam >= '" + DTP.Value.ToString("yyyy-MM-dd") + "' and peminjaman .tanggal_pinjam <= '" + DTP2.Value.ToString("yyyy-MM-dd") + "' and peminjaman.status_peminjaman = 'TUNTAS'"
    '    Dim cmd As New OdbcCommand With {.CommandText = s, .Connection = koneksi}
    '    koneksi.Open()
    '    Dim dr As OdbcDataReader
    '    dr = cmd.ExecuteReader
    '    If Not dr.HasRows Then
    '        MsgBox("Data tidak ditemukan!", MsgBoxStyle.Critical)
    '    Else
    '        While dr.Read
    '            DataGridView1.Rows.Add(dr.Item("kode_peminjaman"), dr.Item("kode_inventaris"), dr.Item("nama"), dr.Item("jumlah"), Format(Convert.ToDateTime(dr.Item("tanggal_pinjam")), "dd MMMM yyyy"), Format(Convert.ToDateTime(dr.Item("tanggal_kembali")), "dd MMMM yyyy"), dr.Item("nama_jenis"), dr.Item("nama_ruang"), dr.Item("nama_pegawai"))
    '        End While
    '    End If
    '    koneksi.Close()
    'End Sub

    Private Sub loadkode()
        Dim s As String = "select kode_peminjaman from peminjaman where status_peminjaman= 'TUNTAS'"
        Dim cmd As New OdbcCommand With {.CommandText = s, .Connection = koneksi}
        koneksi.Open()
        Dim dr As OdbcDataReader
        dr = cmd.ExecuteReader
        While dr.Read
            ComboPin.Items.Add(dr.Item("kode_peminjaman"))
        End While
        koneksi.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ComboPin.Text = "" Then
            MsgBox("Harus memilih kode peminjaman terlebih dahulu!", MsgBoxStyle.Critical)
        Else
            Dim rpt As ReportDataSource
            ReportViewer1.RefreshReport()
            With ReportViewer1.LocalReport
                .ReportPath = Application.StartupPath + "\Reports\Report2.rdlc"
                .DataSources.Clear()
            End With

            koneksi.Open()
            Dim ds As New DataSet1
            Dim da As New OdbcDataAdapter("select detail_pinjam.kode_peminjaman, detail_pinjam.kode_inventaris,detail_pinjam.jumlah, peminjaman.tanggal_pinjam, peminjaman.tanggal_kembali, inventaris.nama, jenis.nama_jenis,ruang.nama_ruang, pegawai.nama_pegawai from detail_pinjam join peminjaman on detail_pinjam.id_peminjaman = peminjaman.id_peminjaman join inventaris on detail_pinjam.id_inventaris = inventaris.id_inventaris join jenis on inventaris.id_jenis = jenis.id_jenis join ruang on inventaris.id_ruang = ruang.id_ruang join pegawai on peminjaman.id_pegawai = pegawai.id_pegawai where detail_pinjam.kode_peminjaman = '" + ComboPin.Text + "' and status_peminjaman = 'TUNTAS'", koneksi)
            da.Fill(ds.Tables("DataTable1"))
            koneksi.Close()

            rpt = New ReportDataSource("DataSet1", ds.Tables("DataTable1"))
            ReportViewer1.LocalReport.DataSources.Add(rpt)
            ReportViewer1.SetDisplayMode((Microsoft.Reporting.WinForms.DisplayMode.PrintLayout))
            ReportViewer1.ZoomMode = ZoomMode.Percent
            ReportViewer1.ZoomPercent = 150
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rpt As ReportDataSource
        ReportViewer1.RefreshReport()
        With ReportViewer1.LocalReport
            .ReportPath = Application.StartupPath + "\Reports\Report2.rdlc"
            .DataSources.Clear()
        End With

        koneksi.Open()
        Dim ds As New DataSet1
        Dim da As New OdbcDataAdapter("select detail_pinjam.kode_peminjaman, detail_pinjam.kode_inventaris,detail_pinjam.jumlah, peminjaman.tanggal_pinjam, peminjaman.tanggal_kembali, inventaris.nama, jenis.nama_jenis,ruang.nama_ruang, pegawai.nama_pegawai from detail_pinjam join peminjaman on detail_pinjam.id_peminjaman = peminjaman.id_peminjaman join inventaris on detail_pinjam.id_inventaris = inventaris.id_inventaris join jenis on inventaris.id_jenis = jenis.id_jenis join ruang on inventaris.id_ruang = ruang.id_ruang join pegawai on peminjaman.id_pegawai = pegawai.id_pegawai where peminjaman.tanggal_pinjam >= '" + DTP.Value.ToString("yyyy-MM-dd") + "' and peminjaman.tanggal_pinjam <= '" + DTP.Value.ToString("yyyy-MM-dd") + "' and status_peminjaman = 'TUNTAS'", koneksi)
        da.Fill(ds.Tables("DataTable1"))
        koneksi.Close()

        rpt = New ReportDataSource("DataSet1", ds.Tables("DataTable1"))
        ReportViewer1.LocalReport.DataSources.Add(rpt)
        ReportViewer1.SetDisplayMode((Microsoft.Reporting.WinForms.DisplayMode.PrintLayout))
        ReportViewer1.ZoomMode = ZoomMode.Percent
        ReportViewer1.ZoomPercent = 150
    End Sub

    Private Sub LaporanPengembalian_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        LaporanNav.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        On Error Resume Next
    End Sub
End Class