Public Class Ubah
    Dim crud As New CRUD
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        crud.Update(txtNama.Text, txtKota.Text, txtDeprt.Text, txtGender.Text, Form1.dgvEmployee.CurrentRow.Cells(0).Value)
    End Sub
End Class