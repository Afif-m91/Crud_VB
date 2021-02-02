Imports System.Data
Imports System.Data.SqlClient


Public Class Form1
    Dim crud As New CRUD

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        crud.Tampil()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        crud.Create(txtNama.Text, txtKota.Text, txtDeprt.Text, txtGender.Text)
    End Sub

    Private Sub dgvEmployee_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployee.CellContentClick

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim Pesan As String = MsgBox("Anda Yakin Ingin Menghapus.?", vbYesNo)

        If Pesan = vbYes Then
            crud.Delete(dgvEmployee.CurrentRow.Cells(0).Value)
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        crud.GetDataByID(dgvEmployee.CurrentRow.Cells(0).Value)
        Ubah.Show()

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

End Class
