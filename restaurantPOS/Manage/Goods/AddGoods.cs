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

namespace restaurantPOS.Manage.Goods
{
    public partial class AddGoods : Form
    {
        private FormsMessages.formsAr formsAr = new FormsMessages.formsAr();
        private FormsMessages.formsEn formsEn = new FormsMessages.formsEn();
        private userMessages.messagesAr messagesAr = new userMessages.messagesAr();
        private userMessages.messagesEn messagesEn = new userMessages.messagesEn();
        private DataAccess.dataAccess db = new dataAccess();
        private SystemSetting.system system = new system();
        string errMsg = "";

        public AddGoods()
        {
            InitializeComponent();
        }

        private void AddGoods_Load(object sender, EventArgs e)
        {
            setLanguage();
            fillComboBox();
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
                lblAddUnitHeader.Text = formsEn.AddGoodHeader;
                btnAdd.Text = formsEn.btnAdd;
                btnClear.Text = formsEn.btnClear;
                lblNameArabicAr.Visible = false;
                lblNameEnglishAr.Visible = false;
                lblUnitAr.Visible = false;
            }
            else
            {
                lblAddUnitHeader.Text = formsAr.AddGoodHeader;
                btnAdd.Text = formsAr.btnAdd;
                btnClear.Text = formsAr.btnClear;
                lblNameArabic.Visible = false;
                lblNameEnglish.Visible = false;
                lblUnitEn.Visible = false;
            }
        }

        private string validation()
        {
            errMsg = "";
            string name = "", unit = "";
            if (string.IsNullOrEmpty(txtNameEnglish.Text))
            {
                if (Settings.Default.Language == "En")
                    name = formsEn.unitNameEn;
                else
                    name = formsAr.unitNameEn;
            }

            if (comboUnit.SelectedIndex <= 0)
            {
                if (Settings.Default.Language == "En")
                    unit = formsEn.AddUnitHeader;
                else
                    unit = formsAr.AddUnitHeader;
            }

            if (name != "" || unit != "")
            {
                if (Settings.Default.Language == "En")
                    errMsg = messagesEn.ErrorMessae + "\n" + name + "\n" + unit;
                else
                    errMsg = messagesAr.ErrorMessae + "\n" + name + "\n" + unit;
            }
            return errMsg;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (validation() == "")
            {int goodsId = db.addGoods(txtNameEnglish.Text, txtNameArabic.Text, (int)comboUnit.SelectedValue);
                if (goodsId != 0)
                    XtraMessageBox.Show(messagesEn.insertedSuccessfully, system.restName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else
                    XtraMessageBox.Show(messagesEn.insertedError, system.restName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                XtraMessageBox.Show(errMsg, system.restName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
        }

        private void fillComboBox()
        {
            try
            {
                DataTable unitsDT = db.getUnit(null, null, null);
                if (unitsDT.Rows.Count > 0)
                {
                    DataRow dr;
                    dr = unitsDT.NewRow();
                    dr.ItemArray = new object[3] { 0, "---Select---", "---اختر---" };
                    unitsDT.Rows.InsertAt(dr, 0);if (Settings.Default.Language == "En")
                        comboUnit.DisplayMember = "unit_name_en";
                    else
                    {
                        comboUnit.DisplayMember = "unit_name_ar";
                        comboUnit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                    }
                    comboUnit.ValueMember = "unit_id";
                    comboUnit.DataSource = unitsDT;
                }
                else
                {
                    if (Settings.Default.Language == "En")
                        MessageBox.Show(messagesEn.fillUnits, system.restName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show(messagesAr.fillUnits, system.restName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                if (Settings.Default.Language == "En")
                    MessageBox.Show(messagesEn.errorFillUnits, system.restName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(messagesAr.errorFillUnits, system.restName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }
    }
}