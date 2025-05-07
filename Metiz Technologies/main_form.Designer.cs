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
            this.Top_panel = new System.Windows.Forms.Panel();
            this.windowTray_btn = new System.Windows.Forms.Button();
            this.mainSearch_txt = new System.Windows.Forms.TextBox();
            this.windowMixMax_btn = new System.Windows.Forms.Button();
            this.Close_btn = new System.Windows.Forms.Button();
            this.metizCompany_lbl = new System.Windows.Forms.Label();
            this.welcomeUser_lbl = new System.Windows.Forms.Label();
            this.main_menuStrip = new System.Windows.Forms.MenuStrip();
            this.reports_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.money_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.деньгиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.движениеТоваровToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reports_userControl = new Metiz_Technologies.User_Controls.Reports_userControl();
            this.Top_panel.SuspendLayout();
            this.main_menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Top_panel
            // 
            this.Top_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(5)))), ((int)(((byte)(50)))));
            this.Top_panel.Controls.Add(this.windowTray_btn);
            this.Top_panel.Controls.Add(this.mainSearch_txt);
            this.Top_panel.Controls.Add(this.windowMixMax_btn);
            this.Top_panel.Controls.Add(this.Close_btn);
            this.Top_panel.Controls.Add(this.metizCompany_lbl);
            this.Top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top_panel.Location = new System.Drawing.Point(0, 0);
            this.Top_panel.Margin = new System.Windows.Forms.Padding(4);
            this.Top_panel.Name = "Top_panel";
            this.Top_panel.Size = new System.Drawing.Size(1100, 36);
            this.Top_panel.TabIndex = 5;
            this.Top_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Top_panel_MouseDown);
            this.Top_panel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Top_panel_MouseMove);
            this.Top_panel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Top_panel_MouseUp);
            // 
            // windowTray_btn
            // 
            this.windowTray_btn.BackgroundImage = global::Metiz_Technologies.Properties.Resources.WhiteThemeClose_20;
            this.windowTray_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.windowTray_btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.windowTray_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.windowTray_btn.FlatAppearance.BorderSize = 0;
            this.windowTray_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.windowTray_btn.Location = new System.Drawing.Point(980, 0);
            this.windowTray_btn.Margin = new System.Windows.Forms.Padding(4);
            this.windowTray_btn.Name = "windowTray_btn";
            this.windowTray_btn.Size = new System.Drawing.Size(40, 36);
            this.windowTray_btn.TabIndex = 8;
            this.windowTray_btn.UseVisualStyleBackColor = true;
            this.windowTray_btn.Click += new System.EventHandler(this.windowTray_btn_Click);
            // 
            // mainSearch_txt
            // 
            this.mainSearch_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainSearch_txt.ForeColor = System.Drawing.Color.DarkGray;
            this.mainSearch_txt.Location = new System.Drawing.Point(627, 4);
            this.mainSearch_txt.Margin = new System.Windows.Forms.Padding(4);
            this.mainSearch_txt.Name = "mainSearch_txt";
            this.mainSearch_txt.Size = new System.Drawing.Size(322, 27);
            this.mainSearch_txt.TabIndex = 6;
            this.mainSearch_txt.Text = "поиск";
            // 
            // windowMixMax_btn
            // 
            this.windowMixMax_btn.BackgroundImage = global::Metiz_Technologies.Properties.Resources.WhiteThemeClose_20;
            this.windowMixMax_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.windowMixMax_btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.windowMixMax_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.windowMixMax_btn.FlatAppearance.BorderSize = 0;
            this.windowMixMax_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.windowMixMax_btn.Location = new System.Drawing.Point(1020, 0);
            this.windowMixMax_btn.Margin = new System.Windows.Forms.Padding(4);
            this.windowMixMax_btn.Name = "windowMixMax_btn";
            this.windowMixMax_btn.Size = new System.Drawing.Size(40, 36);
            this.windowMixMax_btn.TabIndex = 7;
            this.windowMixMax_btn.UseVisualStyleBackColor = true;
            this.windowMixMax_btn.Click += new System.EventHandler(this.windowMixMax_btn_Click);
            // 
            // Close_btn
            // 
            this.Close_btn.BackgroundImage = global::Metiz_Technologies.Properties.Resources.WhiteThemeClose_20;
            this.Close_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Close_btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.Close_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.Close_btn.FlatAppearance.BorderSize = 0;
            this.Close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_btn.Location = new System.Drawing.Point(1060, 0);
            this.Close_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Close_btn.Name = "Close_btn";
            this.Close_btn.Size = new System.Drawing.Size(40, 36);
            this.Close_btn.TabIndex = 5;
            this.Close_btn.UseVisualStyleBackColor = true;
            this.Close_btn.Click += new System.EventHandler(this.Close_btn_Click);
            // 
            // metizCompany_lbl
            // 
            this.metizCompany_lbl.AutoSize = true;
            this.metizCompany_lbl.ForeColor = System.Drawing.Color.White;
            this.metizCompany_lbl.Location = new System.Drawing.Point(15, 7);
            this.metizCompany_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metizCompany_lbl.Name = "metizCompany_lbl";
            this.metizCompany_lbl.Size = new System.Drawing.Size(113, 20);
            this.metizCompany_lbl.TabIndex = 0;
            this.metizCompany_lbl.Text = "Metiz Company";
            // 
            // welcomeUser_lbl
            // 
            this.welcomeUser_lbl.BackColor = System.Drawing.Color.Gainsboro;
            this.welcomeUser_lbl.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.welcomeUser_lbl.ForeColor = System.Drawing.Color.DarkGray;
            this.welcomeUser_lbl.Location = new System.Drawing.Point(15, 44);
            this.welcomeUser_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcomeUser_lbl.Name = "welcomeUser_lbl";
            this.welcomeUser_lbl.Size = new System.Drawing.Size(165, 19);
            this.welcomeUser_lbl.TabIndex = 10;
            this.welcomeUser_lbl.Text = "Welcome";
            // 
            // main_menuStrip
            // 
            this.main_menuStrip.BackColor = System.Drawing.Color.Gainsboro;
            this.main_menuStrip.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.main_menuStrip.GripMargin = new System.Windows.Forms.Padding(2);
            this.main_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reports_toolStripMenuItem,
            this.money_toolStripMenuItem,
            this.toolStripMenuItem4,
            this.деньгиToolStripMenuItem,
            this.отчетыToolStripMenuItem,
            this.движениеТоваровToolStripMenuItem});
            this.main_menuStrip.Location = new System.Drawing.Point(0, 36);
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
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(135, 24);
            this.toolStripMenuItem4.Text = "Заказы на завод";
            // 
            // деньгиToolStripMenuItem
            // 
            this.деньгиToolStripMenuItem.Name = "деньгиToolStripMenuItem";
            this.деньгиToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.деньгиToolStripMenuItem.Text = "Остатки товаров";
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.отчетыToolStripMenuItem.Text = "Заказы";
            // 
            // движениеТоваровToolStripMenuItem
            // 
            this.движениеТоваровToolStripMenuItem.Name = "движениеТоваровToolStripMenuItem";
            this.движениеТоваровToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.движениеТоваровToolStripMenuItem.Text = "Движение товаров";
            // 
            // reports_userControl
            // 
            this.reports_userControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reports_userControl.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.reports_userControl.Location = new System.Drawing.Point(0, 70);
            this.reports_userControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reports_userControl.Name = "reports_userControl";
            this.reports_userControl.Size = new System.Drawing.Size(1100, 490);
            this.reports_userControl.TabIndex = 21;
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 560);
            this.Controls.Add(this.reports_userControl);
            this.Controls.Add(this.welcomeUser_lbl);
            this.Controls.Add(this.main_menuStrip);
            this.Controls.Add(this.Top_panel);
            this.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.main_menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "main_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "main_form";
            this.Load += new System.EventHandler(this.main_form_Load);
            this.Top_panel.ResumeLayout(false);
            this.Top_panel.PerformLayout();
            this.main_menuStrip.ResumeLayout(false);
            this.main_menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Top_panel;
        private System.Windows.Forms.Button Close_btn;
        private System.Windows.Forms.Label metizCompany_lbl;
        public System.Windows.Forms.Label welcomeUser_lbl;
        private System.Windows.Forms.MenuStrip main_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem reports_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem money_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem деньгиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem движениеТоваровToolStripMenuItem;
        private System.Windows.Forms.TextBox mainSearch_txt;
        private User_Controls.Reports_userControl reports_userControl;
        private System.Windows.Forms.Button windowMixMax_btn;
        private System.Windows.Forms.Button windowTray_btn;
    }
}