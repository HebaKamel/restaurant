namespace restaurantPOS.Manage.Items
{
    partial class AddItem
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
            this.splitContainerControlAddClients = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControlAddClientInfo = new DevExpress.XtraEditors.GroupControl();
            this.lblAddClientHeader = new DevExpress.XtraEditors.LabelControl();
            this.txtPrice = new DevExpress.XtraEditors.TextEdit();
            this.lblPriceAr = new DevExpress.XtraEditors.LabelControl();
            this.lblPrice = new DevExpress.XtraEditors.LabelControl();
            this.txtNameArabic = new DevExpress.XtraEditors.TextEdit();
            this.lblNameArabicAr = new DevExpress.XtraEditors.LabelControl();
            this.lblNameArabic = new DevExpress.XtraEditors.LabelControl();
            this.txtNameEnglish = new DevExpress.XtraEditors.TextEdit();
            this.lblNameEnglishAr = new DevExpress.XtraEditors.LabelControl();
            this.lblNameEnglish = new DevExpress.XtraEditors.LabelControl();
            this.groupControlButtons = new DevExpress.XtraEditors.GroupControl();
            this.btnClear = new restaurantPOS.GelButton();
            this.btnAdd = new restaurantPOS.GelButton();
            this.itemsTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboGoods = new System.Windows.Forms.ComboBox();
            this.lblGoodAr = new DevExpress.XtraEditors.LabelControl();
            this.lblGoodEn = new DevExpress.XtraEditors.LabelControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtQuantity = new DevExpress.XtraEditors.TextEdit();
            this.lblQuantityEn = new DevExpress.XtraEditors.LabelControl();
            this.lblQuantityAr = new DevExpress.XtraEditors.LabelControl();
            this.btnAddGoods = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlAddClients)).BeginInit();
            this.splitContainerControlAddClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlAddClientInfo)).BeginInit();
            this.groupControlAddClientInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameArabic.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameEnglish.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlButtons)).BeginInit();
            this.groupControlButtons.SuspendLayout();
            this.itemsTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).BeginInit();
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
            this.splitContainerControlAddClients.Size = new System.Drawing.Size(830, 700);
            this.splitContainerControlAddClients.SplitterPosition = 639;
            this.splitContainerControlAddClients.TabIndex = 1;
            this.splitContainerControlAddClients.Text = "splitContainerControlAddClients";
            // 
            // groupControlAddClientInfo
            // 
            this.groupControlAddClientInfo.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControlAddClientInfo.Appearance.Options.UseBackColor = true;
            this.groupControlAddClientInfo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControlAddClientInfo.Controls.Add(this.itemsTabs);
            this.groupControlAddClientInfo.Controls.Add(this.lblAddClientHeader);
            this.groupControlAddClientInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlAddClientInfo.Location = new System.Drawing.Point(0, 0);
            this.groupControlAddClientInfo.Name = "groupControlAddClientInfo";
            this.groupControlAddClientInfo.Size = new System.Drawing.Size(830, 576);
            this.groupControlAddClientInfo.TabIndex = 47;
            this.groupControlAddClientInfo.Text = "Add Client Info";
            // 
            // lblAddClientHeader
            // 
            this.lblAddClientHeader.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddClientHeader.Location = new System.Drawing.Point(281, 12);
            this.lblAddClientHeader.Name = "lblAddClientHeader";
            this.lblAddClientHeader.Size = new System.Drawing.Size(239, 25);
            this.lblAddClientHeader.TabIndex = 58;
            this.lblAddClientHeader.Text = "Client Information Details";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(173, 157);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Properties.Appearance.Options.UseFont = true;
            this.txtPrice.Size = new System.Drawing.Size(383, 26);
            this.txtPrice.TabIndex = 52;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMobile_KeyPress);
            // 
            // lblPriceAr
            // 
            this.lblPriceAr.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceAr.Location = new System.Drawing.Point(582, 154);
            this.lblPriceAr.Name = "lblPriceAr";
            this.lblPriceAr.Size = new System.Drawing.Size(41, 19);
            this.lblPriceAr.TabIndex = 46;
            this.lblPriceAr.Text = "السعر";
            // 
            // lblPrice
            // 
            this.lblPrice.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(111, 160);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 19);
            this.lblPrice.TabIndex = 46;
            this.lblPrice.Text = "Price";
            // 
            // txtNameArabic
            // 
            this.txtNameArabic.Location = new System.Drawing.Point(173, 114);
            this.txtNameArabic.Name = "txtNameArabic";
            this.txtNameArabic.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameArabic.Properties.Appearance.Options.UseFont = true;
            this.txtNameArabic.Size = new System.Drawing.Size(383, 26);
            this.txtNameArabic.TabIndex = 54;
            // 
            // lblNameArabicAr
            // 
            this.lblNameArabicAr.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameArabicAr.Location = new System.Drawing.Point(582, 121);
            this.lblNameArabicAr.Name = "lblNameArabicAr";
            this.lblNameArabicAr.Size = new System.Drawing.Size(94, 19);
            this.lblNameArabicAr.TabIndex = 47;
            this.lblNameArabicAr.Text = "الاسم بالعربية";
            // 
            // lblNameArabic
            // 
            this.lblNameArabic.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameArabic.Location = new System.Drawing.Point(54, 117);
            this.lblNameArabic.Name = "lblNameArabic";
            this.lblNameArabic.Size = new System.Drawing.Size(103, 19);
            this.lblNameArabic.TabIndex = 47;
            this.lblNameArabic.Text = "Name (Arabic)";
            // 
            // txtNameEnglish
            // 
            this.txtNameEnglish.Location = new System.Drawing.Point(173, 75);
            this.txtNameEnglish.Name = "txtNameEnglish";
            this.txtNameEnglish.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameEnglish.Properties.Appearance.Options.UseFont = true;
            this.txtNameEnglish.Size = new System.Drawing.Size(383, 26);
            this.txtNameEnglish.TabIndex = 53;
            // 
            // lblNameEnglishAr
            // 
            this.lblNameEnglishAr.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameEnglishAr.Location = new System.Drawing.Point(582, 82);
            this.lblNameEnglishAr.Name = "lblNameEnglishAr";
            this.lblNameEnglishAr.Size = new System.Drawing.Size(112, 19);
            this.lblNameEnglishAr.TabIndex = 51;
            this.lblNameEnglishAr.Text = "الاسم بالانجليزية";
            // 
            // lblNameEnglish
            // 
            this.lblNameEnglish.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameEnglish.Location = new System.Drawing.Point(48, 78);
            this.lblNameEnglish.Name = "lblNameEnglish";
            this.lblNameEnglish.Size = new System.Drawing.Size(109, 19);
            this.lblNameEnglish.TabIndex = 51;
            this.lblNameEnglish.Text = "Name (English)";
            // 
            // groupControlButtons
            // 
            this.groupControlButtons.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControlButtons.Appearance.Options.UseBackColor = true;
            this.groupControlButtons.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControlButtons.Controls.Add(this.btnClear);
            this.groupControlButtons.Controls.Add(this.btnAdd);
            this.groupControlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControlButtons.Location = new System.Drawing.Point(0, 576);
            this.groupControlButtons.Name = "groupControlButtons";
            this.groupControlButtons.Size = new System.Drawing.Size(830, 63);
            this.groupControlButtons.TabIndex = 46;
            this.groupControlButtons.Text = "groupControl1";
            // 
            // btnClear
            // 
            this.btnClear.GradientBottom = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(222)))));
            this.btnClear.GradientTop = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(126)))), ((int)(((byte)(10)))));
            this.btnClear.Location = new System.Drawing.Point(201, 19);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(155, 28);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.GradientBottom = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(222)))));
            this.btnAdd.GradientTop = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(126)))), ((int)(((byte)(10)))));
            this.btnAdd.Location = new System.Drawing.Point(429, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(155, 28);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // itemsTabs
            // 
            this.itemsTabs.Controls.Add(this.tabPage1);
            this.itemsTabs.Controls.Add(this.tabPage2);
            this.itemsTabs.Location = new System.Drawing.Point(38, 53);
            this.itemsTabs.Name = "itemsTabs";
            this.itemsTabs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.itemsTabs.SelectedIndex = 0;
            this.itemsTabs.Size = new System.Drawing.Size(763, 460);
            this.itemsTabs.TabIndex = 59;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtPrice);
            this.tabPage1.Controls.Add(this.txtNameEnglish);
            this.tabPage1.Controls.Add(this.lblNameArabic);
            this.tabPage1.Controls.Add(this.lblNameArabicAr);
            this.tabPage1.Controls.Add(this.lblNameEnglish);
            this.tabPage1.Controls.Add(this.txtNameArabic);
            this.tabPage1.Controls.Add(this.lblPrice);
            this.tabPage1.Controls.Add(this.lblPriceAr);
            this.tabPage1.Controls.Add(this.lblNameEnglishAr);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(755, 434);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnAddGoods);
            this.tabPage2.Controls.Add(this.txtQuantity);
            this.tabPage2.Controls.Add(this.lblQuantityEn);
            this.tabPage2.Controls.Add(this.lblQuantityAr);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.comboGoods);
            this.tabPage2.Controls.Add(this.lblGoodAr);
            this.tabPage2.Controls.Add(this.lblGoodEn);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(755, 434);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboGoods
            // 
            this.comboGoods.FormattingEnabled = true;
            this.comboGoods.Location = new System.Drawing.Point(218, 26);
            this.comboGoods.Name = "comboGoods";
            this.comboGoods.Size = new System.Drawing.Size(383, 21);
            this.comboGoods.TabIndex = 62;
            // 
            // lblGoodAr
            // 
            this.lblGoodAr.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoodAr.Location = new System.Drawing.Point(627, 24);
            this.lblGoodAr.Name = "lblGoodAr";
            this.lblGoodAr.Size = new System.Drawing.Size(36, 19);
            this.lblGoodAr.TabIndex = 60;
            this.lblGoodAr.Text = "good";
            // 
            // lblGoodEn
            // 
            this.lblGoodEn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoodEn.Location = new System.Drawing.Point(173, 26);
            this.lblGoodEn.Name = "lblGoodEn";
            this.lblGoodEn.Size = new System.Drawing.Size(38, 19);
            this.lblGoodEn.TabIndex = 61;
            this.lblGoodEn.Text = "Good";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(51, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(652, 289);
            this.dataGridView1.TabIndex = 63;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(218, 69);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Properties.Appearance.Options.UseFont = true;
            this.txtQuantity.Size = new System.Drawing.Size(383, 26);
            this.txtQuantity.TabIndex = 66;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // lblQuantityEn
            // 
            this.lblQuantityEn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityEn.Location = new System.Drawing.Point(142, 72);
            this.lblQuantityEn.Name = "lblQuantityEn";
            this.lblQuantityEn.Size = new System.Drawing.Size(60, 19);
            this.lblQuantityEn.TabIndex = 64;
            this.lblQuantityEn.Text = "Quantity";
            // 
            // lblQuantityAr
            // 
            this.lblQuantityAr.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityAr.Location = new System.Drawing.Point(620, 78);
            this.lblQuantityAr.Name = "lblQuantityAr";
            this.lblQuantityAr.Size = new System.Drawing.Size(43, 19);
            this.lblQuantityAr.TabIndex = 65;
            this.lblQuantityAr.Text = "الكمية";
            // 
            // btnAddGoods
            // 
            this.btnAddGoods.Location = new System.Drawing.Point(51, 78);
            this.btnAddGoods.Name = "btnAddGoods";
            this.btnAddGoods.Size = new System.Drawing.Size(75, 23);
            this.btnAddGoods.TabIndex = 67;
            this.btnAddGoods.Text = "Add";
            this.btnAddGoods.UseVisualStyleBackColor = true;
            this.btnAddGoods.Click += new System.EventHandler(this.btnAddGoods_Click);
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(830, 700);
            this.Controls.Add(this.splitContainerControlAddClients);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddItem";
            this.Load += new System.EventHandler(this.AddItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlAddClients)).EndInit();
            this.splitContainerControlAddClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlAddClientInfo)).EndInit();
            this.groupControlAddClientInfo.ResumeLayout(false);
            this.groupControlAddClientInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameArabic.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameEnglish.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlButtons)).EndInit();
            this.groupControlButtons.ResumeLayout(false);
            this.itemsTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControlAddClients;
        private DevExpress.XtraEditors.GroupControl groupControlAddClientInfo;
        private DevExpress.XtraEditors.LabelControl lblAddClientHeader;
        private DevExpress.XtraEditors.TextEdit txtPrice;
        private DevExpress.XtraEditors.LabelControl lblPrice;
        private DevExpress.XtraEditors.TextEdit txtNameArabic;
        private DevExpress.XtraEditors.LabelControl lblNameArabic;
        private DevExpress.XtraEditors.TextEdit txtNameEnglish;
        private DevExpress.XtraEditors.LabelControl lblNameEnglish;
        private DevExpress.XtraEditors.GroupControl groupControlButtons;
        private GelButton btnAdd;
        private DevExpress.XtraEditors.LabelControl lblPriceAr;
        private DevExpress.XtraEditors.LabelControl lblNameArabicAr;
        private DevExpress.XtraEditors.LabelControl lblNameEnglishAr;
        private GelButton btnClear;
        private System.Windows.Forms.TabControl itemsTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboGoods;
        private DevExpress.XtraEditors.LabelControl lblGoodAr;
        private DevExpress.XtraEditors.LabelControl lblGoodEn;
        private DevExpress.XtraEditors.TextEdit txtQuantity;
        private DevExpress.XtraEditors.LabelControl lblQuantityEn;
        private DevExpress.XtraEditors.LabelControl lblQuantityAr;
        private System.Windows.Forms.Button btnAddGoods;


    }
}