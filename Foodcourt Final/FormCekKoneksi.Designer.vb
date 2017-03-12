<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCekKoneksi
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
        Me.BtnCekKoneksi = New System.Windows.Forms.Button()
        Me.BtnKembali = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnCekKoneksi
        '
        Me.BtnCekKoneksi.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCekKoneksi.Location = New System.Drawing.Point(85, 104)
        Me.BtnCekKoneksi.Name = "BtnCekKoneksi"
        Me.BtnCekKoneksi.Size = New System.Drawing.Size(110, 23)
        Me.BtnCekKoneksi.TabIndex = 0
        Me.BtnCekKoneksi.Text = "Cek Koneksi Database"
        Me.BtnCekKoneksi.UseVisualStyleBackColor = True
        '
        'BtnKembali
        '
        Me.BtnKembali.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKembali.Location = New System.Drawing.Point(103, 133)
        Me.BtnKembali.Name = "BtnKembali"
        Me.BtnKembali.Size = New System.Drawing.Size(75, 23)
        Me.BtnKembali.TabIndex = 1
        Me.BtnKembali.Text = "Kembali"
        Me.BtnKembali.UseVisualStyleBackColor = True
        '
        'FormCekKoneksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(278, 264)
        Me.Controls.Add(Me.BtnKembali)
        Me.Controls.Add(Me.BtnCekKoneksi)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "FormCekKoneksi"
        Me.Text = "Cek Koneksi"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnCekKoneksi As System.Windows.Forms.Button
    Friend WithEvents BtnKembali As System.Windows.Forms.Button
End Class
