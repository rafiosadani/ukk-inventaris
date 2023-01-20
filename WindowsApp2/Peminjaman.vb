Imports System.ComponentModel
Imports System.Data.Odbc
Public Class Peminjaman
    Const DSN = "DSN=inventaris"
    Dim koneksi, koneksi2 As OdbcConnection
    Dim status As String = ""
    Dim id_peminjaman As Integer = 0
    Dim id_inventaris As Integer = 0

    Private Sub Peminjaman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi = New OdbcConnection(DSN)
        koneksi2 = New OdbcConnection(DSN)
        awal()
        pegawai()
        kode()
        loaddata()
    End Sub

    Private Sub kode()
        Dim s As String = "select kode_peminjaman from peminjaman order by kode_peminjaman desc"
        Dim cmd As New OdbcCommand With {.CommandText = s, .Connection = koneksi}
        koneksi.Open()
        Dim dr As OdbcDataReader
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            txtkode.Text = "PJM2001001"
        Else
            If Microsoft.VisualBasic.Mid(dr.Item("kode_peminjaman"), 4, 4) <> Format(Now, "yyMM") Then
                txtkode.Text = "PJM" + Format(Now, "yyMM") + "001"
            Else
                Dim angka As Integer = Microsoft.VisualBasic.Right(dr.Item("kode_peminjaman"), 3) + 1
                Dim kode As String = "PJM" + Format(Now, "yyMM") + Microsoft.VisualBasic.Right("000" & angka, 3)
                txtkode.Text = kode
            End If
        End If
        koneksi.Close()
    End Sub

    Private Sub awal()
        txtkode.Enabled = False
        dtp1.Enabled = True
        dtp2.Enabled = True
        Combopegawai.Enabled = True
        lbltotal.Text = "0"
        DGV.Rows.Clear()
        btnsimpan.Enabled = False
        btnbatal.Enabled = True
        btnkembali.Enabled = True
        DGV.Rows.Clear()
        dtp1.Value = Format(Now, "dd MMMM yyyy")
        dtp2.Value = Format(Now, "dd MMMM yyyy")
    End Sub

    Private Sub pegawai()
        koneksi.Open()
        Dim da As New OdbcDataAdapter("select * from pegawai", koneksi)
        Dim dt As New DataTable
        da.Fill(dt)
        Combopegawai.DataSource = dt
        Combopegawai.ValueMember = "id_pegawai"
        Combopegawai.DisplayMember = "nama_pegawai"
        koneksi.Close()
    End Sub

    Private Sub loaddata()
        DGVInventaris.Rows.Clear()
        Dim sql As String = "select * from inventaris"
        Dim cmd As New OdbcCommand With {.CommandText = sql, .Connection = koneksi}
        koneksi.Open()
        Dim dr As OdbcDataReader
        dr = cmd.ExecuteReader
        While dr.Read
            DGVInventaris.Rows.Add(dr.Item("kode_inventaris"), dr.Item("nama"), dr.Item("jumlah"))
        End While
        DGVInventaris.Refresh()
        koneksi.Close()
    End Sub

    Private Sub DGVInventaris_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVInventaris.CellClick
        On Error Resume Next
        DGV.Focus()
        DGV.Rows.Add(DGVInventaris.Rows(e.RowIndex).Cells(0).Value, DGVInventaris.Rows(e.RowIndex).Cells(1).Value, 1)

        For barisatas As Integer = 0 To DGV.Rows.Count - 2
            For barisbawah As Integer = barisatas + 1 To DGV.Rows.Count - 2
                If DGV.Rows(barisbawah).Cells(0).Value = DGV.Rows(barisatas).Cells(0).Value Then
                    DGV.Rows(barisatas).Cells(2).Value = DGV.Rows(barisatas).Cells(2).Value + 1
                    DGV.Rows.RemoveAt(barisbawah)

                    totalbarang()
                End If
            Next
        Next
        totalbarang()
    End Sub

    Private Sub DGV_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DGV.KeyPress
        If e.KeyChar = Chr(27) Then
            DGV.Rows.Remove(DGV.CurrentRow)
        End If

        If e.KeyChar = Chr(13) Then
            btnsimpan.Enabled = True
            btnsimpan.Select()
        End If
    End Sub

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        awal()
        loaddata()
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If txtkode.Text = "" And Combopegawai.Text = "" Then
            awal()
            MsgBox("Data tidak boleh kosong!", MsgBoxStyle.Critical)
        ElseIf txtkode.Text = "" Or Combopegawai.Text = "" Then
            awal()
            MsgBox("Data tidak boleh kosong, pastikan semua form terisi", MsgBoxStyle.Critical)
        Else
            Dim sql As String = "insert into peminjaman values('" + txtkode.Text + "', '" + dtp1.Value.ToString("yyyy-MM-dd") + "', '" + dtp2.Value.ToString("yyyy-MM-dd") + "', 'PINJAM', '" + Combopegawai.SelectedValue.ToString + "', '" + lbltotal.Text + "')"
            Dim cmd As New OdbcCommand With {.CommandText = sql, .Connection = koneksi}
            koneksi.Open()
            cmd.ExecuteNonQuery()
            koneksi.Close()

            Dim a As String = "select id_peminjaman from peminjaman order by id_peminjaman desc"
            Dim c As New OdbcCommand With {.CommandText = a, .Connection = koneksi}
            koneksi.Open()
            Dim dr As OdbcDataReader
            dr = c.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                id_peminjaman = dr.Item("id_peminjaman")
            End If
            koneksi.Close()

            For baris As Integer = 0 To DGV.Rows.Count - 2
                Dim aa As String = "select id_inventaris from inventaris where kode_inventaris = '" + DGV.Rows(baris).Cells(0).Value + "'"
                Dim cc As New OdbcCommand With {.CommandText = aa, .Connection = koneksi}
                koneksi.Open()
                Dim drr As OdbcDataReader
                drr = cc.ExecuteReader
                drr.Read()
                If drr.HasRows Then
                    id_inventaris = drr.Item("id_inventaris")
                End If
                koneksi.Close()

                Dim s As String = "insert into detail_pinjam values('" + id_peminjaman.ToString + "', '" + txtkode.Text + "', '" + id_inventaris.ToString + "', '" + DGV.Rows(baris).Cells(0).Value.ToString + "', '" + DGV.Rows(baris).Cells(2).Value.ToString + "')"
                Dim com As New OdbcCommand With {.CommandText = s, .Connection = koneksi}
                koneksi.Open()
                com.ExecuteNonQuery()
                koneksi.Close()
            Next

            For baris2 As Integer = 0 To DGV.Rows.Count - 2
                For barisinven As Integer = 0 To DGVInventaris.Rows.Count - 2
                    If DGV.Rows(baris2).Cells(0).Value = DGVInventaris.Rows(barisinven).Cells(0).Value Then
                        DGVInventaris.Rows(barisinven).Cells(2).Value = DGVInventaris.Rows(barisinven).Cells(2).Value - DGV.Rows(baris2).Cells(2).Value
                        Dim update As String = "update inventaris set jumlah = '" + DGVInventaris.Rows(barisinven).Cells(2).Value.ToString + "' where kode_inventaris = '" + DGV.Rows(baris2).Cells(0).Value + "'"
                        Dim cupdate As New OdbcCommand With {.CommandText = update, .Connection = koneksi}
                        koneksi.Open()
                        cupdate.ExecuteNonQuery()
                        koneksi.Close()
                    End If
                Next
            Next

            awal()
            kode()
            totalbarang()
            loaddata()
            MsgBox("Peminjaman barang berhasil dilakukan!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub totalbarang()
        Dim hitung As Integer = 0
        For baris As Integer = 0 To DGV.Rows.Count - 1
            hitung = hitung + DGV.Rows(baris).Cells(2).Value
            lbltotal.Text = hitung
        Next
        lbltotal.Text = hitung
    End Sub

    Private Sub Combopegawai_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Combopegawai.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsNumber(e.KeyChar) Then
            e.Handled = True
            MsgBox("Tidak bisa diketik, harus memilih data!", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub DGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellClick
        On Error Resume Next
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

    Private Sub Peminjaman_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
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