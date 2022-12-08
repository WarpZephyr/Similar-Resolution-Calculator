<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SimilarResCalc
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
        Me.DataOutputBox = New System.Windows.Forms.ListBox()
        Me.DataWidth = New System.Windows.Forms.TextBox()
        Me.DataHeight = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataFeedback = New System.Windows.Forms.Label()
        Me.DataInputBox = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataDivisible = New System.Windows.Forms.TextBox()
        Me.DataIterations = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.DataClear = New System.Windows.Forms.Button()
        Me.DataCalc = New System.Windows.Forms.Button()
        Me.DataInfoBox = New System.Windows.Forms.GroupBox()
        Me.DataInputBox.SuspendLayout()
        Me.DataInfoBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataOutputBox
        '
        Me.DataOutputBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.DataOutputBox.ForeColor = System.Drawing.Color.White
        Me.DataOutputBox.FormattingEnabled = True
        Me.DataOutputBox.Location = New System.Drawing.Point(205, 10)
        Me.DataOutputBox.Margin = New System.Windows.Forms.Padding(1)
        Me.DataOutputBox.Name = "DataOutputBox"
        Me.DataOutputBox.Size = New System.Drawing.Size(219, 251)
        Me.DataOutputBox.TabIndex = 0
        '
        'DataWidth
        '
        Me.DataWidth.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.DataWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataWidth.ForeColor = System.Drawing.Color.White
        Me.DataWidth.Location = New System.Drawing.Point(83, 20)
        Me.DataWidth.Name = "DataWidth"
        Me.DataWidth.Size = New System.Drawing.Size(100, 20)
        Me.DataWidth.TabIndex = 1
        '
        'DataHeight
        '
        Me.DataHeight.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.DataHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataHeight.ForeColor = System.Drawing.Color.White
        Me.DataHeight.Location = New System.Drawing.Point(83, 45)
        Me.DataHeight.Name = "DataHeight"
        Me.DataHeight.Size = New System.Drawing.Size(100, 20)
        Me.DataHeight.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(39, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Width:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(36, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Height:"
        '
        'DataFeedback
        '
        Me.DataFeedback.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.DataFeedback.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.DataFeedback.ForeColor = System.Drawing.Color.White
        Me.DataFeedback.Location = New System.Drawing.Point(6, 15)
        Me.DataFeedback.Name = "DataFeedback"
        Me.DataFeedback.Size = New System.Drawing.Size(177, 48)
        Me.DataFeedback.TabIndex = 11
        '
        'DataInputBox
        '
        Me.DataInputBox.Controls.Add(Me.Label4)
        Me.DataInputBox.Controls.Add(Me.DataDivisible)
        Me.DataInputBox.Controls.Add(Me.DataIterations)
        Me.DataInputBox.Controls.Add(Me.label3)
        Me.DataInputBox.Controls.Add(Me.DataClear)
        Me.DataInputBox.Controls.Add(Me.DataCalc)
        Me.DataInputBox.Controls.Add(Me.DataWidth)
        Me.DataInputBox.Controls.Add(Me.DataHeight)
        Me.DataInputBox.Controls.Add(Me.Label1)
        Me.DataInputBox.Controls.Add(Me.Label2)
        Me.DataInputBox.ForeColor = System.Drawing.Color.White
        Me.DataInputBox.Location = New System.Drawing.Point(12, 5)
        Me.DataInputBox.Name = "DataInputBox"
        Me.DataInputBox.Size = New System.Drawing.Size(189, 184)
        Me.DataInputBox.TabIndex = 12
        Me.DataInputBox.TabStop = False
        Me.DataInputBox.Text = "Input"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(13, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Divisible By:"
        '
        'DataDivisible
        '
        Me.DataDivisible.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.DataDivisible.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataDivisible.ForeColor = System.Drawing.Color.White
        Me.DataDivisible.Location = New System.Drawing.Point(83, 97)
        Me.DataDivisible.Name = "DataDivisible"
        Me.DataDivisible.Size = New System.Drawing.Size(100, 20)
        Me.DataDivisible.TabIndex = 15
        '
        'DataIterations
        '
        Me.DataIterations.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.DataIterations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataIterations.ForeColor = System.Drawing.Color.White
        Me.DataIterations.Location = New System.Drawing.Point(83, 71)
        Me.DataIterations.Name = "DataIterations"
        Me.DataIterations.Size = New System.Drawing.Size(100, 20)
        Me.DataIterations.TabIndex = 13
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.ForeColor = System.Drawing.Color.White
        Me.label3.Location = New System.Drawing.Point(24, 73)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(53, 13)
        Me.label3.TabIndex = 14
        Me.label3.Text = "Iterations:"
        '
        'DataClear
        '
        Me.DataClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.DataClear.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.DataClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DataClear.Location = New System.Drawing.Point(101, 123)
        Me.DataClear.Name = "DataClear"
        Me.DataClear.Size = New System.Drawing.Size(82, 23)
        Me.DataClear.TabIndex = 12
        Me.DataClear.Text = "Clear Output"
        Me.DataClear.UseVisualStyleBackColor = False
        '
        'DataCalc
        '
        Me.DataCalc.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.DataCalc.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.DataCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DataCalc.Location = New System.Drawing.Point(6, 152)
        Me.DataCalc.Name = "DataCalc"
        Me.DataCalc.Size = New System.Drawing.Size(177, 23)
        Me.DataCalc.TabIndex = 11
        Me.DataCalc.Text = "Calculate"
        Me.DataCalc.UseVisualStyleBackColor = False
        '
        'DataInfoBox
        '
        Me.DataInfoBox.Controls.Add(Me.DataFeedback)
        Me.DataInfoBox.ForeColor = System.Drawing.Color.White
        Me.DataInfoBox.Location = New System.Drawing.Point(12, 188)
        Me.DataInfoBox.Name = "DataInfoBox"
        Me.DataInfoBox.Size = New System.Drawing.Size(189, 73)
        Me.DataInfoBox.TabIndex = 13
        Me.DataInfoBox.TabStop = False
        Me.DataInfoBox.Text = "Data"
        '
        'SimilarResCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(434, 271)
        Me.Controls.Add(Me.DataInfoBox)
        Me.Controls.Add(Me.DataInputBox)
        Me.Controls.Add(Me.DataOutputBox)
        Me.ForeColor = System.Drawing.Color.White
        Me.MaximumSize = New System.Drawing.Size(450, 310)
        Me.MinimumSize = New System.Drawing.Size(450, 310)
        Me.Name = "SimilarResCalc"
        Me.Text = "Similar Resolution Calculator"
        Me.DataInputBox.ResumeLayout(False)
        Me.DataInputBox.PerformLayout()
        Me.DataInfoBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataOutputBox As ListBox
    Friend WithEvents DataWidth As TextBox
    Friend WithEvents DataHeight As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataFeedback As Label
    Friend WithEvents DataInputBox As GroupBox
    Friend WithEvents DataInfoBox As GroupBox
    Friend WithEvents DataCalc As Button
    Friend WithEvents DataClear As Button
    Friend WithEvents DataIterations As TextBox
    Friend WithEvents label3 As Label
    Friend WithEvents DataDivisible As TextBox
    Friend WithEvents Label4 As Label
End Class
