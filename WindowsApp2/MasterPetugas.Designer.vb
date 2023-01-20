<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MasterPetugas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnkembali = New System.Windows.Forms.Button()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DTP = New System.Windows.Forms.DateTimePicker()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboRole = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(408, 205)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(76, 32)
        Me.btnsimpan.TabIndex = 47
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(1, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(785, 66)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Master Data Petugas"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtcari)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 250)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(734, 42)
        Me.GroupBox1.TabIndex = 51
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pencarian"
        '
        'txtcari
        '
        Me.txtcari.Location = New System.Drawing.Point(6, 17)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(722, 20)
        Me.txtcari.TabIndex = 22
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.DataGridView1.Location = New System.Drawing.Point(25, 298)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(735, 144)
        Me.DataGridView1.TabIndex = 50
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nama Petugas"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 170
        '
        'Column2
        '
        Me.Column2.HeaderText = "Jenis Kelamin"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 120
        '
        'Column3
        '
        Me.Column3.HeaderText = "Tempat, Tanggal Lahir"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 170
        '
        'Column4
        '
        Me.Column4.HeaderText = "Alamat"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 150
        '
        'Column5
        '
        Me.Column5.HeaderText = "Role"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'btnkembali
        '
        Me.btnkembali.Location = New System.Drawing.Point(684, 205)
        Me.btnkembali.Name = "btnkembali"
        Me.btnkembali.Size = New System.Drawing.Size(76, 32)
        Me.btnkembali.TabIndex = 49
        Me.btnkembali.Text = "Kembali"
        Me.btnkembali.UseVisualStyleBackColor = True
        '
        'btnbatal
        '
        Me.btnbatal.Location = New System.Drawing.Point(546, 205)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(76, 32)
        Me.btnbatal.TabIndex = 48
        Me.btnbatal.Text = "Batal"
        Me.btnbatal.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Location = New System.Drawing.Point(274, 205)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(76, 32)
        Me.btnhapus.TabIndex = 46
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Location = New System.Drawing.Point(148, 205)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(76, 32)
        Me.btnedit.TabIndex = 45
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btntambah
        '
        Me.btntambah.Location = New System.Drawing.Point(25, 205)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(76, 32)
        Me.btntambah.TabIndex = 44
        Me.btntambah.Text = "Tambah"
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(135, 138)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(201, 20)
        Me.txtnama.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Nama Petugas"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(786, 66)
        Me.Panel1.TabIndex = 39
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(135, 86)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(201, 20)
        Me.txtusername.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Username"
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(135, 112)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(201, 20)
        Me.txtpassword.TabIndex = 53
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Password"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Jenis Kelamin"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(135, 162)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(68, 17)
        Me.RadioButton1.TabIndex = 55
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Laki-Laki"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(242, 162)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(79, 17)
        Me.RadioButton2.TabIndex = 56
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Perempuan"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(423, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 13)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Tempat, Tanggal Lahir"
        '
        'DTP
        '
        Me.DTP.CustomFormat = "dd MMMM yyyy"
        Me.DTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP.Location = New System.Drawing.Point(559, 86)
        Me.DTP.Name = "DTP"
        Me.DTP.Size = New System.Drawing.Size(200, 20)
        Me.DTP.TabIndex = 58
        '
        'txtalamat
        '
        Me.txtalamat.Location = New System.Drawing.Point(559, 112)
        Me.txtalamat.Multiline = True
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(201, 46)
        Me.txtalamat.TabIndex = 60
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(424, 115)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "Alamat"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(426, 167)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 13)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "Role"
        '
        'ComboRole
        '
        Me.ComboRole.FormattingEnabled = True
        Me.ComboRole.Location = New System.Drawing.Point(558, 161)
        Me.ComboRole.Name = "ComboRole"
        Me.ComboRole.Size = New System.Drawing.Size(202, 21)
        Me.ComboRole.TabIndex = 62
        '
        'MasterPetugas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 450)
        Me.Controls.Add(Me.ComboRole)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtalamat)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DTP)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnkembali)
        Me.Controls.Add(Me.btnbatal)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MasterPetugas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MasterPetugas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnsimpan As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtcari As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnkembali As Button
    Friend WithEvents btnbatal As Button
    Friend WithEvents btnhapus As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents btntambah As Button
    Friend WithEvents txtnama As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtusername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents DTP As DateTimePicker
    Friend WithEvents txtalamat As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Label8 As Label
    Friend WithEvents ComboRole As ComboBox
End Class
