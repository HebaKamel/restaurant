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

namespace restaurantPOS.Manage.Supplier
{
    public partial class UpdateSupplier : Form
    {
        private FormsMessages.formsAr formsAr = new FormsMessages.formsAr();
        private FormsMessages.formsEn formsEn = new FormsMessages.formsEn();
        private userMessages.messagesAr messagesAr = new userMessages.messagesAr();
        private userMessages.messagesEn messagesEn = new userMessages.messagesEn();
        private DataAccess.dataAccess db = new dataAccess();
        private SystemSetting.system system = new system();
        int supplierId;
        string errMsg = "";

        public UpdateSupplier(int supplierId)
        {
            InitializeComponent();
            this.supplierId = supplierId;
        }

        private void UpdateSupplier_Load(object sender, EventArgs e)
        {
            setLanguage();
            DataTable supplierDT = db.getSupplier(null, null, null, null, null, null, this.supplierId);
            if (supplierDT.Rows.Count > 0)
            {
                txtNameEnglish.Text = supplierDT.Rows[0]["supplier_name_en"].ToString();
                txtNameArabic.Text = supplierDT.Rows[0]["supplier_name_ar"].ToString();
                txtAddrEnglish.Text = supplierDT.Rows[0]["supplier_address_en"].ToString();
                txtAddrArabic.Text = supplierDT.Rows[0]["supplier_address_ar"].ToString();
                txtLandLine.Text = supplierDT.Rows[0]["supplier_telephone_no"].ToString();
                txtMobile.Text = supplierDT.Rows[0]["supplier_mobile_no"].ToString();
            }
        }
        private void setLanguage()
        {
            if (Settings.Default.Language == "En")
            {
                lblClientHeader.Text = formsEn.AddSupplierHeader;
                btnUpdate.Text = formsEn.btnUpdate;
                lblNameArabicAr.Visible = false;
                lblNameEnglishAr.Visible = false;
                lblAddrArabicAr.Visible = false;
                lblAddrEnglishAr.Visible = false;
                lblLandLineAr.Visible = false;
                lblMobileAr.Visible = false;
            }
            else
            {
                lblClientHeader.Text = formsAr.AddSupplierHeader;
                btnUpdate.Text = formsAr.btnUpdate;
                lblNameArabic.Visible = false;
                lblNameEnglish.Visible = false;
                lblAddrArabic.Visible = false;
                lblAddrEnglish.Visible = false;
                lblLandLine.Visible = false;
                lblMobile.Visible = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (validation() == "")
            {
                int updated = db.updateSupplier(txtNameEnglish.Text, txtNameArabic.Text, txtAddrEnglish.Text,
                                              txtAddrArabic.Text, txtLandLine.Text, txtMobile.Text, this.supplierId);
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
    }
}
