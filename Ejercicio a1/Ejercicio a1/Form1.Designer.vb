<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btEjecutar = New Button()
        Label1 = New Label()
        Label2 = New Label()
        lblMostrarMayor = New Label()
        lblMostrarMenor = New Label()
        SuspendLayout()
        ' 
        ' btEjecutar
        ' 
        btEjecutar.Location = New Point(342, 74)
        btEjecutar.Name = "btEjecutar"
        btEjecutar.Size = New Size(121, 56)
        btEjecutar.TabIndex = 0
        btEjecutar.Text = "Ejecutar"
        btEjecutar.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(192, 166)
        Label1.Name = "Label1"
        Label1.Size = New Size(88, 20)
        Label1.TabIndex = 1
        Label1.Text = "El mayor es:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(521, 166)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 20)
        Label2.TabIndex = 2
        Label2.Text = "El menor es:"
        ' 
        ' lblMostrarMayor
        ' 
        lblMostrarMayor.AutoSize = True
        lblMostrarMayor.Location = New Point(233, 200)
        lblMostrarMayor.Name = "lblMostrarMayor"
        lblMostrarMayor.Size = New Size(0, 20)
        lblMostrarMayor.TabIndex = 3
        ' 
        ' lblMostrarMenor
        ' 
        lblMostrarMenor.AutoSize = True
        lblMostrarMenor.Location = New Point(564, 200)
        lblMostrarMenor.Name = "lblMostrarMenor"
        lblMostrarMenor.Size = New Size(0, 20)
        lblMostrarMenor.TabIndex = 4
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblMostrarMenor)
        Controls.Add(lblMostrarMayor)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btEjecutar)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btEjecutar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblMostrarMayor As Label
    Friend WithEvents lblMostrarMenor As Label
End Class
