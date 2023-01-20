<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Peminjaman
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtkode = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtp2 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Combopegawai = New System.Windows.Forms.ComboBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGVInventaris = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.btnkembali = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVInventaris, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Peminjaman"
        '
        'txtkode
        '
        Me.txtkode.Location = New System.Drawing.Point(131, 81)
        Me.txtkode.Name = "txtkode"
        Me.txtkode.Size = New System.Drawing.Size(200, 20)
        Me.txtkode.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(858, 66)
        Me.Panel1.TabIndex = 55
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(-5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(863, 66)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Peminjaman Barang"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtp1
        '
        Me.dtp1.CustomFormat = "dd MMMM yyyy"
        Me.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp1.Location = New System.Drawing.Point(131, 113)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(200, 20)
        Me.dtp1.TabIndex = 56
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Tanggal Pinjam"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(379, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Tanggal Kembali"
        '
        'dtp2
        '
        Me.dtp2.CustomFormat = "dd MMMM yyyy"
        Me.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp2.Location = New System.Drawing.Point(489, 82)
        Me.dtp2.Name = "dtp2"
        Me.dtp2.Size = New System.Drawing.Size(200, 20)
        Me.dtp2.TabIndex = 59
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(379, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "Nama Pegawai"
        '
        'Combopegawai
        '
        Me.Combopegawai.FormattingEnabled = True
        Me.Combopegawai.Location = New System.Drawing.Point(489, 114)
        Me.Combopegawai.Name = "Combopegawai"
        Me.Combopegawai.Size = New System.Drawing.Size(200, 21)
        Me.Combopegawai.TabIndex = 62
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.DGV.Location = New System.Drawing.Point(24, 182)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(448, 178)
        Me.DGV.TabIndex = 63
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Kode Barang"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nama Barang"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 204
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Jumlah Pinjam"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DGVInventaris
        '
        Me.DGVInventaris.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVInventaris.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.DGVInventaris.Location = New System.Drawing.Point(489, 182)
        Me.DGVInventaris.Name = "DGVInventaris"
        Me.DGVInventaris.Size = New System.Drawing.Size(338, 178)
        Me.DGVInventaris.TabIndex = 64
        '
        'Column1
        '
        Me.Column1.HeaderText = "Kode Barang"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nama Barang"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 200
        '
        'Column3
        '
        Me.Column3.HeaderText = "Jumlah"
        Me.Column3.Name = "Column3"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(346, 372)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "Jumlah Pinjam"
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(431, 372)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(13, 13)
        Me.lbltotal.TabIndex = 66
        Me.lbltotal.Text = "0"
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(24, 405)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(145, 35)
        Me.btnsimpan.TabIndex = 67
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'btnbatal
        '
        Me.btnbatal.Location = New System.Drawing.Point(186, 405)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(145, 35)
        Me.btnbatal.TabIndex = 68
        Me.btnbatal.Text = "Batal"
        Me.btnbatal.UseVisualStyleBackColor = True
        '
        'btnkembali
        '
        Me.btnkembali.Location = New System.Drawing.Point(349, 405)
        Me.btnkembali.Name = "btnkembali"
        Me.btnkembali.Size = New System.Drawing.Size(145, 35)
        Me.btnkembali.TabIndex = 69
        Me.btnkembali.Text = "Kembali"
        Me.btnkembali.UseVisualStyleBackColor = True
        '
        'Peminjaman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 458)
        Me.Controls.Add(Me.btnkembali)
        Me.Controls.Add(Me.btnbatal)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DGVInventaris)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.Combopegawai)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtp2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtp1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtkode)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Peminjaman"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Peminjaman Barang"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVInventaris, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtkode As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents dtp1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtp2 As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Combopegawai As ComboBox
    Friend WithEvents DGV As DataGridView
    Friend WithEvents DGVInventaris As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents lbltotal As Label
    Friend WithEvents btnsimpan As Button
    Friend WithEvents btnbatal As Button
    Friend WithEvents btnkembali As Button
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
End Class
