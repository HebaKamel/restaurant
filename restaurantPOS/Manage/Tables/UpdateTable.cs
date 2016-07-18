using System.Web.UI.WebControls;
using DevExpress.XtraEditors;
using restaurantPOS.DataAccess;
using restaurantPOS.Properties;
using restaurantPOS.SystemSetting;
using System;
using System.Windows.Forms;

namespace restaurantPOS.Manage.Tables
{
    public partial class UpdateTable : Form
    {
        private FormsMessages.formsAr formsAr = new FormsMessages.formsAr();
        private FormsMessages.formsEn formsEn = new FormsMessages.formsEn();
        private userMessages.messagesAr messagesAr = new userMessages.messagesAr();
        private userMessages.messagesEn messagesEn = new userMessages.messagesEn();
        private DataAccess.dataAccess db = new dataAccess();
        private SystemSetting.system system = new system();
        int statusId;
        private string statusNameEn, statusNameAr;
        private string errMsg = "";
        private int chairNumber, selectedStatus;
        private bool isVip;
        public UpdateTable(int statusId, string statusNameEn, string statusNameAr, int  chairNumber,bool isVip,int selectedStatus)
        {
            InitializeComponent();
            this.statusId = statusId;
            this.statusNameEn = statusNameEn;
            this.statusNameAr = statusNameAr;
            this.chairNumber = chairNumber;
            this.isVip = isVip;
            this.selectedStatus = selectedStatus;
        }

        private void UpdateTable_Load(object sender, EventArgs e)
        {
            SetLanguage();
           // txtNameEnglish.Text = statusNameEn;
           // txtNameArabic.Text = statusNameAr;
            //statusColor;
        }

        private void SetLanguage()
        {
            if (Settings.Default.Language == "En")
            {
                lblHeader.Text = formsEn.updateTable;
                //btnSearch.Text = formsEn.btnSearch;
                btnUpdate.Text = formsEn.btnUpdate;
                //btnDelete.Text = formsEn.btnDelete;
                //btnClear.Text = formsEn.btnClear;
                lblNameArabicAr.Visible = false;
                lblNameEnglishAr.Visible = false;
                lblChairNumberAr.Visible = false;
                checkBoxIsVipAr.Visible = false;
                lblTableStatusAr.Visible = false;
                dropDownTableStatus.Text = formsEn.tableStatus;
            }
            else
            {
                lblHeader.Text =formsAr.updateTable;
                //btnSearch.Text =formsAr.btnSearch;
                btnUpdate.Text = formsAr.btnUpdate;
                //btnDelete.Text = formsAr.btnDelete;
                //btnClear.Text = formsAr.btnClear;
                lblNameArabic.Visible = false;
                lblNameEnglish.Visible = false;
                lblChairNumberEn.Visible = false;
                checkBoxIsVipEn.Visible = false;
                lblTableStatusEn.Visible = false;
                dropDownTableStatus.Text = formsAr.tableStatus;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (Validation() == messagesEn.ErrorMessae)
            {
                bool isVip = false;
                if (Settings.Default.Language == "En" && checkBoxIsVipEn.Checked)
                    isVip = true;
                else if (Settings.Default.Language == "Ar" && checkBoxIsVipAr.Checked)
                    isVip = true;
                var selectedStatus = Convert.ToInt32(((ListItem)(dropDownTableStatus.SelectedItem)).Value);

                int updated = db.UpdateTable(txtTableEnglish.Text, txtTableArabic.Text, txtChairNumber.Text, isVip, selectedStatus);
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
                        XtraMessageBox.Show(messagesEn.updatedError, system.restName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    else
                        XtraMessageBox.Show(messagesAr.updatedError, system.restName, MessageBoxButtons.OK,  MessageBoxIcon.Asterisk);
                }
                Close();
            }
            else
                XtraMessageBox.Show(errMsg, system.restName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private string Validation()
        {
            errMsg = messagesEn.ErrorMessae;
            string name = "", color = "";
            if (string.IsNullOrEmpty(txtTableEnglish.Text))
            {
                if (Settings.Default.Language == "En")
                    name = formsEn.tableNameEn;
                else
                    name = formsAr.tableNameEn;
                errMsg += "\n" + name;
            }
            if (string.IsNullOrEmpty(txtTableArabic.Text))
            {
                if (Settings.Default.Language == "En")
                    name = formsEn.tableNameAr;
                else
                    name = formsAr.tableNameAr;
                errMsg += "\n" + name;
            }
            if (string.IsNullOrEmpty(txtChairNumber.Text))
            {
                if (Settings.Default.Language == "En")
                    color = formsEn.chairNumber;
                else
                    color = formsAr.chairNumber;
                errMsg += "\n" + color;
            }
            //if (dropDownTableStatus.Text == @"Table Status")
            //{
            //    if (Settings.Default.Language == "En")
            //        color = formsEn.tableStatus;
            //    else
            //        color = formsAr.tableStatus;
            //    errMsg += "\n" + color;
            //}

            return errMsg;
        }

    }
}
