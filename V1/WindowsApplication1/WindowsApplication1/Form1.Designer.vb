<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.green1 = New System.Windows.Forms.PictureBox()
        Me.red1 = New System.Windows.Forms.PictureBox()
        Me.yellow1 = New System.Windows.Forms.PictureBox()
        Me.grey1 = New System.Windows.Forms.PictureBox()
        CType(Me.green1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.red1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.yellow1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grey1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(36, 245)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "red"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(36, 211)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "green"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(36, 178)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "yellow"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(36, 142)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "grey"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'green1
        '
        Me.green1.Image = Global.WindowsApplication1.My.Resources.Resources.yellow
        Me.green1.Location = New System.Drawing.Point(59, 293)
        Me.green1.Name = "green1"
        Me.green1.Size = New System.Drawing.Size(30, 86)
        Me.green1.TabIndex = 11
        Me.green1.TabStop = False
        '
        'red1
        '
        Me.red1.Image = Global.WindowsApplication1.My.Resources.Resources.red
        Me.red1.Location = New System.Drawing.Point(59, 293)
        Me.red1.Name = "red1"
        Me.red1.Size = New System.Drawing.Size(30, 86)
        Me.red1.TabIndex = 10
        Me.red1.TabStop = False
        '
        'yellow1
        '
        Me.yellow1.Image = Global.WindowsApplication1.My.Resources.Resources.green
        Me.yellow1.Location = New System.Drawing.Point(59, 293)
        Me.yellow1.Name = "yellow1"
        Me.yellow1.Size = New System.Drawing.Size(30, 86)
        Me.yellow1.TabIndex = 9
        Me.yellow1.TabStop = False
        '
        'grey1
        '
        Me.grey1.Image = Global.WindowsApplication1.My.Resources.Resources.blank
        Me.grey1.Location = New System.Drawing.Point(59, 293)
        Me.grey1.Name = "grey1"
        Me.grey1.Size = New System.Drawing.Size(30, 86)
        Me.grey1.TabIndex = 8
        Me.grey1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(137, 406)
        Me.Controls.Add(Me.grey1)
        Me.Controls.Add(Me.green1)
        Me.Controls.Add(Me.red1)
        Me.Controls.Add(Me.yellow1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.green1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.red1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.yellow1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grey1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents grey1 As System.Windows.Forms.PictureBox
    Friend WithEvents yellow1 As System.Windows.Forms.PictureBox
    Friend WithEvents red1 As System.Windows.Forms.PictureBox
    Friend WithEvents green1 As System.Windows.Forms.PictureBox

End Class
