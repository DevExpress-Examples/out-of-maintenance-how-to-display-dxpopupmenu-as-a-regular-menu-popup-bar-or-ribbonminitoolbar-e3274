using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils.Menu;
using DevExpress.XtraEditors.Repository;

namespace DXPopupMenu_DisplayMode {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            InitPopupMenu();
        }

        protected virtual void InitPopupMenu() {
            RepositoryItemComboBox riEditComboBox = new RepositoryItemComboBox();
            riEditComboBox.Items.Add("item1");
            riEditComboBox.Items.Add("item2");
            riEditComboBox.Items.Add("item3");
            riEditComboBox.Items.Add("item4");
            riEditComboBox.Items.Add("item5");

            RepositoryItemDateEdit riDateEdit = new RepositoryItemDateEdit();
                        
            menu = new DXPopupMenu();
            menu.Items.Add(new DXMenuItem("Cut", new EventHandler(OnItemClick), DXPopupMenu_DisplayMode.Properties.Resources.Cut_16x16, null, DXPopupMenu_DisplayMode.Properties.Resources.Cut_32x32, null));
            menu.Items.Add(new DXMenuItem("Copy", new EventHandler(OnItemClick), DXPopupMenu_DisplayMode.Properties.Resources.Copy_16x16, null, DXPopupMenu_DisplayMode.Properties.Resources.Copy_32x32, null));
            menu.Items.Add(new DXMenuItem("Paste", new EventHandler(OnItemClick), DXPopupMenu_DisplayMode.Properties.Resources.Paste_16x16, null, DXPopupMenu_DisplayMode.Properties.Resources.Paste_32x32, null));
            menu.Items.Add(new DXEditMenuItem("ComboBox", riEditComboBox, null, null, null, 100, -1));
            menu.Items.Add(new DXEditMenuItem("DateEdit", riDateEdit, null, null, null, 100, -1));
            DXButtonGroupItem group1 = new DXButtonGroupItem();
            group1.Caption = "Button Group 1";
            group1.Items.Add(new DXMenuItem("Open", new EventHandler(OnItemClick), DXPopupMenu_DisplayMode.Properties.Resources.Open_16x16, null, DXPopupMenu_DisplayMode.Properties.Resources.Open_32x32, null));
            group1.Items.Add(new DXMenuItem("Save", new EventHandler(OnItemClick), DXPopupMenu_DisplayMode.Properties.Resources.Save_16x16, null, DXPopupMenu_DisplayMode.Properties.Resources.Save_32x32, null));
            group1.Items.Add(new DXMenuItem("Save All", new EventHandler(OnItemClick), DXPopupMenu_DisplayMode.Properties.Resources.SaveAll_16x16, null, DXPopupMenu_DisplayMode.Properties.Resources.SaveAll_32x32, null));
            DXButtonGroupItem group2 = new DXButtonGroupItem();
            group2.Caption = "Button Group 2";
            group2.Items.Add(new DXMenuItem("Edit", new EventHandler(OnItemClick), DXPopupMenu_DisplayMode.Properties.Resources.Edit_16x16, null, DXPopupMenu_DisplayMode.Properties.Resources.Edit_32x32, null));
            group2.Items.Add(new DXMenuItem("Delete", new EventHandler(OnItemClick), DXPopupMenu_DisplayMode.Properties.Resources.Delete_16x16, null, DXPopupMenu_DisplayMode.Properties.Resources.Delete_32x32, null));
            group2.Items.Add(new DXMenuItem("Print", new EventHandler(OnItemClick), DXPopupMenu_DisplayMode.Properties.Resources.Print_16x16, null, DXPopupMenu_DisplayMode.Properties.Resources.Print_32x32, null));
            DXButtonGroupItem group3 = new DXButtonGroupItem();
            group3.Caption = "Button Group 3";
            group3.Items.Add(new DXMenuItem("Close", new EventHandler(OnItemClick), DXPopupMenu_DisplayMode.Properties.Resources.Close_16x16, null, DXPopupMenu_DisplayMode.Properties.Resources.Close_32x32, null));
            group3.Items.Add(new DXMenuItem("Delete", new EventHandler(OnItemClick), DXPopupMenu_DisplayMode.Properties.Resources.Delete_16x16, null, DXPopupMenu_DisplayMode.Properties.Resources.Delete_32x32, null));
            menu.Items.Add(group1);
            menu.Items.Add(group2);
            menu.Items.Add(group3);
        }
        void OnItemClick(object sender, EventArgs e) { }

        DXPopupMenu menu;
        private void btnDisplayAsRegularMenu_Click(object sender, EventArgs e) {
            SimpleForm form = new SimpleForm();
            form.PopupMenu = menu;
            form.Show();
        }
        private void btnDisplayAsPopupBar_Click(object sender, EventArgs e) {
            BarsForm form = new BarsForm();
            form.PopupMenu = menu;
            form.Show();
        }
        private void btnDisplayAsRibbonMiniToolbar_Click(object sender, EventArgs e) {
            RibbonForm1 form = new RibbonForm1();
            form.PopupMenu = menu;
            form.Show();
        }
    }
}