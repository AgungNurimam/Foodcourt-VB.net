<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin))
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxNama = New System.Windows.Forms.TextBox()
        Me.TextBoxJabatan = New System.Windows.Forms.TextBox()
        Me.TextBoxUsername = New System.Windows.Forms.TextBox()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.TextPassAdmin = New System.Windows.Forms.TextBox()
        Me.TextUsrAdmin = New System.Windows.Forms.TextBox()
        Me.TextJabatanAdmin = New System.Windows.Forms.TextBox()
        Me.TextNamaAdmin = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DataUser = New System.Windows.Forms.DataGridView()
        Me.DataAdmin = New System.Windows.Forms.DataGridView()
        Me.TextBoxRePasword = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBoxRePasswordAdmin = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ButtonSimpan = New System.Windows.Forms.Button()
        Me.Hapus2 = New System.Windows.Forms.Button()
        Me.Hapus = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KasirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CounterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InputDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InputDataMakananMinumanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InputDataCounterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanHarianToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanBulananToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanTahunanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SemuaLaporanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanCounterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.C01ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.C02ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CO3ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CO4ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CO5ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanGrafikToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanHarianToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanBulananToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanTahunanToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LaporanCounterToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TentangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(1342, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(233, 20)
        Me.DateTimePicker1.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModeToolStripMenuItem, Me.InputDataToolStripMenuItem, Me.LaporanToolStripMenuItem, Me.TentangToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(885, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Work Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(363, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Penambahan Akun Kasir/Counter :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Work Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(14, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Work Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Jabatan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Work Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 19)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Username"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Work Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(13, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 19)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Password"
        '
        'TextBoxNama
        '
        Me.TextBoxNama.Font = New System.Drawing.Font("Work Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxNama.Location = New System.Drawing.Point(134, 83)
        Me.TextBoxNama.Name = "TextBoxNama"
        Me.TextBoxNama.Size = New System.Drawing.Size(224, 26)
        Me.TextBoxNama.TabIndex = 7
        '
        'TextBoxJabatan
        '
        Me.TextBoxJabatan.Font = New System.Drawing.Font("Work Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxJabatan.Location = New System.Drawing.Point(134, 114)
        Me.TextBoxJabatan.Name = "TextBoxJabatan"
        Me.TextBoxJabatan.Size = New System.Drawing.Size(224, 26)
        Me.TextBoxJabatan.TabIndex = 8
        '
        'TextBoxUsername
        '
        Me.TextBoxUsername.Font = New System.Drawing.Font("Work Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxUsername.Location = New System.Drawing.Point(134, 145)
        Me.TextBoxUsername.Name = "TextBoxUsername"
        Me.TextBoxUsername.Size = New System.Drawing.Size(224, 26)
        Me.TextBoxUsername.TabIndex = 9
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Font = New System.Drawing.Font("Work Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPassword.Location = New System.Drawing.Point(134, 175)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxPassword.Size = New System.Drawing.Size(224, 26)
        Me.TextBoxPassword.TabIndex = 10
        '
        'TextPassAdmin
        '
        Me.TextPassAdmin.Font = New System.Drawing.Font("Work Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextPassAdmin.Location = New System.Drawing.Point(138, 469)
        Me.TextPassAdmin.Name = "TextPassAdmin"
        Me.TextPassAdmin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextPassAdmin.Size = New System.Drawing.Size(224, 26)
        Me.TextPassAdmin.TabIndex = 20
        '
        'TextUsrAdmin
        '
        Me.TextUsrAdmin.Font = New System.Drawing.Font("Work Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextUsrAdmin.Location = New System.Drawing.Point(138, 439)
        Me.TextUsrAdmin.Name = "TextUsrAdmin"
        Me.TextUsrAdmin.Size = New System.Drawing.Size(224, 26)
        Me.TextUsrAdmin.TabIndex = 19
        '
        'TextJabatanAdmin
        '
        Me.TextJabatanAdmin.Font = New System.Drawing.Font("Work Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextJabatanAdmin.Location = New System.Drawing.Point(138, 409)
        Me.TextJabatanAdmin.Name = "TextJabatanAdmin"
        Me.TextJabatanAdmin.Size = New System.Drawing.Size(224, 26)
        Me.TextJabatanAdmin.TabIndex = 18
        '
        'TextNamaAdmin
        '
        Me.TextNamaAdmin.Font = New System.Drawing.Font("Work Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextNamaAdmin.Location = New System.Drawing.Point(138, 377)
        Me.TextNamaAdmin.Name = "TextNamaAdmin"
        Me.TextNamaAdmin.Size = New System.Drawing.Size(224, 26)
        Me.TextNamaAdmin.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Work Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(16, 472)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 19)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Password"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Work Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(15, 442)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 19)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Username"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Work Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(15, 414)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 19)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Jabatan"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Work Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(16, 380)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 19)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Nama"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Work Sans", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(14, 344)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(285, 23)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Penambahan Akun Admin :"
        '
        'DataUser
        '
        Me.DataUser.BackgroundColor = System.Drawing.SystemColors.ControlText
        Me.DataUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataUser.GridColor = System.Drawing.Color.White
        Me.DataUser.Location = New System.Drawing.Point(388, 83)
        Me.DataUser.Name = "DataUser"
        Me.DataUser.Size = New System.Drawing.Size(470, 122)
        Me.DataUser.TabIndex = 22
        '
        'DataAdmin
        '
        Me.DataAdmin.BackgroundColor = System.Drawing.SystemColors.ControlText
        Me.DataAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataAdmin.Location = New System.Drawing.Point(388, 377)
        Me.DataAdmin.Name = "DataAdmin"
        Me.DataAdmin.Size = New System.Drawing.Size(470, 122)
        Me.DataAdmin.TabIndex = 24
        '
        'TextBoxRePasword
        '
        Me.TextBoxRePasword.Font = New System.Drawing.Font("Work Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxRePasword.Location = New System.Drawing.Point(134, 205)
        Me.TextBoxRePasword.Name = "TextBoxRePasword"
        Me.TextBoxRePasword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxRePasword.Size = New System.Drawing.Size(224, 26)
        Me.TextBoxRePasword.TabIndex = 27
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Work Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(13, 210)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(133, 19)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Re-Password   :"
        '
        'TextBoxRePasswordAdmin
        '
        Me.TextBoxRePasswordAdmin.Font = New System.Drawing.Font("Work Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxRePasswordAdmin.Location = New System.Drawing.Point(138, 500)
        Me.TextBoxRePasswordAdmin.Name = "TextBoxRePasswordAdmin"
        Me.TextBoxRePasswordAdmin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxRePasswordAdmin.Size = New System.Drawing.Size(224, 26)
        Me.TextBoxRePasswordAdmin.TabIndex = 30
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Work Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(16, 501)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(113, 19)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Re-Password"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'ButtonSimpan
        '
        Me.ButtonSimpan.Font = New System.Drawing.Font("Work Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSimpan.ForeColor = System.Drawing.Color.Black
        Me.ButtonSimpan.Image = CType(resources.GetObject("ButtonSimpan.Image"), System.Drawing.Image)
        Me.ButtonSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonSimpan.Location = New System.Drawing.Point(134, 237)
        Me.ButtonSimpan.Name = "ButtonSimpan"
        Me.ButtonSimpan.Size = New System.Drawing.Size(125, 55)
        Me.ButtonSimpan.TabIndex = 31
        Me.ButtonSimpan.Text = "Simpan"
        Me.ButtonSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonSimpan.UseVisualStyleBackColor = True
        '
        'Hapus2
        '
        Me.Hapus2.Font = New System.Drawing.Font("Work Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hapus2.ForeColor = System.Drawing.Color.Black
        Me.Hapus2.Image = CType(resources.GetObject("Hapus2.Image"), System.Drawing.Image)
        Me.Hapus2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Hapus2.Location = New System.Drawing.Point(388, 505)
        Me.Hapus2.Name = "Hapus2"
        Me.Hapus2.Size = New System.Drawing.Size(106, 56)
        Me.Hapus2.TabIndex = 25
        Me.Hapus2.Text = "Hapus"
        Me.Hapus2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Hapus2.UseVisualStyleBackColor = True
        '
        'Hapus
        '
        Me.Hapus.Font = New System.Drawing.Font("Work Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hapus.ForeColor = System.Drawing.Color.Black
        Me.Hapus.Image = CType(resources.GetObject("Hapus.Image"), System.Drawing.Image)
        Me.Hapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Hapus.Location = New System.Drawing.Point(388, 211)
        Me.Hapus.Name = "Hapus"
        Me.Hapus.Size = New System.Drawing.Size(106, 56)
        Me.Hapus.TabIndex = 23
        Me.Hapus.Text = "Hapus"
        Me.Hapus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Hapus.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Work Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(138, 532)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 55)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Simpan"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
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
        'InputDataToolStripMenuItem
        '
        Me.InputDataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InputDataMakananMinumanToolStripMenuItem, Me.InputDataCounterToolStripMenuItem})
        Me.InputDataToolStripMenuItem.Font = New System.Drawing.Font("Work Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InputDataToolStripMenuItem.Image = CType(resources.GetObject("InputDataToolStripMenuItem.Image"), System.Drawing.Image)
        Me.InputDataToolStripMenuItem.Name = "InputDataToolStripMenuItem"
        Me.InputDataToolStripMenuItem.Size = New System.Drawing.Size(93, 20)
        Me.InputDataToolStripMenuItem.Text = "Input Data"
        '
        'InputDataMakananMinumanToolStripMenuItem
        '
        Me.InputDataMakananMinumanToolStripMenuItem.Name = "InputDataMakananMinumanToolStripMenuItem"
        Me.InputDataMakananMinumanToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.InputDataMakananMinumanToolStripMenuItem.Text = "Input Data Makanan Minuman"
        '
        'InputDataCounterToolStripMenuItem
        '
        Me.InputDataCounterToolStripMenuItem.Name = "InputDataCounterToolStripMenuItem"
        Me.InputDataCounterToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.InputDataCounterToolStripMenuItem.Text = "Input Data Counter"
        '
        'LaporanToolStripMenuItem
        '
        Me.LaporanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanHarianToolStripMenuItem, Me.LaporanBulananToolStripMenuItem, Me.LaporanTahunanToolStripMenuItem, Me.SemuaLaporanToolStripMenuItem, Me.LaporanCounterToolStripMenuItem, Me.LaporanGrafikToolStripMenuItem})
        Me.LaporanToolStripMenuItem.Font = New System.Drawing.Font("Work Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaporanToolStripMenuItem.Image = CType(resources.GetObject("LaporanToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        Me.LaporanToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.LaporanToolStripMenuItem.Text = "Laporan"
        '
        'LaporanHarianToolStripMenuItem
        '
        Me.LaporanHarianToolStripMenuItem.Name = "LaporanHarianToolStripMenuItem"
        Me.LaporanHarianToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.LaporanHarianToolStripMenuItem.Text = "Laporan Harian"
        '
        'LaporanBulananToolStripMenuItem
        '
        Me.LaporanBulananToolStripMenuItem.Name = "LaporanBulananToolStripMenuItem"
        Me.LaporanBulananToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.LaporanBulananToolStripMenuItem.Text = "Laporan Bulanan"
        '
        'LaporanTahunanToolStripMenuItem
        '
        Me.LaporanTahunanToolStripMenuItem.Name = "LaporanTahunanToolStripMenuItem"
        Me.LaporanTahunanToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.LaporanTahunanToolStripMenuItem.Text = "Laporan Tahunan"
        '
        'SemuaLaporanToolStripMenuItem
        '
        Me.SemuaLaporanToolStripMenuItem.Name = "SemuaLaporanToolStripMenuItem"
        Me.SemuaLaporanToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.SemuaLaporanToolStripMenuItem.Text = "Semua Laporan"
        '
        'LaporanCounterToolStripMenuItem
        '
        Me.LaporanCounterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.C01ToolStripMenuItem, Me.C02ToolStripMenuItem, Me.CO3ToolStripMenuItem, Me.CO4ToolStripMenuItem, Me.CO5ToolStripMenuItem})
        Me.LaporanCounterToolStripMenuItem.Name = "LaporanCounterToolStripMenuItem"
        Me.LaporanCounterToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.LaporanCounterToolStripMenuItem.Text = "Laporan Counter"
        '
        'C01ToolStripMenuItem
        '
        Me.C01ToolStripMenuItem.Name = "C01ToolStripMenuItem"
        Me.C01ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.C01ToolStripMenuItem.Text = "C01"
        '
        'C02ToolStripMenuItem
        '
        Me.C02ToolStripMenuItem.Name = "C02ToolStripMenuItem"
        Me.C02ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.C02ToolStripMenuItem.Text = "C02"
        '
        'CO3ToolStripMenuItem
        '
        Me.CO3ToolStripMenuItem.Name = "CO3ToolStripMenuItem"
        Me.CO3ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CO3ToolStripMenuItem.Text = "CO3"
        '
        'CO4ToolStripMenuItem
        '
        Me.CO4ToolStripMenuItem.Name = "CO4ToolStripMenuItem"
        Me.CO4ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CO4ToolStripMenuItem.Text = "CO4"
        '
        'CO5ToolStripMenuItem
        '
        Me.CO5ToolStripMenuItem.Name = "CO5ToolStripMenuItem"
        Me.CO5ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CO5ToolStripMenuItem.Text = "CO5"
        '
        'LaporanGrafikToolStripMenuItem
        '
        Me.LaporanGrafikToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LaporanHarianToolStripMenuItem1, Me.LaporanBulananToolStripMenuItem1, Me.LaporanTahunanToolStripMenuItem1, Me.LaporanCounterToolStripMenuItem1})
        Me.LaporanGrafikToolStripMenuItem.Name = "LaporanGrafikToolStripMenuItem"
        Me.LaporanGrafikToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.LaporanGrafikToolStripMenuItem.Text = "Laporan Grafik"
        '
        'LaporanHarianToolStripMenuItem1
        '
        Me.LaporanHarianToolStripMenuItem1.Name = "LaporanHarianToolStripMenuItem1"
        Me.LaporanHarianToolStripMenuItem1.Size = New System.Drawing.Size(168, 22)
        Me.LaporanHarianToolStripMenuItem1.Text = "Laporan Harian"
        '
        'LaporanBulananToolStripMenuItem1
        '
        Me.LaporanBulananToolStripMenuItem1.Name = "LaporanBulananToolStripMenuItem1"
        Me.LaporanBulananToolStripMenuItem1.Size = New System.Drawing.Size(168, 22)
        Me.LaporanBulananToolStripMenuItem1.Text = "Laporan Bulanan"
        '
        'LaporanTahunanToolStripMenuItem1
        '
        Me.LaporanTahunanToolStripMenuItem1.Name = "LaporanTahunanToolStripMenuItem1"
        Me.LaporanTahunanToolStripMenuItem1.Size = New System.Drawing.Size(168, 22)
        Me.LaporanTahunanToolStripMenuItem1.Text = "Laporan Tahunan"
        '
        'LaporanCounterToolStripMenuItem1
        '
        Me.LaporanCounterToolStripMenuItem1.Name = "LaporanCounterToolStripMenuItem1"
        Me.LaporanCounterToolStripMenuItem1.Size = New System.Drawing.Size(168, 22)
        Me.LaporanCounterToolStripMenuItem1.Text = "Laporan Counter"
        '
        'TentangToolStripMenuItem
        '
        Me.TentangToolStripMenuItem.Font = New System.Drawing.Font("Work Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TentangToolStripMenuItem.Image = CType(resources.GetObject("TentangToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TentangToolStripMenuItem.Name = "TentangToolStripMenuItem"
        Me.TentangToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.TentangToolStripMenuItem.Text = "Tentang"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Font = New System.Drawing.Font("Work Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeluarToolStripMenuItem.Image = CType(resources.GetObject("KeluarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.ClientSize = New System.Drawing.Size(885, 741)
        Me.Controls.Add(Me.ButtonSimpan)
        Me.Controls.Add(Me.TextBoxRePasswordAdmin)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TextBoxRePasword)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Hapus2)
        Me.Controls.Add(Me.DataAdmin)
        Me.Controls.Add(Me.Hapus)
        Me.Controls.Add(Me.DataUser)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextPassAdmin)
        Me.Controls.Add(Me.TextUsrAdmin)
        Me.Controls.Add(Me.TextJabatanAdmin)
        Me.Controls.Add(Me.TextNamaAdmin)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.TextBoxUsername)
        Me.Controls.Add(Me.TextBoxJabatan)
        Me.Controls.Add(Me.TextBoxNama)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Work Sans", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Admin"
        Me.Text = "Admin"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ModeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KasirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CounterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InputDataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TentangToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InputDataMakananMinumanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InputDataCounterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBoxNama As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxJabatan As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxUsername As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxPassword As System.Windows.Forms.TextBox
    Friend WithEvents LaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextPassAdmin As System.Windows.Forms.TextBox
    Friend WithEvents TextUsrAdmin As System.Windows.Forms.TextBox
    Friend WithEvents TextJabatanAdmin As System.Windows.Forms.TextBox
    Friend WithEvents TextNamaAdmin As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DataUser As System.Windows.Forms.DataGridView
    Friend WithEvents Hapus As System.Windows.Forms.Button
    Friend WithEvents Hapus2 As System.Windows.Forms.Button
    Friend WithEvents DataAdmin As System.Windows.Forms.DataGridView
    Friend WithEvents TextBoxRePasword As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBoxRePasswordAdmin As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents LaporanBulananToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanTahunanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SemuaLaporanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanCounterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents C01ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents C02ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CO3ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CO4ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CO5ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanHarianToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents LaporanGrafikToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanHarianToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanBulananToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanTahunanToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LaporanCounterToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ButtonSimpan As System.Windows.Forms.Button
End Class
