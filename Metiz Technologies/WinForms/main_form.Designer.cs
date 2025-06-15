namespace Metiz_Technologies
{
    partial class main_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_form));
            this.welcomeUser_lbl = new System.Windows.Forms.Label();
            this.main_menuStrip = new System.Windows.Forms.MenuStrip();
            this.reports_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.money_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersFactory__toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.product_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orders_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trafficProduct_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reports_userControl = new Metiz_Technologies.User_Controls.Reports_userControl();
            this.headerBarMain_userControl = new Metiz_Technologies.User_Controls.HeaderBar_userControl();
            this.main_menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomeUser_lbl
            // 
            this.welcomeUser_lbl.BackColor = System.Drawing.Color.Gainsboro;
            this.welcomeUser_lbl.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.welcomeUser_lbl.ForeColor = System.Drawing.Color.DarkGray;
            this.welcomeUser_lbl.Location = new System.Drawing.Point(15, 34);
            this.welcomeUser_lbl.Margin = new System.Windows.Forms.Padding(0);
            this.welcomeUser_lbl.Name = "welcomeUser_lbl";
            this.welcomeUser_lbl.Size = new System.Drawing.Size(165, 29);
            this.welcomeUser_lbl.TabIndex = 10;
            this.welcomeUser_lbl.Text = "Welcome";
            this.welcomeUser_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // main_menuStrip
            // 
            this.main_menuStrip.BackColor = System.Drawing.Color.Gainsboro;
            this.main_menuStrip.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.main_menuStrip.GripMargin = new System.Windows.Forms.Padding(2);
            this.main_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reports_toolStripMenuItem,
            this.money_toolStripMenuItem,
            this.ordersFactory__toolStripMenuItem,
            this.product_toolStripMenuItem,
            this.orders_toolStripMenuItem,
            this.trafficProduct_toolStripMenuItem});
            this.main_menuStrip.Location = new System.Drawing.Point(0, 32);
            this.main_menuStrip.Name = "main_menuStrip";
            this.main_menuStrip.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.main_menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.main_menuStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.main_menuStrip.Size = new System.Drawing.Size(1100, 34);
            this.main_menuStrip.TabIndex = 12;
            this.main_menuStrip.Text = "main_menuStrip";
            // 
            // reports_toolStripMenuItem
            // 
            this.reports_toolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro;
            this.reports_toolStripMenuItem.Name = "reports_toolStripMenuItem";
            this.reports_toolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.reports_toolStripMenuItem.Text = "Отчеты";
            // 
            // money_toolStripMenuItem
            // 
            this.money_toolStripMenuItem.Name = "money_toolStripMenuItem";
            this.money_toolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.money_toolStripMenuItem.Text = "Деньги";
            // 
            // ordersFactory__toolStripMenuItem
            // 
            this.ordersFactory__toolStripMenuItem.Name = "ordersFactory__toolStripMenuItem";
            this.ordersFactory__toolStripMenuItem.Size = new System.Drawing.Size(135, 24);
            this.ordersFactory__toolStripMenuItem.Text = "Заказы на завод";
            // 
            // product_toolStripMenuItem
            // 
            this.product_toolStripMenuItem.Name = "product_toolStripMenuItem";
            this.product_toolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.product_toolStripMenuItem.Text = "Остатки товаров";
            // 
            // orders_toolStripMenuItem
            // 
            this.orders_toolStripMenuItem.Name = "orders_toolStripMenuItem";
            this.orders_toolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.orders_toolStripMenuItem.Text = "Заказы";
            // 
            // trafficProduct_toolStripMenuItem
            // 
            this.trafficProduct_toolStripMenuItem.Name = "trafficProduct_toolStripMenuItem";
            this.trafficProduct_toolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.trafficProduct_toolStripMenuItem.Text = "Движение товаров";
            // 
            // reports_userControl
            // 
            this.reports_userControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reports_userControl.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.reports_userControl.Location = new System.Drawing.Point(0, 66);
            this.reports_userControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reports_userControl.Name = "reports_userControl";
            this.reports_userControl.Size = new System.Drawing.Size(1100, 494);
            this.reports_userControl.TabIndex = 21;
            // 
            // headerBarMain_userControl
            // 
            this.headerBarMain_userControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerBarMain_userControl.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.headerBarMain_userControl.Location = new System.Drawing.Point(0, 0);
            this.headerBarMain_userControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.headerBarMain_userControl.Name = "headerBarMain_userControl";
            this.headerBarMain_userControl.Size = new System.Drawing.Size(1100, 32);
            this.headerBarMain_userControl.TabIndex = 22;
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 560);
            this.Controls.Add(this.reports_userControl);
            this.Controls.Add(this.welcomeUser_lbl);
            this.Controls.Add(this.main_menuStrip);
            this.Controls.Add(this.headerBarMain_userControl);
            this.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.main_menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "main_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "main_form";
            this.main_menuStrip.ResumeLayout(false);
            this.main_menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label welcomeUser_lbl;
        private System.Windows.Forms.MenuStrip main_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem reports_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem money_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersFactory__toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem product_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orders_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trafficProduct_toolStripMenuItem;
        private User_Controls.Reports_userControl reports_userControl;
        private User_Controls.HeaderBar_userControl headerBarMain_userControl;
    }
}