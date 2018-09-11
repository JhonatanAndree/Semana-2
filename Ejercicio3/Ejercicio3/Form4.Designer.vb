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
        Me.btnsiguiente = New System.Windows.Forms.Button()
        Me.btnlanzar = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnsiguiente
        '
        Me.btnsiguiente.Location = New System.Drawing.Point(153, 79)
        Me.btnsiguiente.Name = "btnsiguiente"
        Me.btnsiguiente.Size = New System.Drawing.Size(140, 31)
        Me.btnsiguiente.TabIndex = 8
        Me.btnsiguiente.Text = "SALIR"
        Me.btnsiguiente.UseVisualStyleBackColor = True
        '
        'btnlanzar
        '
        Me.btnlanzar.Location = New System.Drawing.Point(22, 79)
        Me.btnlanzar.Name = "btnlanzar"
        Me.btnlanzar.Size = New System.Drawing.Size(96, 31)
        Me.btnlanzar.TabIndex = 7
        Me.btnlanzar.Text = "Mensaje"
        Me.btnlanzar.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(62, 23)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(192, 20)
        Me.TextBox1.TabIndex = 6
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 138)
        Me.Controls.Add(Me.btnsiguiente)
        Me.Controls.Add(Me.btnlanzar)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form4"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mensajes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnsiguiente As Button
    Friend WithEvents btnlanzar As Button
    Friend WithEvents TextBox1 As TextBox
End Class
