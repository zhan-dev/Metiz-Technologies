namespace Metiz_Technologies
{
    partial class login_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_form));
            this.login_panel = new System.Windows.Forms.Panel();
            this.userName_lbl = new System.Windows.Forms.Label();
            this.userName_panel = new System.Windows.Forms.Panel();
            this.userName_txt = new System.Windows.Forms.TextBox();
            this.userPassword_lbl = new System.Windows.Forms.Label();
            this.userPassword_panel = new System.Windows.Forms.Panel();
            this.userPassword_txt = new System.Windows.Forms.TextBox();
            this.showPassword_chb = new System.Windows.Forms.CheckBox();
            this.forgotPassword_lbl = new System.Windows.Forms.LinkLabel();
            this.login_btn = new System.Windows.Forms.Button();
            this.createNewAcc_lbl = new System.Windows.Forms.LinkLabel();
            this.loginGif_pb = new System.Windows.Forms.PictureBox();
            this.welcomeBack_lbl = new System.Windows.Forms.Label();
            this.headerBar_userControl = new Metiz_Technologies.User_Controls.HeaderBar_userControl();
            this.login_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginGif_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // login_panel
            // 
            this.login_panel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.login_panel.BackColor = System.Drawing.Color.Transparent;
            this.login_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.login_panel.Controls.Add(this.userName_lbl);
            this.login_panel.Controls.Add(this.userName_panel);
            this.login_panel.Controls.Add(this.userName_txt);
            this.login_panel.Controls.Add(this.userPassword_lbl);
            this.login_panel.Controls.Add(this.userPassword_panel);
            this.login_panel.Controls.Add(this.userPassword_txt);
            this.login_panel.Controls.Add(this.showPassword_chb);
            this.login_panel.Controls.Add(this.forgotPassword_lbl);
            this.login_panel.Controls.Add(this.login_btn);
            this.login_panel.Controls.Add(this.createNewAcc_lbl);
            this.login_panel.Location = new System.Drawing.Point(228, 72);
            this.login_panel.Margin = new System.Windows.Forms.Padding(4);
            this.login_panel.Name = "login_panel";
            this.login_panel.Size = new System.Drawing.Size(336, 382);
            this.login_panel.TabIndex = 5;
            // 
            // userName_lbl
            // 
            this.userName_lbl.AutoSize = true;
            this.userName_lbl.BackColor = System.Drawing.Color.Transparent;
            this.userName_lbl.ForeColor = System.Drawing.Color.White;
            this.userName_lbl.Location = new System.Drawing.Point(46, 29);
            this.userName_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userName_lbl.Name = "userName_lbl";
            this.userName_lbl.Size = new System.Drawing.Size(82, 20);
            this.userName_lbl.TabIndex = 0;
            this.userName_lbl.Text = "User Name";
            // 
            // userName_panel
            // 
            this.userName_panel.BackgroundImage = global::Metiz_Technologies.Properties.Resources.WhiteThemeUser_20;
            this.userName_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.userName_panel.Location = new System.Drawing.Point(18, 53);
            this.userName_panel.Name = "userName_panel";
            this.userName_panel.Size = new System.Drawing.Size(27, 27);
            this.userName_panel.TabIndex = 7;
            // 
            // userName_txt
            // 
            this.userName_txt.Location = new System.Drawing.Point(49, 53);
            this.userName_txt.Margin = new System.Windows.Forms.Padding(4);
            this.userName_txt.Name = "userName_txt";
            this.userName_txt.Size = new System.Drawing.Size(238, 27);
            this.userName_txt.TabIndex = 1;
            // 
            // userPassword_lbl
            // 
            this.userPassword_lbl.AutoSize = true;
            this.userPassword_lbl.BackColor = System.Drawing.Color.Transparent;
            this.userPassword_lbl.ForeColor = System.Drawing.Color.White;
            this.userPassword_lbl.Location = new System.Drawing.Point(46, 100);
            this.userPassword_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userPassword_lbl.Name = "userPassword_lbl";
            this.userPassword_lbl.Size = new System.Drawing.Size(70, 20);
            this.userPassword_lbl.TabIndex = 0;
            this.userPassword_lbl.Text = "Password";
            // 
            // userPassword_panel
            // 
            this.userPassword_panel.BackgroundImage = global::Metiz_Technologies.Properties.Resources.WhiteThemePassword_20;
            this.userPassword_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.userPassword_panel.Location = new System.Drawing.Point(18, 124);
            this.userPassword_panel.Name = "userPassword_panel";
            this.userPassword_panel.Size = new System.Drawing.Size(27, 27);
            this.userPassword_panel.TabIndex = 7;
            // 
            // userPassword_txt
            // 
            this.userPassword_txt.Location = new System.Drawing.Point(49, 124);
            this.userPassword_txt.Margin = new System.Windows.Forms.Padding(4);
            this.userPassword_txt.Name = "userPassword_txt";
            this.userPassword_txt.Size = new System.Drawing.Size(238, 27);
            this.userPassword_txt.TabIndex = 2;
            this.userPassword_txt.UseSystemPasswordChar = true;
            // 
            // showPassword_chb
            // 
            this.showPassword_chb.AutoSize = true;
            this.showPassword_chb.BackColor = System.Drawing.Color.Transparent;
            this.showPassword_chb.ForeColor = System.Drawing.Color.White;
            this.showPassword_chb.Location = new System.Drawing.Point(158, 159);
            this.showPassword_chb.Margin = new System.Windows.Forms.Padding(4);
            this.showPassword_chb.Name = "showPassword_chb";
            this.showPassword_chb.Size = new System.Drawing.Size(129, 24);
            this.showPassword_chb.TabIndex = 3;
            this.showPassword_chb.Text = "Show Password";
            this.showPassword_chb.UseVisualStyleBackColor = false;
            // 
            // forgotPassword_lbl
            // 
            this.forgotPassword_lbl.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.forgotPassword_lbl.AutoSize = true;
            this.forgotPassword_lbl.LinkColor = System.Drawing.Color.DarkGray;
            this.forgotPassword_lbl.Location = new System.Drawing.Point(109, 244);
            this.forgotPassword_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forgotPassword_lbl.Name = "forgotPassword_lbl";
            this.forgotPassword_lbl.Size = new System.Drawing.Size(118, 20);
            this.forgotPassword_lbl.TabIndex = 4;
            this.forgotPassword_lbl.TabStop = true;
            this.forgotPassword_lbl.Text = "Forgot Password";
            // 
            // login_btn
            // 
            this.login_btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.login_btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(5)))), ((int)(((byte)(50)))));
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.Location = new System.Drawing.Point(50, 279);
            this.login_btn.Margin = new System.Windows.Forms.Padding(4);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(237, 42);
            this.login_btn.TabIndex = 5;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // createNewAcc_lbl
            // 
            this.createNewAcc_lbl.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.createNewAcc_lbl.AutoSize = true;
            this.createNewAcc_lbl.LinkColor = System.Drawing.Color.DarkGray;
            this.createNewAcc_lbl.Location = new System.Drawing.Point(96, 334);
            this.createNewAcc_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.createNewAcc_lbl.Name = "createNewAcc_lbl";
            this.createNewAcc_lbl.Size = new System.Drawing.Size(144, 20);
            this.createNewAcc_lbl.TabIndex = 6;
            this.createNewAcc_lbl.TabStop = true;
            this.createNewAcc_lbl.Text = "Create New Account";
            // 
            // loginGif_pb
            // 
            this.loginGif_pb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginGif_pb.Image = global::Metiz_Technologies.Properties.Resources.loginAnimatedBackgroundAsGif;
            this.loginGif_pb.Location = new System.Drawing.Point(0, 0);
            this.loginGif_pb.Margin = new System.Windows.Forms.Padding(4);
            this.loginGif_pb.Name = "loginGif_pb";
            this.loginGif_pb.Size = new System.Drawing.Size(800, 476);
            this.loginGif_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loginGif_pb.TabIndex = 6;
            this.loginGif_pb.TabStop = false;
            // 
            // welcomeBack_lbl
            // 
            this.welcomeBack_lbl.AutoSize = true;
            this.welcomeBack_lbl.BackColor = System.Drawing.Color.Transparent;
            this.welcomeBack_lbl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.welcomeBack_lbl.ForeColor = System.Drawing.Color.DarkGray;
            this.welcomeBack_lbl.Location = new System.Drawing.Point(691, 448);
            this.welcomeBack_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcomeBack_lbl.Name = "welcomeBack_lbl";
            this.welcomeBack_lbl.Size = new System.Drawing.Size(96, 19);
            this.welcomeBack_lbl.TabIndex = 8;
            this.welcomeBack_lbl.Text = "Welcome Back";
            // 
            // headerBar_userControl
            // 
            this.headerBar_userControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerBar_userControl.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.headerBar_userControl.Location = new System.Drawing.Point(0, 0);
            this.headerBar_userControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.headerBar_userControl.Name = "headerBar_userControl";
            this.headerBar_userControl.Size = new System.Drawing.Size(800, 36);
            this.headerBar_userControl.TabIndex = 9;
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(5)))), ((int)(((byte)(50)))));
            this.BackgroundImage = global::Metiz_Technologies.Properties.Resources.loginAnimatedBackgroundAsImg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.headerBar_userControl);
            this.Controls.Add(this.welcomeBack_lbl);
            this.Controls.Add(this.login_panel);
            this.Controls.Add(this.loginGif_pb);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "login_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.login_panel.ResumeLayout(false);
            this.login_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginGif_pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userName_lbl;
        private System.Windows.Forms.Label userPassword_lbl;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.TextBox userName_txt;
        private System.Windows.Forms.TextBox userPassword_txt;
        private System.Windows.Forms.CheckBox showPassword_chb;
        private System.Windows.Forms.Panel login_panel;
        private System.Windows.Forms.LinkLabel createNewAcc_lbl;
        private System.Windows.Forms.LinkLabel forgotPassword_lbl;
        private System.Windows.Forms.PictureBox loginGif_pb;
        private System.Windows.Forms.Panel userPassword_panel;
        private System.Windows.Forms.Panel userName_panel;
        private System.Windows.Forms.Label welcomeBack_lbl;
        private User_Controls.HeaderBar_userControl headerBar_userControl;
    }
}

