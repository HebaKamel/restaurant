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

namespace restaurantPOS.Manage.Supplier
{
    public partial class SearchSupplier : Form
    {
        private FormsMessages.formsAr formsAr = new FormsMessages.formsAr();
        private FormsMessages.formsEn formsEn = new FormsMessages.formsEn();
        private userMessages.messagesAr messagesAr = new userMessages.messagesAr();
        private userMessages.messagesEn messagesEn = new userMessages.messagesEn();
        private DataAccess.dataAccess db = new dataAccess();
        private SystemSetting.system system = new system();
        string errMsg = "";

        public SearchSupplier()
        {
            InitializeComponent();
            
        }


        private void setLanguage(){
            if (Settings.Default.Language == "En")
            {
                lblSearchClientHeader.Text = formsEn.AddSupplierHeader;
                btnSearch.Text = formsEn.btnSearch;
                btnDeleteClient.Text = formsEn.btnDelete;
                btnClearClient.Text = formsEn.btnClear;
                btnUpdateClient.Text = formsEn.btnUpdate;
                lblNameArabicAr.Visible = false;
                lblNameEnglishAr.Visible = false;
                lblAddrArabicAr.Visible = false;
                lblAddrEnglishAr.Visible = false;
                lblLandLineAr.Visible = false;
                lblMobileAr.Visible = false;
            }
            else
            {
                lblSearchClientHeader.Text = formsAr.AddSupplierHeader;
                btnSearch.Text = formsAr.btnSearch;
                btnDeleteClient.Text = formsAr.btnDelete;
                btnClearClient.Text = formsAr.btnClear;
                btnUpdateClient.Text = formsAr.btnUpdate;
                lblNameArabic.Visible = false;
                lblNameEnglish.Visible = false;
                lblAddrArabic.Visible = false;
                lblAddrEnglish.Visible = false;
                lblLandLine.Visible = false;
                lblMobile.Visible = false;
            }
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
            //clear all controls
            loadGrid();
        } 

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadGrid();
        }

        private void SearchSupplier_Load(object sender, EventArgs e)
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
            DataTable supplierDT = db.getSupplier(txtNameEnglish.Text, txtNameArabic.Text, txtAddrEnglish.Text, txtAddrArabic.Text, txtLandLine.Text, txtMobile.Text, null);
            DataGrid.DataSource = supplierDT;
            DataGrid.Columns[0].Visible = false;
            if (Settings.Default.Language == "En")
            {
                DataGrid.Columns[1].HeaderText = formsEn.clientNameEn;
                DataGrid.Columns[2].HeaderText = formsEn.clientNameAr;
                DataGrid.Columns[3].HeaderText = formsEn.clientAddressEn;
                DataGrid.Columns[4].HeaderText = formsEn.clientAddressAr;
                DataGrid.Columns[5].HeaderText = formsEn.clientTelephone;
                DataGrid.Columns[6].HeaderText = formsEn.clientMobile;
            }
            else 
            {
                DataGrid.Columns[1].HeaderText = formsAr.clientNameEn;
                DataGrid.Columns[2].HeaderText = formsAr.clientNameAr;
                DataGrid.Columns[3].HeaderText = formsAr.clientAddressEn;
                DataGrid.Columns[4].HeaderText = formsAr.clientAddressAr;
                DataGrid.Columns[5].HeaderText = formsAr.clientTelephone;
                DataGrid.Columns[6].HeaderText = formsAr.clientMobile;
                DataGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            }
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
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
                    int supplierId = Convert.ToInt32(DataGrid.Rows[rowId].Cells[0].Value);
                    int deleted = db.deleteSupplier(supplierId);
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

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            int rowId = Convert.ToInt32(DataGrid.CurrentCell.RowIndex);
            int supplierId = Convert.ToInt32(DataGrid.Rows[rowId].Cells[0].Value);
            UpdateSupplier UpdateSupplier = new UpdateSupplier(supplierId);
            UpdateSupplier.ShowDialog();
            loadGrid();
        }
    }
}