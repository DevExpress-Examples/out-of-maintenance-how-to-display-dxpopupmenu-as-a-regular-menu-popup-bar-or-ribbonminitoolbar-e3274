Imports Microsoft.VisualBasic
Imports System
Namespace DXPopupMenu_DisplayMode
	Partial Public Class SimpleForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.SuspendLayout()
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(301, 199)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(92, 13)
			Me.labelControl1.TabIndex = 0
			Me.labelControl1.Text = "Right-click the form"
			' 
			' SimpleForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(694, 441)
			Me.Controls.Add(Me.labelControl1)
			Me.Name = "SimpleForm"
			Me.Text = "SimpleForm"
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private labelControl1 As DevExpress.XtraEditors.LabelControl
	End Class
End Namespace