using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.IO;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using restaurantPOS.DataAccess;
using restaurantPOS.Properties;
using restaurantPOS.SystemSetting;
using ComboBox = System.Windows.Forms.ComboBox;

namespace restaurantPOS.Manage.Tables
{
    public partial class AddTable : Form
    {
        private FormsMessages.formsAr formsAr = new FormsMessages.formsAr();
        private FormsMessages.formsEn formsEn = new FormsMessages.formsEn();
        private userMessages.messagesAr messagesAr = new userMessages.messagesAr();
        private userMessages.messagesEn messagesEn = new userMessages.messagesEn();
        private DataAccess.dataAccess db = new dataAccess();
        private SystemSetting.system system = new system();
        string errMsg = "";

        public AddTable()
        {
            InitializeComponent();
        }

        private void AddTable_Load(object sender, EventArgs e)
        {
            setLanguage();
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

            //var db = 
        }

        private void setLanguage()
        {
            if (Settings.Default.Language == "En")
            {
                lblAddHeader.Text = formsEn.status;
                btnAdd.Text = formsEn.btnAdd;
                btnClear.Text = formsEn.btnClear;
                lblNameArabicAr.Visible = false;
                lblNameEnglishAr.Visible = false;
                lblChairNumberAr.Visible = false;
                checkBoxIsVipAr.Visible = false;
                lblTableStatusAr.Visible = false;
                dropDownTableStatus.Text = formsEn.tableStatus;
            }
            else
            {
                lblAddHeader.Text = formsAr.status;
                btnAdd.Text = formsAr.btnAdd;
                btnClear.Text = formsAr.btnClear;
                lblNameArabic.Visible = false;
                lblNameEnglish.Visible = false;
                lblChairNumberEn.Visible = false;
                checkBoxIsVipEn.Visible = false;
                lblTableStatusEn.Visible = false;
                dropDownTableStatus.Text = formsAr.tableStatus;
            }
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var selectedStatus = Convert.ToInt32(((ListItem)(dropDownTableStatus.SelectedItem)).Value);
            if (Validation() == messagesEn.ErrorMessae)
            {
                bool isVip = false;
                if (Settings.Default.Language == "En" && checkBoxIsVipEn.Checked)
                    isVip = true;
                else if (Settings.Default.Language == "Ar" && checkBoxIsVipAr.Checked)
                    isVip = true;

                int tableId = db.addTable(txtTableEnglish.Text, txtTableArabic.Text, Convert.ToInt32(txtChairNumber.Text), isVip, selectedStatus);
                if (tableId != 0)
                    XtraMessageBox.Show(messagesEn.insertedSuccessfully, system.restName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                else
                    XtraMessageBox.Show(messagesEn.insertedError, system.restName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                XtraMessageBox.Show(errMsg, system.restName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            btnClear_Click(sender, e);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTableArabic.Text = "";
            txtTableEnglish.Text = "";
            txtChairNumber.Text = "";
            checkBoxIsVipAr.Checked = false;
            checkBoxIsVipEn.Checked = false;
            dropDownTableStatus.Text = Settings.Default.Language == "En" ? formsEn.tableStatus : formsAr.tableStatus;
        }

    }
}