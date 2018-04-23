Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Utils.Menu
Imports DevExpress.LookAndFeel.Design

Namespace DXPopupMenu_DisplayMode
	Partial Public Class SimpleForm
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Public PopupMenu As DXPopupMenu

		Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
			If e.Button = MouseButtons.Right Then
				CType(PopupMenu, IDXDropDownControl).Show(New SkinMenuManager(UserLookAndFeelDefault.Default), Me, e.Location)
			End If
		End Sub
	End Class
End Namespace