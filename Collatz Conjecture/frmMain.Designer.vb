<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.lblInitialNo = New System.Windows.Forms.Label()
        Me.txtInitialNo = New System.Windows.Forms.TextBox()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.txtIterations = New System.Windows.Forms.TextBox()
        Me.lblIterations = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblInitialNo
        '
        Me.lblInitialNo.AutoSize = True
        Me.lblInitialNo.Location = New System.Drawing.Point(12, 15)
        Me.lblInitialNo.Name = "lblInitialNo"
        Me.lblInitialNo.Size = New System.Drawing.Size(71, 13)
        Me.lblInitialNo.TabIndex = 0
        Me.lblInitialNo.Text = "Initial Number"
        '
        'txtInitialNo
        '
        Me.txtInitialNo.Location = New System.Drawing.Point(89, 12)
        Me.txtInitialNo.Name = "txtInitialNo"
        Me.txtInitialNo.Size = New System.Drawing.Size(102, 20)
        Me.txtInitialNo.TabIndex = 1
        '
        'btnGo
        '
        Me.btnGo.Location = New System.Drawing.Point(197, 12)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(68, 20)
        Me.btnGo.TabIndex = 2
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'txtIterations
        '
        Me.txtIterations.Location = New System.Drawing.Point(12, 61)
        Me.txtIterations.Multiline = True
        Me.txtIterations.Name = "txtIterations"
        Me.txtIterations.ReadOnly = True
        Me.txtIterations.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtIterations.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtIterations.Size = New System.Drawing.Size(253, 490)
        Me.txtIterations.TabIndex = 3
        '
        'lblIterations
        '
        Me.lblIterations.AutoSize = True
        Me.lblIterations.Location = New System.Drawing.Point(12, 45)
        Me.lblIterations.Name = "lblIterations"
        Me.lblIterations.Size = New System.Drawing.Size(50, 13)
        Me.lblIterations.TabIndex = 4
        Me.lblIterations.Text = "Iterations"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(277, 563)
        Me.Controls.Add(Me.lblIterations)
        Me.Controls.Add(Me.txtIterations)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.txtInitialNo)
        Me.Controls.Add(Me.lblInitialNo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Collatz Conjecture"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInitialNo As Label
    Friend WithEvents txtInitialNo As TextBox
    Friend WithEvents btnGo As Button
    Friend WithEvents txtIterations As TextBox
    Friend WithEvents lblIterations As Label
End Class
