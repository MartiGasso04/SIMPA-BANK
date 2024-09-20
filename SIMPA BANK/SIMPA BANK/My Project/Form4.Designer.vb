<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.Ingressar = New System.Windows.Forms.Button()
        Me.Traspas = New System.Windows.Forms.Button()
        Me.Compte = New System.Windows.Forms.Button()
        Me.Pagar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Ingressar
        '
        Me.Ingressar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Ingressar.Location = New System.Drawing.Point(332, 102)
        Me.Ingressar.Name = "Ingressar"
        Me.Ingressar.Size = New System.Drawing.Size(115, 47)
        Me.Ingressar.TabIndex = 0
        Me.Ingressar.Text = "Ingressar"
        Me.Ingressar.UseVisualStyleBackColor = False
        '
        'Traspas
        '
        Me.Traspas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Traspas.Location = New System.Drawing.Point(332, 169)
        Me.Traspas.Name = "Traspas"
        Me.Traspas.Size = New System.Drawing.Size(115, 47)
        Me.Traspas.TabIndex = 1
        Me.Traspas.Text = "Traspas"
        Me.Traspas.UseVisualStyleBackColor = False
        '
        'Compte
        '
        Me.Compte.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Compte.Location = New System.Drawing.Point(332, 236)
        Me.Compte.Name = "Compte"
        Me.Compte.Size = New System.Drawing.Size(115, 47)
        Me.Compte.TabIndex = 2
        Me.Compte.Text = "Compte"
        Me.Compte.UseVisualStyleBackColor = False
        '
        'Pagar
        '
        Me.Pagar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Pagar.Location = New System.Drawing.Point(332, 308)
        Me.Pagar.Name = "Pagar"
        Me.Pagar.Size = New System.Drawing.Size(115, 47)
        Me.Pagar.TabIndex = 3
        Me.Pagar.Text = "Pagaments"
        Me.Pagar.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(629, 391)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 47)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Sortir"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Pagar)
        Me.Controls.Add(Me.Compte)
        Me.Controls.Add(Me.Traspas)
        Me.Controls.Add(Me.Ingressar)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Ingressar As Button
    Friend WithEvents Traspas As Button
    Friend WithEvents Compte As Button
    Friend WithEvents Pagar As Button
    Friend WithEvents Button1 As Button
End Class
