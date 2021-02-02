Public Class FrmMenu
    Public Sub Main()
        InitializeComponent()
        ToolStripStatusLabel2.Text = Date.Now().ToString("dd MMMM yyyy - HH : mm : ss ")
    End Sub
    Private Sub DataKaryawanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataKaryawanToolStripMenuItem.Click
        Form1.Show()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel2.Text = Date.Now().ToString("dd MMMM yyyy - HH : mm : ss ")
    End Sub

    Private Sub ToolStripStatusLabel2_Click(sender As Object, e As EventArgs) Handles ToolStripStatusLabel2.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub FORM2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FORM2ToolStripMenuItem.Click
        Form2.Show()
    End Sub
End Class