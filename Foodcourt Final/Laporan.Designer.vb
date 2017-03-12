<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Laporan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Laporan))
        Me.DataGridLaporan = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnBulan = New System.Windows.Forms.Button()
        Me.BtnTahun = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.KembaliToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBulan = New System.Windows.Forms.TextBox()
        Me.TextTahun = New System.Windows.Forms.TextBox()
        Me.ButtonBersihkan = New System.Windows.Forms.Button()
        Me.Textidcounter = New System.Windows.Forms.TextBox()
        Me.BtnLapCounter = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextTotalMasukBulan = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextTotalMasukTahun = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextTotalCounter = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.andtahun = New System.Windows.Forms.TextBox()
        Me.andok = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.andcounter = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.andtotal = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.andbulan = New System.Windows.Forms.TextBox()
        Me.TextBestseller = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.DataGridLaporan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridLaporan
        '
        Me.DataGridLaporan.BackgroundColor = System.Drawing.SystemColors.ControlText
        Me.DataGridLaporan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridLaporan.GridColor = System.Drawing.Color.Black
        Me.DataGridLaporan.Location = New System.Drawing.Point(297, 34)
        Me.DataGridLaporan.Name = "DataGridLaporan"
        Me.DataGridLaporan.Size = New System.Drawing.Size(923, 244)
        Me.DataGridLaporan.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Work Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Laporan Berdasarkan Bulan :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Work Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Laporan Berdasarkan Tahun :"
        '
        'BtnBulan
        '
        Me.BtnBulan.Font = New System.Drawing.Font("Work Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBulan.Location = New System.Drawing.Point(215, 55)
        Me.BtnBulan.Name = "BtnBulan"
        Me.BtnBulan.Size = New System.Drawing.Size(75, 23)
        Me.BtnBulan.TabIndex = 9
        Me.BtnBulan.Text = "Semua"
        Me.BtnBulan.UseVisualStyleBackColor = True
        '
        'BtnTahun
        '
        Me.BtnTahun.Font = New System.Drawing.Font("Work Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTahun.Location = New System.Drawing.Point(215, 124)
        Me.BtnTahun.Name = "BtnTahun"
        Me.BtnTahun.Size = New System.Drawing.Size(75, 23)
        Me.BtnTahun.TabIndex = 10
        Me.BtnTahun.Text = "Semua"
        Me.BtnTahun.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KembaliToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1244, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'KembaliToolStripMenuItem
        '
        Me.KembaliToolStripMenuItem.Image = CType(resources.GetObject("KembaliToolStripMenuItem.Image"), System.Drawing.Image)
        Me.KembaliToolStripMenuItem.Name = "KembaliToolStripMenuItem"
        Me.KembaliToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.KembaliToolStripMenuItem.Text = "Kembali"
        '
        'TextBulan
        '
        Me.TextBulan.Font = New System.Drawing.Font("Work Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBulan.Location = New System.Drawing.Point(12, 57)
        Me.TextBulan.Name = "TextBulan"
        Me.TextBulan.Size = New System.Drawing.Size(197, 20)
        Me.TextBulan.TabIndex = 12
        '
        'TextTahun
        '
        Me.TextTahun.Font = New System.Drawing.Font("Work Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextTahun.Location = New System.Drawing.Point(12, 127)
        Me.TextTahun.Name = "TextTahun"
        Me.TextTahun.Size = New System.Drawing.Size(197, 20)
        Me.TextTahun.TabIndex = 13
        '
        'ButtonBersihkan
        '
        Me.ButtonBersihkan.ForeColor = System.Drawing.Color.Black
        Me.ButtonBersihkan.Location = New System.Drawing.Point(1132, 284)
        Me.ButtonBersihkan.Name = "ButtonBersihkan"
        Me.ButtonBersihkan.Size = New System.Drawing.Size(88, 23)
        Me.ButtonBersihkan.TabIndex = 14
        Me.ButtonBersihkan.Text = "Bersihkan"
        Me.ButtonBersihkan.UseVisualStyleBackColor = True
        '
        'Textidcounter
        '
        Me.Textidcounter.Font = New System.Drawing.Font("Work Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Textidcounter.Location = New System.Drawing.Point(12, 200)
        Me.Textidcounter.Name = "Textidcounter"
        Me.Textidcounter.Size = New System.Drawing.Size(197, 20)
        Me.Textidcounter.TabIndex = 17
        '
        'BtnLapCounter
        '
        Me.BtnLapCounter.Font = New System.Drawing.Font("Work Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLapCounter.Location = New System.Drawing.Point(215, 197)
        Me.BtnLapCounter.Name = "BtnLapCounter"
        Me.BtnLapCounter.Size = New System.Drawing.Size(75, 23)
        Me.BtnLapCounter.TabIndex = 16
        Me.BtnLapCounter.Text = "Semua"
        Me.BtnLapCounter.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Work Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 184)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Laporan Berdasarkan Counter :"
        '
        'TextTotalMasukBulan
        '
        Me.TextTotalMasukBulan.Font = New System.Drawing.Font("Work Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextTotalMasukBulan.Location = New System.Drawing.Point(57, 84)
        Me.TextTotalMasukBulan.Name = "TextTotalMasukBulan"
        Me.TextTotalMasukBulan.Size = New System.Drawing.Size(152, 20)
        Me.TextTotalMasukBulan.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Work Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Total :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Work Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Total :"
        '
        'TextTotalMasukTahun
        '
        Me.TextTotalMasukTahun.Font = New System.Drawing.Font("Work Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextTotalMasukTahun.Location = New System.Drawing.Point(56, 159)
        Me.TextTotalMasukTahun.Name = "TextTotalMasukTahun"
        Me.TextTotalMasukTahun.Size = New System.Drawing.Size(153, 20)
        Me.TextTotalMasukTahun.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Work Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 229)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Total :"
        '
        'TextTotalCounter
        '
        Me.TextTotalCounter.Font = New System.Drawing.Font("Work Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextTotalCounter.Location = New System.Drawing.Point(59, 226)
        Me.TextTotalCounter.Name = "TextTotalCounter"
        Me.TextTotalCounter.Size = New System.Drawing.Size(150, 20)
        Me.TextTotalCounter.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Work Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(11, 303)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Tahun :"
        '
        'andtahun
        '
        Me.andtahun.Font = New System.Drawing.Font("Work Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.andtahun.Location = New System.Drawing.Point(68, 300)
        Me.andtahun.Name = "andtahun"
        Me.andtahun.Size = New System.Drawing.Size(161, 20)
        Me.andtahun.TabIndex = 27
        '
        'andok
        '
        Me.andok.Font = New System.Drawing.Font("Work Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.andok.ForeColor = System.Drawing.Color.Black
        Me.andok.Location = New System.Drawing.Point(233, 326)
        Me.andok.Name = "andok"
        Me.andok.Size = New System.Drawing.Size(57, 23)
        Me.andok.TabIndex = 25
        Me.andok.Text = "OK"
        Me.andok.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Work Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(9, 258)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(127, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Laporan Berdasarkan :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Work Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(11, 329)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Counter :"
        '
        'andcounter
        '
        Me.andcounter.Font = New System.Drawing.Font("Work Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.andcounter.Location = New System.Drawing.Point(68, 326)
        Me.andcounter.Name = "andcounter"
        Me.andcounter.Size = New System.Drawing.Size(161, 20)
        Me.andcounter.TabIndex = 29
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Work Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 355)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 13)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Total :"
        '
        'andtotal
        '
        Me.andtotal.Font = New System.Drawing.Font("Work Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.andtotal.Location = New System.Drawing.Point(68, 352)
        Me.andtotal.Name = "andtotal"
        Me.andtotal.Size = New System.Drawing.Size(161, 20)
        Me.andtotal.TabIndex = 31
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Work Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(11, 277)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Bulan :"
        '
        'andbulan
        '
        Me.andbulan.Font = New System.Drawing.Font("Work Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.andbulan.Location = New System.Drawing.Point(68, 274)
        Me.andbulan.Name = "andbulan"
        Me.andbulan.Size = New System.Drawing.Size(161, 20)
        Me.andbulan.TabIndex = 33
        '
        'TextBestseller
        '
        Me.TextBestseller.Location = New System.Drawing.Point(922, 322)
        Me.TextBestseller.Name = "TextBestseller"
        Me.TextBestseller.Size = New System.Drawing.Size(298, 20)
        Me.TextBestseller.TabIndex = 35
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(853, 325)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 13)
        Me.Label12.TabIndex = 36
        Me.Label12.Text = "Best Seller ;"
        '
        'Laporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.ClientSize = New System.Drawing.Size(1244, 444)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TextBestseller)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.andbulan)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.andtotal)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.andcounter)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.andtahun)
        Me.Controls.Add(Me.andok)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextTotalCounter)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextTotalMasukTahun)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextTotalMasukBulan)
        Me.Controls.Add(Me.Textidcounter)
        Me.Controls.Add(Me.BtnLapCounter)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonBersihkan)
        Me.Controls.Add(Me.TextTahun)
        Me.Controls.Add(Me.TextBulan)
        Me.Controls.Add(Me.BtnTahun)
        Me.Controls.Add(Me.BtnBulan)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridLaporan)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Laporan"
        Me.Text = "Laporan"
        CType(Me.DataGridLaporan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridLaporan As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnBulan As System.Windows.Forms.Button
    Friend WithEvents BtnTahun As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents KembaliToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBulan As System.Windows.Forms.TextBox
    Friend WithEvents TextTahun As System.Windows.Forms.TextBox
    Friend WithEvents ButtonBersihkan As System.Windows.Forms.Button
    Friend WithEvents Textidcounter As System.Windows.Forms.TextBox
    Friend WithEvents BtnLapCounter As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextTotalMasukBulan As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextTotalMasukTahun As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextTotalCounter As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents andtahun As System.Windows.Forms.TextBox
    Friend WithEvents andok As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents andcounter As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents andtotal As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents andbulan As System.Windows.Forms.TextBox
    Friend WithEvents TextBestseller As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
