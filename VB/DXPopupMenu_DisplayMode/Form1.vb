Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors.Repository

Namespace DXPopupMenu_DisplayMode
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()

			InitPopupMenu()
		End Sub

		Protected Overridable Sub InitPopupMenu()
			Dim riEditComboBox As New RepositoryItemComboBox()
			riEditComboBox.Items.Add("item1")
			riEditComboBox.Items.Add("item2")
			riEditComboBox.Items.Add("item3")
			riEditComboBox.Items.Add("item4")
			riEditComboBox.Items.Add("item5")

			Dim riDateEdit As New RepositoryItemDateEdit()

			menu = New DXPopupMenu()
			menu.Items.Add(New DXMenuItem("Cut", New EventHandler(AddressOf OnItemClick), My.Resources.Cut_16x16, Nothing, My.Resources.Cut_32x32, Nothing))
			menu.Items.Add(New DXMenuItem("Copy", New EventHandler(AddressOf OnItemClick), My.Resources.Copy_16x16, Nothing, My.Resources.Copy_32x32, Nothing))
			menu.Items.Add(New DXMenuItem("Paste", New EventHandler(AddressOf OnItemClick), My.Resources.Paste_16x16, Nothing, My.Resources.Paste_32x32, Nothing))
			menu.Items.Add(New DXEditMenuItem("ComboBox", riEditComboBox, Nothing, Nothing, Nothing, 100, -1))
			menu.Items.Add(New DXEditMenuItem("DateEdit", riDateEdit, Nothing, Nothing, Nothing, 100, -1))
			Dim group1 As New DXButtonGroupItem()
			group1.Caption = "Button Group 1"
			group1.Items.Add(New DXMenuItem("Open", New EventHandler(AddressOf OnItemClick), My.Resources.Open_16x16, Nothing, My.Resources.Open_32x32, Nothing))
			group1.Items.Add(New DXMenuItem("Save", New EventHandler(AddressOf OnItemClick), My.Resources.Save_16x16, Nothing, My.Resources.Save_32x32, Nothing))
			group1.Items.Add(New DXMenuItem("Save All", New EventHandler(AddressOf OnItemClick), My.Resources.SaveAll_16x16, Nothing, My.Resources.SaveAll_32x32, Nothing))
			Dim group2 As New DXButtonGroupItem()
			group2.Caption = "Button Group 2"
			group2.Items.Add(New DXMenuItem("Edit", New EventHandler(AddressOf OnItemClick), My.Resources.Edit_16x16, Nothing, My.Resources.Edit_32x32, Nothing))
			group2.Items.Add(New DXMenuItem("Delete", New EventHandler(AddressOf OnItemClick), My.Resources.Delete_16x16, Nothing, My.Resources.Delete_32x32, Nothing))
			group2.Items.Add(New DXMenuItem("Print", New EventHandler(AddressOf OnItemClick), My.Resources.Print_16x16, Nothing, My.Resources.Print_32x32, Nothing))
			Dim group3 As New DXButtonGroupItem()
			group3.Caption = "Button Group 3"
			group3.Items.Add(New DXMenuItem("Close", New EventHandler(AddressOf OnItemClick), My.Resources.Close_16x16, Nothing, My.Resources.Close_32x32, Nothing))
			group3.Items.Add(New DXMenuItem("Delete", New EventHandler(AddressOf OnItemClick), My.Resources.Delete_16x16, Nothing, My.Resources.Delete_32x32, Nothing))
			menu.Items.Add(group1)
			menu.Items.Add(group2)
			menu.Items.Add(group3)
		End Sub
		Private Sub OnItemClick(ByVal sender As Object, ByVal e As EventArgs)
		End Sub

		Private menu As DXPopupMenu
		Private Sub btnDisplayAsRegularMenu_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDisplayAsRegularMenu.Click
			Dim form As New SimpleForm()
			form.PopupMenu = menu
			form.Show()
		End Sub
		Private Sub btnDisplayAsPopupBar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDisplayAsPopupBar.Click
			Dim form As New BarsForm()
			form.PopupMenu = menu
			form.Show()
		End Sub
		Private Sub btnDisplayAsRibbonMiniToolbar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDisplayAsRibbonMiniToolbar.Click
			Dim form As New RibbonForm1()
			form.PopupMenu = menu
			form.Show()
		End Sub
	End Class
End Namespace