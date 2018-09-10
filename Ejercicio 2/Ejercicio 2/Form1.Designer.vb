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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtn1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtn2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtpromedio = New System.Windows.Forms.TextBox()
        Me.btncalcular = New System.Windows.Forms.Button()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(79, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Número 1"
        '
        'txtn1
        '
        Me.txtn1.Location = New System.Drawing.Point(182, 37)
        Me.txtn1.Name = "txtn1"
        Me.txtn1.Size = New System.Drawing.Size(100, 20)
        Me.txtn1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(79, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Número 2"
        '
        'txtn2
        '
        Me.txtn2.Location = New System.Drawing.Point(182, 86)
        Me.txtn2.Name = "txtn2"
        Me.txtn2.Size = New System.Drawing.Size(100, 20)
        Me.txtn2.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(79, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 18)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "PROMEDIO"
        '
        'txtpromedio
        '
        Me.txtpromedio.Location = New System.Drawing.Point(182, 137)
        Me.txtpromedio.Name = "txtpromedio"
        Me.txtpromedio.Size = New System.Drawing.Size(100, 20)
        Me.txtpromedio.TabIndex = 2
        '
        'btncalcular
        '
        Me.btncalcular.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btncalcular.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btncalcular.FlatAppearance.BorderSize = 0
        Me.btncalcular.Font = New System.Drawing.Font("Roboto Lt", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncalcular.ForeColor = System.Drawing.Color.White
        Me.btncalcular.Location = New System.Drawing.Point(23, 203)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.Size = New System.Drawing.Size(88, 33)
        Me.btncalcular.TabIndex = 3
        Me.btncalcular.Text = "CALCULAR"
        Me.btncalcular.UseVisualStyleBackColor = False
        '
        'btnlimpiar
        '
        Me.btnlimpiar.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnlimpiar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnlimpiar.FlatAppearance.BorderSize = 0
        Me.btnlimpiar.Font = New System.Drawing.Font("Roboto Lt", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlimpiar.ForeColor = System.Drawing.Color.White
        Me.btnlimpiar.Location = New System.Drawing.Point(137, 203)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(88, 33)
        Me.btnlimpiar.TabIndex = 4
        Me.btnlimpiar.Text = "LIMPIAR"
        Me.btnlimpiar.UseVisualStyleBackColor = False
        '
        'btnsalir
        '
        Me.btnsalir.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnsalir.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnsalir.FlatAppearance.BorderSize = 0
        Me.btnsalir.Font = New System.Drawing.Font("Roboto Lt", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalir.ForeColor = System.Drawing.Color.White
        Me.btnsalir.Location = New System.Drawing.Point(249, 203)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(88, 33)
        Me.btnsalir.TabIndex = 5
        Me.btnsalir.Text = "SALIR"
        Me.btnsalir.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(362, 277)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnlimpiar)
        Me.Controls.Add(Me.btncalcular)
        Me.Controls.Add(Me.txtpromedio)
        Me.Controls.Add(Me.txtn2)
        Me.Controls.Add(Me.txtn1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Encontrar Promedio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtn1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtn2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtpromedio As TextBox
    Friend WithEvents btncalcular As Button
    Friend WithEvents btnlimpiar As Button
    Friend WithEvents btnsalir As Button
End Class
