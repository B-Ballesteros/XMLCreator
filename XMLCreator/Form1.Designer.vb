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
        Me.generateBtn = New System.Windows.Forms.Button()
        Me.readBtn = New System.Windows.Forms.Button()
        Me.appendBtn = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'generateBtn
        '
        Me.generateBtn.Location = New System.Drawing.Point(78, 22)
        Me.generateBtn.Name = "generateBtn"
        Me.generateBtn.Size = New System.Drawing.Size(75, 23)
        Me.generateBtn.TabIndex = 0
        Me.generateBtn.Text = "Generate"
        Me.generateBtn.UseVisualStyleBackColor = True
        '
        'readBtn
        '
        Me.readBtn.Location = New System.Drawing.Point(78, 62)
        Me.readBtn.Name = "readBtn"
        Me.readBtn.Size = New System.Drawing.Size(75, 23)
        Me.readBtn.TabIndex = 1
        Me.readBtn.Text = "Read"
        Me.readBtn.UseVisualStyleBackColor = True
        '
        'appendBtn
        '
        Me.appendBtn.Location = New System.Drawing.Point(78, 101)
        Me.appendBtn.Name = "appendBtn"
        Me.appendBtn.Size = New System.Drawing.Size(75, 23)
        Me.appendBtn.TabIndex = 2
        Me.appendBtn.Text = "Append"
        Me.appendBtn.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(60, 153)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.appendBtn)
        Me.Controls.Add(Me.readBtn)
        Me.Controls.Add(Me.generateBtn)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents generateBtn As Button
    Friend WithEvents readBtn As Button
    Friend WithEvents appendBtn As Button
    Friend WithEvents ComboBox1 As ComboBox
End Class
