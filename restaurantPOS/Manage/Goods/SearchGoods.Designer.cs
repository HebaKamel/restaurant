namespace restaurantPOS.Manage.Goods
{
    partial class SearchGoods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchGoods));
            this.groupControlButtons = new DevExpress.XtraEditors.GroupControl();
            this.btnDelete = new restaurantPOS.GelButton();
            this.btnUpdate = new restaurantPOS.GelButton();
            this.btnClear = new restaurantPOS.GelButton();
            this.btnSearch = new restaurantPOS.GelButton();
            this.groupControlAddClientInfo = new DevExpress.XtraEditors.GroupControl();
            this.comboUnit = new System.Windows.Forms.ComboBox();
            this.txtNameArabic = new DevExpress.XtraEditors.TextEdit();
            this.lblUnitAr = new DevExpress.XtraEditors.LabelControl();
            this.lblNameArabicAr = new DevExpress.XtraEditors.LabelControl();
            this.lblUnitEn = new DevExpress.XtraEditors.LabelControl();
            this.lblNameArabic = new DevExpress.XtraEditors.LabelControl();
            this.txtNameEnglish = new DevExpress.XtraEditors.TextEdit();
            this.lblNameEnglishAr = new DevExpress.XtraEditors.LabelControl();
            this.lblNameEnglish = new DevExpress.XtraEditors.LabelControl();
            this.lblSearchHeader = new DevExpress.XtraEditors.LabelControl();
            this.splitContainerControlAddClients = new DevExpress.XtraEditors.SplitContainerControl();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlButtons)).BeginInit();
            this.groupControlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlAddClientInfo)).BeginInit();
            this.groupControlAddClientInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameArabic.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameEnglish.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlAddClients)).BeginInit();
            this.splitContainerControlAddClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControlButtons
            // 
            this.groupControlButtons.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControlButtons.Appearance.Options.UseBackColor = true;
            this.groupControlButtons.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControlButtons.Controls.Add(this.btnDelete);
            this.groupControlButtons.Controls.Add(this.btnUpdate);
            this.groupControlButtons.Controls.Add(this.btnClear);
            this.groupControlButtons.Controls.Add(this.btnSearch);
            this.groupControlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControlButtons.Location = new System.Drawing.Point(0, 263);
            this.groupControlButtons.Name = "groupControlButtons";
            this.groupControlButtons.Size = new System.Drawing.Size(830, 42);
            this.groupControlButtons.TabIndex = 46;
            this.groupControlButtons.Text = "groupControl1";
            // 
            // btnDelete
            // 
            this.btnDelete.GradientBottom = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(222)))));
            this.btnDelete.GradientTop = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(126)))), ((int)(((byte)(10)))));
            this.btnDelete.Location = new System.Drawing.Point(3, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(155, 28);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.GradientBottom = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(222)))));
            this.btnUpdate.GradientTop = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(126)))), ((int)(((byte)(10)))));
            this.btnUpdate.Location = new System.Drawing.Point(231, 6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(155, 28);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.GradientBottom = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(222)))));
            this.btnClear.GradientTop = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(126)))), ((int)(((byte)(10)))));
            this.btnClear.Location = new System.Drawing.Point(406, 6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(155, 28);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.GradientBottom = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(222)))));
            this.btnSearch.GradientTop = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(126)))), ((int)(((byte)(10)))));
            this.btnSearch.Location = new System.Drawing.Point(634, 6);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(155, 28);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupControlAddClientInfo
            // 
            this.groupControlAddClientInfo.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControlAddClientInfo.Appearance.Options.UseBackColor = true;
            this.groupControlAddClientInfo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControlAddClientInfo.Controls.Add(this.comboUnit);
            this.groupControlAddClientInfo.Controls.Add(this.txtNameArabic);
            this.groupControlAddClientInfo.Controls.Add(this.lblUnitAr);
            this.groupControlAddClientInfo.Controls.Add(this.lblNameArabicAr);
            this.groupControlAddClientInfo.Controls.Add(this.lblUnitEn);
            this.groupControlAddClientInfo.Controls.Add(this.lblNameArabic);
            this.groupControlAddClientInfo.Controls.Add(this.txtNameEnglish);
            this.groupControlAddClientInfo.Controls.Add(this.lblNameEnglishAr);
            this.groupControlAddClientInfo.Controls.Add(this.lblNameEnglish);
            this.groupControlAddClientInfo.Controls.Add(this.lblSearchHeader);
            this.groupControlAddClientInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlAddClientInfo.Location = new System.Drawing.Point(0, 0);
            this.groupControlAddClientInfo.Name = "groupControlAddClientInfo";
            this.groupControlAddClientInfo.Size = new System.Drawing.Size(830, 263);
            this.groupControlAddClientInfo.TabIndex = 47;
            this.groupControlAddClientInfo.Text = "Add Client Info";
            // 
            // comboUnit
            // 
            this.comboUnit.FormattingEnabled = true;
            this.comboUnit.Location = new System.Drawing.Point(217, 155);
            this.comboUnit.Name = "comboUnit";
            this.comboUnit.Size = new System.Drawing.Size(383, 21);
            this.comboUnit.TabIndex = 68;
            // 
            // txtNameArabic
            // 
            this.txtNameArabic.Location = new System.Drawing.Point(217, 120);
            this.txtNameArabic.Name = "txtNameArabic";
            this.txtNameArabic.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameArabic.Properties.Appearance.Options.UseFont = true;
            this.txtNameArabic.Size = new System.Drawing.Size(383, 26);
            this.txtNameArabic.TabIndex = 67;
            // 
            // lblUnitAr
            // 
            this.lblUnitAr.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitAr.Location = new System.Drawing.Point(626, 153);
            this.lblUnitAr.Name = "lblUnitAr";
            this.lblUnitAr.Size = new System.Drawing.Size(44, 19);
            this.lblUnitAr.TabIndex = 60;
            this.lblUnitAr.Text = "الوحدة";
            // 
            // lblNameArabicAr
            // 
            this.lblNameArabicAr.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameArabicAr.Location = new System.Drawing.Point(626, 127);
            this.lblNameArabicAr.Name = "lblNameArabicAr";
            this.lblNameArabicAr.Size = new System.Drawing.Size(94, 19);
            this.lblNameArabicAr.TabIndex = 61;
            this.lblNameArabicAr.Text = "الاسم بالعربية";
            // 
            // lblUnitEn
            // 
            this.lblUnitEn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitEn.Location = new System.Drawing.Point(172, 153);
            this.lblUnitEn.Name = "lblUnitEn";
            this.lblUnitEn.Size = new System.Drawing.Size(29, 19);
            this.lblUnitEn.TabIndex = 62;
            this.lblUnitEn.Text = "Unit";
            // 
            // lblNameArabic
            // 
            this.lblNameArabic.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameArabic.Location = new System.Drawing.Point(98, 123);
            this.lblNameArabic.Name = "lblNameArabic";
            this.lblNameArabic.Size = new System.Drawing.Size(103, 19);
            this.lblNameArabic.TabIndex = 63;
            this.lblNameArabic.Text = "Name (Arabic)";
            // 
            // txtNameEnglish
            // 
            this.txtNameEnglish.Location = new System.Drawing.Point(217, 87);
            this.txtNameEnglish.Name = "txtNameEnglish";
            this.txtNameEnglish.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameEnglish.Properties.Appearance.Options.UseFont = true;
            this.txtNameEnglish.Size = new System.Drawing.Size(383, 26);
            this.txtNameEnglish.TabIndex = 66;
            // 
            // lblNameEnglishAr
            // 
            this.lblNameEnglishAr.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameEnglishAr.Location = new System.Drawing.Point(626, 94);
            this.lblNameEnglishAr.Name = "lblNameEnglishAr";
            this.lblNameEnglishAr.Size = new System.Drawing.Size(112, 19);
            this.lblNameEnglishAr.TabIndex = 64;
            this.lblNameEnglishAr.Text = "الاسم بالانجليزية";
            // 
            // lblNameEnglish
            // 
            this.lblNameEnglish.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameEnglish.Location = new System.Drawing.Point(92, 90);
            this.lblNameEnglish.Name = "lblNameEnglish";
            this.lblNameEnglish.Size = new System.Drawing.Size(109, 19);
            this.lblNameEnglish.TabIndex = 65;
            this.lblNameEnglish.Text = "Name (English)";
            // 
            // lblSearchHeader
            // 
            this.lblSearchHeader.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchHeader.Location = new System.Drawing.Point(281, 12);
            this.lblSearchHeader.Name = "lblSearchHeader";
            this.lblSearchHeader.Size = new System.Drawing.Size(239, 25);
            this.lblSearchHeader.TabIndex = 58;
            this.lblSearchHeader.Text = "Client Information Details";
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
            this.splitContainerControlAddClients.Panel2.Controls.Add(this.DataGrid);
            this.splitContainerControlAddClients.Panel2.Text = "Panel2";
            this.splitContainerControlAddClients.Size = new System.Drawing.Size(830, 700);
            this.splitContainerControlAddClients.SplitterPosition = 305;
            this.splitContainerControlAddClients.TabIndex = 1;
            this.splitContainerControlAddClients.Text = "splitContainerControlAddClients";
            // 
            // DataGrid
            // 
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGrid.Location = new System.Drawing.Point(3, 1);
            this.DataGrid.MultiSelect = false;
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid.Size = new System.Drawing.Size(824, 245);
            this.DataGrid.TabIndex = 0;
            // 
            // SearchGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(830, 700);
            this.Controls.Add(this.splitContainerControlAddClients);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchGoods";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchClients";
            this.Load += new System.EventHandler(this.SearchGoods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlButtons)).EndInit();
            this.groupControlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlAddClientInfo)).EndInit();
            this.groupControlAddClientInfo.ResumeLayout(false);
            this.groupControlAddClientInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameArabic.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameEnglish.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlAddClients)).EndInit();
            this.splitContainerControlAddClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControlButtons;
        private GelButton btnClear;
        private GelButton btnSearch;
        private DevExpress.XtraEditors.GroupControl groupControlAddClientInfo;
        private DevExpress.XtraEditors.LabelControl lblSearchHeader;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControlAddClients;
        private GelButton btnDelete;
        private GelButton btnUpdate;
        private System.Windows.Forms.DataGridView DataGrid;
        private System.Windows.Forms.ComboBox comboUnit;
        private DevExpress.XtraEditors.TextEdit txtNameArabic;
        private DevExpress.XtraEditors.LabelControl lblUnitAr;
        private DevExpress.XtraEditors.LabelControl lblNameArabicAr;
        private DevExpress.XtraEditors.LabelControl lblUnitEn;
        private DevExpress.XtraEditors.LabelControl lblNameArabic;
        private DevExpress.XtraEditors.TextEdit txtNameEnglish;
        private DevExpress.XtraEditors.LabelControl lblNameEnglishAr;
        private DevExpress.XtraEditors.LabelControl lblNameEnglish;



    }
}