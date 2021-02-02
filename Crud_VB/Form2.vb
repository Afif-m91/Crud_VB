Imports Data.System
Imports System.Data.SqlClient

Public Class Form2
    Dim db As New Database
    Dim Koneksi As SqlConnection
    Dim ds As DataSet
    Dim sql As String
    Dim cmd As New SqlCommand
    Dim i As Integer


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        db.Koneksi()
        Disp_Data()

        btnSave.Enabled = True
        btnUpdate.Enabled = False

    End Sub
    Sub Clear_Data()
        txtNama.Clear()
        txtKota.Clear()
        txtGender.Clear()
        txtDeprt.Clear()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If db.conn.State = ConnectionState.Open Then
                db.conn.Close()
            End If
            db.conn.Open()

            Dim query As New SqlCommand("Insert Into tblEmployee Values 
                ('" & txtNama.Text & "','" & txtKota.Text & "','" & txtDeprt.Text & "','" & txtGender.Text & "') ", db.conn)
            Dim cmd = query.ExecuteNonQuery()
            If cmd = 1 Then
                MsgBox("Data Berhasil Disimpan", MsgBoxStyle.Information, "Sukses")
                Disp_Data()
                Clear_Data()
            Else
                MsgBox("Data Gagal Tersimpan", MsgBoxStyle.Critical, "Gagal")
            End If
            db.conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try

            If db.conn.State = ConnectionState.Open Then
                db.conn.Close()
            End If
            db.conn.Open()

            Dim query As New SqlCommand("Update tblEmployee SET Name = '" + txtNama.Text + "', City = '" + txtKota.Text + "', 
            Department = '" + txtDeprt.Text + "', Gender = '" + txtGender.Text + "' Where EmployeeId = " & i & "", db.conn)
            Dim cmd = query.ExecuteNonQuery()
            If cmd = 1 Then
                MsgBox("Data Berhasil Di Edit", MsgBoxStyle.Information, "Sukses")
                Clear_Data()
                Disp_Data()
            Else
                MsgBox("Data Gagal Di Edit", MsgBoxStyle.Critical, "Gagal")
            End If
            db.conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If db.conn.State = ConnectionState.Open Then
                db.conn.Close()
            End If
            db.conn.Open()
            Dim query As New SqlCommand("Delete From tblEmployee Where Name = '" + txtNama.Text + "'", db.conn)
            Dim cmd = query.ExecuteNonQuery()
            If cmd = 1 Then
                MsgBox("Data Berhasil Di Hapus", MsgBoxStyle.Information, "Sukses")
                Clear_Data()
                Disp_Data()
            Else
                MsgBox("Data Gagal Di Hapus", MsgBoxStyle.Critical, "Gagal")
            End If
            db.conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub Disp_Data()
        cmd = db.conn.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Select * From tblEmployee"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        dgvMahasiswa.DataSource = dt
    End Sub
    Private Sub dgvMahasiswa_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMahasiswa.CellClick
        Try
            btnSave.Enabled = False
            btnUpdate.Enabled = True

            If db.conn.State = ConnectionState.Open Then
                db.conn.Close()
            End If
            db.conn.Open()
            i = Convert.ToInt32(dgvMahasiswa.SelectedCells.Item(0).Value.ToString())

            cmd = db.conn.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "Select * From tblEmployee Where EmployeeId = " & i & ""
            cmd.ExecuteNonQuery()
            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            While dr.Read
                txtNama.Text = dr.GetString(1).ToString()
                txtKota.Text = dr.GetString(2).ToString()
                txtDeprt.Text = dr.GetString(3).ToString()
                txtGender.Text = dr.GetString(4).ToString()
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
