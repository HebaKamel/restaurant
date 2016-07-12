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

namespace restaurantPOS.Manage.ProgramSetting
{
    public partial class ProgSetting : Form
    {
        private FormsMessages.formsAr formsAr = new FormsMessages.formsAr();
        private FormsMessages.formsEn formsEn = new FormsMessages.formsEn();
        private userMessages.messagesAr messagesAr = new userMessages.messagesAr();
        private userMessages.messagesEn messagesEn = new userMessages.messagesEn();
        private DataAccess.dataAccess db = new dataAccess();
        private SystemSetting.system system = new system();
        string errMsg = "", fileName;
        
        public ProgSetting()
        {
            InitializeComponent();
        }

        private void ProgSetting_Load(object sender, EventArgs e)
        {
            setLanguage();
            loadData();
            this.panel1.AutoScroll = true;
            this.logoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize; 
            //logoPicture.SizeMode = PictureBoxSizeMode.AutoSize;
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

        private void setLanguage()
        {
            if (Settings.Default.Language == "En")
            {
                lblAddClientHeader.Text = formsEn.AddClientHeader;
                btnAdd.Text = formsEn.btnAdd;
                btnUploadLogo.Text = formsEn.btnUpload;
                lblNameArabicAr.Visible = false;
                lblNameEnglishAr.Visible = false;
                lblAddrArabicAr.Visible = false;
                lblAddrEnglishAr.Visible = false;
                lblLandLineAr.Visible = false;
                lblMobileAr.Visible = false;
                lblWebsiteAr.Visible = false;
                lblFooterAr.Visible = false;
                lblLogoAr.Visible = false;
            }
            else
            {
                lblAddClientHeader.Text = formsAr.AddClientHeader;
                btnAdd.Text = formsAr.btnAdd;
                btnUploadLogo.Text = formsEn.btnUpload;
                lblNameArabic.Visible = false;
                lblNameEnglish.Visible = false;
                lblAddrArabic.Visible = false;
                lblAddrEnglish.Visible = false;
                lblLandLine.Visible = false;
                lblMobile.Visible = false;
                lblWebsiteEn.Visible = false;
                lblFooterEn.Visible = false;
                lblLogoEn.Visible = false;
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
            //save image in path..
            Image bitmap = Image.FromFile(fileName);
            bitmap.Save(@"D:\Heba\sourceControl\restaurant\restaurantPOS\Images\logo.bmp");  

            int id = db.updateProg(txtNameEnglish.Text, txtNameArabic.Text, txtAddrEnglish.Text,
                                      txtAddrArabic.Text, txtLandLine.Text, txtMobile.Text, txtWebsite.Text, txtFooter.Text, "logo.bmp");
            if (id >= 0)
                XtraMessageBox.Show(messagesEn.insertedSuccessfully, system.restName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else
                XtraMessageBox.Show(messagesEn.insertedError, system.restName, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void loadData()
        {
            DataTable dt = new DataTable();
            dt = db.getProg();
            if(dt.Rows.Count == 1)
            {
                txtNameEnglish.Text = dt.Rows[0]["name_en"].ToString();
                txtNameArabic.Text = dt.Rows[0]["name_ar"].ToString();
                txtAddrEnglish.Text = dt.Rows[0]["address_en"].ToString();
                txtAddrArabic.Text = dt.Rows[0]["address_ar"].ToString();
                txtLandLine.Text = dt.Rows[0]["telephone_no"].ToString();
                txtMobile.Text = dt.Rows[0]["mobile_no"].ToString();
                txtWebsite.Text = dt.Rows[0]["website"].ToString();
                txtFooter.Text = dt.Rows[0]["reset_footer"].ToString();
            }
        }
        private void btnUploadLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            dlg.Title = "Save an Image File";
            //dlg.ShowDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                fileName = dlg.FileName;
                logoPicture.Image = new Bitmap(dlg.FileName);
            }
        }
    }
}