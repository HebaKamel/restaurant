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

namespace restaurantPOS.Manage.Items
{
    public partial class AddItem : Form
    {
        private FormsMessages.formsAr formsAr = new FormsMessages.formsAr();
        private FormsMessages.formsEn formsEn = new FormsMessages.formsEn();
        private userMessages.messagesAr messagesAr = new userMessages.messagesAr();
        private userMessages.messagesEn messagesEn = new userMessages.messagesEn();
        private DataAccess.dataAccess db = new dataAccess();
        private SystemSetting.system system = new system();

        private List<int> goodsId = new List<int>();
        private List<decimal> quantities = new List<decimal>();
        string errMsg = "";

        public AddItem()
        {
            InitializeComponent();
        }

        private void AddItem_Load(object sender, EventArgs e)
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
                lblAddClientHeader.Text = formsEn.itemsHeader;
                btnAdd.Text = formsEn.btnAdd;
                btnClear.Text = formsEn.btnClear;
                btnAddGoods.Text = formsEn.btnAdd;
                lblNameArabicAr.Visible = false;
                lblNameEnglishAr.Visible = false;
                lblPriceAr.Visible = false;
                lblGoodAr.Visible = false;
                lblQuantityAr.Visible = false;
                itemsTabs.RightToLeftLayout = false;
                tabPage1.Text = formsEn.items;
                tabPage2.Text = formsEn.itemsGoods;
            }
            else
            {
                lblAddClientHeader.Text = formsAr.itemsHeader;
                btnAdd.Text = formsAr.btnAdd;
                btnClear.Text = formsAr.btnClear;
                btnAddGoods.Text = formsAr.btnAdd;
                lblNameArabic.Visible = false;
                lblNameEnglish.Visible = false;
                lblPrice.Visible = false;
                lblGoodEn.Visible = false;
                lblQuantityEn.Visible = false;
                itemsTabs.RightToLeftLayout = true;
                tabPage1.Text = formsAr.items;
                tabPage2.Text = formsAr.itemsGoods;
            }
        }

        private string validation()
        {
            errMsg = messagesEn.ErrorMessae;
            string name = "", price = "";
            if (string.IsNullOrEmpty(txtNameEnglish.Text))
            {
                if (Settings.Default.Language == "En")
                    name = formsEn.clientNameEn;
                else
                    name = formsAr.clientNameEn;
                errMsg += "\n" + name;
            }

            if (string.IsNullOrEmpty(txtPrice.Text))
            {
                if (Settings.Default.Language == "En")
                    price = formsEn.itemPrice;
                else
                    price = formsAr.itemPrice;
                errMsg += "\n" + price;
            }
            return errMsg;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (validation() == "")
            {
                //int clientId = db.addClient(txtNameEnglish.Text, txtNameArabic.Text, txtAddrEnglish.Text,
                //                          txtAddrArabic.Text, txtLandLine.Text, txtPrice.Text, isVip, txtEmail.Text);
                //if (clientId != 0)
                //    XtraMessageBox.Show(messagesEn.insertedSuccessfully, system.restName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                //else
                //    XtraMessageBox.Show(messagesEn.insertedError, system.restName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                XtraMessageBox.Show(errMsg, system.restName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btnAddGoods_Click(object sender, EventArgs e)
        {
            //validation details
            if(comboGoods.SelectedIndex > 0 && !string.IsNullOrEmpty(txtQuantity.Text))
            {
                goodsId.Add((int)comboGoods.SelectedValue);
                quantities.Add(Convert.ToDecimal(txtQuantity.Text));
            } else {
                if (Settings.Default.Language == "En")
                        MessageBox.Show(messagesEn.itemDetail, system.restName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show(messagesAr.itemDetail, system.restName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fillComboBox()
        {
            try
            {
                DataTable goodsDT = db.getGoods(null, null, null);
                if (goodsDT.Rows.Count > 0)
                {
                    DataRow dr;
                    dr = goodsDT.NewRow();
                    dr.ItemArray = new object[3] { 0, "---Select---", "---اختر---" };
                    goodsDT.Rows.InsertAt(dr, 0); if (Settings.Default.Language == "En")
                        comboGoods.DisplayMember = "goods_name_en";
                    else
                    {
                        comboGoods.DisplayMember = "goods_name_ar";
                        comboGoods.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                    }
                    comboGoods.ValueMember = "goods_id";
                    comboGoods.DataSource = goodsDT;
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