﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.btnlanzar = New System.Windows.Forms.Button()
        Me.btnsiguiente = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(86, 32)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(169, 20)
        Me.txt1.TabIndex = 0
        '
        'btnlanzar
        '
        Me.btnlanzar.Location = New System.Drawing.Point(35, 85)
        Me.btnlanzar.Name = "btnlanzar"
        Me.btnlanzar.Size = New System.Drawing.Size(96, 31)
        Me.btnlanzar.TabIndex = 1
        Me.btnlanzar.Text = "Mensaje"
        Me.btnlanzar.UseVisualStyleBackColor = True
        '
        'btnsiguiente
        '
        Me.btnsiguiente.Location = New System.Drawing.Point(182, 85)
        Me.btnsiguiente.Name = "btnsiguiente"
        Me.btnsiguiente.Size = New System.Drawing.Size(140, 31)
        Me.btnsiguiente.TabIndex = 1
        Me.btnsiguiente.Text = "Siguiente mensaje >"
        Me.btnsiguiente.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 149)
        Me.Controls.Add(Me.btnsiguiente)
        Me.Controls.Add(Me.btnlanzar)
        Me.Controls.Add(Me.txt1)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mensajes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt1 As TextBox
    Friend WithEvents btnlanzar As Button
    Friend WithEvents btnsiguiente As Button
End Class
