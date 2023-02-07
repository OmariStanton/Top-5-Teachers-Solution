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
        Me.lstTop5 = New System.Windows.Forms.ListBox()
        Me.picTeacher = New System.Windows.Forms.PictureBox()
        CType(Me.picTeacher, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstTop5
        '
        Me.lstTop5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstTop5.FormattingEnabled = True
        Me.lstTop5.ItemHeight = 31
        Me.lstTop5.Items.AddRange(New Object() {"Number 5", "Number 4", "Number 3", "Number 2", "Number 1"})
        Me.lstTop5.Location = New System.Drawing.Point(382, 62)
        Me.lstTop5.Name = "lstTop5"
        Me.lstTop5.Size = New System.Drawing.Size(138, 190)
        Me.lstTop5.TabIndex = 0
        '
        'picTeacher
        '
        Me.picTeacher.Location = New System.Drawing.Point(77, 70)
        Me.picTeacher.Name = "picTeacher"
        Me.picTeacher.Size = New System.Drawing.Size(215, 173)
        Me.picTeacher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTeacher.TabIndex = 1
        Me.picTeacher.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.picTeacher)
        Me.Controls.Add(Me.lstTop5)
        Me.Name = "frmMain"
        Me.Text = "Top 5 Teachers"
        CType(Me.picTeacher, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstTop5 As ListBox
    Friend WithEvents picTeacher As PictureBox
End Class
