namespace Metiz_Technologies.User_Controls
{
    partial class HeaderBar_userControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.headerBar_panel = new System.Windows.Forms.Panel();
            this.lang_panel = new System.Windows.Forms.Panel();
            this.companyName_lbl = new System.Windows.Forms.Label();
            this.ua_panel = new System.Windows.Forms.Panel();
            this.ru_panel = new System.Windows.Forms.Panel();
            this.us_panel = new System.Windows.Forms.Panel();
            this.windowTray_btn = new System.Windows.Forms.Button();
            this.windowMinMax_btn = new System.Windows.Forms.Button();
            this.close_btn = new System.Windows.Forms.Button();
            this.headerBar_panel.SuspendLayout();
            this.lang_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerBar_panel
            // 
            this.headerBar_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(5)))), ((int)(((byte)(50)))));
            this.headerBar_panel.Controls.Add(this.lang_panel);
            this.headerBar_panel.Controls.Add(this.windowTray_btn);
            this.headerBar_panel.Controls.Add(this.windowMinMax_btn);
            this.headerBar_panel.Controls.Add(this.companyName_lbl);
            this.headerBar_panel.Controls.Add(this.close_btn);
            this.headerBar_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerBar_panel.Location = new System.Drawing.Point(0, 0);
            this.headerBar_panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.headerBar_panel.Name = "headerBar_panel";
            this.headerBar_panel.Size = new System.Drawing.Size(800, 36);
            this.headerBar_panel.TabIndex = 1;
            // 
            // lang_panel
            // 
            this.lang_panel.BackColor = System.Drawing.Color.Transparent;
            this.lang_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.lang_panel.Controls.Add(this.ua_panel);
            this.lang_panel.Controls.Add(this.ru_panel);
            this.lang_panel.Controls.Add(this.us_panel);
            this.lang_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.lang_panel.Location = new System.Drawing.Point(586, 0);
            this.lang_panel.Margin = new System.Windows.Forms.Padding(4);
            this.lang_panel.Name = "lang_panel";
            this.lang_panel.Size = new System.Drawing.Size(94, 36);
            this.lang_panel.TabIndex = 14;
            // 
            // companyName_lbl
            // 
            this.companyName_lbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.companyName_lbl.ForeColor = System.Drawing.Color.White;
            this.companyName_lbl.Location = new System.Drawing.Point(0, 0);
            this.companyName_lbl.Name = "companyName_lbl";
            this.companyName_lbl.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.companyName_lbl.Size = new System.Drawing.Size(130, 36);
            this.companyName_lbl.TabIndex = 1;
            this.companyName_lbl.Text = "Company Name";
            this.companyName_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ua_panel
            // 
            this.ua_panel.BackgroundImage = global::Metiz_Technologies.Properties.Resources.flag_ua;
            this.ua_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ua_panel.Location = new System.Drawing.Point(66, 11);
            this.ua_panel.Name = "ua_panel";
            this.ua_panel.Size = new System.Drawing.Size(22, 14);
            this.ua_panel.TabIndex = 8;
            // 
            // ru_panel
            // 
            this.ru_panel.BackgroundImage = global::Metiz_Technologies.Properties.Resources.flag_ru;
            this.ru_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ru_panel.Location = new System.Drawing.Point(36, 11);
            this.ru_panel.Name = "ru_panel";
            this.ru_panel.Size = new System.Drawing.Size(22, 14);
            this.ru_panel.TabIndex = 7;
            // 
            // us_panel
            // 
            this.us_panel.BackgroundImage = global::Metiz_Technologies.Properties.Resources.flag_us;
            this.us_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.us_panel.Location = new System.Drawing.Point(6, 11);
            this.us_panel.Name = "us_panel";
            this.us_panel.Size = new System.Drawing.Size(22, 14);
            this.us_panel.TabIndex = 7;
            // 
            // windowTray_btn
            // 
            this.windowTray_btn.BackgroundImage = global::Metiz_Technologies.Properties.Resources.WhiteThemeMinimizeWindow_20;
            this.windowTray_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.windowTray_btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.windowTray_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.windowTray_btn.FlatAppearance.BorderSize = 0;
            this.windowTray_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.windowTray_btn.Location = new System.Drawing.Point(680, 0);
            this.windowTray_btn.Margin = new System.Windows.Forms.Padding(4);
            this.windowTray_btn.Name = "windowTray_btn";
            this.windowTray_btn.Size = new System.Drawing.Size(40, 36);
            this.windowTray_btn.TabIndex = 16;
            this.windowTray_btn.UseVisualStyleBackColor = true;
            // 
            // windowMinMax_btn
            // 
            this.windowMinMax_btn.BackgroundImage = global::Metiz_Technologies.Properties.Resources.WhiteThemeFullScreen_20;
            this.windowMinMax_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.windowMinMax_btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.windowMinMax_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.windowMinMax_btn.FlatAppearance.BorderSize = 0;
            this.windowMinMax_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.windowMinMax_btn.Location = new System.Drawing.Point(720, 0);
            this.windowMinMax_btn.Margin = new System.Windows.Forms.Padding(4);
            this.windowMinMax_btn.Name = "windowMinMax_btn";
            this.windowMinMax_btn.Size = new System.Drawing.Size(40, 36);
            this.windowMinMax_btn.TabIndex = 15;
            this.windowMinMax_btn.UseVisualStyleBackColor = true;
            // 
            // close_btn
            // 
            this.close_btn.BackgroundImage = global::Metiz_Technologies.Properties.Resources.WhiteThemeClose_20;
            this.close_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.close_btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.close_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.close_btn.FlatAppearance.BorderSize = 0;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.Location = new System.Drawing.Point(760, 0);
            this.close_btn.Margin = new System.Windows.Forms.Padding(4);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(40, 36);
            this.close_btn.TabIndex = 8;
            this.close_btn.UseVisualStyleBackColor = true;
            // 
            // HeaderBar_userControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.headerBar_panel);
            this.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HeaderBar_userControl";
            this.Size = new System.Drawing.Size(800, 36);
            this.headerBar_panel.ResumeLayout(false);
            this.lang_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerBar_panel;
        private System.Windows.Forms.Label companyName_lbl;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Panel lang_panel;
        private System.Windows.Forms.Panel ua_panel;
        private System.Windows.Forms.Panel ru_panel;
        private System.Windows.Forms.Panel us_panel;
        private System.Windows.Forms.Button windowTray_btn;
        public System.Windows.Forms.Button windowMinMax_btn;
    }
}
