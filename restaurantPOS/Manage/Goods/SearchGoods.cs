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
using restaurantPOS.Manage.Client;
using restaurantPOS.Properties;
using restaurantPOS.SystemSetting;

namespace restaurantPOS.Manage.Goods
{
    public partial class SearchGoods : Form
    {
        private FormsMessages.formsAr formsAr = new FormsMessages.formsAr();
        private FormsMessages.formsEn formsEn = new FormsMessages.formsEn();
        private userMessages.messagesAr messagesAr = new userMessages.messagesAr();
        private userMessages.messagesEn messagesEn = new userMessages.messagesEn();
        private DataAccess.dataAccess db = new dataAccess();
        private SystemSetting.system system = new system();
        string errMsg = "";

        public SearchGoods()
        {
            InitializeComponent();
        }


        private void setLanguage(){
            if (Settings.Default.Language == "En")
            {
                lblSearchHeader.Text = formsEn.AddGoodHeader;
                btnSearch.Text = formsEn.btnSearch;
                btnDelete.Text = formsEn.btnDelete;
                btnClear.Text = formsEn.btnClear;
                btnUpdate.Text = formsEn.btnUpdate;
                lblNameArabicAr.Visible = false;
                lblNameEnglishAr.Visible = false;
                lblUnitAr.Visible = false;
            }
            else
            {
                lblSearchHeader.Text = formsAr.AddGoodHeader;
                btnSearch.Text = formsAr.btnSearch;
                btnDelete.Text = formsAr.btnDelete;
                btnClear.Text = formsAr.btnClear;
                btnUpdate.Text = formsAr.btnUpdate;
                lblNameArabic.Visible = false;
                lblNameEnglish.Visible = false;
                lblUnitEn.Visible = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear all controls
            loadGrid(true);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadGrid(false);
        }

        private void SearchGoods_Load(object sender, EventArgs e)
        {
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

            setLanguage();
            fillComboBox();
            loadGrid(true);
        }

        private void loadGrid(bool isLoad)
        {
            DataTable GoodsDT;
            if(isLoad)
                GoodsDT = db.getGoods(txtNameEnglish.Text, txtNameArabic.Text, null, null);
            else
                GoodsDT = db.getGoods(txtNameEnglish.Text, txtNameArabic.Text, (int)comboUnit.SelectedValue, null);
            int s = GoodsDT.Rows.Count;
            DataGrid.DataSource = GoodsDT;
            DataGrid.Columns[0].Visible = false;
            DataGrid.Columns[5].Visible = false;
            if (Settings.Default.Language == "En")
            {
                DataGrid.Columns[1].HeaderText = formsEn.clientNameEn;
                DataGrid.Columns[2].HeaderText = formsEn.clientNameAr;
                DataGrid.Columns[3].HeaderText = formsEn.unitNameEn;
                DataGrid.Columns[4].HeaderText = formsEn.unitNameAr;
                DataGrid.Columns[4].Visible = false;
            }
            else
            {
                DataGrid.Columns[1].HeaderText = formsAr.clientNameEn;
                DataGrid.Columns[2].HeaderText = formsAr.clientNameAr;
                DataGrid.Columns[3].HeaderText = formsEn.unitNameEn;
                DataGrid.Columns[4].HeaderText = formsAr.unitNameAr;
                DataGrid.Columns[3].Visible = false;
                DataGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult;
                if (Settings.Default.Language == "En")
                    dialogResult = XtraMessageBox.Show(messagesEn.deleteConfirm, system.restName, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                else
                    dialogResult = XtraMessageBox.Show(messagesAr.deleteConfirm, system.restName, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (dialogResult == DialogResult.Yes)
                {
                    int rowId = Convert.ToInt32(DataGrid.CurrentCell.RowIndex);
                    int goodsId = Convert.ToInt32(DataGrid.Rows[rowId].Cells[0].Value);
                    int deleted = db.deleteGoods(goodsId);
                    if (deleted == 1)
                    {
                        if (Settings.Default.Language == "En")
                            XtraMessageBox.Show(messagesEn.deletedSuccessfully, system.restName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        else
                            XtraMessageBox.Show(messagesAr.deletedSuccessfully, system.restName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        DataGrid.Rows.RemoveAt(rowId);
                    }
                    else
                    {
                        if (Settings.Default.Language == "En")
                            XtraMessageBox.Show(messagesEn.deletedError, system.restName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            XtraMessageBox.Show(messagesAr.deletedError, system.restName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                if (Settings.Default.Language == "En")
                    XtraMessageBox.Show(messagesEn.chooseRow, system.restName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    XtraMessageBox.Show(messagesAr.chooseRow, system.restName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int rowId = Convert.ToInt32(DataGrid.CurrentCell.RowIndex);
            int goodsId = Convert.ToInt32(DataGrid.Rows[rowId].Cells[0].Value);
            UpdateGoods UpdateGoods = new UpdateGoods(goodsId);
            UpdateGoods.ShowDialog();
            loadGrid(false);
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

    }
}