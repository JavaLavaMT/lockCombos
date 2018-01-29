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
        Me.btnCal = New System.Windows.Forms.Button()
        Me.lstCombo = New System.Windows.Forms.ListBox()
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSec = New System.Windows.Forms.TextBox()
        Me.txtThird = New System.Windows.Forms.TextBox()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnSec = New System.Windows.Forms.Button()
        Me.btnThird = New System.Windows.Forms.Button()
        Me.lblFirst = New System.Windows.Forms.Label()
        Me.lblSec = New System.Windows.Forms.Label()
        Me.lblThird = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCal
        '
        Me.btnCal.Location = New System.Drawing.Point(141, 224)
        Me.btnCal.Name = "btnCal"
        Me.btnCal.Size = New System.Drawing.Size(75, 23)
        Me.btnCal.TabIndex = 0
        Me.btnCal.Text = "Cal"
        Me.btnCal.UseVisualStyleBackColor = True
        '
        'lstCombo
        '
        Me.lstCombo.FormattingEnabled = True
        Me.lstCombo.Location = New System.Drawing.Point(296, 29)
        Me.lstCombo.Name = "lstCombo"
        Me.lstCombo.Size = New System.Drawing.Size(116, 290)
        Me.lstCombo.TabIndex = 1
        '
        'txtFirst
        '
        Me.txtFirst.Location = New System.Drawing.Point(12, 33)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(100, 20)
        Me.txtFirst.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "First combo range"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Second Combo range"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Third combo range"
        '
        'txtSec
        '
        Me.txtSec.Location = New System.Drawing.Point(15, 78)
        Me.txtSec.Name = "txtSec"
        Me.txtSec.Size = New System.Drawing.Size(100, 20)
        Me.txtSec.TabIndex = 6
        '
        'txtThird
        '
        Me.txtThird.Location = New System.Drawing.Point(19, 128)
        Me.txtThird.Name = "txtThird"
        Me.txtThird.Size = New System.Drawing.Size(100, 20)
        Me.txtThird.TabIndex = 7
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(141, 29)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(36, 23)
        Me.btnFirst.TabIndex = 8
        Me.btnFirst.Text = "Add"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnSec
        '
        Me.btnSec.Location = New System.Drawing.Point(141, 75)
        Me.btnSec.Name = "btnSec"
        Me.btnSec.Size = New System.Drawing.Size(36, 23)
        Me.btnSec.TabIndex = 9
        Me.btnSec.Text = "Add"
        Me.btnSec.UseVisualStyleBackColor = True
        '
        'btnThird
        '
        Me.btnThird.Location = New System.Drawing.Point(141, 125)
        Me.btnThird.Name = "btnThird"
        Me.btnThird.Size = New System.Drawing.Size(36, 23)
        Me.btnThird.TabIndex = 10
        Me.btnThird.Text = "Add"
        Me.btnThird.UseVisualStyleBackColor = True
        '
        'lblFirst
        '
        Me.lblFirst.AutoSize = True
        Me.lblFirst.Location = New System.Drawing.Point(195, 33)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(0, 13)
        Me.lblFirst.TabIndex = 11
        '
        'lblSec
        '
        Me.lblSec.AutoSize = True
        Me.lblSec.Location = New System.Drawing.Point(195, 85)
        Me.lblSec.Name = "lblSec"
        Me.lblSec.Size = New System.Drawing.Size(0, 13)
        Me.lblSec.TabIndex = 12
        '
        'lblThird
        '
        Me.lblThird.AutoSize = True
        Me.lblThird.Location = New System.Drawing.Point(195, 135)
        Me.lblThird.Name = "lblThird"
        Me.lblThird.Size = New System.Drawing.Size(0, 13)
        Me.lblThird.TabIndex = 13
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(198, 172)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(0, 13)
        Me.lblTotal.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 324)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblThird)
        Me.Controls.Add(Me.lblSec)
        Me.Controls.Add(Me.lblFirst)
        Me.Controls.Add(Me.btnThird)
        Me.Controls.Add(Me.btnSec)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.txtThird)
        Me.Controls.Add(Me.txtSec)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFirst)
        Me.Controls.Add(Me.lstCombo)
        Me.Controls.Add(Me.btnCal)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCal As Button
    Friend WithEvents lstCombo As ListBox
    Friend WithEvents txtFirst As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSec As TextBox
    Friend WithEvents txtThird As TextBox
    Friend WithEvents btnFirst As Button
    Friend WithEvents btnSec As Button
    Friend WithEvents btnThird As Button
    Friend WithEvents lblFirst As Label
    Friend WithEvents lblSec As Label
    Friend WithEvents lblThird As Label
    Friend WithEvents lblTotal As Label
End Class
