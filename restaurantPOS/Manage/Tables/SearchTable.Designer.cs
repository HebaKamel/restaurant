namespace restaurantPOS.Manage.Tables
{
    partial class SearchTable
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupControlButtons = new DevExpress.XtraEditors.GroupControl();
            this.btnDelete = new restaurantPOS.GelButton();
            this.btnUpdate = new restaurantPOS.GelButton();
            this.btnClearClient = new restaurantPOS.GelButton();
            this.btnSearch = new restaurantPOS.GelButton();
            this.groupControlAddClientInfo = new DevExpress.XtraEditors.GroupControl();
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
            this.lblSearchHeader = new DevExpress.XtraEditors.LabelControl();
            this.splitContainerControlAddClients = new DevExpress.XtraEditors.SplitContainerControl();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlButtons)).BeginInit();
            this.groupControlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlAddClientInfo)).BeginInit();
            this.groupControlAddClientInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownTableStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChairNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTableArabic.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTableEnglish.Properties)).BeginInit();
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
            this.groupControlButtons.Controls.Add(this.btnClearClient);
            this.groupControlButtons.Controls.Add(this.btnSearch);
            this.groupControlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControlButtons.Location = new System.Drawing.Point(0, 308);
            this.groupControlButtons.Name = "groupControlButtons";
            this.groupControlButtons.Size = new System.Drawing.Size(800, 40);
            this.groupControlButtons.TabIndex = 46;
            this.groupControlButtons.Text = "groupControl1";
            // 
            // btnDelete
            // 
            this.btnDelete.GradientBottom = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(222)))));
            this.btnDelete.GradientTop = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(126)))), ((int)(((byte)(10)))));
            this.btnDelete.Location = new System.Drawing.Point(422, 6);
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
            this.btnUpdate.Location = new System.Drawing.Point(224, 6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(155, 28);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClearClient
            // 
            this.btnClearClient.GradientBottom = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(222)))));
            this.btnClearClient.GradientTop = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(126)))), ((int)(((byte)(10)))));
            this.btnClearClient.Location = new System.Drawing.Point(620, 6);
            this.btnClearClient.Name = "btnClearClient";
            this.btnClearClient.Size = new System.Drawing.Size(155, 28);
            this.btnClearClient.TabIndex = 0;
            this.btnClearClient.Text = "Clear";
            this.btnClearClient.UseVisualStyleBackColor = true;
            this.btnClearClient.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.GradientBottom = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(222)))));
            this.btnSearch.GradientTop = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(126)))), ((int)(((byte)(10)))));
            this.btnSearch.Location = new System.Drawing.Point(26, 6);
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
            this.groupControlAddClientInfo.Controls.Add(this.dropDownTableStatus);
            this.groupControlAddClientInfo.Controls.Add(this.checkBoxIsVipAr);
            this.groupControlAddClientInfo.Controls.Add(this.checkBoxIsVipEn);
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
            this.groupControlAddClientInfo.Controls.Add(this.lblSearchHeader);
            this.groupControlAddClientInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlAddClientInfo.Location = new System.Drawing.Point(0, 0);
            this.groupControlAddClientInfo.Name = "groupControlAddClientInfo";
            this.groupControlAddClientInfo.Size = new System.Drawing.Size(800, 308);
            this.groupControlAddClientInfo.TabIndex = 47;
            this.groupControlAddClientInfo.Text = "Add Client Info";
            // 
            // dropDownTableStatus
            // 
            this.dropDownTableStatus.Location = new System.Drawing.Point(208, 256);
            this.dropDownTableStatus.Name = "dropDownTableStatus";
            this.dropDownTableStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dropDownTableStatus.Properties.DropDownRows = 5;
            this.dropDownTableStatus.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned;
            this.dropDownTableStatus.Properties.Sorted = true;
            this.dropDownTableStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dropDownTableStatus.Size = new System.Drawing.Size(383, 20);
            this.dropDownTableStatus.TabIndex = 64;
            this.dropDownTableStatus.TextChanged += new System.EventHandler(this.dropDownTableStatus_TextChanged);
            // 
            // checkBoxIsVipAr
            // 
            this.checkBoxIsVipAr.AutoSize = true;
            this.checkBoxIsVipAr.Location = new System.Drawing.Point(540, 212);
            this.checkBoxIsVipAr.Name = "checkBoxIsVipAr";
            this.checkBoxIsVipAr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxIsVipAr.Size = new System.Drawing.Size(51, 17);
            this.checkBoxIsVipAr.TabIndex = 63;
            this.checkBoxIsVipAr.Text = "خاصة";
            this.checkBoxIsVipAr.UseVisualStyleBackColor = true;
            this.checkBoxIsVipAr.CheckedChanged += new System.EventHandler(this.checkBoxIsVipAr_CheckedChanged);
            // 
            // checkBoxIsVipEn
            // 
            this.checkBoxIsVipEn.AutoSize = true;
            this.checkBoxIsVipEn.Location = new System.Drawing.Point(208, 212);
            this.checkBoxIsVipEn.Name = "checkBoxIsVipEn";
            this.checkBoxIsVipEn.Size = new System.Drawing.Size(43, 17);
            this.checkBoxIsVipEn.TabIndex = 62;
            this.checkBoxIsVipEn.Text = "VIP";
            this.checkBoxIsVipEn.UseVisualStyleBackColor = true;
            this.checkBoxIsVipEn.CheckedChanged += new System.EventHandler(this.checkBoxIsVipEn_CheckedChanged);
            // 
            // txtChairNumber
            // 
            this.txtChairNumber.Location = new System.Drawing.Point(208, 161);
            this.txtChairNumber.Name = "txtChairNumber";
            this.txtChairNumber.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChairNumber.Properties.Appearance.Options.UseFont = true;
            this.txtChairNumber.Size = new System.Drawing.Size(383, 26);
            this.txtChairNumber.TabIndex = 61;
            this.txtChairNumber.TextChanged += new System.EventHandler(this.txtChairNumber_TextChanged);
            // 
            // txtTableArabic
            // 
            this.txtTableArabic.Location = new System.Drawing.Point(208, 114);
            this.txtTableArabic.Name = "txtTableArabic";
            this.txtTableArabic.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTableArabic.Properties.Appearance.Options.UseFont = true;
            this.txtTableArabic.Size = new System.Drawing.Size(383, 26);
            this.txtTableArabic.TabIndex = 60;
            this.txtTableArabic.TextChanged += new System.EventHandler(this.txtTableArabic_TextChanged);
            // 
            // lblTableStatusAr
            // 
            this.lblTableStatusAr.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableStatusAr.Location = new System.Drawing.Point(704, 257);
            this.lblTableStatusAr.Name = "lblTableStatusAr";
            this.lblTableStatusAr.Size = new System.Drawing.Size(81, 19);
            this.lblTableStatusAr.TabIndex = 65;
            this.lblTableStatusAr.Text = "حالة الطاولة";
            // 
            // lblTableStatusEn
            // 
            this.lblTableStatusEn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableStatusEn.Location = new System.Drawing.Point(26, 257);
            this.lblTableStatusEn.Name = "lblTableStatusEn";
            this.lblTableStatusEn.Size = new System.Drawing.Size(87, 19);
            this.lblTableStatusEn.TabIndex = 66;
            this.lblTableStatusEn.Text = "Table Status";
            // 
            // lblChairNumberAr
            // 
            this.lblChairNumberAr.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChairNumberAr.Location = new System.Drawing.Point(694, 165);
            this.lblChairNumberAr.Name = "lblChairNumberAr";
            this.lblChairNumberAr.Size = new System.Drawing.Size(91, 19);
            this.lblChairNumberAr.TabIndex = 67;
            this.lblChairNumberAr.Text = "عدد الكراسي";
            // 
            // lblChairNumberEn
            // 
            this.lblChairNumberEn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChairNumberEn.Location = new System.Drawing.Point(26, 165);
            this.lblChairNumberEn.Name = "lblChairNumberEn";
            this.lblChairNumberEn.Size = new System.Drawing.Size(99, 19);
            this.lblChairNumberEn.TabIndex = 68;
            this.lblChairNumberEn.Text = "Chair Number";
            // 
            // lblNameArabicAr
            // 
            this.lblNameArabicAr.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameArabicAr.Location = new System.Drawing.Point(642, 118);
            this.lblNameArabicAr.Name = "lblNameArabicAr";
            this.lblNameArabicAr.Size = new System.Drawing.Size(147, 19);
            this.lblNameArabicAr.TabIndex = 69;
            this.lblNameArabicAr.Text = "اسم الطاولة (بالعربية)";
            // 
            // lblNameArabic
            // 
            this.lblNameArabic.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameArabic.Location = new System.Drawing.Point(26, 118);
            this.lblNameArabic.Name = "lblNameArabic";
            this.lblNameArabic.Size = new System.Drawing.Size(147, 19);
            this.lblNameArabic.TabIndex = 70;
            this.lblNameArabic.Text = "Table Name (Arabic)";
            // 
            // txtTableEnglish
            // 
            this.txtTableEnglish.Location = new System.Drawing.Point(208, 67);
            this.txtTableEnglish.Name = "txtTableEnglish";
            this.txtTableEnglish.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTableEnglish.Properties.Appearance.Options.UseFont = true;
            this.txtTableEnglish.Size = new System.Drawing.Size(383, 26);
            this.txtTableEnglish.TabIndex = 59;
            this.txtTableEnglish.TextChanged += new System.EventHandler(this.txtTableEnglish_TextChanged);
            // 
            // lblNameEnglishAr
            // 
            this.lblNameEnglishAr.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameEnglishAr.Location = new System.Drawing.Point(620, 70);
            this.lblNameEnglishAr.Name = "lblNameEnglishAr";
            this.lblNameEnglishAr.Size = new System.Drawing.Size(165, 19);
            this.lblNameEnglishAr.TabIndex = 71;
            this.lblNameEnglishAr.Text = "(اسم الطاولة (بالانجليزية";
            // 
            // lblNameEnglish
            // 
            this.lblNameEnglish.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameEnglish.Location = new System.Drawing.Point(26, 71);
            this.lblNameEnglish.Name = "lblNameEnglish";
            this.lblNameEnglish.Size = new System.Drawing.Size(153, 19);
            this.lblNameEnglish.TabIndex = 72;
            this.lblNameEnglish.Text = "Table Name (English)";
            // 
            // lblSearchHeader
            // 
            this.lblSearchHeader.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchHeader.Location = new System.Drawing.Point(267, 12);
            this.lblSearchHeader.Name = "lblSearchHeader";
            this.lblSearchHeader.Size = new System.Drawing.Size(58, 25);
            this.lblSearchHeader.TabIndex = 58;
            this.lblSearchHeader.Text = "Status";
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
            this.splitContainerControlAddClients.Size = new System.Drawing.Size(800, 700);
            this.splitContainerControlAddClients.SplitterPosition = 348;
            this.splitContainerControlAddClients.TabIndex = 1;
            this.splitContainerControlAddClients.Text = "splitContainerControlAddClients";
            // 
            // DataGrid
            // 
            this.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGrid.Location = new System.Drawing.Point(0, 0);
            this.DataGrid.MultiSelect = false;
            this.DataGrid.Name = "DataGrid";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid.Size = new System.Drawing.Size(800, 347);
            this.DataGrid.TabIndex = 0;
            this.DataGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellValueChanged);
            // 
            // SearchTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::restaurantPOS.Properties.Resources.Untitled_11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 700);
            this.Controls.Add(this.splitContainerControlAddClients);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Table";
            this.Load += new System.EventHandler(this.SearchTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlButtons)).EndInit();
            this.groupControlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlAddClientInfo)).EndInit();
            this.groupControlAddClientInfo.ResumeLayout(false);
            this.groupControlAddClientInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dropDownTableStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChairNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTableArabic.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTableEnglish.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControlAddClients)).EndInit();
            this.splitContainerControlAddClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControlButtons;
        private GelButton btnClearClient;
        private GelButton btnSearch;
        private DevExpress.XtraEditors.GroupControl groupControlAddClientInfo;
        private DevExpress.XtraEditors.LabelControl lblSearchHeader;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControlAddClients;
        private GelButton btnDelete;
        private GelButton btnUpdate;
        private System.Windows.Forms.DataGridView DataGrid;
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