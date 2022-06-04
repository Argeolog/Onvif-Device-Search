<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Anasayfa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Anasayfa))
        Me.richTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Ara_Buton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'richTextBox1
        '
        Me.richTextBox1.Location = New System.Drawing.Point(12, 60)
        Me.richTextBox1.Name = "richTextBox1"
        Me.richTextBox1.Size = New System.Drawing.Size(762, 114)
        Me.richTextBox1.TabIndex = 6
        Me.richTextBox1.Text = resources.GetString("richTextBox1.Text")
        '
        'Ara_Buton
        '
        Me.Ara_Buton.Location = New System.Drawing.Point(12, 385)
        Me.Ara_Buton.Name = "Ara_Buton"
        Me.Ara_Buton.Size = New System.Drawing.Size(762, 59)
        Me.Ara_Buton.TabIndex = 5
        Me.Ara_Buton.Text = "Kamera Ara"
        Me.Ara_Buton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(223, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(314, 24)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Network IP Scanner Soap Xml Kodu"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 180)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(762, 199)
        Me.ListBox1.TabIndex = 11
        '
        'Anasayfa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 458)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.richTextBox1)
        Me.Controls.Add(Me.Ara_Buton)
        Me.Name = "Anasayfa"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents richTextBox1 As RichTextBox
    Friend WithEvents Ara_Buton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
End Class
