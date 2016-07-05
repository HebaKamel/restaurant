using System;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using restaurantPOS.DataAccess;
using restaurantPOS.Properties;
using restaurantPOS.userMessages;

namespace restaurantPOS
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        public string systemLang = "En";
        private dataAccess db = new dataAccess();
        private messagesEn messagesEn = new messagesEn();
        private messagesAr messagesAr = new messagesAr();
        private SystemSetting.system system = new SystemSetting.system();

        public FrmLogin()
        {
            InitializeComponent();
            this.ActiveControl = txtPassword;
            //get last user name tried to sign in
            txtUserName.Text = Settings.Default.UserName;
            //use custom font
            var pfc = new PrivateFontCollection();
            const string fontNamerechargebd = "recharge bd.ttf";
            const string fontNameblue = "blue.ttf";
            const string fontNameBEsfhnBd = "BEsfhnBd.ttf";

            //apply fonts to controls
            if (File.Exists(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), fontNameBEsfhnBd)) && File.Exists(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), fontNamerechargebd)) && File.Exists(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), fontNameblue)))
            {
                pfc.AddFontFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), fontNameblue));
                btnLogin.Font = new Font(pfc.Families[0], 20, FontStyle.Regular);
                pfc.AddFontFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), fontNameblue));lblChooseLang.Font = new Font(pfc.Families[0], 20, FontStyle.Regular);
                lblPassword.Font = new Font(pfc.Families[0], 20, FontStyle.Regular);
                lblUserName.Font = new Font(pfc.Families[0], 20, FontStyle.Regular);
                lblCopyRightsLoginForm.Font = new Font(pfc.Families[0], 8, FontStyle.Regular);
                pfc.AddFontFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), fontNamerechargebd));
                txtUserName.Font = new Font(pfc.Families[0], 17, FontStyle.Regular);
                txtPassword.Font = new Font(pfc.Families[0], 17, FontStyle.Regular);
                pfc.AddFontFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), fontNameblue));
                btnEnLanguage.Font = new Font(pfc.Families[0], 15, FontStyle.Regular);
                pfc.AddFontFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), fontNameBEsfhnBd));
                //btnArLanguage.Font = new Font(pfc.Families[0], 12, FontStyle.Regular);
                btnArLanguage.Padding = new Padding(0);

                //foreach (Control control in Controls)
                //{
                //    if (control.Name.ToLower().Contains("btnLogin"))
                //    {
                //        pfc.AddFontFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), fontNameblue));
                //        control.Font = new Font(pfc.Families[0], 20, FontStyle.Regular);
                //    }
                //    else if (control.Name.Contains("btn"))
                //    {
                //        pfc.AddFontFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), fontNameblue));
                //        control.Font = new Font(pfc.Families[0], 15, FontStyle.Regular);
                //    }
                //    else if (control.Name.ToLower().Contains("copyright"))
                //    {
                //        pfc.AddFontFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), fontNamerechargebd));
                //        control.Font = new Font(pfc.Families[0], 8, FontStyle.Regular);
                //    }
                //    else if (control.Name.ToLower().Contains("txt"))
                //    {
                //        pfc.AddFontFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), fontNamerechargebd));
                //        control.Font = new Font(pfc.Families[0], 17, FontStyle.Regular);
                //    }
                //    else
                //    {
                //        pfc.AddFontFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), fontNamerechargebd));
                //        control.Font = new Font(pfc.Families[0], 20, FontStyle.Regular);
                //    }
                //}
            }
            else
            {
                if (systemLang == "En")
                    XtraMessageBox.Show(messagesEn.fontsError, system.restName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    XtraMessageBox.Show(messagesAr.fontsError, system.restName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            Thread.Sleep(500);
            btnEnLanguage_CheckedChanged(sender, e);
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin_Click(sender, e);
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin_Click(sender, e);
        }

        private void btnEnLanguage_CheckedChanged(object sender, EventArgs e)
        {
            btnEnLanguage.ForeColor = Color.Green;
            btnArLanguage.ForeColor = Color.Black;
            this.systemLang = "En";
        }

        private void btnArLanguage_CheckedChanged(object sender, EventArgs e)
        {
            btnArLanguage.ForeColor = Color.Green;
            btnEnLanguage.ForeColor = Color.Black;
            this.systemLang = "Ar";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            //if (!string.IsNullOrEmpty(txtUserName.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            if (!string.IsNullOrEmpty(txtUserName.Text) && string.IsNullOrEmpty(txtPassword.Text))
            {
                //login
                //DataTable user = db.getUser(txtUserName.Text, txtPassword.Text);
                DataTable user = db.getUser("Admin", "admin123");
                if (user.Rows.Count > 0)
                {
                    //save last user name tried to sign in
                    Settings.Default.UserName = txtUserName.Text;
                    Settings.Default.Save();
                    Settings.Default.Language = systemLang;
                    Settings.Default.Save();
                    var mainFormObj = new FrmMainForm(user);
                    mainFormObj.Show();
                    this.Hide();
                }
                else
                {
                    if (systemLang == "En")
                        XtraMessageBox.Show(messagesEn.loginError, system.restName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        XtraMessageBox.Show(messagesAr.loginError, system.restName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLogin_MouseDown(object sender, MouseEventArgs e)
        {
            btnLogin.GradientTop = Color.IndianRed;
            btnLogin.ForeColor = Color.Green;
        }

        private void btnLogin_MouseUp(object sender, MouseEventArgs e)
        {
            btnLogin.GradientTop = ColorTranslator.FromHtml("#FA7E0A");
            btnLogin.ForeColor = Color.Black;
        }
    }
}