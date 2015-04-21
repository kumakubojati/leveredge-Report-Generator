<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRepABP
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRepABP))
        Me.dtRepBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsRep = New Report_Generator.dsRep()
        Me.dtHeadRepBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dtHeadRep2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.rvABP = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.dtRepBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsRep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtHeadRepBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtHeadRep2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtRepBindingSource
        '
        Me.dtRepBindingSource.DataMember = "dtRep"
        Me.dtRepBindingSource.DataSource = Me.dsRep
        '
        'dsRep
        '
        Me.dsRep.DataSetName = "dsRep"
        Me.dsRep.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtHeadRepBindingSource
        '
        Me.dtHeadRepBindingSource.DataMember = "dtHeadRep"
        Me.dtHeadRepBindingSource.DataSource = Me.dsRep
        '
        'dtHeadRep2BindingSource
        '
        Me.dtHeadRep2BindingSource.DataMember = "dtHeadRep2"
        Me.dtHeadRep2BindingSource.DataSource = Me.dsRep
        '
        'rvABP
        '
        Me.rvABP.AutoSize = True
        ReportDataSource1.Name = "dsAchByProd"
        ReportDataSource1.Value = Me.dtRepBindingSource
        ReportDataSource2.Name = "dsHeadRep"
        ReportDataSource2.Value = Me.dtHeadRepBindingSource
        ReportDataSource3.Name = "dsHeadRep2"
        ReportDataSource3.Value = Me.dtHeadRep2BindingSource
        Me.rvABP.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rvABP.LocalReport.DataSources.Add(ReportDataSource2)
        Me.rvABP.LocalReport.DataSources.Add(ReportDataSource3)
        Me.rvABP.LocalReport.ReportEmbeddedResource = "Report_Generator.AchievementByProduct.rdlc"
        Me.rvABP.Location = New System.Drawing.Point(0, 0)
        Me.rvABP.Name = "rvABP"
        Me.rvABP.Size = New System.Drawing.Size(1363, 741)
        Me.rvABP.TabIndex = 0
        '
        'frmRepABP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 641)
        Me.Controls.Add(Me.rvABP)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRepABP"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Achievement By Product"
        CType(Me.dtRepBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsRep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtHeadRepBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtHeadRep2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rvABP As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents dtRepBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dsRep As Report_Generator.dsRep
    Friend WithEvents dtHeadRepBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dtHeadRep2BindingSource As System.Windows.Forms.BindingSource
End Class
