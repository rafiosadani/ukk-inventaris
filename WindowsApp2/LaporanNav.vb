Imports System.ComponentModel

Public Class LaporanNav
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        LaporanInventarisir.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        LaporanPeminjaman.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        LaporanPengembalian.Show()
        Me.Hide()
    End Sub

    Private Sub LaporanNav_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        AdminNav.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AdminNav.Show()
        Me.Hide()
    End Sub
End Class