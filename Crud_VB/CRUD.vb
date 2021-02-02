Imports System.Data.SqlClient

Public Class CRUD
    Dim db As New Database

    Public Sub Create(nama As String, kota As String, deprt As String, jk As String)
        db.Koneksi()
        Dim query = "Insert Into tblEmployee (Name,City, Department, Gender) Values (@nama,@kota, @deprt, @jk)"
        Dim cmd As New SqlCommand(query, db.conn)
        Try
            cmd.Parameters.Add("@nama", SqlDbType.VarChar).Value = nama
            cmd.Parameters.Add("@kota", SqlDbType.VarChar).Value = kota
            cmd.Parameters.Add("@deprt", SqlDbType.VarChar).Value = deprt
            cmd.Parameters.Add("@jk", SqlDbType.VarChar).Value = jk

            If cmd.ExecuteNonQuery Then
                MsgBox("Data Tersimpan.!", vbInformation)
                Form1.txtNama.Text = ""
                Form1.txtKota.Text = ""
                Form1.txtDeprt.Text = ""
                Form1.txtGender.Text = ""

                db.conn.Close()
                Tampil()
            Else
                MsgBox("Gagal Tersimpan.!!", vbCritical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Public Sub Tampil()
        db.Koneksi()
        Dim query = "Select * From tblEmployee"
        Dim da As New SqlDataAdapter(query, db.conn)
        Dim dt As New DataTable
        da.Fill(dt)

        Form1.dgvEmployee.DataSource = dt
    End Sub

    Public Sub Delete(EmployeeId)
        db.Koneksi()
        Dim query = "Delete From tblEmployee Where EmployeeId = @EmployeeId"
        Dim cmd As New SqlCommand(query, db.conn)

        cmd.Parameters.Add("@EmployeeId", SqlDbType.Int).Value = EmployeeId

        If cmd.ExecuteNonQuery Then
            MsgBox("Data Berhasil di Hapus", vbInformation)
            db.conn.Close()
            Tampil()
        Else
            MsgBox("Gagal Menghapus Data", vbCritical)
        End If
    End Sub

    Public Sub GetDataByID(Id As Integer)
        db.Koneksi()
        Dim query = "Select * From tblEmployee Where EmployeeId = @Id"
        Dim cmd As New SqlCommand(query, db.conn)
        Try
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = Id
            Dim er = cmd.ExecuteReader
            er.Read()

            If er.HasRows Then
                Ubah.txtNama.Text = er(1)
                Ubah.txtKota.Text = er(2)
                Ubah.txtDeprt.Text = er(3)
                Ubah.txtGender.Text = er(4)
            Else
                MsgBox("Data Tidak Ditemukan.!!", vbInformation)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub Update(nama As String, kota As String, deprt As String, jk As String, Id As Integer)
        db.Koneksi()
        Dim query = "Update tblEmployee SET Name = @nama, City = @kota, Department = @deprt, Gender = @jk Where EmployeeId = @Id"
        Dim cmd As New SqlCommand(query, db.conn)
        Try
            cmd.Parameters.Add("@Id", SqlDbType.Int).Value = Id
            cmd.Parameters.Add("@nama", SqlDbType.VarChar).Value = nama
            cmd.Parameters.Add("@kota", SqlDbType.VarChar).Value = kota
            cmd.Parameters.Add("@deprt", SqlDbType.VarChar).Value = deprt
            cmd.Parameters.Add("@jk", SqlDbType.VarChar).Value = jk

            If cmd.ExecuteNonQuery Then
                MsgBox("Update Berhasil.!", vbInformation)
                db.conn.Close()
                Ubah.Close()
                Tampil()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
