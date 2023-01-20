Public Class AdminNav
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If MsgBox("Apakah anda yakin ingin Logout?", MsgBoxStyle.YesNo, "Logout") = MsgBoxResult.Yes Then
            My.Settings.petugasid = 0
            My.Settings.id_level = 0
            My.Settings.nama = ""
            My.Settings.Save()
            FormLogin.Show()
            Me.Hide()
            MsgBox("Anda berhasil Logout!", MsgBoxStyle.Information)
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MasterData.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MasterInventaris.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Peminjaman.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Pengembalian.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        LaporanNav.Show()
        Me.Hide()
    End Sub
End Class