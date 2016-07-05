namespace restaurantPOS
{
    partial class FrmLogin
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
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::restaurantPOS.SplashScreen1), true, true);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.lblUserName = new DevExpress.XtraEditors.LabelControl();
            this.lblPassword = new DevExpress.XtraEditors.LabelControl();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.lblChooseLang = new DevExpress.XtraEditors.LabelControl();
            this.lblCopyRightsLoginForm = new DevExpress.XtraEditors.LabelControl();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.btnArLanguage = new DevExpress.XtraEditors.CheckButton();
            this.btnEnLanguage = new DevExpress.XtraEditors.CheckButton();
            this.btnLogin = new restaurantPOS.GelButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.Location = new System.Drawing.Point(18, 23);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(49, 13);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "UserName";
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(18, 62);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(46, 13);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.EditValue = "";
            this.txtPassword.Location = new System.Drawing.Point(163, 61);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtPassword.Properties.Appearance.Options.UseFont = true;
            this.txtPassword.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None;
            this.txtPassword.Properties.Mask.BeepOnError = true;
            this.txtPassword.Properties.Mask.EditMask = "d";
            this.txtPassword.Properties.Mask.IgnoreMaskBlank = false;
            this.txtPassword.Properties.Mask.SaveLiteral = false;
            this.txtPassword.Properties.Mask.ShowPlaceHolders = false;
            this.txtPassword.Properties.MaxLength = 20;
            this.txtPassword.Properties.NullValuePrompt = "Enter Your Password!";
            this.txtPassword.Properties.PasswordChar = '*';
            this.txtPassword.Properties.ValidateOnEnterKey = true;
            this.txtPassword.Size = new System.Drawing.Size(268, 32);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            // 
            // lblChooseLang
            // 
            this.lblChooseLang.Location = new System.Drawing.Point(18, 113);
            this.lblChooseLang.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.lblChooseLang.Name = "lblChooseLang";
            this.lblChooseLang.Size = new System.Drawing.Size(47, 13);
            this.lblChooseLang.TabIndex = 1;
            this.lblChooseLang.Text = "Language";
            // 
            // lblCopyRightsLoginForm
            // 
            this.lblCopyRightsLoginForm.Appearance.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyRightsLoginForm.Appearance.ForeColor = System.Drawing.Color.IndianRed;
            this.lblCopyRightsLoginForm.Location = new System.Drawing.Point(224, 233);
            this.lblCopyRightsLoginForm.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.lblCopyRightsLoginForm.Name = "lblCopyRightsLoginForm";
            this.lblCopyRightsLoginForm.Size = new System.Drawing.Size(163, 11);
            this.lblCopyRightsLoginForm.TabIndex = 1;
            this.lblCopyRightsLoginForm.Text = "Copy rights reserved to Estoda © 2016";
            // 
            // txtUserName
            // 
            this.txtUserName.EditValue = "";
            this.txtUserName.Location = new System.Drawing.Point(163, 22);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtUserName.Properties.Appearance.Options.UseFont = true;
            this.txtUserName.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.None;
            this.txtUserName.Properties.Mask.BeepOnError = true;
            this.txtUserName.Properties.Mask.EditMask = "d";
            this.txtUserName.Properties.Mask.IgnoreMaskBlank = false;
            this.txtUserName.Properties.Mask.SaveLiteral = false;
            this.txtUserName.Properties.Mask.ShowPlaceHolders = false;
            this.txtUserName.Properties.MaxLength = 20;
            this.txtUserName.Properties.NullText = "Enter Your Password!";
            this.txtUserName.Properties.NullValuePrompt = "Enter Your Password!";
            this.txtUserName.Properties.ValidateOnEnterKey = true;
            this.txtUserName.Size = new System.Drawing.Size(268, 32);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserName_KeyDown);
            // 
            // btnArLanguage
            // 
            this.btnArLanguage.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.btnArLanguage.Appearance.Options.UseForeColor = true;
            this.btnArLanguage.GroupIndex = 1;
            this.btnArLanguage.Location = new System.Drawing.Point(317, 114);
            this.btnArLanguage.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnArLanguage.Name = "btnArLanguage";
            this.btnArLanguage.Size = new System.Drawing.Size(114, 33);
            this.btnArLanguage.TabIndex = 3;
            this.btnArLanguage.TabStop = false;
            this.btnArLanguage.Text = "عربي";
            this.btnArLanguage.CheckedChanged += new System.EventHandler(this.btnArLanguage_CheckedChanged);
            // 
            // btnEnLanguage
            // 
            this.btnEnLanguage.Checked = true;
            this.btnEnLanguage.GroupIndex = 1;
            this.btnEnLanguage.Location = new System.Drawing.Point(163, 114);
            this.btnEnLanguage.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnEnLanguage.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnEnLanguage.Name = "btnEnLanguage";
            this.btnEnLanguage.Size = new System.Drawing.Size(114, 33);
            this.btnEnLanguage.TabIndex = 2;
            this.btnEnLanguage.Text = "English";
            this.btnEnLanguage.CheckedChanged += new System.EventHandler(this.btnEnLanguage_CheckedChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.GradientBottom = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(222)))));
            this.btnLogin.GradientTop = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(126)))), ((int)(((byte)(10)))));
            this.btnLogin.Location = new System.Drawing.Point(163, 154);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(268, 68);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnLogin_MouseDown);
            this.btnLogin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnLogin_MouseUp);
            // 
            // FrmLogin
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Appearance.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = global::restaurantPOS.Properties.Resources.Untitled_11;
            this.ClientSize = new System.Drawing.Size(456, 248);
            this.Controls.Add(this.btnArLanguage);
            this.Controls.Add(this.btnEnLanguage);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblCopyRightsLoginForm);
            this.Controls.Add(this.lblChooseLang);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to Estoda Cheese King";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblUserName;
        private DevExpress.XtraEditors.LabelControl lblPassword;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.LabelControl lblChooseLang;
        private DevExpress.XtraEditors.LabelControl lblCopyRightsLoginForm;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private GelButton btnLogin;
        private DevExpress.XtraEditors.CheckButton btnArLanguage;
        private DevExpress.XtraEditors.CheckButton btnEnLanguage;
    }
}