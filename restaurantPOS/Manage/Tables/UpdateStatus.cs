using DevExpress.XtraEditors;
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

namespace restaurantPOS.Manage.Tables
{
    public partial class UpdateStatus : Form
    {
        private FormsMessages.formsAr formsAr = new FormsMessages.formsAr();
        private FormsMessages.formsEn formsEn = new FormsMessages.formsEn();
        private userMessages.messagesAr messagesAr = new userMessages.messagesAr();
        private userMessages.messagesEn messagesEn = new userMessages.messagesEn();
        private DataAccess.dataAccess db = new dataAccess();
        private SystemSetting.system system = new system();
        int statusId;
        private string statusNameEn, statusNameAr, statusColor;
        private string errMsg = "";

        public UpdateStatus(int statusId, string statusNameEn, string statusNameAr, string statusColor)
        {
            InitializeComponent();
            this.statusId = statusId;
            this.statusNameEn = statusNameEn;
            this.statusNameAr = statusNameAr;
            this.statusColor = statusColor;
        }

        private void UpdateStatus_Load(object sender, EventArgs e)
        {
            setLanguage();
            txtNameEnglish.Text = statusNameEn;
            txtNameArabic.Text = statusNameAr;
            //statusColor;
        }

        private void setLanguage()
        {
            if (Settings.Default.Language == "En"){
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
                MessageBox.Show("color--->" + statusColorPick.EditValue.ToString());
                int updated = db.UpdateStatus(txtNameEnglish.Text, txtNameArabic.Text, statusColorPick.EditValue.ToString(), this.statusId);
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
                        XtraMessageBox.Show(messagesEn.updatedError, system.restName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    else
                        XtraMessageBox.Show(messagesAr.updatedError, system.restName, MessageBoxButtons.OK,  MessageBoxIcon.Asterisk);
                }
            }
            else
                XtraMessageBox.Show(errMsg, system.restName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private string validation()
        {
            errMsg = messagesEn.ErrorMessae;
            string name = "", color = "";
            if (string.IsNullOrEmpty(txtNameEnglish.Text))
            {
                if (Settings.Default.Language == "En")
                    name = formsEn.statusNameEn;
                else
                    name = formsAr.statusNameEn;
                errMsg += "\n" + name;
            }
            if (statusColorPick.EditValue.ToString().ToLower().Contains("empty"))
            {
                if (Settings.Default.Language == "En")
                    color = formsEn.statusColor;
                else
                    color = formsAr.statusColor;
                errMsg += "\n" + color;
            }
            return errMsg;
        }
    }
}
