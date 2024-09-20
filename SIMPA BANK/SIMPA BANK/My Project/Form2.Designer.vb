<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Iniciar_sessio = New System.Windows.Forms.Button()
        Me.Sortir = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Crear_compte = New System.Windows.Forms.Button()
        Me.Correu = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Iniciar_sessio
        '
        Me.Iniciar_sessio.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Iniciar_sessio.Location = New System.Drawing.Point(417, 247)
        Me.Iniciar_sessio.Name = "Iniciar_sessio"
        Me.Iniciar_sessio.Size = New System.Drawing.Size(115, 46)
        Me.Iniciar_sessio.TabIndex = 0
        Me.Iniciar_sessio.Text = "Entrar"
        Me.Iniciar_sessio.UseVisualStyleBackColor = False
        '
        'Sortir
        '
        Me.Sortir.BackColor = System.Drawing.Color.Salmon
        Me.Sortir.Location = New System.Drawing.Point(254, 247)
        Me.Sortir.Name = "Sortir"
        Me.Sortir.Size = New System.Drawing.Size(115, 46)
        Me.Sortir.TabIndex = 1
        Me.Sortir.Text = "Sortir"
        Me.Sortir.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(254, 189)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(278, 20)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = "Contraseña"
        '
        'Crear_compte
        '
        Me.Crear_compte.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Crear_compte.Location = New System.Drawing.Point(338, 319)
        Me.Crear_compte.Name = "Crear_compte"
        Me.Crear_compte.Size = New System.Drawing.Size(115, 46)
        Me.Crear_compte.TabIndex = 3
        Me.Crear_compte.Text = "No tens compte? Crea un aqui"
        Me.Crear_compte.UseVisualStyleBackColor = False
        '
        'Correu
        '
        Me.Correu.Location = New System.Drawing.Point(254, 140)
        Me.Correu.Name = "Correu"
        Me.Correu.Size = New System.Drawing.Size(278, 20)
        Me.Correu.TabIndex = 4
        Me.Correu.Text = "E-mail"
        '
        'Label1
        '
        Me.Label1.AllowDrop = True
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(254, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Introdueix el correu"
        '
        'Label2
        '
        Me.Label2.AllowDrop = True
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(254, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Introdueix la contrasenya"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Correu)
        Me.Controls.Add(Me.Crear_compte)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Sortir)
        Me.Controls.Add(Me.Iniciar_sessio)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Iniciar_sessio As Button
    Friend WithEvents Sortir As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Crear_compte As Button
    Friend WithEvents Correu As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
