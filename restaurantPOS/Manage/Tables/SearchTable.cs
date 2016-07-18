﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using restaurantPOS.DataAccess;
using restaurantPOS.Properties;
using restaurantPOS.SystemSetting;

namespace restaurantPOS.Manage.Tables
{
    public partial class SearchTable : Form
    {
        private FormsMessages.formsAr formsAr = new FormsMessages.formsAr();
        private FormsMessages.formsEn formsEn = new FormsMessages.formsEn();
        private userMessages.messagesAr messagesAr = new userMessages.messagesAr();
        private userMessages.messagesEn messagesEn = new userMessages.messagesEn();
        private DataAccess.dataAccess db = new dataAccess();
        private SystemSetting.system system = new system();
        string errMsg = "";

        public SearchTable()
        {
            InitializeComponent();
        }

        private void SetLanguage()
        {
            if (Settings.Default.Language == "En")
            {
                lblHeader.Text = formsEn.searchTable;
                btnSearch.Text = formsEn.btnSearch;
                btnDelete.Text = formsEn.btnDelete;
                btnClear.Text = formsEn.btnClear;
                btnUpdate.Text = formsEn.btnUpdate;
                lblNameArabicAr.Visible = false;
                lblNameEnglishAr.Visible = false;
                lblChairNumberAr.Visible = false;
                checkBoxIsVipAr.Visible = false;
                lblTableStatusAr.Visible = false;
                dropDownTableStatus.Text = formsEn.tableStatus;

            }
            else
            {
                lblHeader.Text = formsAr.searchTable;
                btnSearch.Text = formsAr.btnSearch;
                btnDelete.Text = formsAr.btnDelete;
                btnClear.Text = formsAr.btnClear;
                btnUpdate.Text = formsAr.btnUpdate;
                lblNameArabic.Visible = false;
                lblNameEnglish.Visible = false;
                lblChairNumberEn.Visible = false;
                checkBoxIsVipEn.Visible = false;
                lblTableStatusEn.Visible = false;
                dropDownTableStatus.Text = formsAr.tableStatus;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear all controls
            txtTableArabic.Text = "";
            txtTableEnglish.Text = "";
            txtChairNumber.Text = "";
            checkBoxIsVipAr.Checked = false;
            checkBoxIsVipEn.Checked = false;
            dropDownTableStatus.Text = Settings.Default.Language == "En" ? formsEn.tableStatus : formsAr.tableStatus;
            LoadGrid();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void SearchTable_Load(object sender, EventArgs e)
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
            var con = new SqlConnection(ConfigurationManager.ConnectionStrings["restaurantDB"].ConnectionString);
            var dt = new DataTable();
            using (var cmd = new SqlCommand(@"SELECT * FROM dineIn_tables_status", con))
            {
                if (con.State != ConnectionState.Open)
                    con.Open();
                dt.Load(cmd.ExecuteReader());
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
            for (var row = 0; row < dt.Rows.Count; row++)
            {
                if (Settings.Default.Language == "En")
                {
                    dropDownTableStatus.Properties.Items.Add(new ListItem(dt.Rows[row].ItemArray[1].ToString(),
                        dt.Rows[row].ItemArray[0].ToString()));
                }
                else
                {
                    dropDownTableStatus.Properties.Items.Add(new ListItem(dt.Rows[row].ItemArray[2].ToString(),
                        dt.Rows[row].ItemArray[0].ToString()));
                }
            }
            SetLanguage();
            LoadGrid();
        }

        private void LoadGrid()
        {
            int? selectedStatus = 0;
            //string statusColorSelected = statusColorPick.Color.ToArgb() == 0 ? null : statusColorPick.Color.ToArgb().ToString(CultureInfo.InvariantCulture);
            if ((string) dropDownTableStatus.SelectedItem != formsEn.tableStatus && (string) dropDownTableStatus.SelectedItem != formsAr.tableStatus)
            {
                selectedStatus = Convert.ToInt32(((ListItem)(dropDownTableStatus.SelectedItem)).Value);                
            }
            else
            {
                selectedStatus = null;
            }
            bool isVip = false;
            if (Settings.Default.Language == "En" && checkBoxIsVipEn.Checked)
                isVip = true;
            else if (Settings.Default.Language == "Ar" && checkBoxIsVipAr.Checked)
                isVip = true;

            DataTable unitsDT = db.getTable(txtTableEnglish.Text, txtTableArabic.Text, txtChairNumber.Text, isVip, selectedStatus);
            DataGrid.DataSource = unitsDT;
            DataGrid.Columns[0].Visible = false;
            if (Settings.Default.Language == "En")
            {
                DataGrid.Columns[1].HeaderText = formsEn.tableNameEn;
                DataGrid.Columns[2].HeaderText = formsEn.tableNameAr;
                DataGrid.Columns[3].HeaderText = formsEn.chairNumber;
                DataGrid.Columns[3].HeaderText = formsEn.isVip;
                DataGrid.Columns[3].HeaderText = formsEn.tableStatus;
            }
            else
            {
                DataGrid.Columns[1].HeaderText = formsAr.tableNameEn;
                DataGrid.Columns[2].HeaderText = formsAr.tableNameAr;
                DataGrid.Columns[3].HeaderText = formsAr.chairNumber;
                DataGrid.Columns[3].HeaderText = formsAr.isVip;
                DataGrid.Columns[3].HeaderText = formsAr.tableStatus;
                DataGrid.RightToLeft = RightToLeft.Yes;
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
                    int unitId = Convert.ToInt32(DataGrid.Rows[rowId].Cells[0].Value);
                    int deleted = db.deleteUnit(unitId);
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
            if (DataGrid.CurrentCell == null)
            {
                return;
            }
            int rowId = Convert.ToInt32(DataGrid.CurrentCell.RowIndex);
            var updateStatus = new UpdateStatus(Convert.ToInt32(DataGrid.Rows[rowId].Cells[0].Value), DataGrid.Rows[rowId].Cells[1].Value.ToString(), DataGrid.Rows[rowId].Cells[2].Value.ToString(), DataGrid.Rows[rowId].Cells[3].Value.ToString());
            updateStatus.ShowDialog();
            LoadGrid();
        }

        private void DataGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //foreach (DataGridViewRow row in DataGrid.Rows)
            //{
            //    var clr = Color.FromArgb(Convert.ToInt32(row.Cells[3].Value.ToString()));
            //    if (clr.A == 0) continue;
            //    row.Cells[3].Style.BackColor = clr;
            //    row.Cells[3].Style.ForeColor = clr;
            //    row.Cells[3].Value = "";
            //}
            DataGrid.Rows[0].Cells[3].Style.BackColor = Color.Red;
            DataGrid.Rows[0].Cells[3].Style.ForeColor = Color.Red;
            

        }

        private void txtTableEnglish_TextChanged(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void txtTableArabic_TextChanged(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void txtChairNumber_TextChanged(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void dropDownTableStatus_TextChanged(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void checkBoxIsVipEn_CheckedChanged(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void checkBoxIsVipAr_CheckedChanged(object sender, EventArgs e)
        {
            LoadGrid();
        }
    }
}