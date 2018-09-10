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
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt3 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnmsg1 = New System.Windows.Forms.Button()
        Me.btnmsg23 = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(30, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mensaje 1:"
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(123, 89)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(158, 20)
        Me.txt1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(31, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mensaje 2:"
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(123, 134)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(158, 20)
        Me.txt2.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(31, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 19)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Mensaje 3:"
        '
        'txt3
        '
        Me.txt3.Location = New System.Drawing.Point(122, 178)
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(158, 20)
        Me.txt3.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Semana2.My.Resources.Resources.sandwich
        Me.PictureBox1.Location = New System.Drawing.Point(333, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(273, 229)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'btnmsg1
        '
        Me.btnmsg1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnmsg1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnmsg1.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmsg1.ForeColor = System.Drawing.Color.White
        Me.btnmsg1.Location = New System.Drawing.Point(34, 291)
        Me.btnmsg1.Name = "btnmsg1"
        Me.btnmsg1.Size = New System.Drawing.Size(133, 42)
        Me.btnmsg1.TabIndex = 3
        Me.btnmsg1.Text = "Primer Mensaje"
        Me.btnmsg1.UseVisualStyleBackColor = False
        '
        'btnmsg23
        '
        Me.btnmsg23.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnmsg23.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnmsg23.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmsg23.ForeColor = System.Drawing.Color.White
        Me.btnmsg23.Location = New System.Drawing.Point(186, 291)
        Me.btnmsg23.Name = "btnmsg23"
        Me.btnmsg23.Size = New System.Drawing.Size(262, 42)
        Me.btnmsg23.TabIndex = 3
        Me.btnmsg23.Text = "Segundo y Tercer Mensaje"
        Me.btnmsg23.UseVisualStyleBackColor = False
        '
        'btnsalir
        '
        Me.btnsalir.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnsalir.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnsalir.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsalir.ForeColor = System.Drawing.Color.White
        Me.btnsalir.Location = New System.Drawing.Point(473, 291)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(133, 42)
        Me.btnsalir.TabIndex = 3
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = False
        '
        'btnlimpiar
        '
        Me.btnlimpiar.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnlimpiar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnlimpiar.FlatAppearance.BorderSize = 0
        Me.btnlimpiar.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlimpiar.ForeColor = System.Drawing.Color.White
        Me.btnlimpiar.Location = New System.Drawing.Point(186, 223)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(95, 30)
        Me.btnlimpiar.TabIndex = 3
        Me.btnlimpiar.Text = "Limpiar"
        Me.btnlimpiar.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(629, 359)
        Me.Controls.Add(Me.btnlimpiar)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btnmsg23)
        Me.Controls.Add(Me.btnmsg1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txt3)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Semana 2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt3 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnmsg1 As Button
    Friend WithEvents btnmsg23 As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents btnlimpiar As Button
End Class
