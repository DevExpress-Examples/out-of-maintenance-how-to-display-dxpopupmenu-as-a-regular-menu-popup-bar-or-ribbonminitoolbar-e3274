namespace DXPopupMenu_DisplayMode {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnDisplayAsRegularMenu = new System.Windows.Forms.Button();
            this.btnDisplayAsPopupBar = new System.Windows.Forms.Button();
            this.btnDisplayAsRibbonMiniToolbar = new System.Windows.Forms.Button();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // btnDisplayAsRegularMenu
            // 
            this.btnDisplayAsRegularMenu.Location = new System.Drawing.Point(148, 31);
            this.btnDisplayAsRegularMenu.Name = "btnDisplayAsRegularMenu";
            this.btnDisplayAsRegularMenu.Size = new System.Drawing.Size(135, 23);
            this.btnDisplayAsRegularMenu.TabIndex = 0;
            this.btnDisplayAsRegularMenu.Text = "Regular Menu";
            this.btnDisplayAsRegularMenu.UseVisualStyleBackColor = true;
            this.btnDisplayAsRegularMenu.Click += new System.EventHandler(this.btnDisplayAsRegularMenu_Click);
            // 
            // btnDisplayAsPopupBar
            // 
            this.btnDisplayAsPopupBar.Location = new System.Drawing.Point(148, 68);
            this.btnDisplayAsPopupBar.Name = "btnDisplayAsPopupBar";
            this.btnDisplayAsPopupBar.Size = new System.Drawing.Size(135, 23);
            this.btnDisplayAsPopupBar.TabIndex = 1;
            this.btnDisplayAsPopupBar.Text = "Popup Bar";
            this.btnDisplayAsPopupBar.UseVisualStyleBackColor = true;
            this.btnDisplayAsPopupBar.Click += new System.EventHandler(this.btnDisplayAsPopupBar_Click);
            // 
            // btnDisplayAsRibbonMiniToolbar
            // 
            this.btnDisplayAsRibbonMiniToolbar.Location = new System.Drawing.Point(148, 105);
            this.btnDisplayAsRibbonMiniToolbar.Name = "btnDisplayAsRibbonMiniToolbar";
            this.btnDisplayAsRibbonMiniToolbar.Size = new System.Drawing.Size(135, 23);
            this.btnDisplayAsRibbonMiniToolbar.TabIndex = 2;
            this.btnDisplayAsRibbonMiniToolbar.Text = "RibbonMiniToolbar";
            this.btnDisplayAsRibbonMiniToolbar.UseVisualStyleBackColor = true;
            this.btnDisplayAsRibbonMiniToolbar.Click += new System.EventHandler(this.btnDisplayAsRibbonMiniToolbar_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 73);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(124, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Display DXPopupMenu as:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 185);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnDisplayAsRibbonMiniToolbar);
            this.Controls.Add(this.btnDisplayAsPopupBar);
            this.Controls.Add(this.btnDisplayAsRegularMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDisplayAsRegularMenu;
        private System.Windows.Forms.Button btnDisplayAsPopupBar;
        private System.Windows.Forms.Button btnDisplayAsRibbonMiniToolbar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}

