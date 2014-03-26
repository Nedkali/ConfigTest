<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ComboBox300 = New System.Windows.Forms.ComboBox()
        Me.Label147 = New System.Windows.Forms.Label()
        Me.Label300 = New System.Windows.Forms.Label()
        Me.NumericUpDown300 = New System.Windows.Forms.NumericUpDown()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.NumericUpDown300, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ComboBox300)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label147)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label300)
        Me.SplitContainer1.Panel1.Controls.Add(Me.NumericUpDown300)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Button1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.RichTextBox1)
        Me.SplitContainer1.Size = New System.Drawing.Size(993, 577)
        Me.SplitContainer1.SplitterDistance = 248
        Me.SplitContainer1.TabIndex = 0
        '
        'ComboBox300
        '
        Me.ComboBox300.FormattingEnabled = True
        Me.ComboBox300.Items.AddRange(New Object() {"NTConfig_Script.push", "ComboBox", "NumBox"})
        Me.ComboBox300.Location = New System.Drawing.Point(28, 57)
        Me.ComboBox300.Name = "ComboBox300"
        Me.ComboBox300.Size = New System.Drawing.Size(184, 21)
        Me.ComboBox300.TabIndex = 15
        '
        'Label147
        '
        Me.Label147.AutoSize = True
        Me.Label147.Location = New System.Drawing.Point(35, 41)
        Me.Label147.Name = "Label147"
        Me.Label147.Size = New System.Drawing.Size(31, 13)
        Me.Label147.TabIndex = 14
        Me.Label147.Text = "Type"
        '
        'Label300
        '
        Me.Label300.AutoSize = True
        Me.Label300.Location = New System.Drawing.Point(35, 156)
        Me.Label300.Name = "Label300"
        Me.Label300.Size = New System.Drawing.Size(76, 13)
        Me.Label300.TabIndex = 13
        Me.Label300.Text = "Entries per line"
        '
        'NumericUpDown300
        '
        Me.NumericUpDown300.Location = New System.Drawing.Point(137, 154)
        Me.NumericUpDown300.Minimum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.NumericUpDown300.Name = "NumericUpDown300"
        Me.NumericUpDown300.Size = New System.Drawing.Size(56, 20)
        Me.NumericUpDown300.TabIndex = 12
        Me.NumericUpDown300.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(79, 228)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "run tool sub"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(741, 577)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(993, 577)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.NumericUpDown300, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents ComboBox300 As System.Windows.Forms.ComboBox
    Friend WithEvents Label147 As System.Windows.Forms.Label
    Friend WithEvents Label300 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown300 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
