Imports System.ComponentModel
Imports System.Data.Odbc
Public Class MasterPetugas
    Const DSN = "DSN=inventaris"
    Dim koneksi, koneksi2 As OdbcConnection
    Dim status As String = ""
    Dim id As Integer = 0

    Private Sub MasterPetugas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi = New OdbcConnection(DSN)
        koneksi2 = New OdbcConnection(DSN)
        Awal()
        loaddata()
        combor()
    End Sub

    Private Sub combor()
        koneksi.Open()
        Dim da As New OdbcDataAdapter("select * from level", koneksi)
        Dim dt As New DataTable
        da.Fill(dt)
        ComboRole.DataSource = dt
        ComboRole.ValueMember = "id_level"
        ComboRole.DisplayMember = "nama_level"
        koneksi.Close()
    End Sub

    Private Sub loaddata()
        DataGridView1.Rows.Clear()
        Dim sql As String = "select petugas.*,level.nama_level from petugas join level on petugas.id_level = level.id_level"
        Dim cmd As New OdbcCommand With {.CommandText = sql, .Connection = koneksi}
        koneksi.Open()
        Dim dr As OdbcDataReader
        dr = cmd.ExecuteReader
        While dr.Read
            DataGridView1.Rows.Add(dr.Item("nama_petugas"), dr.Item("jk"), Format(Convert.ToDateTime(dr.Item("ttl")), "dd MMMM yyyy"), dr.Item("alamat"), dr.Item("nama_level"))
        End While
        DataGridView1.Refresh()
        koneksi.Close()
    End Sub

    Private Sub Awal()
        txtnama.Enabled = False
        txtusername.Enabled = False
        txtpassword.Enabled = False
        RadioButton1.Enabled = False
        RadioButton2.Enabled = False
        DTP.Enabled = False
        txtalamat.Enabled = False
        ComboRole.Enabled = False
        txtcari.Enabled = True
        txtnama.Text = ""
        txtusername.Text = ""
        txtpassword.Text = ""
        txtalamat.Text = ""
        DTP.Value = Format(Now, "dd MMMM yyyy")
        btntambah.Enabled = True
        btnedit.Enabled = False
        btnhapus.Enabled = False
        btnsimpan.Enabled = False
        btnbatal.Enabled = False
        btnkembali.Enabled = True
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        tampilkan()
        status = "Tambah"
    End Sub

    Private Sub btnbatal_Click(sender As Object, e As EventArgs) Handles btnbatal.Click
        Awal()
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        tampilkan()
        status = "Edit"
    End Sub

    Private Sub tampilkan()
        txtnama.Enabled = True
        txtusername.Enabled = True
        txtpassword.Enabled = True
        RadioButton1.Enabled = True
        RadioButton2.Enabled = True
        DTP.Enabled = True
        txtalamat.Enabled = True
        ComboRole.Enabled = True
        txtcari.Enabled = False
        btntambah.Enabled = False
        btnedit.Enabled = False
        btnhapus.Enabled = False
        btnsimpan.Enabled = True
        btnbatal.Enabled = True
        btnkembali.Enabled = False
    End Sub

    Private Sub btnsimpan_Click(sender As Object, e As EventArgs) Handles btnsimpan.Click
        If status = "Tambah" Then
            If txtusername.Text = "" And txtpassword.Text = "" And txtnama.Text = "" And txtalamat.Text = "" And ComboRole.Text = "" Then
                Awal()
                MsgBox("Data tidak boleh kosong!", MsgBoxStyle.Critical)
            ElseIf txtusername.Text = "" Or txtpassword.Text = "" Or txtnama.Text = "" Or txtalamat.Text = "" Or ComboRole.Text = "" Then
                Awal()
                MsgBox("Data tidak boleh kosong, pastikan semua file terisi!", MsgBoxStyle.Critical)
            ElseIf RadioButton1.Checked = False And RadioButton2.Checked = False Then
                MsgBox("Harus memilih jenis kelamin terlebih dahulu!", MsgBoxStyle.Critical)
            Else
                Dim jk As String
                If RadioButton1.Checked = True Then
                    jk = "Laki-Laki"
                ElseIf RadioButton2.Checked = True Then
                    jk = "Perempuan"
                End If

                Dim sql As String = "insert into petugas values('" + txtusername.Text + "', '" + txtpassword.Text + "', '" + txtnama.Text + "', '" + jk + "', '" + DTP.Value.ToString("yyyy-MM-dd") + "', '" + txtalamat.Text + "', '" + ComboRole.SelectedValue.ToString + "')"
                Dim cmd As New OdbcCommand With {.CommandText = sql, .Connection = koneksi}
                koneksi.Open()
                cmd.ExecuteNonQuery()
                koneksi.Close()

                Awal()
                loaddata()
                MsgBox("Data berhasil ditambahkan!", MsgBoxStyle.Information)
            End If
        ElseIf status = "Edit" Then
            If txtusername.Text = "" And txtpassword.Text = "" And txtnama.Text = "" And txtalamat.Text = "" And ComboRole.Text = "" Then
                Awal()
                MsgBox("Data tidak boleh kosong!", MsgBoxStyle.Critical)
            ElseIf txtusername.Text = "" Or txtpassword.Text = "" Or txtnama.Text = "" Or txtalamat.Text = "" Or ComboRole.Text = "" Then
                Awal()
                MsgBox("Data tidak boleh kosong, pastikan semua file terisi!", MsgBoxStyle.Critical)
            ElseIf RadioButton1.Checked = False And RadioButton2.Checked = False Then
                MsgBox("Harus memilih jenis kelamin terlebih dahulu!", MsgBoxStyle.Critical)
            Else
                Dim jk As String
                If RadioButton1.Checked = True Then
                    jk = "Laki-Laki"
                ElseIf RadioButton2.Checked = True Then
                    jk = "Perempuan"
                End If

                Dim sql As String = "update petugas set nama_petugas = '" + txtnama.Text + "', username = '" + txtusername.Text + "', password = '" + txtpassword.Text + "', jk = '" + jk + "', ttl = '" + DTP.Value.ToString("yyyy-MM-dd") + "', id_level = '" + ComboRole.SelectedValue.ToString + "' where id_petugas = '" + id.ToString + "'"
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
        Dim sql As String = "select petugas.*,level.nama_level from petugas join level on petugas.id_level = level.id_level where nama_petugas like '%" + txtcari.Text + "%' or jk like '%" + txtcari.Text + "%' or ttl like '%" + txtcari.Text + "%' or alamat like '%" + txtcari.Text + "%' or nama_level like '%" + txtcari.Text + "%'"
        Dim cmd As New OdbcCommand With {.CommandText = sql, .Connection = koneksi}
        koneksi.Open()
        Dim dr As OdbcDataReader
        dr = cmd.ExecuteReader
        While dr.Read
            DataGridView1.Rows.Add(dr.Item("nama_petugas"), dr.Item("jk"), Format(Convert.ToDateTime(dr.Item("ttl")), "dd MMMM yyyy"), dr.Item("alamat"), dr.Item("nama_level"))
        End While
        DataGridView1.Refresh()
        koneksi.Close()
    End Sub

    Private Sub btnhapus_Click(sender As Object, e As EventArgs) Handles btnhapus.Click
        If MsgBox("Apakah anda yakin mau menghapus data ini?", MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            Dim sql As String = "delete from petugas where id_petugas = '" + id.ToString + "'"
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

        Dim s As String = "select petugas.*,level.nama_level from petugas join level on petugas.id_level = level.id_level where petugas.nama_petugas = '" + DataGridView1.Rows(e.RowIndex).Cells(0).Value + "'"
        Dim c As New OdbcCommand With {.CommandText = s, .Connection = koneksi}
        koneksi.Open()
        Dim d As OdbcDataReader
        d = c.ExecuteReader
        d.Read()
        If d.HasRows Then
            id = d.Item("id_petugas")
            txtusername.Text = d.Item("username")
            txtpassword.Text = d.Item("password")
            txtnama.Text = d.Item("nama_petugas")
            If d.Item("jk") = "Laki-Laki" Then
                RadioButton1.Checked = True
            ElseIf d.Item("jk") = "Perempuan" Then
                RadioButton2.Checked = True
            End If
            ComboRole.Text = d.Item("nama_level")
        End If
        DTP.Value = Convert.ToDateTime(DataGridView1.Rows(e.RowIndex).Cells(2).Value)
        txtalamat.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        koneksi.Close()
    End Sub

    Private Sub btnkembali_Click(sender As Object, e As EventArgs) Handles btnkembali.Click
        MasterData.Show()
        Me.Hide()
    End Sub

    Private Sub ComboRole_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboRole.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsNumber(e.KeyChar) Then
            e.Handled = True
            MsgBox("Tidak bisa diketik! harus memilih data!", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub MasterPetugas_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        MasterData.Show()
        Me.Hide()
    End Sub
End Class