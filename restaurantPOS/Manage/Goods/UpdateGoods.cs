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

namespace restaurantPOS.Manage.Goods
{
    public partial class UpdateGoods : Form
    {
        private FormsMessages.formsAr formsAr = new FormsMessages.formsAr();
        private FormsMessages.formsEn formsEn = new FormsMessages.formsEn();
        private userMessages.messagesAr messagesAr = new userMessages.messagesAr();
        private userMessages.messagesEn messagesEn = new userMessages.messagesEn();
        private DataAccess.dataAccess db = new dataAccess();
        private SystemSetting.system system = new system();
        int goodsId;
        private string errMsg = "";

        public UpdateGoods(int goodsId)
        {
            InitializeComponent();
            this.goodsId = goodsId;
        }

        private void UpdateGoods_Load(object sender, EventArgs e)
        {
            setLanguage();
            fillComboBox();
            DataTable goodsDT = db.getGoods(null, null, null, this.goodsId);
            if (goodsDT.Rows.Count > 0)
            {
                txtNameEnglish.Text = goodsDT.Rows[0]["goods_name_en"].ToString();
                txtNameArabic.Text = goodsDT.Rows[0]["goods_name_ar"].ToString();
                comboUnit.SelectedValue = Convert.ToInt32(goodsDT.Rows[0]["unit_id"].ToString());
            }
        }

        private void setLanguage()
        {
            if (Settings.Default.Language == "En")
            {
                lblHeader.Text = formsEn.AddGoodHeader;
                btnUpdate.Text = formsEn.btnUpdate;
                lblNameArabicAr.Visible = false;
                lblNameEnglishAr.Visible = false;
                lblUnitAr.Visible = false;
            }
            else
            {
                lblHeader.Text = formsAr.AddGoodHeader;
                btnUpdate.Text = formsAr.btnUpdate;
                lblNameArabic.Visible = false;
                lblNameEnglish.Visible = false;
                lblUnitEn.Visible = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (validation() == "")
            {
                int updated = db.updateGoods(txtNameEnglish.Text, txtNameArabic.Text, (int)comboUnit.SelectedValue, this.goodsId);
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
                    unitsDT.Rows.InsertAt(dr, 0);
                    if (Settings.Default.Language == "En")
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

        private string validation()
        {
            errMsg = messagesEn.ErrorMessae;
            string name = "", unit = "";
            if (string.IsNullOrEmpty(txtNameEnglish.Text))
            {
                if (Settings.Default.Language == "En")
                    name = formsEn.unitNameEn;
                else
                    name = formsAr.unitNameEn;

                errMsg += "\n" + name;
            }

            if (comboUnit.SelectedIndex <= 0)
            {
                if (Settings.Default.Language == "En")
                    unit = formsEn.AddUnitHeader;
                else
                    unit = formsAr.AddUnitHeader;
                errMsg += "\n" + unit;
            }

            return errMsg;
        }
    }
}
