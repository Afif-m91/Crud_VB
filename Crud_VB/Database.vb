Imports System.Data.SqlClient

Public Class Database
    Public cmd As SqlCommand
    Public query As String
    Public conn As SqlConnection

    Public Sub Koneksi()
        Try
            'Dengan Password
            ' Sql = "Data Source=NGADIMUN-PC\SQLEXPRESS;Initial Catalog=dtoee;Persist Security Info=True;UID=sa;PWD=ngadimun123"
            conn = New SqlConnection("data source = .\SQLEXPRESS; initial catalog = DemoTest; integrated security = true")
            conn.Open()

        Catch ex As Exception
            MsgBox("Koneksi Database Gagal.! :" + ex.Message())
        End Try
    End Sub
End Class
