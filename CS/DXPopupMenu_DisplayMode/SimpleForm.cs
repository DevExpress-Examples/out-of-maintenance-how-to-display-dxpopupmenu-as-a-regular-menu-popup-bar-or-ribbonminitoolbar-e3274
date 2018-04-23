using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils.Menu;
using DevExpress.LookAndFeel.Design;

namespace DXPopupMenu_DisplayMode {
    public partial class SimpleForm : Form {
        public SimpleForm() {
            InitializeComponent();
        }

        public DXPopupMenu PopupMenu;

        protected override void OnMouseUp(MouseEventArgs e) {
            if(e.Button == MouseButtons.Right) {
                ((IDXDropDownControl)PopupMenu).Show(new SkinMenuManager(UserLookAndFeelDefault.Default), this, e.Location);
            }
        }
    }
}