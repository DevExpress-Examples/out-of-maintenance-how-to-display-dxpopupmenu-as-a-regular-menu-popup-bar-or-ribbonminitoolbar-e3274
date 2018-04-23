Imports Microsoft.VisualBasic
Imports System
Namespace DXPopupMenu_DisplayMode
	Partial Public Class Form1
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
			Me.btnDisplayAsRegularMenu = New System.Windows.Forms.Button()
			Me.btnDisplayAsPopupBar = New System.Windows.Forms.Button()
			Me.btnDisplayAsRibbonMiniToolbar = New System.Windows.Forms.Button()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			Me.SuspendLayout()
			' 
			' btnDisplayAsRegularMenu
			' 
			Me.btnDisplayAsRegularMenu.Location = New System.Drawing.Point(148, 31)
			Me.btnDisplayAsRegularMenu.Name = "btnDisplayAsRegularMenu"
			Me.btnDisplayAsRegularMenu.Size = New System.Drawing.Size(135, 23)
			Me.btnDisplayAsRegularMenu.TabIndex = 0
			Me.btnDisplayAsRegularMenu.Text = "Regular Menu"
			Me.btnDisplayAsRegularMenu.UseVisualStyleBackColor = True
'			Me.btnDisplayAsRegularMenu.Click += New System.EventHandler(Me.btnDisplayAsRegularMenu_Click);
			' 
			' btnDisplayAsPopupBar
			' 
			Me.btnDisplayAsPopupBar.Location = New System.Drawing.Point(148, 68)
			Me.btnDisplayAsPopupBar.Name = "btnDisplayAsPopupBar"
			Me.btnDisplayAsPopupBar.Size = New System.Drawing.Size(135, 23)
			Me.btnDisplayAsPopupBar.TabIndex = 1
			Me.btnDisplayAsPopupBar.Text = "Popup Bar"
			Me.btnDisplayAsPopupBar.UseVisualStyleBackColor = True
'			Me.btnDisplayAsPopupBar.Click += New System.EventHandler(Me.btnDisplayAsPopupBar_Click);
			' 
			' btnDisplayAsRibbonMiniToolbar
			' 
			Me.btnDisplayAsRibbonMiniToolbar.Location = New System.Drawing.Point(148, 105)
			Me.btnDisplayAsRibbonMiniToolbar.Name = "btnDisplayAsRibbonMiniToolbar"
			Me.btnDisplayAsRibbonMiniToolbar.Size = New System.Drawing.Size(135, 23)
			Me.btnDisplayAsRibbonMiniToolbar.TabIndex = 2
			Me.btnDisplayAsRibbonMiniToolbar.Text = "RibbonMiniToolbar"
			Me.btnDisplayAsRibbonMiniToolbar.UseVisualStyleBackColor = True
'			Me.btnDisplayAsRibbonMiniToolbar.Click += New System.EventHandler(Me.btnDisplayAsRibbonMiniToolbar_Click);
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(12, 73)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(124, 13)
			Me.labelControl1.TabIndex = 3
			Me.labelControl1.Text = "Display DXPopupMenu as:"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(338, 185)
			Me.Controls.Add(Me.labelControl1)
			Me.Controls.Add(Me.btnDisplayAsRibbonMiniToolbar)
			Me.Controls.Add(Me.btnDisplayAsPopupBar)
			Me.Controls.Add(Me.btnDisplayAsRegularMenu)
			Me.Name = "Form1"
			Me.Text = "Form1"
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents btnDisplayAsRegularMenu As System.Windows.Forms.Button
		Private WithEvents btnDisplayAsPopupBar As System.Windows.Forms.Button
		Private WithEvents btnDisplayAsRibbonMiniToolbar As System.Windows.Forms.Button
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
	End Class
End Namespace

