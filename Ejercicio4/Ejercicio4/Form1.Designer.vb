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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtn1 = New System.Windows.Forms.TextBox()
        Me.txtn2 = New System.Windows.Forms.TextBox()
        Me.txtn3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtsuma = New System.Windows.Forms.TextBox()
        Me.txtpromedio = New System.Windows.Forms.TextBox()
        Me.btncalcular = New System.Windows.Forms.Button()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto Lt", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(38, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Número 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto Lt", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(38, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Número 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto Lt", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(39, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Número 3"
        '
        'txtn1
        '
        Me.txtn1.Location = New System.Drawing.Point(116, 50)
        Me.txtn1.Name = "txtn1"
        Me.txtn1.Size = New System.Drawing.Size(100, 20)
        Me.txtn1.TabIndex = 0
        '
        'txtn2
        '
        Me.txtn2.Location = New System.Drawing.Point(116, 89)
        Me.txtn2.Name = "txtn2"
        Me.txtn2.Size = New System.Drawing.Size(100, 20)
        Me.txtn2.TabIndex = 1
        '
        'txtn3
        '
        Me.txtn3.Location = New System.Drawing.Point(116, 129)
        Me.txtn3.Name = "txtn3"
        Me.txtn3.Size = New System.Drawing.Size(100, 20)
        Me.txtn3.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Roboto Lt", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(379, 39)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "RESULTADOS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Roboto Lt", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(255, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "SUMA"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Roboto Lt", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(255, 111)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 15)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "PROMEDIO"
        '
        'txtsuma
        '
        Me.txtsuma.Location = New System.Drawing.Point(361, 75)
        Me.txtsuma.Name = "txtsuma"
        Me.txtsuma.Size = New System.Drawing.Size(133, 20)
        Me.txtsuma.TabIndex = 6
        '
        'txtpromedio
        '
        Me.txtpromedio.Location = New System.Drawing.Point(361, 109)
        Me.txtpromedio.Name = "txtpromedio"
        Me.txtpromedio.Size = New System.Drawing.Size(133, 20)
        Me.txtpromedio.TabIndex = 7
        '
        'btncalcular
        '
        Me.btncalcular.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btncalcular.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btncalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncalcular.Font = New System.Drawing.Font("Roboto Lt", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncalcular.ForeColor = System.Drawing.Color.White
        Me.btncalcular.Location = New System.Drawing.Point(64, 197)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btncalcular.Size = New System.Drawing.Size(107, 30)
        Me.btncalcular.TabIndex = 3
        Me.btncalcular.Text = "CALCULAR"
        Me.btncalcular.UseVisualStyleBackColor = False
        '
        'btnlimpiar
        '
        Me.btnlimpiar.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnlimpiar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnlimpiar.Font = New System.Drawing.Font("Roboto Lt", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlimpiar.ForeColor = System.Drawing.Color.White
        Me.btnlimpiar.Location = New System.Drawing.Point(206, 197)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnlimpiar.Size = New System.Drawing.Size(107, 30)
        Me.btnlimpiar.TabIndex = 4
        Me.btnlimpiar.Text = "LIMPIAR"
        Me.btnlimpiar.UseVisualStyleBackColor = False
        '
        'btnsalir
        '
        Me.btnsalir.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnsalir.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsalir.Font = New System.Drawing.Font("Roboto Lt", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalir.ForeColor = System.Drawing.Color.White
        Me.btnsalir.Location = New System.Drawing.Point(349, 197)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnsalir.Size = New System.Drawing.Size(107, 30)
        Me.btnsalir.TabIndex = 5
        Me.btnsalir.Text = "SALIR"
        Me.btnsalir.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(524, 260)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnlimpiar)
        Me.Controls.Add(Me.btncalcular)
        Me.Controls.Add(Me.txtn3)
        Me.Controls.Add(Me.txtn2)
        Me.Controls.Add(Me.txtpromedio)
        Me.Controls.Add(Me.txtsuma)
        Me.Controls.Add(Me.txtn1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cálculo Suma y Promedio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtn1 As TextBox
    Friend WithEvents txtn2 As TextBox
    Friend WithEvents txtn3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtsuma As TextBox
    Friend WithEvents txtpromedio As TextBox
    Friend WithEvents btncalcular As Button
    Friend WithEvents btnlimpiar As Button
    Friend WithEvents btnsalir As Button
End Class
