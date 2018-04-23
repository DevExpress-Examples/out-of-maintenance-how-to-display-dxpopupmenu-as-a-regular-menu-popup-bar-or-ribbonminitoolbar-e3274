using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using DevExpress.Utils.Menu;

namespace DXPopupMenu_DisplayMode {
    public partial class RibbonForm1 : RibbonForm {
        public RibbonForm1() {
            InitializeComponent();
        }

        public DXPopupMenu PopupMenu;

        protected override void OnMouseUp(MouseEventArgs e) {
            if(e.Button == MouseButtons.Right) {
                PopupMenu.MenuViewType = MenuViewType.RibbonMiniToolbar;
                ((IDXDropDownControl)PopupMenu).Show(ribbonControl1, this, e.Location);
            }
        }
    }
}