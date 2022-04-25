<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SethRas_Etcho_A_Sketch
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
        Me.DrawPictureBox = New System.Windows.Forms.PictureBox()
        Me.DrawTANButton = New System.Windows.Forms.Button()
        Me.DrawCosButton = New System.Windows.Forms.Button()
        Me.DrawSINButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.ToolStripMenu = New System.Windows.Forms.ToolStrip()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.DrawPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DrawPictureBox
        '
        Me.DrawPictureBox.Location = New System.Drawing.Point(0, 0)
        Me.DrawPictureBox.Name = "DrawPictureBox"
        Me.DrawPictureBox.Size = New System.Drawing.Size(542, 310)
        Me.DrawPictureBox.TabIndex = 0
        Me.DrawPictureBox.TabStop = False
        '
        'DrawTANButton
        '
        Me.DrawTANButton.Location = New System.Drawing.Point(0, 316)
        Me.DrawTANButton.Name = "DrawTANButton"
        Me.DrawTANButton.Size = New System.Drawing.Size(92, 23)
        Me.DrawTANButton.TabIndex = 1
        Me.DrawTANButton.Text = "Draw TAN"
        Me.DrawTANButton.UseVisualStyleBackColor = True
        '
        'DrawCosButton
        '
        Me.DrawCosButton.Location = New System.Drawing.Point(141, 316)
        Me.DrawCosButton.Name = "DrawCosButton"
        Me.DrawCosButton.Size = New System.Drawing.Size(96, 23)
        Me.DrawCosButton.TabIndex = 2
        Me.DrawCosButton.Text = "Draw Cosine"
        Me.DrawCosButton.UseVisualStyleBackColor = True
        '
        'DrawSINButton
        '
        Me.DrawSINButton.Location = New System.Drawing.Point(280, 316)
        Me.DrawSINButton.Name = "DrawSINButton"
        Me.DrawSINButton.Size = New System.Drawing.Size(88, 23)
        Me.DrawSINButton.TabIndex = 3
        Me.DrawSINButton.Text = "Draw Sin"
        Me.DrawSINButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(0, 345)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(368, 76)
        Me.ClearButton.TabIndex = 4
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ToolStripMenu
        '
        Me.ToolStripMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStripMenu.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripMenu.Name = "ToolStripMenu"
        Me.ToolStripMenu.Size = New System.Drawing.Size(1269, 25)
        Me.ToolStripMenu.TabIndex = 5
        Me.ToolStripMenu.Text = "ToolStrip1"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(137, 427)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 6
        '
        'SethRas_Etcho_A_Sketch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1269, 450)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ToolStripMenu)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.DrawSINButton)
        Me.Controls.Add(Me.DrawCosButton)
        Me.Controls.Add(Me.DrawTANButton)
        Me.Controls.Add(Me.DrawPictureBox)
        Me.Name = "SethRas_Etcho_A_Sketch"
        Me.Text = "Form1"
        CType(Me.DrawPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DrawPictureBox As PictureBox
    Friend WithEvents DrawTANButton As Button
    Friend WithEvents DrawCosButton As Button
    Friend WithEvents DrawSINButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents ToolStripMenu As ToolStrip
    Friend WithEvents TextBox1 As TextBox
End Class
