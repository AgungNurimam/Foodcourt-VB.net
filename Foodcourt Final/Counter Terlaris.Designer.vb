<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Counter_Terlaris
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
        Me.DataCounterTerlaris = New System.Windows.Forms.DataGridView()
        CType(Me.DataCounterTerlaris, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataCounterTerlaris
        '
        Me.DataCounterTerlaris.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataCounterTerlaris.Location = New System.Drawing.Point(0, 1)
        Me.DataCounterTerlaris.Name = "DataCounterTerlaris"
        Me.DataCounterTerlaris.Size = New System.Drawing.Size(491, 392)
        Me.DataCounterTerlaris.TabIndex = 0
        '
        'Counter_Terlaris
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 393)
        Me.Controls.Add(Me.DataCounterTerlaris)
        Me.Name = "Counter_Terlaris"
        Me.Text = "Counter_Terlaris"
        CType(Me.DataCounterTerlaris, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataCounterTerlaris As System.Windows.Forms.DataGridView
End Class
