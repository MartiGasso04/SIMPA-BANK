<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Accedir = New System.Windows.Forms.Button()
        Me.Sortir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Accedir
        '
        Me.Accedir.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Accedir.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Accedir.Location = New System.Drawing.Point(436, 347)
        Me.Accedir.Name = "Accedir"
        Me.Accedir.Size = New System.Drawing.Size(185, 47)
        Me.Accedir.TabIndex = 0
        Me.Accedir.Text = "Accedir a SIMPA BANK APP"
        Me.Accedir.UseVisualStyleBackColor = False
        '
        'Sortir
        '
        Me.Sortir.BackColor = System.Drawing.Color.Salmon
        Me.Sortir.Location = New System.Drawing.Point(188, 347)
        Me.Sortir.Name = "Sortir"
        Me.Sortir.Size = New System.Drawing.Size(196, 47)
        Me.Sortir.TabIndex = 1
        Me.Sortir.Text = "Sortir de SIMPA BANK APP"
        Me.Sortir.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SIMPA_BANK.My.Resources.Resources.Captura_de_pantalla_2024_05_10_164450
        Me.PictureBox1.Location = New System.Drawing.Point(-131, -107)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(969, 566)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Sortir)
        Me.Controls.Add(Me.Accedir)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Accedir As Button
    Friend WithEvents Sortir As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
