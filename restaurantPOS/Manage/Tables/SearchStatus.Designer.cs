﻿namespace restaurantPOS.Manage.Tables
{
    partial class SearchStatus
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
            this.groupControlButtons = new DevExpress.XtraEditors.GroupControl();
            this.groupControlAddClientInfo = new DevExpress.XtraEditors.GroupControl();
            this.statusColorPick = new DevExpress.XtraEditors.ColorPickEdit();
            this.lblColorAr = new DevExpress.XtraEditors.LabelControl();
            this.lblColorEn = new DevExpress.XtraEditors.LabelControl();
            this.lblSearchHeader = new DevExpress.XtraEditors.LabelControl();
            this.txtNameArabic = new DevExpress.XtraEditors.TextEdit();
            this.lblNameArabicAr = new DevExpress.XtraEditors.LabelControl();
            this.lblNameArabic = new DevExpress.XtraEditors.LabelControl();
            this.txtNameEnglish = new DevExpress.XtraEditors.TextEdit();
            this.lblNameEnglishAr = new DevExpress.XtraEditors.LabelControl();
            this.lblNameEnglish = new DevExpress.XtraEditors.LabelControl();
            this.splitContainerControlAddClients = new DevExpress.XtraEditors.SplitContainerControl();
            this.DataGrid = new System.Windows.Forms.DataGridView();
            this.btnDelete = new restaurantPOS.GelButton();
            this.btnUpdate = new restaurantPOS.GelButton();
            this.btnClearClient = new restaurantPOS.GelButton();
            this.btnSearch = new restaurantPOS.GelButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlButtons)).BeginInit();
            this.groupControlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlAddClientInfo)).BeginInit();
            this.groupControlAddClientInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusColorPick.Properties)).BeginInit();
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
            this.groupControlButtons.Controls.Add(this.btnClearClient);
            this.groupControlButtons.Controls.Add(this.btnSearch);
            this.groupControlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControlButtons.Location = new System.Drawing.Point(0, 225);
            this.groupControlButtons.Name = "groupControlButtons";
            this.groupControlButtons.Size = new System.Drawing.Size(800, 40);
            this.groupControlButtons.TabIndex = 46;
            this.groupControlButtons.Text = "groupControl1";
            // 
            // groupControlAddClientInfo
            // 
            this.groupControlAddClientInfo.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControlAddClientInfo.Appearance.Options.UseBackColor = true;
            this.groupControlAddClientInfo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.groupControlAddClientInfo.Controls.Add(this.statusColorPick);
            this.groupControlAddClientInfo.Controls.Add(this.lblColorAr);
            this.groupControlAddClientInfo.Controls.Add(this.lblColorEn);
            this.groupControlAddClientInfo.Controls.Add(this.lblSearchHeader);
            this.groupControlAddClientInfo.Controls.Add(this.txtNameArabic);
            this.groupControlAddClientInfo.Controls.Add(this.lblNameArabicAr);
            this.groupControlAddClientInfo.Controls.Add(this.lblNameArabic);
            this.groupControlAddClientInfo.Controls.Add(this.txtNameEnglish);
            this.groupControlAddClientInfo.Controls.Add(this.lblNameEnglishAr);
            this.groupControlAddClientInfo.Controls.Add(this.lblNameEnglish);
            this.groupControlAddClientInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlAddClientInfo.Location = new System.Drawing.Point(0, 0);
            this.groupControlAddClientInfo.Name = "groupControlAddClientInfo";
            this.groupControlAddClientInfo.Size = new System.Drawing.Size(800, 225);
            this.groupControlAddClientInfo.TabIndex = 47;
            this.groupControlAddClientInfo.Text = "Add Client Info";
            // 
            // statusColorPick
            // 
            this.statusColorPick.EditValue = System.Drawing.Color.Empty;
            this.statusColorPick.Location = new System.Drawing.Point(270, 184);
            this.statusColorPick.Name = "statusColorPick";
            this.statusColorPick.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.statusColorPick.Properties.Appearance.Options.UseBackColor = true;
            this.statusColorPick.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.statusColorPick.Size = new System.Drawing.Size(264, 20);
            this.statusColorPick.TabIndex = 83;
            this.statusColorPick.TextChanged += new System.EventHandler(this.statusColorPick_TextChanged);
            // 
            // lblColorAr
            // 
            this.lblColorAr.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorAr.Location = new System.Drawing.Point(684, 182);
            this.lblColorAr.Name = "lblColorAr";
            this.lblColorAr.Size = new System.Drawing.Size(33, 19);
            this.lblColorAr.TabIndex = 81;
            this.lblColorAr.Text = "اللون";
            // 
            // lblColorEn
            // 
            this.lblColorEn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorEn.Location = new System.Drawing.Point(65, 182);
            this.lblColorEn.Name = "lblColorEn";
            this.lblColorEn.Size = new System.Drawing.Size(38, 19);
            this.lblColorEn.TabIndex = 82;
            this.lblColorEn.Text = "Color";
            // 
            // lblSearchUnitHeader
            // 
            this.lblSearchHeader.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchHeader.Location = new System.Drawing.Point(267, 12);
            this.lblSearchHeader.Name = "lblSearchHeader";
            this.lblSearchHeader.Size = new System.Drawing.Size(58, 25);
            this.lblSearchHeader.TabIndex = 58;
            this.lblSearchHeader.Text = "Status";
            // 
            // txtNameArabic
            // 
            this.txtNameArabic.Location = new System.Drawing.Point(212, 122);
            this.txtNameArabic.Name = "txtNameArabic";
            this.txtNameArabic.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameArabic.Properties.Appearance.Options.UseFont = true;
            this.txtNameArabic.Size = new System.Drawing.Size(383, 26);
            this.txtNameArabic.TabIndex = 54;
            this.txtNameArabic.TextChanged += new System.EventHandler(this.txtNameArabic_TextChanged);
            // 
            // lblNameArabicAr
            // 
            this.lblNameArabicAr.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameArabicAr.Location = new System.Drawing.Point(658, 123);
            this.lblNameArabicAr.Name = "lblNameArabicAr";
            this.lblNameArabicAr.Size = new System.Drawing.Size(94, 19);
            this.lblNameArabicAr.TabIndex = 47;
            this.lblNameArabicAr.Text = "الاسم بالعربية";
            // 
            // lblNameArabic
            // 
            this.lblNameArabic.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameArabic.Location = new System.Drawing.Point(39, 123);
            this.lblNameArabic.Name = "lblNameArabic";
            this.lblNameArabic.Size = new System.Drawing.Size(103, 19);
            this.lblNameArabic.TabIndex = 47;
            this.lblNameArabic.Text = "Name (Arabic)";
            // 
            // txtNameEnglish
            // 
            this.txtNameEnglish.Location = new System.Drawing.Point(212, 63);
            this.txtNameEnglish.Name = "txtNameEnglish";
            this.txtNameEnglish.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameEnglish.Properties.Appearance.Options.UseFont = true;
            this.txtNameEnglish.Size = new System.Drawing.Size(383, 26);
            this.txtNameEnglish.TabIndex = 53;
            this.txtNameEnglish.TextChanged += new System.EventHandler(this.txtNameEnglish_TextChanged);
            // 
            // lblNameEnglishAr
            // 
            this.lblNameEnglishAr.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameEnglishAr.Location = new System.Drawing.Point(658, 64);
            this.lblNameEnglishAr.Name = "lblNameEnglishAr";
            this.lblNameEnglishAr.Size = new System.Drawing.Size(112, 19);
            this.lblNameEnglishAr.TabIndex = 51;
            this.lblNameEnglishAr.Text = "الاسم بالانجليزية";
            // 
            // lblNameEnglish
            // 
            this.lblNameEnglish.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameEnglish.Location = new System.Drawing.Point(33, 64);
            this.lblNameEnglish.Name = "lblNameEnglish";
            this.lblNameEnglish.Size = new System.Drawing.Size(109, 19);
            this.lblNameEnglish.TabIndex = 51;
            this.lblNameEnglish.Text = "Name (English)";
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
            this.splitContainerControlAddClients.SplitterPosition = 265;
            this.splitContainerControlAddClients.TabIndex = 1;
            this.splitContainerControlAddClients.Text = "splitContainerControlAddClients";
            // 
            // DataGrid
            // 
            this.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DataGrid.Location = new System.Drawing.Point(0, 0);
            this.DataGrid.MultiSelect = false;
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid.Size = new System.Drawing.Size(800, 430);
            this.DataGrid.TabIndex = 0;
            this.DataGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellValueChanged);
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
            // SearchStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::restaurantPOS.Properties.Resources.Untitled_11;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 700);
            this.Controls.Add(this.splitContainerControlAddClients);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Status";
            this.Load += new System.EventHandler(this.SearchStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlButtons)).EndInit();
            this.groupControlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlAddClientInfo)).EndInit();
            this.groupControlAddClientInfo.ResumeLayout(false);
            this.groupControlAddClientInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusColorPick.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameArabic.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameEnglish.Properties)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit txtNameArabic;
        private DevExpress.XtraEditors.LabelControl lblNameArabicAr;
        private DevExpress.XtraEditors.LabelControl lblNameArabic;
        private DevExpress.XtraEditors.TextEdit txtNameEnglish;
        private DevExpress.XtraEditors.LabelControl lblNameEnglishAr;
        private DevExpress.XtraEditors.LabelControl lblNameEnglish;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControlAddClients;
        private GelButton btnDelete;
        private GelButton btnUpdate;
        private System.Windows.Forms.DataGridView DataGrid;
        private DevExpress.XtraEditors.ColorPickEdit statusColorPick;
        private DevExpress.XtraEditors.LabelControl lblColorAr;
        private DevExpress.XtraEditors.LabelControl lblColorEn;



    }
}