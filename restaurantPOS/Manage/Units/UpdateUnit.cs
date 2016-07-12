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

namespace restaurantPOS.Manage.Units
{
    public partial class UpdateUnit : Form
    {
        private FormsMessages.formsAr formsAr = new FormsMessages.formsAr();
        private FormsMessages.formsEn formsEn = new FormsMessages.formsEn();
        private userMessages.messagesAr messagesAr = new userMessages.messagesAr();
        private userMessages.messagesEn messagesEn = new userMessages.messagesEn();
        private DataAccess.dataAccess db = new dataAccess();
        private SystemSetting.system system = new system();
        int unitId;
        private string errMsg = ""; 

        public UpdateUnit(int unitId)
        {
            InitializeComponent();
            this.unitId = unitId;
        }

        private void UpdateUnit_Load(object sender, EventArgs e)
        {
            setLanguage();
            DataTable clientDT = db.getUnit(null, null, this.unitId);
            if (clientDT.Rows.Count > 0)
            {
                txtNameEnglish.Text = clientDT.Rows[0]["unit_name_en"].ToString();
                txtNameArabic.Text = clientDT.Rows[0]["unit_name_ar"].ToString();
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
            if (validation() == "")
            {
                int updated = db.updateUnit(txtNameEnglish.Text, txtNameArabic.Text, this.unitId);
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
            errMsg = "";
            string name = "";
            if (string.IsNullOrEmpty(txtNameEnglish.Text))
            {
                if (Settings.Default.Language == "En")
                    name = formsEn.unitNameEn;
                else
                    name = formsAr.unitNameEn;
            }

            return errMsg;
        }
    }
}
