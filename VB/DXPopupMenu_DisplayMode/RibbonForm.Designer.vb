Imports Microsoft.VisualBasic
Imports System
Namespace DXPopupMenu_DisplayMode
	Partial Public Class RibbonForm1
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
			Me.components = New System.ComponentModel.Container()
			Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
			Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
			Me.popupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
			Me.barEditItem3 = New DevExpress.XtraBars.BarEditItem()
			Me.repositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
			Me.barEditItem1 = New DevExpress.XtraBars.BarEditItem()
			Me.repositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
			Me.barButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
			Me.barEditItem2 = New DevExpress.XtraBars.BarEditItem()
			Me.repositoryItemDateEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
			Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
			Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.ribbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.ribbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.ribbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.popupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemDateEdit2.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' ribbonControl1
			' 
			Me.ribbonControl1.ApplicationButtonText = Nothing
			' 
			' 
			' 
			Me.ribbonControl1.ExpandCollapseItem.Id = 0
			Me.ribbonControl1.ExpandCollapseItem.Name = ""
			Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl1.ExpandCollapseItem, Me.barButtonItem1, Me.barEditItem1, Me.barButtonItem2, Me.barButtonItem3, Me.barEditItem2, Me.barEditItem3})
			Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
			Me.ribbonControl1.MaxItemId = 7
			Me.ribbonControl1.Name = "ribbonControl1"
			Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.ribbonPage1})
			Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemDateEdit1, Me.repositoryItemDateEdit2, Me.repositoryItemComboBox1})
			Me.ribbonControl1.SelectedPage = Me.ribbonPage1
			Me.ribbonControl1.Size = New System.Drawing.Size(825, 147)
			' 
			' barButtonItem1
			' 
			Me.barButtonItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
			Me.barButtonItem1.Caption = "barButtonItem1"
			Me.barButtonItem1.DropDownControl = Me.popupMenu1
            Me.barButtonItem1.Glyph = Resources.SaveAll_32x32
            Me.barButtonItem1.Id = 1
			Me.barButtonItem1.Name = "barButtonItem1"
			' 
			' popupMenu1
			' 
			Me.popupMenu1.ItemLinks.Add(Me.barEditItem3)
			Me.popupMenu1.Name = "popupMenu1"
			Me.popupMenu1.Ribbon = Me.ribbonControl1
			' 
			' barEditItem3
			' 
			Me.barEditItem3.Caption = "barEditItem3"
			Me.barEditItem3.Edit = Me.repositoryItemComboBox1
			Me.barEditItem3.Id = 6
			Me.barEditItem3.Name = "barEditItem3"
			' 
			' repositoryItemComboBox1
			' 
			Me.repositoryItemComboBox1.AutoHeight = False
			Me.repositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemComboBox1.Items.AddRange(New Object() { "item1", "item2", "item3", "item4", "item5"})
			Me.repositoryItemComboBox1.Name = "repositoryItemComboBox1"
			' 
			' barEditItem1
			' 
			Me.barEditItem1.Caption = "barEditItem1"
			Me.barEditItem1.Edit = Me.repositoryItemDateEdit1
			Me.barEditItem1.EditHeight = 32
			Me.barEditItem1.Id = 2
			Me.barEditItem1.Name = "barEditItem1"
			' 
			' repositoryItemDateEdit1
			' 
			Me.repositoryItemDateEdit1.AutoHeight = False
			Me.repositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1"
			Me.repositoryItemDateEdit1.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			' 
			' barButtonItem2
			' 
			Me.barButtonItem2.Caption = "barButtonItem2"
			Me.barButtonItem2.Id = 3
			Me.barButtonItem2.Name = "barButtonItem2"
			' 
			' barButtonItem3
			' 
			Me.barButtonItem3.Caption = "barButtonItem3"
			Me.barButtonItem3.Id = 4
			Me.barButtonItem3.Name = "barButtonItem3"
			' 
			' barEditItem2
			' 
			Me.barEditItem2.Caption = "barEditItem2"
			Me.barEditItem2.Edit = Me.repositoryItemDateEdit2
			Me.barEditItem2.Id = 5
			Me.barEditItem2.Name = "barEditItem2"
			' 
			' repositoryItemDateEdit2
			' 
			Me.repositoryItemDateEdit2.AutoHeight = False
			Me.repositoryItemDateEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2"
			Me.repositoryItemDateEdit2.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			' 
			' ribbonPage1
			' 
			Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup1, Me.ribbonPageGroup2, Me.ribbonPageGroup3, Me.ribbonPageGroup4})
			Me.ribbonPage1.Name = "ribbonPage1"
			Me.ribbonPage1.Text = "ribbonPage1"
			' 
			' ribbonPageGroup1
			' 
			Me.ribbonPageGroup1.ItemLinks.Add(Me.barButtonItem1)
			Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
			Me.ribbonPageGroup1.Text = "ribbonPageGroup1"
			' 
			' ribbonPageGroup2
			' 
			Me.ribbonPageGroup2.Name = "ribbonPageGroup2"
			Me.ribbonPageGroup2.Text = "ribbonPageGroup2"
			' 
			' ribbonPageGroup3
			' 
			Me.ribbonPageGroup3.Name = "ribbonPageGroup3"
			Me.ribbonPageGroup3.Text = "ribbonPageGroup3"
			' 
			' ribbonPageGroup4
			' 
			Me.ribbonPageGroup4.ItemLinks.Add(Me.barButtonItem2)
			Me.ribbonPageGroup4.ItemLinks.Add(Me.barButtonItem3)
			Me.ribbonPageGroup4.ItemLinks.Add(Me.barEditItem2)
			Me.ribbonPageGroup4.Name = "ribbonPageGroup4"
			Me.ribbonPageGroup4.Text = "ribbonPageGroup4"
			' 
			' labelControl1
			' 
			Me.labelControl1.Location = New System.Drawing.Point(367, 291)
			Me.labelControl1.Name = "labelControl1"
			Me.labelControl1.Size = New System.Drawing.Size(92, 13)
			Me.labelControl1.TabIndex = 1
			Me.labelControl1.Text = "Right-click the form"
			' 
			' RibbonForm1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(825, 505)
			Me.Controls.Add(Me.labelControl1)
			Me.Controls.Add(Me.ribbonControl1)
			Me.Name = "RibbonForm1"
			Me.Ribbon = Me.ribbonControl1
			Me.Text = "RibbonForm"
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.popupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemDateEdit1.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemDateEdit2.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemDateEdit2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
		Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
		Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private barButtonItem1 As DevExpress.XtraBars.BarButtonItem
		Private barEditItem1 As DevExpress.XtraBars.BarEditItem
		Private repositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
		Private barButtonItem2 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem3 As DevExpress.XtraBars.BarButtonItem
		Private barEditItem2 As DevExpress.XtraBars.BarEditItem
		Private repositoryItemDateEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
		Private ribbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private ribbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private ribbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private barEditItem3 As DevExpress.XtraBars.BarEditItem
		Private repositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
		Private popupMenu1 As DevExpress.XtraBars.PopupMenu
		Private labelControl1 As DevExpress.XtraEditors.LabelControl
	End Class
End Namespace