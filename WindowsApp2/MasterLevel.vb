Imports System.ComponentModel
Imports System.Data.Odbc
Public Class MasterLevel
    Const DSN = "DSN=inventaris"
    Dim koneksi, koneksi2 As OdbcConnection
    Dim status As String = ""

    Private Sub MasterLevel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi = New OdbcConnection(DSN)
        koneksi2 = New OdbcConnection(DSN)
        Awal()
        loaddata()
        kode()
    End Sub

    Private Sub Awal()
        txtnama.Enabled = False
        txtkode.Enabled = False
        txtcari.Enabled = True
        txtnama.Text = ""
        btntambah.Enabled = True
        btnedit.Enabled = False
        btnhapus.Enabled = False
        btnsimpan.Enabled = False
        btnbatal.Enabled = False
        btnkembali.Enabled = True
    End Sub

    Private Sub tampilkan()
        txtnama.Enabled = True
        txtkode.Enabled = False
        txtcari.Enabled = False
        btntambah.Enabled = False
        btnedit.Enabled = False
        btnhapus.Enabled = False
        btnsimpan.Enabled = True
        btnbatal.Enabled = True
        btnkembali.Enabled = False
    End Sub

    Private Sub loaddata()
        DataGridView1.Rows.Clear()
        Dim sql As String = "select * from level"
        Dim cmd As New OdbcCommand With {.CommandText = sql, .Connection = koneksi}
        koneksi.Open()
        Dim dr As OdbcDataReader
        dr = cmd.ExecuteReader
        While dr.Read
            DataGridView1.Rows.Add(dr.Item("kode_level"), dr.Item("nama_level"))
        End While
        DataGridView1.Refresh()
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

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        If MsgBox("Apakah anda yakin mau menghapus data ini?", MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            Dim sql As String = "delete from level where kode_level = '" + txtkode.Text + "'"
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

    Private Sub kode()
        Dim s As String = "select kode_level from level order by kode_level desc"
        Dim cmd As New OdbcCommand With {.CommandText = s, .Connection = koneksi}
        koneksi.Open()
        Dim dr As OdbcDataReader
        dr = cmd.ExecuteReader
        dr.Read()
        If Not dr.HasRows Then
            txtkode.Text = "LV0001"
        Else
            Dim angka As Integer = Microsoft.VisualBasic.Right(dr.Item("kode_level"), 4) + 1
            Dim kode As String = "LV" + Microsoft.VisualBasic.Right("0000" & angka, 4)
            txtkode.Text = kode
        End If
        koneksi.Close()
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If status = "Tambah" Then
            If txtnama.Text = "" And txtkode.Text = "" Then
                Awal()
                MsgBox("Data tidak boleh kosong!", MsgBoxStyle.Critical)
            ElseIf txtnama.Text = "" Or txtkode.Text = "" Then
                Awal()
                MsgBox("Data tidak boleh kosong, pastikan semua file terisi!", MsgBoxStyle.Critical)
            Else
                Dim sql As String = "insert into level values('" + txtkode.Text + "', '" + txtnama.Text + "')"
                Dim cmd As New OdbcCommand With {.CommandText = sql, .Connection = koneksi}
                koneksi.Open()
                cmd.ExecuteNonQuery()
                koneksi.Close()

                Awal()
                loaddata()
                kode()
                MsgBox("Data berhasil ditambahkan!", MsgBoxStyle.Information)
            End If
        ElseIf status = "Edit" Then
            If txtnama.Text = "" And txtkode.Text = "" Then
                Awal()
                MsgBox("Data tidak boleh kosong!", MsgBoxStyle.Critical)
            ElseIf txtnama.Text = "" Or txtkode.Text = "" Then
                Awal()
                MsgBox("Data tidak boleh kosong, pastikan semua file terisi!", MsgBoxStyle.Critical)
            Else
                Dim sql As String = "update level set nama_level = '" + txtnama.Text + "', kode_level = '" + txtkode.Text + "' where kode_level = '" + txtkode.Text + "'"
                Dim cmd As New OdbcCommand With {.CommandText = sql, .Connection = koneksi}
                koneksi.Open()
                cmd.ExecuteNonQuery()
                koneksi.Close()

                Awal()
                loaddata()
                kode()
                MsgBox("Data berhasil diedit!", MsgBoxStyle.Information)
            End If
        End If
    End Sub

    Private Sub txtcari_TextChanged(sender As Object, e As EventArgs) Handles txtcari.TextChanged
        DataGridView1.Rows.Clear()
        Dim sql As String = "select * from level where kode_level like '%" + txtcari.Text + "%' or nama_level like '%" + txtcari.Text + "%'"
        Dim cmd As New OdbcCommand With {.CommandText = sql, .Connection = koneksi}
        koneksi.Open()
        Dim dr As OdbcDataReader
        dr = cmd.ExecuteReader
        While dr.Read
            DataGridView1.Rows.Add(dr.Item("kode_level"), dr.Item("nama_level"))
        End While
        DataGridView1.Refresh()
        koneksi.Close()
    End Sub

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        Awal()
    End Sub

    Private Sub btnkembali_Click(sender As Object, e As EventArgs) Handles btnkembali.Click
        MasterData.Show()
        Me.Hide()
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
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub txtnama_TextChanged(sender As Object, e As EventArgs) Handles txtnama.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub txtkode_TextChanged(sender As Object, e As EventArgs) Handles txtkode.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub MasterLevel_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        MasterData.Show()
        Me.Hide()
    End Sub
End Class