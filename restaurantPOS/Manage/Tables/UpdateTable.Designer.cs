namespace restaurantPOS.Manage.Tables
{
    partial class UpdateTable
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
            this.btnUpdate = new restaurantPOS.GelButton();
            this.lblHeader = new DevExpress.XtraEditors.LabelControl();
            this.dropDownTableStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            this.checkBoxIsVipAr = new System.Windows.Forms.CheckBox();
            this.checkBoxIsVipEn = new System.Windows.Forms.CheckBox();
            this.txtChairNumber = new DevExpress.XtraEditors.TextEdit();
            this.txtTableArabic = new DevExpress.XtraEditors.TextEdit();
            this.lblTableStatusAr = new DevExpress.XtraEditors.LabelControl();
            this.lblTableStatusEn = new DevExpress.XtraEditors.LabelControl();
            this.lblChairNumberAr = new DevExpress.XtraEditors.LabelControl();
            this.lblChairNumberEn = new DevExpress.XtraEditors.LabelControl();
            this.lblNameArabicAr = new DevExpress.XtraEditors.LabelControl();
            this.lblNameArabic = new DevExpress.XtraEditors.LabelControl();
            this.txtTableEnglish = new DevExpress.XtraEditors.TextEdit();
            this.lblNameEnglishAr = new DevExpress.XtraEditors.LabelControl();
            this.lblNameEnglish = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownTableStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChairNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTableArabic.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTableEnglish.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.GradientBottom = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(222)))));
            this.btnUpdate.GradientTop = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(126)))), ((int)(((byte)(10)))));
            this.btnUpdate.Location = new System.Drawing.Point(309, 315);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(155, 28);
            this.btnUpdate.TabIndex = 77;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(260, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(123, 25);
            this.lblHeader.TabIndex = 81;
            this.lblHeader.Text = "Table update";
            // 
            // dropDownTableStatus
            // 
            this.dropDownTableStatus.Location = new System.Drawing.Point(199, 266);
            this.dropDownTableStatus.Name = "dropDownTableStatus";
            this.dropDownTableStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dropDownTableStatus.Properties.DropDownRows = 5;
            this.dropDownTableStatus.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.dropDownTableStatus.Properties.Sorted = true;
            this.dropDownTableStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dropDownTableStatus.Size = new System.Drawing.Size(383, 20);
            this.dropDownTableStatus.TabIndex = 87;
            // 
            // checkBoxIsVipAr
            // 
            this.checkBoxIsVipAr.AutoSize = true;
            this.checkBoxIsVipAr.Location = new System.Drawing.Point(531, 222);
            this.checkBoxIsVipAr.Name = "checkBoxIsVipAr";
            this.checkBoxIsVipAr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxIsVipAr.Size = new System.Drawing.Size(51, 17);
            this.checkBoxIsVipAr.TabIndex = 86;
            this.checkBoxIsVipAr.Text = "خاصة";
            this.checkBoxIsVipAr.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsVipEn
            // 
            this.checkBoxIsVipEn.AutoSize = true;
            this.checkBoxIsVipEn.Location = new System.Drawing.Point(199, 222);
            this.checkBoxIsVipEn.Name = "checkBoxIsVipEn";
            this.checkBoxIsVipEn.Size = new System.Drawing.Size(43, 17);
            this.checkBoxIsVipEn.TabIndex = 85;
            this.checkBoxIsVipEn.Text = "VIP";
            this.checkBoxIsVipEn.UseVisualStyleBackColor = true;
            // 
            // txtChairNumber
            // 
            this.txtChairNumber.Location = new System.Drawing.Point(199, 171);
            this.txtChairNumber.Name = "txtChairNumber";
            this.txtChairNumber.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChairNumber.Properties.Appearance.Options.UseFont = true;
            this.txtChairNumber.Size = new System.Drawing.Size(383, 26);
            this.txtChairNumber.TabIndex = 84;
            // 
            // txtTableArabic
            // 
            this.txtTableArabic.Location = new System.Drawing.Point(199, 124);
            this.txtTableArabic.Name = "txtTableArabic";
            this.txtTableArabic.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTableArabic.Properties.Appearance.Options.UseFont = true;
            this.txtTableArabic.Size = new System.Drawing.Size(383, 26);
            this.txtTableArabic.TabIndex = 83;
            // 
            // lblTableStatusAr
            // 
            this.lblTableStatusAr.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableStatusAr.Location = new System.Drawing.Point(695, 267);
            this.lblTableStatusAr.Name = "lblTableStatusAr";
            this.lblTableStatusAr.Size = new System.Drawing.Size(81, 19);
            this.lblTableStatusAr.TabIndex = 88;
            this.lblTableStatusAr.Text = "حالة الطاولة";
            // 
            // lblTableStatusEn
            // 
            this.lblTableStatusEn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableStatusEn.Location = new System.Drawing.Point(17, 267);
            this.lblTableStatusEn.Name = "lblTableStatusEn";
            this.lblTableStatusEn.Size = new System.Drawing.Size(87, 19);
            this.lblTableStatusEn.TabIndex = 89;
            this.lblTableStatusEn.Text = "Table Status";
            // 
            // lblChairNumberAr
            // 
            this.lblChairNumberAr.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChairNumberAr.Location = new System.Drawing.Point(685, 175);
            this.lblChairNumberAr.Name = "lblChairNumberAr";
            this.lblChairNumberAr.Size = new System.Drawing.Size(91, 19);
            this.lblChairNumberAr.TabIndex = 90;
            this.lblChairNumberAr.Text = "عدد الكراسي";
            // 
            // lblChairNumberEn
            // 
            this.lblChairNumberEn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChairNumberEn.Location = new System.Drawing.Point(17, 175);
            this.lblChairNumberEn.Name = "lblChairNumberEn";
            this.lblChairNumberEn.Size = new System.Drawing.Size(99, 19);
            this.lblChairNumberEn.TabIndex = 91;
            this.lblChairNumberEn.Text = "Chair Number";
            // 
            // lblNameArabicAr
            // 
            this.lblNameArabicAr.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameArabicAr.Location = new System.Drawing.Point(633, 128);
            this.lblNameArabicAr.Name = "lblNameArabicAr";
            this.lblNameArabicAr.Size = new System.Drawing.Size(147, 19);
            this.lblNameArabicAr.TabIndex = 92;
            this.lblNameArabicAr.Text = "اسم الطاولة (بالعربية)";
            // 
            // lblNameArabic
            // 
            this.lblNameArabic.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameArabic.Location = new System.Drawing.Point(17, 128);
            this.lblNameArabic.Name = "lblNameArabic";
            this.lblNameArabic.Size = new System.Drawing.Size(147, 19);
            this.lblNameArabic.TabIndex = 93;
            this.lblNameArabic.Text = "Table Name (Arabic)";
            // 
            // txtTableEnglish
            // 
            this.txtTableEnglish.Location = new System.Drawing.Point(199, 77);
            this.txtTableEnglish.Name = "txtTableEnglish";
            this.txtTableEnglish.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTableEnglish.Properties.Appearance.Options.UseFont = true;
            this.txtTableEnglish.Size = new System.Drawing.Size(383, 26);
            this.txtTableEnglish.TabIndex = 82;
            // 
            // lblNameEnglishAr
            // 
            this.lblNameEnglishAr.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameEnglishAr.Location = new System.Drawing.Point(611, 80);
            this.lblNameEnglishAr.Name = "lblNameEnglishAr";
            this.lblNameEnglishAr.Size = new System.Drawing.Size(165, 19);
            this.lblNameEnglishAr.TabIndex = 94;
            this.lblNameEnglishAr.Text = "(اسم الطاولة (بالانجليزية";
            // 
            // lblNameEnglish
            // 
            this.lblNameEnglish.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameEnglish.Location = new System.Drawing.Point(17, 81);
            this.lblNameEnglish.Name = "lblNameEnglish";
            this.lblNameEnglish.Size = new System.Drawing.Size(153, 19);
            this.lblNameEnglish.TabIndex = 95;
            this.lblNameEnglish.Text = "Table Name (English)";
            // 
            // UpdateTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::restaurantPOS.Properties.Resources.Untitled_11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(801, 380);
            this.Controls.Add(this.dropDownTableStatus);
            this.Controls.Add(this.checkBoxIsVipAr);
            this.Controls.Add(this.checkBoxIsVipEn);
            this.Controls.Add(this.txtChairNumber);
            this.Controls.Add(this.txtTableArabic);
            this.Controls.Add(this.lblTableStatusAr);
            this.Controls.Add(this.lblTableStatusEn);
            this.Controls.Add(this.lblChairNumberAr);
            this.Controls.Add(this.lblChairNumberEn);
            this.Controls.Add(this.lblNameArabicAr);
            this.Controls.Add(this.lblNameArabic);
            this.Controls.Add(this.txtTableEnglish);
            this.Controls.Add(this.lblNameEnglishAr);
            this.Controls.Add(this.lblNameEnglish);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateTable";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update Table";
            this.Load += new System.EventHandler(this.UpdateTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dropDownTableStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChairNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTableArabic.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTableEnglish.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GelButton btnUpdate;
        private DevExpress.XtraEditors.LabelControl lblHeader;
        private DevExpress.XtraEditors.ComboBoxEdit dropDownTableStatus;
        private System.Windows.Forms.CheckBox checkBoxIsVipAr;
        private System.Windows.Forms.CheckBox checkBoxIsVipEn;
        private DevExpress.XtraEditors.TextEdit txtChairNumber;
        private DevExpress.XtraEditors.TextEdit txtTableArabic;
        private DevExpress.XtraEditors.LabelControl lblTableStatusAr;
        private DevExpress.XtraEditors.LabelControl lblTableStatusEn;
        private DevExpress.XtraEditors.LabelControl lblChairNumberAr;
        private DevExpress.XtraEditors.LabelControl lblChairNumberEn;
        private DevExpress.XtraEditors.LabelControl lblNameArabicAr;
        private DevExpress.XtraEditors.LabelControl lblNameArabic;
        private DevExpress.XtraEditors.TextEdit txtTableEnglish;
        private DevExpress.XtraEditors.LabelControl lblNameEnglishAr;
        private DevExpress.XtraEditors.LabelControl lblNameEnglish;
    }
}