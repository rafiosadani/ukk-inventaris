<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MasterInventaris
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtkondisi = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnkembali = New System.Windows.Forms.Button()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.txtketerangan = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtjumlah = New System.Windows.Forms.TextBox()
        Me.Combojenis = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Comboruang = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtkode = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(426, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 78
        Me.Label5.Text = "Jumlah"
        '
        'txtkondisi
        '
        Me.txtkondisi.Location = New System.Drawing.Point(135, 133)
        Me.txtkondisi.Name = "txtkondisi"
        Me.txtkondisi.Size = New System.Drawing.Size(201, 20)
        Me.txtkondisi.TabIndex = 77
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "Kondisi"
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(408, 209)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(76, 32)
        Me.btnsimpan.TabIndex = 71
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtcari)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 254)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(734, 42)
        Me.GroupBox1.TabIndex = 75
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.DataGridView1.Location = New System.Drawing.Point(25, 302)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(735, 144)
        Me.DataGridView1.TabIndex = 74
        '
        'Column1
        '
        Me.Column1.HeaderText = "Kode Barang"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 170
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nama Barang"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 120
        '
        'Column3
        '
        Me.Column3.HeaderText = "Kondisi"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 170
        '
        'Column4
        '
        Me.Column4.HeaderText = "Keterangan"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 150
        '
        'Column5
        '
        Me.Column5.HeaderText = "Jumlah"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Jenis"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 150
        '
        'Column7
        '
        Me.Column7.HeaderText = "Ruang"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 150
        '
        'btnkembali
        '
        Me.btnkembali.Location = New System.Drawing.Point(684, 209)
        Me.btnkembali.Name = "btnkembali"
        Me.btnkembali.Size = New System.Drawing.Size(76, 32)
        Me.btnkembali.TabIndex = 73
        Me.btnkembali.Text = "Kembali"
        Me.btnkembali.UseVisualStyleBackColor = True
        '
        'btnbatal
        '
        Me.btnbatal.Location = New System.Drawing.Point(546, 209)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(76, 32)
        Me.btnbatal.TabIndex = 72
        Me.btnbatal.Text = "Batal"
        Me.btnbatal.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Location = New System.Drawing.Point(274, 209)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(76, 32)
        Me.btnhapus.TabIndex = 70
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Location = New System.Drawing.Point(148, 209)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(76, 32)
        Me.btnedit.TabIndex = 69
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btntambah
        '
        Me.btntambah.Location = New System.Drawing.Point(25, 209)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(76, 32)
        Me.btntambah.TabIndex = 68
        Me.btntambah.Text = "Tambah"
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'txtketerangan
        '
        Me.txtketerangan.Location = New System.Drawing.Point(135, 159)
        Me.txtketerangan.Name = "txtketerangan"
        Me.txtketerangan.Size = New System.Drawing.Size(201, 20)
        Me.txtketerangan.TabIndex = 67
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Keterangan"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(790, 66)
        Me.Panel1.TabIndex = 65
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(1, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(785, 66)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Master Data Inventaris"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(135, 107)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(201, 20)
        Me.txtnama.TabIndex = 64
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Nama Barang"
        '
        'txtjumlah
        '
        Me.txtjumlah.Location = New System.Drawing.Point(517, 79)
        Me.txtjumlah.Name = "txtjumlah"
        Me.txtjumlah.Size = New System.Drawing.Size(202, 20)
        Me.txtjumlah.TabIndex = 87
        '
        'Combojenis
        '
        Me.Combojenis.FormattingEnabled = True
        Me.Combojenis.Location = New System.Drawing.Point(517, 118)
        Me.Combojenis.Name = "Combojenis"
        Me.Combojenis.Size = New System.Drawing.Size(202, 21)
        Me.Combojenis.TabIndex = 89
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(426, 122)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 13)
        Me.Label7.TabIndex = 88
        Me.Label7.Text = "Jenis"
        '
        'Comboruang
        '
        Me.Comboruang.FormattingEnabled = True
        Me.Comboruang.Location = New System.Drawing.Point(517, 157)
        Me.Comboruang.Name = "Comboruang"
        Me.Comboruang.Size = New System.Drawing.Size(202, 21)
        Me.Comboruang.TabIndex = 91
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(426, 161)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 90
        Me.Label6.Text = "Ruang"
        '
        'txtkode
        '
        Me.txtkode.Location = New System.Drawing.Point(135, 79)
        Me.txtkode.Name = "txtkode"
        Me.txtkode.Size = New System.Drawing.Size(201, 20)
        Me.txtkode.TabIndex = 93
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(22, 82)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 13)
        Me.Label9.TabIndex = 92
        Me.Label9.Text = "Kode Barang"
        '
        'MasterInventaris
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 465)
        Me.Controls.Add(Me.txtkode)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Comboruang)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Combojenis)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtjumlah)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtkondisi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnkembali)
        Me.Controls.Add(Me.btnbatal)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.txtketerangan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MasterInventaris"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MasterInventaris"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents txtkondisi As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnsimpan As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtcari As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnkembali As Button
    Friend WithEvents btnbatal As Button
    Friend WithEvents btnhapus As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents btntambah As Button
    Friend WithEvents txtketerangan As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents txtnama As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtjumlah As TextBox
    Friend WithEvents Combojenis As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Comboruang As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtkode As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
End Class
