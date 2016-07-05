﻿using System;
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
    public partial class SearchClients : Form
    {
        private FormsMessages.formsAr formsAr = new FormsMessages.formsAr();
        private FormsMessages.formsEn formsEn = new FormsMessages.formsEn();
        private userMessages.messagesAr messagesAr = new userMessages.messagesAr();
        private userMessages.messagesEn messagesEn = new userMessages.messagesEn();
        private DataAccess.dataAccess db = new dataAccess();
        private SystemSetting.system system = new system();
        string errMsg = "";

        public SearchClients()
        {
            InitializeComponent();
            
        }


        private void setLanguage(){
            if (Settings.Default.Language == "En")
            {
                lblSearchClientHeader.Text = formsEn.SearchClientHeader;
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
                lblSearchClientHeader.Text = formsAr.SearchClientHeader;
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

        private void SearchClients_Load(object sender, EventArgs e)
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
            DataTable clientsDT = db.getClient(txtNameEnglish.Text, txtNameArabic.Text, txtAddrEnglish.Text, txtAddrArabic.Text, txtLandLine.Text, txtMobile.Text, null);
            ClientsGrid.DataSource = clientsDT;
            ClientsGrid.Columns[0].Visible = false;
            if (Settings.Default.Language == "En")
            {
                ClientsGrid.Columns[1].HeaderText = formsEn.clientNameEn;
                ClientsGrid.Columns[2].HeaderText = formsEn.clientNameAr;
                ClientsGrid.Columns[3].HeaderText = formsEn.clientAddressEn;
                ClientsGrid.Columns[4].HeaderText = formsEn.clientAddressAr;
                ClientsGrid.Columns[5].HeaderText = formsEn.clientTelephone;
                ClientsGrid.Columns[6].HeaderText = formsEn.clientMobile;
            }
            else 
            {
                ClientsGrid.Columns[1].HeaderText = formsAr.clientNameEn;
                ClientsGrid.Columns[2].HeaderText = formsAr.clientNameAr;
                ClientsGrid.Columns[3].HeaderText = formsAr.clientAddressEn;
                ClientsGrid.Columns[4].HeaderText = formsAr.clientAddressAr;
                ClientsGrid.Columns[5].HeaderText = formsAr.clientTelephone;
                ClientsGrid.Columns[6].HeaderText = formsAr.clientMobile;
                ClientsGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
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
                    int rowId = Convert.ToInt32(ClientsGrid.CurrentCell.RowIndex);
                    int clientId = Convert.ToInt32(ClientsGrid.Rows[rowId].Cells[0].Value);
                    int deleted = db.deleteClient(clientId);
                    if (deleted == 1)
                    {
                        if (Settings.Default.Language == "En")
                            XtraMessageBox.Show(messagesEn.deletedSuccessfully, system.restName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        else
                            XtraMessageBox.Show(messagesAr.deletedSuccessfully, system.restName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        ClientsGrid.Rows.RemoveAt(rowId);
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
                    XtraMessageBox.Show(messagesEn.chooseClientRow, system.restName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    XtraMessageBox.Show(messagesAr.chooseClientRow, system.restName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            int rowId = Convert.ToInt32(ClientsGrid.CurrentCell.RowIndex);
            int clientId = Convert.ToInt32(ClientsGrid.Rows[rowId].Cells[0].Value);
            UpdateClient UpdateClient = new UpdateClient(clientId);
            UpdateClient.ShowDialog();
            loadGrid();
        }
    }
}