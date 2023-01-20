Imports System.ComponentModel

Public Class MasterData
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MasterPegawai.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MasterJenis.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MasterRuang.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MasterPetugas.Show()
        Me.Hide()
    End Sub

    Private Sub MasterData_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MasterData_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        AdminNav.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        AdminNav.Show()
        Me.Hide()
    End Sub
End Class