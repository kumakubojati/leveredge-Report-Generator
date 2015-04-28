<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SSloading
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
    Friend WithEvents ssLoadData As System.Windows.Forms.TableLayoutPanel

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SSloading))
        Me.ssLoadData = New System.Windows.Forms.TableLayoutPanel()
        Me.SuspendLayout()
        '
        'ssLoadData
        '
        Me.ssLoadData.BackColor = System.Drawing.Color.Transparent
        Me.ssLoadData.BackgroundImage = CType(resources.GetObject("ssLoadData.BackgroundImage"), System.Drawing.Image)
        Me.ssLoadData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ssLoadData.ColumnCount = 3
        Me.ssLoadData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131.0!))
        Me.ssLoadData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 275.0!))
        Me.ssLoadData.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180.0!))
        Me.ssLoadData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ssLoadData.Location = New System.Drawing.Point(0, 0)
        Me.ssLoadData.Name = "ssLoadData"
        Me.ssLoadData.RowCount = 3
        Me.ssLoadData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 114.0!))
        Me.ssLoadData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 102.0!))
        Me.ssLoadData.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.ssLoadData.Size = New System.Drawing.Size(496, 303)
        Me.ssLoadData.TabIndex = 0
        '
        'SSloading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 303)
        Me.ControlBox = False
        Me.Controls.Add(Me.ssLoadData)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SSloading"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub

End Class
