namespace restaurantPOS.Manage.Tables
{
    partial class AddTable{
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
            this.splitContainerControlAddClients = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControlAddClientInfo = new DevExpress.XtraEditors.GroupControl();
            this.dropDownTableStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            this.checkBoxIsVipAr = new System.Windows.Forms.CheckBox();
            this.checkBoxIsVipEn = new System.Windows.Forms.CheckBox();
            this.lblAddHeader = new DevExpress.XtraEditors.LabelControl();
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
            this.groupControlButtons = new DevExpress.XtraEditors.GroupControl();
            this.btnClear = new restaurantPOS.GelButton();
            this.btnAdd = new restaurantPOS.GelButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlAddClients)).BeginInit();
            this.splitContainerControlAddClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlAddClientInfo)).BeginInit();
            this.groupControlAddClientInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownTableStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChairNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTableArabic.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTableEnglish.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlButtons)).BeginInit();
            this.groupControlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerControlAddClients
            // 
            this.splitContainerControlAddClients.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.splitContainerControlAddClients.Appearance.Options.UseBackColor = true;
            this.splitContainerControlAddClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControlAddClients.Horizontal = false;
            this.splitContainerControlAddClients.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControlAddClients.Name = "splitContainerControlAddClients";
            this.splitContainerControlAddClients.Panel1.Controls.Add(this.groupControlAddClientInfo);
            this.splitContainerControlAddClients.Panel1.Controls.Add(this.groupControlButtons);
            this.splitContainerControlAddClients.Panel1.Text = "Panel1";
            this.splitContainerControlAddClients.Panel2.Text = "Panel2";
            this.splitContainerControlAddClients.Size = new System.Drawing.Size(800, 700);
            this.splitContainerControlAddClients.SplitterPosition = 340;
            this.splitContainerControlAddClients.TabIndex = 1;
            this.splitContainerControlAddClients.Text = "splitContainerControlAddClients";
            // 
            // groupControlAddClientInfo
            // 
            this.groupControlAddClientInfo.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControlAddClientInfo.Appearance.Options.UseBackColor = true;
            this.groupControlAddClientInfo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControlAddClientInfo.Controls.Add(this.dropDownTableStatus);
            this.groupControlAddClientInfo.Controls.Add(this.checkBoxIsVipAr);
            this.groupControlAddClientInfo.Controls.Add(this.checkBoxIsVipEn);
            this.groupControlAddClientInfo.Controls.Add(this.lblAddHeader);
            this.groupControlAddClientInfo.Controls.Add(this.txtChairNumber);
            this.groupControlAddClientInfo.Controls.Add(this.txtTableArabic);
            this.groupControlAddClientInfo.Controls.Add(this.lblTableStatusAr);
            this.groupControlAddClientInfo.Controls.Add(this.lblTableStatusEn);
            this.groupControlAddClientInfo.Controls.Add(this.lblChairNumberAr);
            this.groupControlAddClientInfo.Controls.Add(this.lblChairNumberEn);
            this.groupControlAddClientInfo.Controls.Add(this.lblNameArabicAr);
            this.groupControlAddClientInfo.Controls.Add(this.lblNameArabic);
            this.groupControlAddClientInfo.Controls.Add(this.txtTableEnglish);
            this.groupControlAddClientInfo.Controls.Add(this.lblNameEnglishAr);
            this.groupControlAddClientInfo.Controls.Add(this.lblNameEnglish);
            this.groupControlAddClientInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlAddClientInfo.Location = new System.Drawing.Point(0, 0);
            this.groupControlAddClientInfo.Name = "groupControlAddClientInfo";
            this.groupControlAddClientInfo.Size = new System.Drawing.Size(800, 299);
            this.groupControlAddClientInfo.TabIndex = 47;
            this.groupControlAddClientInfo.Text = "Add Client Info";
            // 
            // dropDownTableStatus
            // 
            this.dropDownTableStatus.Location = new System.Drawing.Point(207, 251);
            this.dropDownTableStatus.Name = "dropDownTableStatus";
            this.dropDownTableStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dropDownTableStatus.Properties.DropDownRows = 5;
            this.dropDownTableStatus.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.dropDownTableStatus.Properties.Sorted = true;
            this.dropDownTableStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dropDownTableStatus.Size = new System.Drawing.Size(383, 20);
            this.dropDownTableStatus.TabIndex = 5;
            // 
            // checkBoxIsVipAr
            // 
            this.checkBoxIsVipAr.AutoSize = true;
            this.checkBoxIsVipAr.Location = new System.Drawing.Point(539, 207);
            this.checkBoxIsVipAr.Name = "checkBoxIsVipAr";
            this.checkBoxIsVipAr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxIsVipAr.Size = new System.Drawing.Size(51, 17);
            this.checkBoxIsVipAr.TabIndex = 4;
            this.checkBoxIsVipAr.Text = "خاصة";
            this.checkBoxIsVipAr.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsVipEn
            // 
            this.checkBoxIsVipEn.AutoSize = true;
            this.checkBoxIsVipEn.Location = new System.Drawing.Point(207, 207);
            this.checkBoxIsVipEn.Name = "checkBoxIsVipEn";
            this.checkBoxIsVipEn.Size = new System.Drawing.Size(43, 17);
            this.checkBoxIsVipEn.TabIndex = 3;
            this.checkBoxIsVipEn.Text = "VIP";
            this.checkBoxIsVipEn.UseVisualStyleBackColor = true;
            // 
            // lblAddHeader
            // 
            this.lblAddHeader.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddHeader.Location = new System.Drawing.Point(338, 12);
            this.lblAddHeader.Name = "lblAddHeader";
            this.lblAddHeader.Size = new System.Drawing.Size(51, 25);
            this.lblAddHeader.TabIndex = 58;
            this.lblAddHeader.Text = "Table";
            // 
            // txtChairNumber
            // 
            this.txtChairNumber.Location = new System.Drawing.Point(207, 156);
            this.txtChairNumber.Name = "txtChairNumber";
            this.txtChairNumber.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChairNumber.Properties.Appearance.Options.UseFont = true;
            this.txtChairNumber.Size = new System.Drawing.Size(383, 26);
            this.txtChairNumber.TabIndex = 2;
            // 
            // txtTableArabic
            // 
            this.txtTableArabic.Location = new System.Drawing.Point(207, 109);
            this.txtTableArabic.Name = "txtTableArabic";
            this.txtTableArabic.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTableArabic.Properties.Appearance.Options.UseFont = true;
            this.txtTableArabic.Size = new System.Drawing.Size(383, 26);
            this.txtTableArabic.TabIndex = 1;
            // 
            // lblTableStatusAr
            // 
            this.lblTableStatusAr.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableStatusAr.Location = new System.Drawing.Point(703, 252);
            this.lblTableStatusAr.Name = "lblTableStatusAr";
            this.lblTableStatusAr.Size = new System.Drawing.Size(81, 19);
            this.lblTableStatusAr.TabIndex = 47;
            this.lblTableStatusAr.Text = "حالة الطاولة";
            // 
            // lblTableStatusEn
            // 
            this.lblTableStatusEn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableStatusEn.Location = new System.Drawing.Point(25, 252);
            this.lblTableStatusEn.Name = "lblTableStatusEn";
            this.lblTableStatusEn.Size = new System.Drawing.Size(87, 19);
            this.lblTableStatusEn.TabIndex = 47;
            this.lblTableStatusEn.Text = "Table Status";
            // 
            // lblChairNumberAr
            // 
            this.lblChairNumberAr.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChairNumberAr.Location = new System.Drawing.Point(693, 160);
            this.lblChairNumberAr.Name = "lblChairNumberAr";
            this.lblChairNumberAr.Size = new System.Drawing.Size(91, 19);
            this.lblChairNumberAr.TabIndex = 47;
            this.lblChairNumberAr.Text = "عدد الكراسي";
            // 
            // lblChairNumberEn
            // 
            this.lblChairNumberEn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChairNumberEn.Location = new System.Drawing.Point(25, 160);
            this.lblChairNumberEn.Name = "lblChairNumberEn";
            this.lblChairNumberEn.Size = new System.Drawing.Size(99, 19);
            this.lblChairNumberEn.TabIndex = 47;
            this.lblChairNumberEn.Text = "Chair Number";
            // 
            // lblNameArabicAr
            // 
            this.lblNameArabicAr.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameArabicAr.Location = new System.Drawing.Point(641, 113);
            this.lblNameArabicAr.Name = "lblNameArabicAr";
            this.lblNameArabicAr.Size = new System.Drawing.Size(147, 19);
            this.lblNameArabicAr.TabIndex = 47;
            this.lblNameArabicAr.Text = "اسم الطاولة (بالعربية)";
            // 
            // lblNameArabic
            // 
            this.lblNameArabic.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameArabic.Location = new System.Drawing.Point(25, 113);
            this.lblNameArabic.Name = "lblNameArabic";
            this.lblNameArabic.Size = new System.Drawing.Size(147, 19);
            this.lblNameArabic.TabIndex = 47;
            this.lblNameArabic.Text = "Table Name (Arabic)";
            // 
            // txtTableEnglish
            // 
            this.txtTableEnglish.Location = new System.Drawing.Point(207, 62);
            this.txtTableEnglish.Name = "txtTableEnglish";
            this.txtTableEnglish.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTableEnglish.Properties.Appearance.Options.UseFont = true;
            this.txtTableEnglish.Size = new System.Drawing.Size(383, 26);
            this.txtTableEnglish.TabIndex = 0;
            // 
            // lblNameEnglishAr
            // 
            this.lblNameEnglishAr.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameEnglishAr.Location = new System.Drawing.Point(619, 65);
            this.lblNameEnglishAr.Name = "lblNameEnglishAr";
            this.lblNameEnglishAr.Size = new System.Drawing.Size(165, 19);
            this.lblNameEnglishAr.TabIndex = 51;
            this.lblNameEnglishAr.Text = "(اسم الطاولة (بالانجليزية";
            // 
            // lblNameEnglish
            // 
            this.lblNameEnglish.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameEnglish.Location = new System.Drawing.Point(25, 66);
            this.lblNameEnglish.Name = "lblNameEnglish";
            this.lblNameEnglish.Size = new System.Drawing.Size(153, 19);
            this.lblNameEnglish.TabIndex = 51;
            this.lblNameEnglish.Text = "Table Name (English)";
            // 
            // groupControlButtons
            // 
            this.groupControlButtons.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControlButtons.Appearance.Options.UseBackColor = true;
            this.groupControlButtons.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControlButtons.Controls.Add(this.btnClear);
            this.groupControlButtons.Controls.Add(this.btnAdd);
            this.groupControlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControlButtons.Location = new System.Drawing.Point(0, 299);
            this.groupControlButtons.Name = "groupControlButtons";
            this.groupControlButtons.Size = new System.Drawing.Size(800, 41);
            this.groupControlButtons.TabIndex = 46;
            this.groupControlButtons.Text = "groupControl1";
            // 
            // btnClear
            // 
            this.btnClear.GradientBottom = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(222)))));
            this.btnClear.GradientTop = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(126)))), ((int)(((byte)(10)))));
            this.btnClear.Location = new System.Drawing.Point(420, 6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(155, 28);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.GradientBottom = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(222)))));
            this.btnAdd.GradientTop = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(126)))), ((int)(((byte)(10)))));
            this.btnAdd.Location = new System.Drawing.Point(192, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(155, 28);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::restaurantPOS.Properties.Resources.Untitled_11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 700);
            this.Controls.Add(this.splitContainerControlAddClients);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTablesStatus";
            this.Load += new System.EventHandler(this.AddTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlAddClients)).EndInit();
            this.splitContainerControlAddClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlAddClientInfo)).EndInit();
            this.groupControlAddClientInfo.ResumeLayout(false);
            this.groupControlAddClientInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownTableStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChairNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTableArabic.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTableEnglish.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlButtons)).EndInit();
            this.groupControlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControlAddClients;
        private DevExpress.XtraEditors.GroupControl groupControlAddClientInfo;
        private DevExpress.XtraEditors.LabelControl lblAddHeader;
        private DevExpress.XtraEditors.TextEdit txtTableArabic;
        private DevExpress.XtraEditors.LabelControl lblNameArabic;
        private DevExpress.XtraEditors.TextEdit txtTableEnglish;
        private DevExpress.XtraEditors.LabelControl lblNameEnglish;
        private DevExpress.XtraEditors.GroupControl groupControlButtons;
        private GelButton btnAdd;
        private DevExpress.XtraEditors.LabelControl lblNameArabicAr;
        private DevExpress.XtraEditors.LabelControl lblNameEnglishAr;
        private GelButton btnClear;
        private DevExpress.XtraEditors.TextEdit txtChairNumber;
        private DevExpress.XtraEditors.LabelControl lblChairNumberAr;
        private DevExpress.XtraEditors.LabelControl lblChairNumberEn;
        private System.Windows.Forms.CheckBox checkBoxIsVipAr;
        private System.Windows.Forms.CheckBox checkBoxIsVipEn;
        private DevExpress.XtraEditors.LabelControl lblTableStatusAr;
        private DevExpress.XtraEditors.LabelControl lblTableStatusEn;
        private DevExpress.XtraEditors.ComboBoxEdit dropDownTableStatus;


    }
}