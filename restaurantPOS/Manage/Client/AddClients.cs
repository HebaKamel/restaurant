using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using restaurantPOS.DataAccess;
using restaurantPOS.Properties;
using restaurantPOS.SystemSetting;

namespace restaurantPOS.Manage.Client
{
    public partial class AddClients : Form
    {
        private FormsMessages.formsAr formsAr = new FormsMessages.formsAr();
        private FormsMessages.formsEn formsEn = new FormsMessages.formsEn();
        private userMessages.messagesAr messagesAr = new userMessages.messagesAr();
        private userMessages.messagesEn messagesEn = new userMessages.messagesEn();
        private DataAccess.dataAccess db = new dataAccess();
        private SystemSetting.system system = new system();
        string errMsg = "";

        public AddClients()
        {
            InitializeComponent();
        }

        private void AddClients_Load(object sender, EventArgs e)
        {
            setLanguage();
            //use custom font
            var pfc = new PrivateFontCollection();
            const string fontNameRechargebd = "recharge bd.ttf";
            const string fontNameBlue = "blue.ttf";
            if (File.Exists(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), fontNameRechargebd)) && File.Exists(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), fontNameBlue)))
            {
                //pfc.AddFontFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), fontNameBlue));
                //lblAddClientHeader.Font = new Font(pfc.Families[0], 30, FontStyle.Regular);
                //lblAddrArabic.Font = new Font(pfc.Families[0], 20, FontStyle.Regular);
                //lblAddrEnglish.Font = new Font(pfc.Families[0], 20, FontStyle.Regular);
                //lblNameArabic.Font = new Font(pfc.Families[0], 20, FontStyle.Regular);
                //lblNameEnglish.Font = new Font(pfc.Families[0], 20, FontStyle.Regular);
                //lblMobile.Font = new Font(pfc.Families[0], 20, FontStyle.Regular);
                //lblLandLine.Font = new Font(pfc.Families[0], 20, FontStyle.Regular);
                //txtAddrArabic.Font = new Font(pfc.Families[0], 15, FontStyle.Regular);
                //txtAddrEnglish.Font = new Font(pfc.Families[0], 15, FontStyle.Regular);
                //txtNameArabic.Font = new Font(pfc.Families[0], 15, FontStyle.Regular);
                //txtNameEnglish.Font = new Font(pfc.Families[0], 15, FontStyle.Regular);
                //txtMobile.Font = new Font(pfc.Families[0], 15, FontStyle.Regular);
                //txtLandLine.Font = new Font(pfc.Families[0], 15, FontStyle.Regular);
                //pfc.AddFontFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), fontNameRechargebd));
                //btnDelete.Font = new Font(pfc.Families[0], 15, FontStyle.Regular);
                //btnUpdate.Font = new Font(pfc.Families[0], 15, FontStyle.Regular);

            }
        }

        private void setLanguage(){
            if (Settings.Default.Language == "En")
            {
                lblAddClientHeader.Text = formsEn.AddClientHeader;
                btnAdd.Text = formsEn.btnAdd;
                btnClear.Text = formsEn.btnClear;
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
                lblAddClientHeader.Text = formsAr.AddClientHeader;
                btnAdd.Text = formsAr.btnAdd;
                btnClear.Text = formsAr.btnClear;
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

        private string validation()
        {
            errMsg = "";
            string name = "", mobile = "";
            if (string.IsNullOrEmpty(txtNameEnglish.Text))
            {
                if (Settings.Default.Language == "En")
                    name = formsEn.clientNameEn;
                else
                    name = formsAr.clientNameEn;
            }

            if (string.IsNullOrEmpty(txtMobile.Text))
            {
                if (Settings.Default.Language == "En")
                    mobile = formsEn.clientMobile;
                else
                    mobile = formsAr.clientMobile;
            }
            if (name != "" || mobile != "")
            {
                if (Settings.Default.Language == "En")
                    errMsg = messagesEn.ErrorMessae + "\n" + name + "\n" + mobile;
                else
                    errMsg = messagesAr.ErrorMessae + "\n" + name + "\n" + mobile;
            }
            return errMsg;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (validation() == "")
            {
                int isVip = 0;
                if (chkIsVip.Checked) isVip = 1;
                int clientId = db.addClient(txtNameEnglish.Text, txtNameArabic.Text, txtAddrEnglish.Text,
                                          txtAddrArabic.Text, txtLandLine.Text, txtMobile.Text, isVip, txtEmail.Text);
                if (clientId != 0)
                    XtraMessageBox.Show(messagesEn.insertedSuccessfully, system.restName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else
                    XtraMessageBox.Show(messagesEn.insertedError, system.restName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                XtraMessageBox.Show(errMsg, system.restName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtLandLine_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
        }
    }
}