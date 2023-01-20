Imports System.ComponentModel
Imports System.Data.Odbc
Imports Microsoft.Reporting.WinForms
Public Class LaporanInventarisir
    Const DSN = "DSN=inventaris"
    Dim koneksi, koneksi2 As OdbcConnection
    Dim status As String = ""

    Private Sub LaporanInventarisir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi = New OdbcConnection(DSN)
        koneksi2 = New OdbcConnection(DSN)
        Me.ReportViewer1.RefreshReport
    End Sub

    Private Sub LaporanInventarisir_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        LaporanNav.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rpt As ReportDataSource
        ReportViewer1.RefreshReport()
        With ReportViewer1.LocalReport
            .ReportPath = Application.StartupPath + "\Reports\Report1.rdlc"
            .DataSources.Clear()
        End With

        koneksi.Open()
        Dim ds As New DataSet1
        Dim da As New OdbcDataAdapter("select inventaris.kode_inventaris,inventaris.nama, inventaris.kondisi,inventaris.keterangan,inventaris.jumlah, jenis.nama_jenis, ruang.nama_ruang, petugas.nama_petugas from inventaris join jenis on inventaris.id_jenis = jenis.id_jenis join ruang on inventaris.id_ruang = ruang.id_ruang join petugas on inventaris.id_petugas = petugas.id_petugas", koneksi)
        da.Fill(ds.Tables("DataTable2"))
        koneksi.Close()

        rpt = New ReportDataSource("DataSet1", ds.Tables("DataTable2"))
        ReportViewer1.LocalReport.DataSources.Add(rpt)
        ReportViewer1.SetDisplayMode((Microsoft.Reporting.WinForms.DisplayMode.PrintLayout))
        ReportViewer1.ZoomMode = ZoomMode.Percent
        ReportViewer1.ZoomPercent = 100
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        'DataGridView1.Rows.Clear()
    End Sub

    'Private Sub loaddata()
    '    DataGridView1.Rows.Clear()
    '    Dim sql As String = "select inventaris.*, jenis.nama_jenis, ruang.nama_ruang, petugas.nama_petugas from inventaris join jenis on inventaris.id_jenis = jenis.id_jenis join ruang on inventaris.id_ruang = ruang.id_ruang join petugas on inventaris.id_petugas = petugas.id_petugas"
    '    Dim cmd As New OdbcCommand With {.CommandText = sql, .Connection = koneksi}
    '    koneksi.Open()
    '    Dim dr As OdbcDataReader
    '    dr = cmd.ExecuteReader
    '    While dr.Read
    '        DataGridView1.Rows.Add(dr.Item("kode_inventaris"), dr.Item("nama"), dr.Item("kondisi"), dr.Item("keterangan"), dr.Item("jumlah"), dr.Item("nama_jenis"), dr.Item("nama_ruang"))
    '    End While
    '    DataGridView1.Refresh()
    '    koneksi.Close()
    'End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        On Error Resume Next
    End Sub
End Class