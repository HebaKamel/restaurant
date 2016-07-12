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

namespace restaurantPOS.Manage.Client
{
    public partial class UpdateClient : Form
    {
        private FormsMessages.formsAr formsAr = new FormsMessages.formsAr();
        private FormsMessages.formsEn formsEn = new FormsMessages.formsEn();
        private userMessages.messagesAr messagesAr = new userMessages.messagesAr();
        private userMessages.messagesEn messagesEn = new userMessages.messagesEn();
        private DataAccess.dataAccess db = new dataAccess();
        private SystemSetting.system system = new system();
        int clientId;
        string errMsg = ""; 

        public UpdateClient(int clientId)
        {
            InitializeComponent();
            this.clientId = clientId;
        }

        private void UpdateClient_Load(object sender, EventArgs e)
        {
            setLanguage();
            DataTable clientDT = db.getClient(null, null, null, null, null, null, null, this.clientId, null);
            if (clientDT.Rows.Count > 0)
            {
                txtNameEnglish.Text = clientDT.Rows[0]["client_name_en"].ToString();
                txtNameArabic.Text = clientDT.Rows[0]["client_name_ar"].ToString();
                txtAddrEnglish.Text = clientDT.Rows[0]["client_address_en"].ToString();
                txtAddrArabic.Text = clientDT.Rows[0]["client_address_ar"].ToString();
                txtLandLine.Text = clientDT.Rows[0]["client_telephone_no"].ToString();
                txtMobile.Text = clientDT.Rows[0]["client_mobile_no"].ToString();
                txtEmail.Text = clientDT.Rows[0]["client_email"].ToString();if (clientDT.Rows[0]["Is_VIP"].ToString() == "True")
                    chkIsVip.Checked = true;
            }
        }
        private void setLanguage()
        {
            if (Settings.Default.Language == "En")
            {
                lblClientHeader.Text = formsEn.AddClientHeader;
                btnUpdate.Text = formsEn.btnUpdate;
                lblNameArabicAr.Visible = false;
                lblNameEnglishAr.Visible = false;
                lblAddrArabicAr.Visible = false;
                lblAddrEnglishAr.Visible = false;
                lblLandLineAr.Visible = false;
                lblMobileAr.Visible = false;
                lblIsVipAr.Visible = false;
                lblEmailAr.Visible = false;
            }
            else
            {
                lblClientHeader.Text = formsAr.AddClientHeader;
                btnUpdate.Text = formsAr.btnUpdate;
                lblNameArabic.Visible = false;
                lblNameEnglish.Visible = false;
                lblAddrArabic.Visible = false;
                lblAddrEnglish.Visible = false;
                lblLandLine.Visible = false;
                lblMobile.Visible = false;
                lblIsVipEn.Visible = false;
                lblEmailEn.Visible = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (validation() == "")
            {
                int isVip = 0;
                if (chkIsVip.Checked) isVip = 1;
                int updated = db.updateClient(txtNameEnglish.Text, txtNameArabic.Text, txtAddrEnglish.Text,
                                              txtAddrArabic.Text, txtLandLine.Text, txtMobile.Text, txtEmail.Text,
                                              this.clientId, isVip);
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
            string name = "", mobile = "";
            if (string.IsNullOrEmpty(txtNameEnglish.Text))
            {
                if (Settings.Default.Language == "En")
                    name = formsEn.clientNameEn;
                else
                    name = formsAr.clientNameEn;
                errMsg += "\n" + name;
            }

            if (string.IsNullOrEmpty(txtMobile.Text))
            {
                if (Settings.Default.Language == "En")
                    mobile = formsEn.clientMobile;
                else
                    mobile = formsAr.clientMobile;
                errMsg += "\n" + mobile;
            }
            return errMsg;
        }
    }
}
