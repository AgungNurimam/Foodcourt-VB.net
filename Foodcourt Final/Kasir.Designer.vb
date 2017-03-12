<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kasir
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Kasir))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KasirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CounterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RiwayatTransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridRincian = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxTotal = New System.Windows.Forms.TextBox()
        Me.TextTotalBayar = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxKembalian = New System.Windows.Forms.TextBox()
        Me.ButtonHitung = New System.Windows.Forms.Button()
        Me.TextAtasNama = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridRincian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModeToolStripMenuItem, Me.RiwayatTransaksiToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1184, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ModeToolStripMenuItem
        '
        Me.ModeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdminToolStripMenuItem, Me.KasirToolStripMenuItem, Me.CounterToolStripMenuItem})
        Me.ModeToolStripMenuItem.Font = New System.Drawing.Font("Work Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModeToolStripMenuItem.Image = CType(resources.GetObject("ModeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ModeToolStripMenuItem.Name = "ModeToolStripMenuItem"
        Me.ModeToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.ModeToolStripMenuItem.Text = "Mode"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.Image = CType(resources.GetObject("AdminToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.AdminToolStripMenuItem.Text = "Admin"
        '
        'KasirToolStripMenuItem
        '
        Me.KasirToolStripMenuItem.Image = CType(resources.GetObject("KasirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.KasirToolStripMenuItem.Name = "KasirToolStripMenuItem"
        Me.KasirToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.KasirToolStripMenuItem.Text = "Kasir"
        '
        'CounterToolStripMenuItem
        '
        Me.CounterToolStripMenuItem.Image = CType(resources.GetObject("CounterToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CounterToolStripMenuItem.Name = "CounterToolStripMenuItem"
        Me.CounterToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.CounterToolStripMenuItem.Text = "Counter"
        '
        'RiwayatTransaksiToolStripMenuItem
        '
        Me.RiwayatTransaksiToolStripMenuItem.Name = "RiwayatTransaksiToolStripMenuItem"
        Me.RiwayatTransaksiToolStripMenuItem.Size = New System.Drawing.Size(112, 20)
        Me.RiwayatTransaksiToolStripMenuItem.Text = "Riwayat Transaksi"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Font = New System.Drawing.Font("Work Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeluarToolStripMenuItem.Image = CType(resources.GetObject("KeluarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(975, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(214, 20)
        Me.DateTimePicker1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(14, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 31)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Rincian :"
        '
        'DataGridRincian
        '
        Me.DataGridRincian.BackgroundColor = System.Drawing.SystemColors.InfoText
        Me.DataGridRincian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridRincian.Location = New System.Drawing.Point(21, 136)
        Me.DataGridRincian.Name = "DataGridRincian"
        Me.DataGridRincian.Size = New System.Drawing.Size(558, 348)
        Me.DataGridRincian.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Work Sans", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(597, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(177, 32)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Total Harga :"
        '
        'TextBoxTotal
        '
        Me.TextBoxTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTotal.Location = New System.Drawing.Point(810, 133)
        Me.TextBoxTotal.Name = "TextBoxTotal"
        Me.TextBoxTotal.ReadOnly = True
        Me.TextBoxTotal.Size = New System.Drawing.Size(366, 38)
        Me.TextBoxTotal.TabIndex = 9
        '
        'TextTotalBayar
        '
        Me.TextTotalBayar.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextTotalBayar.Location = New System.Drawing.Point(810, 192)
        Me.TextTotalBayar.Name = "TextTotalBayar"
        Me.TextTotalBayar.Size = New System.Drawing.Size(366, 38)
        Me.TextTotalBayar.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Work Sans", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(597, 433)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(188, 32)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Kembalian   :"
        '
        'TextBoxKembalian
        '
        Me.TextBoxKembalian.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxKembalian.Location = New System.Drawing.Point(810, 433)
        Me.TextBoxKembalian.Name = "TextBoxKembalian"
        Me.TextBoxKembalian.ReadOnly = True
        Me.TextBoxKembalian.Size = New System.Drawing.Size(366, 38)
        Me.TextBoxKembalian.TabIndex = 13
        '
        'ButtonHitung
        '
        Me.ButtonHitung.Font = New System.Drawing.Font("Work Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonHitung.Location = New System.Drawing.Point(810, 488)
        Me.ButtonHitung.Name = "ButtonHitung"
        Me.ButtonHitung.Size = New System.Drawing.Size(105, 72)
        Me.ButtonHitung.TabIndex = 18
        Me.ButtonHitung.Text = "Hitung"
        Me.ButtonHitung.UseVisualStyleBackColor = True
        '
        'TextAtasNama
        '
        Me.TextAtasNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextAtasNama.Location = New System.Drawing.Point(292, 48)
        Me.TextAtasNama.Name = "TextAtasNama"
        Me.TextAtasNama.Size = New System.Drawing.Size(206, 38)
        Me.TextAtasNama.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Work Sans", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(14, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(247, 32)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Masukkan Nama :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Work Sans", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(600, 196)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(174, 32)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Total Bayar :"
        '
        'BtnOK
        '
        Me.BtnOK.Font = New System.Drawing.Font("Work Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOK.Image = CType(resources.GetObject("BtnOK.Image"), System.Drawing.Image)
        Me.BtnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnOK.Location = New System.Drawing.Point(505, 48)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(90, 57)
        Me.BtnOK.TabIndex = 21
        Me.BtnOK.Text = "OK"
        Me.BtnOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Work Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(959, 488)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 72)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "Simpan"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Kasir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Blue
        Me.ClientSize = New System.Drawing.Size(1184, 592)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.TextAtasNama)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ButtonHitung)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBoxKembalian)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextTotalBayar)
        Me.Controls.Add(Me.TextBoxTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DataGridRincian)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Work Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Kasir"
        Me.Text = "Kasir"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridRincian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ModeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KasirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CounterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridRincian As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxTotal As System.Windows.Forms.TextBox
    Friend WithEvents TextTotalBayar As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBoxKembalian As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ButtonHitung As System.Windows.Forms.Button
    Friend WithEvents TextAtasNama As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BtnOK As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents RiwayatTransaksiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
