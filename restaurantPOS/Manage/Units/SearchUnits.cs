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

namespace restaurantPOS.Manage.Units
{
    public partial class SearchUnits : Form
    {
        private FormsMessages.formsAr formsAr = new FormsMessages.formsAr();
        private FormsMessages.formsEn formsEn = new FormsMessages.formsEn();
        private userMessages.messagesAr messagesAr = new userMessages.messagesAr();
        private userMessages.messagesEn messagesEn = new userMessages.messagesEn();
        private DataAccess.dataAccess db = new dataAccess();
        private SystemSetting.system system = new system();
        string errMsg = "";

        public SearchUnits()
        {
            InitializeComponent();
            
        }


        private void setLanguage(){
            if (Settings.Default.Language == "En")
            {
                lblSearchUnitHeader.Text = formsEn.SearchUnitHeader;
                btnSearch.Text = formsEn.btnSearch;
                btnDelete.Text = formsEn.btnDelete;
                btnClearClient.Text = formsEn.btnClear;
                btnUpdate.Text = formsEn.btnUpdate;
                lblNameArabicAr.Visible = false;
                lblNameEnglishAr.Visible = false;
            }
            else
            {
                lblSearchUnitHeader.Text = formsAr.SearchUnitHeader;
                btnSearch.Text = formsAr.btnSearch;
                btnDelete.Text = formsAr.btnDelete;
                btnClearClient.Text = formsAr.btnClear;
                btnUpdate.Text = formsAr.btnUpdate;
                lblNameArabic.Visible = false;
                lblNameEnglish.Visible = false;
            }
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear all controls
            loadGrid();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadGrid();
        }

        private void SearchUnits_Load(object sender, EventArgs e)
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
            loadGrid();
        }

        private void loadGrid()
        {
            DataTable unitsDT = db.getUnit(txtNameEnglish.Text, txtNameArabic.Text, null);
            UnitsGrid.DataSource = unitsDT;
            UnitsGrid.Columns[0].Visible = false;
            if (Settings.Default.Language == "En")
            {
                UnitsGrid.Columns[1].HeaderText = formsEn.unitNameEn;
                UnitsGrid.Columns[2].HeaderText = formsEn.unitNameAr;
            }
            else 
            {
                UnitsGrid.Columns[1].HeaderText = formsAr.unitNameEn;
                UnitsGrid.Columns[2].HeaderText = formsAr.unitNameAr;
                UnitsGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
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
                    int rowId = Convert.ToInt32(UnitsGrid.CurrentCell.RowIndex);
                    int unitId = Convert.ToInt32(UnitsGrid.Rows[rowId].Cells[0].Value);
                    int deleted = db.deleteUnit(unitId);
                    if (deleted == 1)
                    {
                        if (Settings.Default.Language == "En")
                            XtraMessageBox.Show(messagesEn.deletedSuccessfully, system.restName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        else
                            XtraMessageBox.Show(messagesAr.deletedSuccessfully, system.restName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        UnitsGrid.Rows.RemoveAt(rowId);
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
            int rowId = Convert.ToInt32(UnitsGrid.CurrentCell.RowIndex);
            int unitId = Convert.ToInt32(UnitsGrid.Rows[rowId].Cells[0].Value);
            UpdateUnit UpdateUnit = new UpdateUnit(unitId);
            UpdateUnit.ShowDialog();
            loadGrid();
        }
    }
}