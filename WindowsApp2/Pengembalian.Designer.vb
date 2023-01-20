<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pengembalian
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
        Me.btnkembali = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtp2 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Combokode = New System.Windows.Forms.ComboBox()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnkembali
        '
        Me.btnkembali.Location = New System.Drawing.Point(346, 410)
        Me.btnkembali.Name = "btnkembali"
        Me.btnkembali.Size = New System.Drawing.Size(145, 35)
        Me.btnkembali.TabIndex = 85
        Me.btnkembali.Text = "Kembali"
        Me.btnkembali.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(21, 410)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(145, 35)
        Me.btnsimpan.TabIndex = 83
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Location = New System.Drawing.Point(428, 377)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(13, 13)
        Me.lbltotal.TabIndex = 82
        Me.lbltotal.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(343, 377)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 81
        Me.Label6.Text = "Jumlah Pinjam"
        '
        'btnbatal
        '
        Me.btnbatal.Location = New System.Drawing.Point(183, 410)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(145, 35)
        Me.btnbatal.TabIndex = 84
        Me.btnbatal.Text = "Batal"
        Me.btnbatal.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(376, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 77
        Me.Label5.Text = "Nama Pegawai"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(376, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "Tanggal Kembali"
        '
        'dtp2
        '
        Me.dtp2.CustomFormat = "dd MMMM yyyy"
        Me.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp2.Location = New System.Drawing.Point(486, 87)
        Me.dtp2.Name = "dtp2"
        Me.dtp2.Size = New System.Drawing.Size(200, 20)
        Me.dtp2.TabIndex = 75
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Tanggal Pinjam"
        '
        'dtp1
        '
        Me.dtp1.CustomFormat = "dd MMMM yyyy"
        Me.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp1.Location = New System.Drawing.Point(128, 118)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(200, 20)
        Me.dtp1.TabIndex = 73
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(-5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(717, 66)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Pengembalian Barang"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.DGV.Location = New System.Drawing.Point(21, 187)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(665, 178)
        Me.DGV.TabIndex = 79
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(712, 66)
        Me.Panel1.TabIndex = 72
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Kode Peminjaman"
        '
        'Combokode
        '
        Me.Combokode.FormattingEnabled = True
        Me.Combokode.Location = New System.Drawing.Point(128, 86)
        Me.Combokode.Name = "Combokode"
        Me.Combokode.Size = New System.Drawing.Size(200, 21)
        Me.Combokode.TabIndex = 86
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(486, 120)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(200, 20)
        Me.txtnama.TabIndex = 87
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Kode Barang"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 220
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nama Barang"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 300
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Jumlah Pinjam"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'Pengembalian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 457)
        Me.Controls.Add(Me.txtnama)
        Me.Controls.Add(Me.Combokode)
        Me.Controls.Add(Me.btnkembali)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnbatal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtp2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtp1)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Pengembalian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pengembalian"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnkembali As Button
    Friend WithEvents btnsimpan As Button
    Friend WithEvents lbltotal As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnbatal As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dtp2 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents dtp1 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents DGV As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Combokode As ComboBox
    Friend WithEvents txtnama As TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
End Class
