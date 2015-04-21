<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmABP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmABP))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpfrom_ABP = New System.Windows.Forms.DateTimePicker()
        Me.dtpTo_ABP = New System.Windows.Forms.DateTimePicker()
        Me.dgridSKU = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbRepCond = New System.Windows.Forms.GroupBox()
        Me.rbOR = New System.Windows.Forms.RadioButton()
        Me.rbAND = New System.Windows.Forms.RadioButton()
        Me.btnPrevRep = New System.Windows.Forms.Button()
        CType(Me.dgridSKU, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbRepCond.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Date From"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(298, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Date To"
        '
        'dtpfrom_ABP
        '
        Me.dtpfrom_ABP.CustomFormat = """yyyyMMdd"""
        Me.dtpfrom_ABP.Location = New System.Drawing.Point(81, 19)
        Me.dtpfrom_ABP.Name = "dtpfrom_ABP"
        Me.dtpfrom_ABP.Size = New System.Drawing.Size(197, 20)
        Me.dtpfrom_ABP.TabIndex = 2
        '
        'dtpTo_ABP
        '
        Me.dtpTo_ABP.CustomFormat = """yyyyMMdd"""
        Me.dtpTo_ABP.Location = New System.Drawing.Point(359, 19)
        Me.dtpTo_ABP.Name = "dtpTo_ABP"
        Me.dtpTo_ABP.Size = New System.Drawing.Size(200, 20)
        Me.dtpTo_ABP.TabIndex = 3
        '
        'dgridSKU
        '
        Me.dgridSKU.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgridSKU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgridSKU.Location = New System.Drawing.Point(12, 122)
        Me.dgridSKU.Name = "dgridSKU"
        Me.dgridSKU.Size = New System.Drawing.Size(547, 179)
        Me.dgridSKU.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Minimum SKU"
        '
        'gbRepCond
        '
        Me.gbRepCond.Controls.Add(Me.rbOR)
        Me.gbRepCond.Controls.Add(Me.rbAND)
        Me.gbRepCond.Location = New System.Drawing.Point(7, 54)
        Me.gbRepCond.Name = "gbRepCond"
        Me.gbRepCond.Size = New System.Drawing.Size(135, 49)
        Me.gbRepCond.TabIndex = 12
        Me.gbRepCond.TabStop = False
        Me.gbRepCond.Text = "Condition Minimum SKU"
        '
        'rbOR
        '
        Me.rbOR.AutoSize = True
        Me.rbOR.Location = New System.Drawing.Point(65, 20)
        Me.rbOR.Name = "rbOR"
        Me.rbOR.Size = New System.Drawing.Size(41, 17)
        Me.rbOR.TabIndex = 1
        Me.rbOR.TabStop = True
        Me.rbOR.Text = "OR"
        Me.rbOR.UseVisualStyleBackColor = True
        '
        'rbAND
        '
        Me.rbAND.AutoSize = True
        Me.rbAND.Checked = True
        Me.rbAND.Location = New System.Drawing.Point(7, 20)
        Me.rbAND.Name = "rbAND"
        Me.rbAND.Size = New System.Drawing.Size(48, 17)
        Me.rbAND.TabIndex = 0
        Me.rbAND.TabStop = True
        Me.rbAND.Text = "AND"
        Me.rbAND.UseVisualStyleBackColor = True
        '
        'btnPrevRep
        '
        Me.btnPrevRep.Location = New System.Drawing.Point(467, 307)
        Me.btnPrevRep.Name = "btnPrevRep"
        Me.btnPrevRep.Size = New System.Drawing.Size(92, 23)
        Me.btnPrevRep.TabIndex = 13
        Me.btnPrevRep.Text = "View Report"
        Me.btnPrevRep.UseVisualStyleBackColor = True
        '
        'frmABP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 338)
        Me.Controls.Add(Me.btnPrevRep)
        Me.Controls.Add(Me.gbRepCond)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgridSKU)
        Me.Controls.Add(Me.dtpTo_ABP)
        Me.Controls.Add(Me.dtpfrom_ABP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmABP"
        Me.Text = "Achievement by Product"
        CType(Me.dgridSKU, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbRepCond.ResumeLayout(False)
        Me.gbRepCond.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpfrom_ABP As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTo_ABP As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgridSKU As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gbRepCond As System.Windows.Forms.GroupBox
    Friend WithEvents rbOR As System.Windows.Forms.RadioButton
    Friend WithEvents rbAND As System.Windows.Forms.RadioButton
    Friend WithEvents btnPrevRep As System.Windows.Forms.Button

End Class
