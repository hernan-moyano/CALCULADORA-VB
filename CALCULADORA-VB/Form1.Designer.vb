<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCalc
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
        Me.bt0 = New System.Windows.Forms.Button()
        Me.btComa = New System.Windows.Forms.Button()
        Me.btSuma = New System.Windows.Forms.Button()
        Me.btResultado = New System.Windows.Forms.Button()
        Me.bt2 = New System.Windows.Forms.Button()
        Me.bt3 = New System.Windows.Forms.Button()
        Me.btMultiplicacion = New System.Windows.Forms.Button()
        Me.bt5 = New System.Windows.Forms.Button()
        Me.bt6 = New System.Windows.Forms.Button()
        Me.btResta = New System.Windows.Forms.Button()
        Me.bt8 = New System.Windows.Forms.Button()
        Me.btDivision = New System.Windows.Forms.Button()
        Me.bt9 = New System.Windows.Forms.Button()
        Me.btBorrar = New System.Windows.Forms.Button()
        Me.bt1 = New System.Windows.Forms.Button()
        Me.bt4 = New System.Windows.Forms.Button()
        Me.bt7 = New System.Windows.Forms.Button()
        Me.txtDisplay = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'bt0
        '
        Me.bt0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt0.Location = New System.Drawing.Point(12, 189)
        Me.bt0.Name = "bt0"
        Me.bt0.Size = New System.Drawing.Size(86, 40)
        Me.bt0.TabIndex = 0
        Me.bt0.Text = "0"
        Me.bt0.UseVisualStyleBackColor = True
        '
        'btComa
        '
        Me.btComa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btComa.Location = New System.Drawing.Point(104, 189)
        Me.btComa.Name = "btComa"
        Me.btComa.Size = New System.Drawing.Size(40, 40)
        Me.btComa.TabIndex = 1
        Me.btComa.Text = "."
        Me.btComa.UseVisualStyleBackColor = True
        '
        'btSuma
        '
        Me.btSuma.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSuma.Location = New System.Drawing.Point(150, 189)
        Me.btSuma.Name = "btSuma"
        Me.btSuma.Size = New System.Drawing.Size(40, 40)
        Me.btSuma.TabIndex = 2
        Me.btSuma.Text = "+"
        Me.btSuma.UseVisualStyleBackColor = True
        '
        'btResultado
        '
        Me.btResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btResultado.Location = New System.Drawing.Point(196, 97)
        Me.btResultado.Name = "btResultado"
        Me.btResultado.Size = New System.Drawing.Size(40, 132)
        Me.btResultado.TabIndex = 3
        Me.btResultado.Text = "="
        Me.btResultado.UseVisualStyleBackColor = True
        '
        'bt2
        '
        Me.bt2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt2.Location = New System.Drawing.Point(58, 143)
        Me.bt2.Name = "bt2"
        Me.bt2.Size = New System.Drawing.Size(40, 40)
        Me.bt2.TabIndex = 4
        Me.bt2.Text = "2"
        Me.bt2.UseVisualStyleBackColor = True
        '
        'bt3
        '
        Me.bt3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt3.Location = New System.Drawing.Point(104, 143)
        Me.bt3.Name = "bt3"
        Me.bt3.Size = New System.Drawing.Size(40, 40)
        Me.bt3.TabIndex = 5
        Me.bt3.Text = "3"
        Me.bt3.UseVisualStyleBackColor = True
        '
        'btMultiplicacion
        '
        Me.btMultiplicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btMultiplicacion.Location = New System.Drawing.Point(150, 143)
        Me.btMultiplicacion.Name = "btMultiplicacion"
        Me.btMultiplicacion.Size = New System.Drawing.Size(40, 40)
        Me.btMultiplicacion.TabIndex = 6
        Me.btMultiplicacion.Text = "x"
        Me.btMultiplicacion.UseVisualStyleBackColor = True
        '
        'bt5
        '
        Me.bt5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt5.Location = New System.Drawing.Point(58, 97)
        Me.bt5.Name = "bt5"
        Me.bt5.Size = New System.Drawing.Size(40, 40)
        Me.bt5.TabIndex = 7
        Me.bt5.Text = "5"
        Me.bt5.UseVisualStyleBackColor = True
        '
        'bt6
        '
        Me.bt6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt6.Location = New System.Drawing.Point(104, 97)
        Me.bt6.Name = "bt6"
        Me.bt6.Size = New System.Drawing.Size(40, 40)
        Me.bt6.TabIndex = 8
        Me.bt6.Text = "6"
        Me.bt6.UseVisualStyleBackColor = True
        '
        'btResta
        '
        Me.btResta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btResta.Location = New System.Drawing.Point(150, 97)
        Me.btResta.Name = "btResta"
        Me.btResta.Size = New System.Drawing.Size(40, 40)
        Me.btResta.TabIndex = 9
        Me.btResta.Text = "-"
        Me.btResta.UseVisualStyleBackColor = True
        '
        'bt8
        '
        Me.bt8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt8.Location = New System.Drawing.Point(58, 51)
        Me.bt8.Name = "bt8"
        Me.bt8.Size = New System.Drawing.Size(40, 40)
        Me.bt8.TabIndex = 10
        Me.bt8.Text = "8"
        Me.bt8.UseVisualStyleBackColor = True
        '
        'btDivision
        '
        Me.btDivision.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btDivision.Location = New System.Drawing.Point(150, 51)
        Me.btDivision.Name = "btDivision"
        Me.btDivision.Size = New System.Drawing.Size(40, 40)
        Me.btDivision.TabIndex = 11
        Me.btDivision.Text = "/"
        Me.btDivision.UseVisualStyleBackColor = True
        '
        'bt9
        '
        Me.bt9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt9.Location = New System.Drawing.Point(104, 51)
        Me.bt9.Name = "bt9"
        Me.bt9.Size = New System.Drawing.Size(40, 40)
        Me.bt9.TabIndex = 12
        Me.bt9.Text = "9"
        Me.bt9.UseVisualStyleBackColor = True
        '
        'btBorrar
        '
        Me.btBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btBorrar.Location = New System.Drawing.Point(196, 51)
        Me.btBorrar.Name = "btBorrar"
        Me.btBorrar.Size = New System.Drawing.Size(40, 40)
        Me.btBorrar.TabIndex = 13
        Me.btBorrar.Text = "C"
        Me.btBorrar.UseVisualStyleBackColor = True
        '
        'bt1
        '
        Me.bt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt1.Location = New System.Drawing.Point(12, 143)
        Me.bt1.Name = "bt1"
        Me.bt1.Size = New System.Drawing.Size(40, 40)
        Me.bt1.TabIndex = 14
        Me.bt1.Text = "1"
        Me.bt1.UseVisualStyleBackColor = True
        '
        'bt4
        '
        Me.bt4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt4.Location = New System.Drawing.Point(12, 97)
        Me.bt4.Name = "bt4"
        Me.bt4.Size = New System.Drawing.Size(40, 40)
        Me.bt4.TabIndex = 15
        Me.bt4.Text = "4"
        Me.bt4.UseVisualStyleBackColor = True
        '
        'bt7
        '
        Me.bt7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt7.Location = New System.Drawing.Point(12, 51)
        Me.bt7.Name = "bt7"
        Me.bt7.Size = New System.Drawing.Size(40, 40)
        Me.bt7.TabIndex = 16
        Me.bt7.Text = "7"
        Me.bt7.UseVisualStyleBackColor = True
        '
        'txtDisplay
        '
        Me.txtDisplay.Location = New System.Drawing.Point(12, 12)
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.Size = New System.Drawing.Size(224, 20)
        Me.txtDisplay.TabIndex = 17
        '
        'FormCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkKhaki
        Me.ClientSize = New System.Drawing.Size(244, 243)
        Me.Controls.Add(Me.txtDisplay)
        Me.Controls.Add(Me.bt7)
        Me.Controls.Add(Me.bt4)
        Me.Controls.Add(Me.bt1)
        Me.Controls.Add(Me.btBorrar)
        Me.Controls.Add(Me.bt9)
        Me.Controls.Add(Me.btDivision)
        Me.Controls.Add(Me.bt8)
        Me.Controls.Add(Me.btResta)
        Me.Controls.Add(Me.bt6)
        Me.Controls.Add(Me.bt5)
        Me.Controls.Add(Me.btMultiplicacion)
        Me.Controls.Add(Me.bt3)
        Me.Controls.Add(Me.bt2)
        Me.Controls.Add(Me.btResultado)
        Me.Controls.Add(Me.btSuma)
        Me.Controls.Add(Me.btComa)
        Me.Controls.Add(Me.bt0)
        Me.Name = "FormCalc"
        Me.Text = "Calculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bt0 As Button
    Friend WithEvents btComa As Button
    Friend WithEvents btSuma As Button
    Friend WithEvents btResultado As Button
    Friend WithEvents bt2 As Button
    Friend WithEvents bt3 As Button
    Friend WithEvents btMultiplicacion As Button
    Friend WithEvents bt5 As Button
    Friend WithEvents bt6 As Button
    Friend WithEvents btResta As Button
    Friend WithEvents bt8 As Button
    Friend WithEvents btDivision As Button
    Friend WithEvents bt9 As Button
    Friend WithEvents btBorrar As Button
    Friend WithEvents bt1 As Button
    Friend WithEvents bt4 As Button
    Friend WithEvents bt7 As Button
    Friend WithEvents txtDisplay As TextBox
End Class
