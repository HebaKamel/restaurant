﻿using DevExpress.XtraEditors;
using restaurantPOS.DataAccess;
using restaurantPOS.Properties;
using restaurantPOS.SystemSetting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restaurantPOS.Manage.Categories
{
    public partial class UpdateCategory : Form
    {
        private FormsMessages.formsAr formsAr = new FormsMessages.formsAr();
        private FormsMessages.formsEn formsEn = new FormsMessages.formsEn();
        private userMessages.messagesAr messagesAr = new userMessages.messagesAr();
        private userMessages.messagesEn messagesEn = new userMessages.messagesEn();
        private DataAccess.dataAccess db = new dataAccess();
        private SystemSetting.system system = new system();
        int categoryId;
        private string errMsg = "";

        public UpdateCategory(int categoryId)
        {
            InitializeComponent();
            this.categoryId = categoryId;
        }

        private void UpdateCategory_Load(object sender, EventArgs e)
        {
            setLanguage();
            DataTable categoryDT = db.getCategory(null, null, this.categoryId);
            if (categoryDT.Rows.Count > 0)
            {
                txtNameEnglish.Text = categoryDT.Rows[0]["category_name_en"].ToString();
                txtNameArabic.Text = categoryDT.Rows[0]["category_name_ar"].ToString();
            }
        }

        private void setLanguage()
        {
            if (Settings.Default.Language == "En")
            {
                lblHeader.Text = formsEn.AddUnitHeader;
                btnUpdate.Text = formsEn.btnUpdate;
                lblNameArabicAr.Visible = false;
                lblNameEnglishAr.Visible = false;
            }
            else
            {
                lblHeader.Text = formsAr.AddUnitHeader;
                btnUpdate.Text = formsAr.btnUpdate;
                lblNameArabic.Visible = false;
                lblNameEnglish.Visible = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (validation() == messagesEn.ErrorMessae)
            {
                int updated = db.updateCategory(txtNameEnglish.Text, txtNameArabic.Text, this.categoryId);
                if (updated == 0)
                {
                    if (Settings.Default.Language == "En")
                        XtraMessageBox.Show(messagesEn.updatedSuccessfully, system.restName, MessageBoxButtons.OK,
                                            MessageBoxIcon.Asterisk);
                    else
                        XtraMessageBox.Show(messagesEn.updatedSuccessfully, system.restName, MessageBoxButtons.OK,
                                            MessageBoxIcon.Asterisk);
                }
                else
                {
                    if (Settings.Default.Language == "En")
                        XtraMessageBox.Show(messagesEn.updatedError, system.restName, MessageBoxButtons.OK,
                                            MessageBoxIcon.Asterisk);
                    else
                        XtraMessageBox.Show(messagesAr.updatedError, system.restName, MessageBoxButtons.OK,
                                            MessageBoxIcon.Asterisk);
                }
            }
            else
                XtraMessageBox.Show(errMsg, system.restName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private string validation()
        {
            errMsg = messagesEn.ErrorMessae;
            string nameEn = "", nameAr = "";
            if (string.IsNullOrEmpty(txtNameEnglish.Text))
            {
                if (Settings.Default.Language == "En")
                    nameEn = formsEn.unitNameEn;
                else
                    nameEn = formsAr.unitNameEn;
                errMsg += "\n" + nameEn;
            }

            if (string.IsNullOrEmpty(txtNameArabic.Text))
            {
                if (Settings.Default.Language == "En")
                    nameAr = formsEn.unitNameAr;
                else
                    nameAr = formsAr.unitNameAr;
                errMsg += "\n" + nameAr;
            }

            return errMsg;
        }
    }
}
