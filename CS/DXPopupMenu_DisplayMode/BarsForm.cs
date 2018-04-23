using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Utils.Menu;

namespace DXPopupMenu_DisplayMode {
    public partial class BarsForm : Form {
        public BarsForm() {
            InitializeComponent();
        }

        public DXPopupMenu PopupMenu;

        protected override void OnMouseUp(MouseEventArgs e) {
            if(e.Button == MouseButtons.Right) {
                PopupMenu.MenuViewType = MenuViewType.Toolbar;
                ((IDXDropDownControl)PopupMenu).Show(barManager1, this, e.Location);
            }
        }
    }
}