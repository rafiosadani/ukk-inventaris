Public Class PeminjamNav
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Peminjaman.Show()
        Me.Hide()
    End Sub
End Class