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
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblSymbol = New System.Windows.Forms.Label()
        Me.lblAtmMass = New System.Windows.Forms.Label()
        Me.lblAtmNum = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbSrch = New System.Windows.Forms.TextBox()
        Me.lblElectrons = New System.Windows.Forms.Label()
        Me.lblRowCol = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(81, 150)
        Me.lblName.MaximumSize = New System.Drawing.Size(120, 17)
        Me.lblName.MinimumSize = New System.Drawing.Size(120, 17)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(120, 17)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblSymbol
        '
        Me.lblSymbol.AutoSize = True
        Me.lblSymbol.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSymbol.Location = New System.Drawing.Point(70, 94)
        Me.lblSymbol.MaximumSize = New System.Drawing.Size(142, 42)
        Me.lblSymbol.MinimumSize = New System.Drawing.Size(142, 42)
        Me.lblSymbol.Name = "lblSymbol"
        Me.lblSymbol.Size = New System.Drawing.Size(142, 42)
        Me.lblSymbol.TabIndex = 1
        Me.lblSymbol.Text = "Symbol"
        Me.lblSymbol.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblAtmMass
        '
        Me.lblAtmMass.AutoSize = True
        Me.lblAtmMass.Location = New System.Drawing.Point(98, 187)
        Me.lblAtmMass.MaximumSize = New System.Drawing.Size(87, 17)
        Me.lblAtmMass.MinimumSize = New System.Drawing.Size(87, 17)
        Me.lblAtmMass.Name = "lblAtmMass"
        Me.lblAtmMass.Size = New System.Drawing.Size(87, 17)
        Me.lblAtmMass.TabIndex = 2
        Me.lblAtmMass.Text = "Atomic Mass"
        Me.lblAtmMass.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblAtmNum
        '
        Me.lblAtmNum.AutoSize = True
        Me.lblAtmNum.Location = New System.Drawing.Point(89, 62)
        Me.lblAtmNum.MaximumSize = New System.Drawing.Size(104, 17)
        Me.lblAtmNum.MinimumSize = New System.Drawing.Size(104, 17)
        Me.lblAtmNum.Name = "lblAtmNum"
        Me.lblAtmNum.Size = New System.Drawing.Size(104, 17)
        Me.lblAtmNum.TabIndex = 3
        Me.lblAtmNum.Text = "Atomic Number"
        Me.lblAtmNum.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Search"
        '
        'tbSrch
        '
        Me.tbSrch.Location = New System.Drawing.Point(63, 4)
        Me.tbSrch.Name = "tbSrch"
        Me.tbSrch.Size = New System.Drawing.Size(207, 22)
        Me.tbSrch.TabIndex = 5
        '
        'lblElectrons
        '
        Me.lblElectrons.AutoSize = True
        Me.lblElectrons.Location = New System.Drawing.Point(1, 252)
        Me.lblElectrons.MaximumSize = New System.Drawing.Size(280, 17)
        Me.lblElectrons.MinimumSize = New System.Drawing.Size(280, 17)
        Me.lblElectrons.Name = "lblElectrons"
        Me.lblElectrons.Size = New System.Drawing.Size(280, 17)
        Me.lblElectrons.TabIndex = 6
        Me.lblElectrons.Text = "Valence Electrons"
        Me.lblElectrons.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRowCol
        '
        Me.lblRowCol.AutoSize = True
        Me.lblRowCol.Location = New System.Drawing.Point(1, 235)
        Me.lblRowCol.MaximumSize = New System.Drawing.Size(280, 17)
        Me.lblRowCol.MinimumSize = New System.Drawing.Size(280, 17)
        Me.lblRowCol.Name = "lblRowCol"
        Me.lblRowCol.Size = New System.Drawing.Size(280, 17)
        Me.lblRowCol.TabIndex = 7
        Me.lblRowCol.Text = "Row/Column"
        Me.lblRowCol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 281)
        Me.Controls.Add(Me.lblRowCol)
        Me.Controls.Add(Me.lblElectrons)
        Me.Controls.Add(Me.tbSrch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblAtmNum)
        Me.Controls.Add(Me.lblAtmMass)
        Me.Controls.Add(Me.lblSymbol)
        Me.Controls.Add(Me.lblName)
        Me.Name = "Form1"
        Me.Text = "HPT - Ace N"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblSymbol As System.Windows.Forms.Label
    Friend WithEvents lblAtmMass As System.Windows.Forms.Label
    Friend WithEvents lblAtmNum As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbSrch As System.Windows.Forms.TextBox
    Friend WithEvents lblElectrons As System.Windows.Forms.Label
    Friend WithEvents lblRowCol As System.Windows.Forms.Label

End Class
