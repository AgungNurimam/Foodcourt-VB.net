<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuTerlaris
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
        Me.GridMenuTerlaris = New System.Windows.Forms.DataGridView()
        CType(Me.GridMenuTerlaris, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridMenuTerlaris
        '
        Me.GridMenuTerlaris.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridMenuTerlaris.Location = New System.Drawing.Point(-1, 0)
        Me.GridMenuTerlaris.Name = "GridMenuTerlaris"
        Me.GridMenuTerlaris.Size = New System.Drawing.Size(425, 385)
        Me.GridMenuTerlaris.TabIndex = 0
        '
        'MenuTerlaris
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 385)
        Me.Controls.Add(Me.GridMenuTerlaris)
        Me.Name = "MenuTerlaris"
        Me.Text = "MenuTerlaris"
        CType(Me.GridMenuTerlaris, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridMenuTerlaris As System.Windows.Forms.DataGridView
End Class
