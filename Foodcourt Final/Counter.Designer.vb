<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Counter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Counter))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KasirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CounterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditPesananToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformasiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuTerkarisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CounterTerlarisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextCounter = New System.Windows.Forms.TextBox()
        Me.DataGridViewMenuCounter = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridViewTransaksi = New System.Windows.Forms.DataGridView()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextTotalHarga = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxNamaCounter = New System.Windows.Forms.TextBox()
        Me.TexAtasNama = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnLihatID = New System.Windows.Forms.Button()
        Me.BtnOrder = New System.Windows.Forms.Button()
        Me.ButtonBatal = New System.Windows.Forms.Button()
        Me.ButtonKosongkan = New System.Windows.Forms.Button()
        Me.BtnPesan = New System.Windows.Forms.Button()
        Me.BtnCounter = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridViewMenuCounter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewTransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModeToolStripMenuItem, Me.EditMenuToolStripMenuItem, Me.EditPesananToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.InformasiToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1190, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ModeToolStripMenuItem
        '
        Me.ModeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KasirToolStripMenuItem, Me.AdminToolStripMenuItem, Me.CounterToolStripMenuItem})
        Me.ModeToolStripMenuItem.Font = New System.Drawing.Font("Work Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModeToolStripMenuItem.Image = CType(resources.GetObject("ModeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ModeToolStripMenuItem.Name = "ModeToolStripMenuItem"
        Me.ModeToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.ModeToolStripMenuItem.Text = "Mode"
        '
        'KasirToolStripMenuItem
        '
        Me.KasirToolStripMenuItem.Image = CType(resources.GetObject("KasirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.KasirToolStripMenuItem.Name = "KasirToolStripMenuItem"
        Me.KasirToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.KasirToolStripMenuItem.Text = "Kasir"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.Image = CType(resources.GetObject("AdminToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.AdminToolStripMenuItem.Text = "Admin"
        '
        'CounterToolStripMenuItem
        '
        Me.CounterToolStripMenuItem.Image = CType(resources.GetObject("CounterToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CounterToolStripMenuItem.Name = "CounterToolStripMenuItem"
        Me.CounterToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.CounterToolStripMenuItem.Text = "Counter"
        '
        'EditMenuToolStripMenuItem
        '
        Me.EditMenuToolStripMenuItem.Font = New System.Drawing.Font("Work Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditMenuToolStripMenuItem.Name = "EditMenuToolStripMenuItem"
        Me.EditMenuToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.EditMenuToolStripMenuItem.Text = "Edit Menu"
        '
        'EditPesananToolStripMenuItem
        '
        Me.EditPesananToolStripMenuItem.Name = "EditPesananToolStripMenuItem"
        Me.EditPesananToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.EditPesananToolStripMenuItem.Text = "Edit Pesanan"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.Font = New System.Drawing.Font("Work Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaporanToolStripMenuItem.Image = CType(resources.GetObject("LaporanToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'InformasiToolStripMenuItem
        '
        Me.InformasiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuTerkarisToolStripMenuItem, Me.CounterTerlarisToolStripMenuItem})
        Me.InformasiToolStripMenuItem.Name = "InformasiToolStripMenuItem"
        Me.InformasiToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.InformasiToolStripMenuItem.Text = "Informasi"
        '
        'MenuTerkarisToolStripMenuItem
        '
        Me.MenuTerkarisToolStripMenuItem.Name = "MenuTerkarisToolStripMenuItem"
        Me.MenuTerkarisToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.MenuTerkarisToolStripMenuItem.Text = "Menu Terkaris"
        '
        'CounterTerlarisToolStripMenuItem
        '
        Me.CounterTerlarisToolStripMenuItem.Name = "CounterTerlarisToolStripMenuItem"
        Me.CounterTerlarisToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.CounterTerlarisToolStripMenuItem.Text = "Counter Terlaris"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Font = New System.Drawing.Font("Work Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeluarToolStripMenuItem.Image = CType(resources.GetObject("KeluarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Work Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(26, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID Counter :"
        '
        'TextCounter
        '
        Me.TextCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextCounter.Location = New System.Drawing.Point(184, 45)
        Me.TextCounter.Name = "TextCounter"
        Me.TextCounter.Size = New System.Drawing.Size(217, 26)
        Me.TextCounter.TabIndex = 2
        '
        'DataGridViewMenuCounter
        '
        Me.DataGridViewMenuCounter.BackgroundColor = System.Drawing.SystemColors.ControlText
        Me.DataGridViewMenuCounter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewMenuCounter.Location = New System.Drawing.Point(30, 182)
        Me.DataGridViewMenuCounter.Name = "DataGridViewMenuCounter"
        Me.DataGridViewMenuCounter.Size = New System.Drawing.Size(488, 333)
        Me.DataGridViewMenuCounter.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Work Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(667, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Daftar Pesanan :"
        '
        'DataGridViewTransaksi
        '
        Me.DataGridViewTransaksi.BackgroundColor = System.Drawing.SystemColors.ControlText
        Me.DataGridViewTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewTransaksi.Location = New System.Drawing.Point(672, 74)
        Me.DataGridViewTransaksi.Name = "DataGridViewTransaksi"
        Me.DataGridViewTransaksi.Size = New System.Drawing.Size(504, 342)
        Me.DataGridViewTransaksi.TabIndex = 6
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Work Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(957, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(233, 20)
        Me.DateTimePicker1.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Work Sans", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(660, 430)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(177, 32)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Total Harga :"
        '
        'TextTotalHarga
        '
        Me.TextTotalHarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextTotalHarga.Location = New System.Drawing.Point(859, 430)
        Me.TextTotalHarga.Name = "TextTotalHarga"
        Me.TextTotalHarga.ReadOnly = True
        Me.TextTotalHarga.Size = New System.Drawing.Size(317, 38)
        Me.TextTotalHarga.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Work Sans", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(24, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 24)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Menu :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Work Sans", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(24, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(164, 24)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Nama Counter :"
        '
        'TextBoxNamaCounter
        '
        Me.TextBoxNamaCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNamaCounter.Location = New System.Drawing.Point(30, 121)
        Me.TextBoxNamaCounter.Name = "TextBoxNamaCounter"
        Me.TextBoxNamaCounter.ReadOnly = True
        Me.TextBoxNamaCounter.Size = New System.Drawing.Size(487, 30)
        Me.TextBoxNamaCounter.TabIndex = 18
        '
        'TexAtasNama
        '
        Me.TexAtasNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TexAtasNama.Location = New System.Drawing.Point(859, 477)
        Me.TexAtasNama.Name = "TexAtasNama"
        Me.TexAtasNama.Size = New System.Drawing.Size(317, 38)
        Me.TexAtasNama.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Work Sans", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(660, 483)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 32)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Nama :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(930, 32)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 36)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Kosongkan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnLihatID
        '
        Me.BtnLihatID.Font = New System.Drawing.Font("Work Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLihatID.Image = CType(resources.GetObject("BtnLihatID.Image"), System.Drawing.Image)
        Me.BtnLihatID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLihatID.Location = New System.Drawing.Point(530, 45)
        Me.BtnLihatID.Name = "BtnLihatID"
        Me.BtnLihatID.Size = New System.Drawing.Size(121, 63)
        Me.BtnLihatID.TabIndex = 22
        Me.BtnLihatID.Text = "Lihat ID"
        Me.BtnLihatID.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLihatID.UseVisualStyleBackColor = True
        '
        'BtnOrder
        '
        Me.BtnOrder.Font = New System.Drawing.Font("Work Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOrder.Image = CType(resources.GetObject("BtnOrder.Image"), System.Drawing.Image)
        Me.BtnOrder.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnOrder.Location = New System.Drawing.Point(1055, 521)
        Me.BtnOrder.Name = "BtnOrder"
        Me.BtnOrder.Size = New System.Drawing.Size(121, 74)
        Me.BtnOrder.TabIndex = 19
        Me.BtnOrder.Text = "Pesan Baru"
        Me.BtnOrder.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnOrder.UseVisualStyleBackColor = True
        '
        'ButtonBatal
        '
        Me.ButtonBatal.Font = New System.Drawing.Font("Work Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBatal.Image = CType(resources.GetObject("ButtonBatal.Image"), System.Drawing.Image)
        Me.ButtonBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonBatal.Location = New System.Drawing.Point(530, 284)
        Me.ButtonBatal.Name = "ButtonBatal"
        Me.ButtonBatal.Size = New System.Drawing.Size(121, 72)
        Me.ButtonBatal.TabIndex = 16
        Me.ButtonBatal.Text = "Batal <<"
        Me.ButtonBatal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonBatal.UseVisualStyleBackColor = True
        '
        'ButtonKosongkan
        '
        Me.ButtonKosongkan.Font = New System.Drawing.Font("Work Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonKosongkan.Image = CType(resources.GetObject("ButtonKosongkan.Image"), System.Drawing.Image)
        Me.ButtonKosongkan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonKosongkan.Location = New System.Drawing.Point(824, 32)
        Me.ButtonKosongkan.Name = "ButtonKosongkan"
        Me.ButtonKosongkan.Size = New System.Drawing.Size(100, 36)
        Me.ButtonKosongkan.TabIndex = 12
        Me.ButtonKosongkan.Text = "Refresh"
        Me.ButtonKosongkan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonKosongkan.UseVisualStyleBackColor = True
        '
        'BtnPesan
        '
        Me.BtnPesan.Font = New System.Drawing.Font("Work Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPesan.Image = CType(resources.GetObject("BtnPesan.Image"), System.Drawing.Image)
        Me.BtnPesan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPesan.Location = New System.Drawing.Point(530, 194)
        Me.BtnPesan.Name = "BtnPesan"
        Me.BtnPesan.Size = New System.Drawing.Size(121, 70)
        Me.BtnPesan.TabIndex = 11
        Me.BtnPesan.Text = "Pesan >>"
        Me.BtnPesan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnPesan.UseVisualStyleBackColor = True
        '
        'BtnCounter
        '
        Me.BtnCounter.Font = New System.Drawing.Font("Work Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCounter.Image = CType(resources.GetObject("BtnCounter.Image"), System.Drawing.Image)
        Me.BtnCounter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCounter.Location = New System.Drawing.Point(408, 45)
        Me.BtnCounter.Name = "BtnCounter"
        Me.BtnCounter.Size = New System.Drawing.Size(96, 63)
        Me.BtnCounter.TabIndex = 10
        Me.BtnCounter.Text = "OK"
        Me.BtnCounter.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCounter.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Work Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.Location = New System.Drawing.Point(859, 521)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(121, 74)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Update Pesanan"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Counter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.ClientSize = New System.Drawing.Size(1190, 673)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnLihatID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TexAtasNama)
        Me.Controls.Add(Me.BtnOrder)
        Me.Controls.Add(Me.TextBoxNamaCounter)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ButtonBatal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextTotalHarga)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ButtonKosongkan)
        Me.Controls.Add(Me.BtnPesan)
        Me.Controls.Add(Me.BtnCounter)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.DataGridViewTransaksi)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridViewMenuCounter)
        Me.Controls.Add(Me.TextCounter)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Work Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Counter"
        Me.Text = "Counter"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridViewMenuCounter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewTransaksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ModeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

    Private Sub ModeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModeToolStripMenuItem.Click

    End Sub
    Friend WithEvents KasirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CounterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextCounter As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewMenuCounter As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTransaksi As System.Windows.Forms.DataGridView
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnCounter As System.Windows.Forms.Button
    Friend WithEvents BtnPesan As System.Windows.Forms.Button
    Friend WithEvents ButtonKosongkan As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextTotalHarga As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ButtonBatal As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBoxNamaCounter As System.Windows.Forms.TextBox
    Friend WithEvents BtnOrder As System.Windows.Forms.Button
    Friend WithEvents TexAtasNama As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BtnLihatID As System.Windows.Forms.Button
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents InformasiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuTerkarisToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CounterTerlarisToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditPesananToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
