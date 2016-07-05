namespace restaurantPOS.Manage.Units
{
    partial class UpdateUnit
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
            this.txtNameArabic = new DevExpress.XtraEditors.TextEdit();
            this.lblNameArabicAr = new DevExpress.XtraEditors.LabelControl();
            this.lblNameArabic = new DevExpress.XtraEditors.LabelControl();
            this.txtNameEnglish = new DevExpress.XtraEditors.TextEdit();
            this.lblNameEnglishAr = new DevExpress.XtraEditors.LabelControl();
            this.lblNameEnglish = new DevExpress.XtraEditors.LabelControl();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnUpdate = new restaurantPOS.GelButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameArabic.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameEnglish.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNameArabic
            // 
            this.txtNameArabic.Location = new System.Drawing.Point(167, 104);
            this.txtNameArabic.Name = "txtNameArabic";
            this.txtNameArabic.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameArabic.Properties.Appearance.Options.UseFont = true;
            this.txtNameArabic.Size = new System.Drawing.Size(383, 26);
            this.txtNameArabic.TabIndex = 72;
            // 
            // lblNameArabicAr
            // 
            this.lblNameArabicAr.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameArabicAr.Location = new System.Drawing.Point(576, 111);
            this.lblNameArabicAr.Name = "lblNameArabicAr";
            this.lblNameArabicAr.Size = new System.Drawing.Size(94, 19);
            this.lblNameArabicAr.TabIndex = 61;
            this.lblNameArabicAr.Text = "الاسم بالعربية";
            // 
            // lblNameArabic
            // 
            this.lblNameArabic.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameArabic.Location = new System.Drawing.Point(48, 107);
            this.lblNameArabic.Name = "lblNameArabic";
            this.lblNameArabic.Size = new System.Drawing.Size(103, 19);
            this.lblNameArabic.TabIndex = 60;
            this.lblNameArabic.Text = "Name (Arabic)";
            // 
            // txtNameEnglish
            // 
            this.txtNameEnglish.Location = new System.Drawing.Point(167, 75);
            this.txtNameEnglish.Name = "txtNameEnglish";
            this.txtNameEnglish.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameEnglish.Properties.Appearance.Options.UseFont = true;
            this.txtNameEnglish.Size = new System.Drawing.Size(383, 26);
            this.txtNameEnglish.TabIndex = 71;
            // 
            // lblNameEnglishAr
            // 
            this.lblNameEnglishAr.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameEnglishAr.Location = new System.Drawing.Point(576, 82);
            this.lblNameEnglishAr.Name = "lblNameEnglishAr";
            this.lblNameEnglishAr.Size = new System.Drawing.Size(112, 19);
            this.lblNameEnglishAr.TabIndex = 69;
            this.lblNameEnglishAr.Text = "الاسم بالانجليزية";
            // 
            // lblNameEnglish
            // 
            this.lblNameEnglish.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameEnglish.Location = new System.Drawing.Point(42, 78);
            this.lblNameEnglish.Name = "lblNameEnglish";
            this.lblNameEnglish.Size = new System.Drawing.Size(109, 19);
            this.lblNameEnglish.TabIndex = 68;
            this.lblNameEnglish.Text = "Name (English)";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Location = new System.Drawing.Point(312, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(35, 13);
            this.lblHeader.TabIndex = 76;
            this.lblHeader.Text = "label1";
            // 
            // btnUpdate
            // 
            this.btnUpdate.GradientBottom = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(222)))));
            this.btnUpdate.GradientTop = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(126)))), ((int)(((byte)(10)))));
            this.btnUpdate.Location = new System.Drawing.Point(273, 241);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(155, 28);
            this.btnUpdate.TabIndex = 77;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // UpdateUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 281);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.txtNameArabic);
            this.Controls.Add(this.lblNameArabicAr);
            this.Controls.Add(this.lblNameArabic);
            this.Controls.Add(this.txtNameEnglish);
            this.Controls.Add(this.lblNameEnglishAr);
            this.Controls.Add(this.lblNameEnglish);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateUnit";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UpdateClient";
            this.Load += new System.EventHandler(this.UpdateUnit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNameArabic.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameEnglish.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtNameArabic;
        private DevExpress.XtraEditors.LabelControl lblNameArabicAr;
        private DevExpress.XtraEditors.LabelControl lblNameArabic;
        private DevExpress.XtraEditors.TextEdit txtNameEnglish;
        private DevExpress.XtraEditors.LabelControl lblNameEnglishAr;
        private DevExpress.XtraEditors.LabelControl lblNameEnglish;
        private System.Windows.Forms.Label lblHeader;
        private GelButton btnUpdate;
    }
}