<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Mahasiswa = New System.Windows.Forms.GroupBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDeprt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtKota = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvMahasiswa = New System.Windows.Forms.DataGridView()
        Me.EmployeeId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamKar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.City = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Department = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Gender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mahasiswa.SuspendLayout()
        CType(Me.dgvMahasiswa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Mahasiswa
        '
        Me.Mahasiswa.Controls.Add(Me.btnDelete)
        Me.Mahasiswa.Controls.Add(Me.btnUpdate)
        Me.Mahasiswa.Controls.Add(Me.btnSave)
        Me.Mahasiswa.Controls.Add(Me.Label4)
        Me.Mahasiswa.Controls.Add(Me.txtNama)
        Me.Mahasiswa.Controls.Add(Me.Label3)
        Me.Mahasiswa.Controls.Add(Me.txtGender)
        Me.Mahasiswa.Controls.Add(Me.Label2)
        Me.Mahasiswa.Controls.Add(Me.txtDeprt)
        Me.Mahasiswa.Controls.Add(Me.Label1)
        Me.Mahasiswa.Controls.Add(Me.txtKota)
        Me.Mahasiswa.Dock = System.Windows.Forms.DockStyle.Top
        Me.Mahasiswa.Location = New System.Drawing.Point(0, 0)
        Me.Mahasiswa.Name = "Mahasiswa"
        Me.Mahasiswa.Size = New System.Drawing.Size(818, 200)
        Me.Mahasiswa.TabIndex = 0
        Me.Mahasiswa.TabStop = False
        Me.Mahasiswa.Text = "Mahasiwa"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(404, 158)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 22
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(277, 158)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 21
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(163, 158)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 20
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Jenis Kelamin"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(163, 32)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(189, 20)
        Me.txtNama.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Department"
        '
        'txtGender
        '
        Me.txtGender.Location = New System.Drawing.Point(163, 110)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(189, 20)
        Me.txtGender.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Kota"
        '
        'txtDeprt
        '
        Me.txtDeprt.Location = New System.Drawing.Point(163, 84)
        Me.txtDeprt.Name = "txtDeprt"
        Me.txtDeprt.Size = New System.Drawing.Size(189, 20)
        Me.txtDeprt.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Nama"
        '
        'txtKota
        '
        Me.txtKota.Location = New System.Drawing.Point(163, 58)
        Me.txtKota.Name = "txtKota"
        Me.txtKota.Size = New System.Drawing.Size(189, 20)
        Me.txtKota.TabIndex = 13
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 441)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(818, 38)
        Me.Panel1.TabIndex = 21
        '
        'dgvMahasiswa
        '
        Me.dgvMahasiswa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMahasiswa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmployeeId, Me.NamKar, Me.City, Me.Department, Me.Gender})
        Me.dgvMahasiswa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMahasiswa.Location = New System.Drawing.Point(0, 200)
        Me.dgvMahasiswa.Name = "dgvMahasiswa"
        Me.dgvMahasiswa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMahasiswa.Size = New System.Drawing.Size(818, 241)
        Me.dgvMahasiswa.TabIndex = 22
        '
        'EmployeeId
        '
        Me.EmployeeId.DataPropertyName = "EmployeeId"
        Me.EmployeeId.HeaderText = "ID"
        Me.EmployeeId.Name = "EmployeeId"
        '
        'NamKar
        '
        Me.NamKar.DataPropertyName = "Name"
        Me.NamKar.HeaderText = "Nama Karyawan"
        Me.NamKar.Name = "NamKar"
        '
        'City
        '
        Me.City.DataPropertyName = "City"
        Me.City.HeaderText = "Kota"
        Me.City.Name = "City"
        '
        'Department
        '
        Me.Department.DataPropertyName = "Department"
        Me.Department.HeaderText = "Dept"
        Me.Department.Name = "Department"
        '
        'Gender
        '
        Me.Gender.DataPropertyName = "Gender"
        Me.Gender.HeaderText = "Jenis Kelamin"
        Me.Gender.Name = "Gender"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(818, 479)
        Me.Controls.Add(Me.dgvMahasiswa)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Mahasiswa)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.Mahasiswa.ResumeLayout(False)
        Me.Mahasiswa.PerformLayout()
        CType(Me.dgvMahasiswa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Mahasiswa As GroupBox
    Friend WithEvents Label4 As Label
    Public WithEvents txtNama As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtGender As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDeprt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtKota As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents dgvMahasiswa As DataGridView
    Friend WithEvents EmployeeId As DataGridViewTextBoxColumn
    Friend WithEvents NamKar As DataGridViewTextBoxColumn
    Friend WithEvents City As DataGridViewTextBoxColumn
    Friend WithEvents Department As DataGridViewTextBoxColumn
    Friend WithEvents Gender As DataGridViewTextBoxColumn
End Class
