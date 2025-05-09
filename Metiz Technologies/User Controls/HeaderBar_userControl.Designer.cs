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
            this.companyName_lbl = new System.Windows.Forms.Label();
            this.close_btn = new System.Windows.Forms.Button();
            this.headerBar_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerBar_panel
            // 
            this.headerBar_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(5)))), ((int)(((byte)(50)))));
            this.headerBar_panel.Controls.Add(this.companyName_lbl);
            this.headerBar_panel.Controls.Add(this.close_btn);
            this.headerBar_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerBar_panel.Location = new System.Drawing.Point(0, 0);
            this.headerBar_panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.headerBar_panel.Name = "headerBar_panel";
            this.headerBar_panel.Size = new System.Drawing.Size(800, 36);
            this.headerBar_panel.TabIndex = 1;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerBar_panel;
        private System.Windows.Forms.Label companyName_lbl;
        private System.Windows.Forms.Button close_btn;
    }
}
