using System;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;using DevExpress.XtraEditors;
using restaurantPOS.DataAccess;
using restaurantPOS.FormsMessages;
using restaurantPOS.Properties;
using restaurantPOS.SystemSetting;
using restaurantPOS.userMessages;

namespace restaurantPOS
{
    public partial class FrmMainForm : XtraForm
    {
        private formsEn formsEn = new formsEn();
        private formsAr formsAr = new formsAr();
        private dataAccess db = new dataAccess();
        private systemAuth systemAuth = new systemAuth();
        private system system = new system();
        private messagesEn messagesEn = new messagesEn();
        private messagesAr messagesAr = new messagesAr();
        private DataTable user, role;
        public string systemLang, userName;
        private int _duration;

        public FrmMainForm(DataTable user)
        {
            InitializeComponent();
            this.systemLang = Settings.Default.Language;
            userName = Settings.Default.UserName;//user.Rows[0]["users_name"].ToString();
            lblUserNameMainForm.Text = userName;
            this.user = user;
            role = db.getRole((int)user.Rows[0]["role_id"]);
            
            if (this.systemLang == "En")
            {
                Text = @"Estoda Cheese King - " + formsEn.mainForm;
                lblUserRoleMainForm.Text = role.Rows[0]["role_name_en"].ToString();
            }
            else
            {
                btnTickets.BackgroundImage = Properties.Resources.ticketsArabic;
                btnPOS.BackgroundImage = Properties.Resources.template_button_POS2new_arabic;
                btnWorkPeriods.BackgroundImage = Properties.Resources.template_button_workperiod_arabic;
                btnMenu.BackgroundImage = Properties.Resources.template_button_Menu_arabic;
                btnWarehouses.BackgroundImage = Properties.Resources.template_button_warehouse_arabic;
                btnAccounts.BackgroundImage = Properties.Resources.template_button_Accounts_Arabic;
                btnLogout.BackgroundImage = Properties.Resources.template_button_logout2_arabic;
                btnManage.BackgroundImage = Properties.Resources.template_button_settings_arabic;
                btnReports.BackgroundImage = Properties.Resources.template_button_reportspsd_arabic;
                Text = formsAr.mainForm;
                lblUserRoleMainForm.Text = role.Rows[0]["role_name_ar"].ToString();
            }
            Settings.Default.UserRole = lblUserRoleMainForm.Text;
            Settings.Default.Save();
            checkPermissions();


            
        }

        private void FrmMainForm_Load(object sender, EventArgs e)
        {
            //don't allow focus
            btnAccounts.AllowFocus = false;
            btnAccounts.AllowFocus = false;
            btnLogout.AllowFocus = false;
            btnManage.AllowFocus = false;
            btnPOS.AllowFocus = false;
            btnReports.AllowFocus = false;
            btnMenu.AllowFocus = false;
            btnTickets.AllowFocus = false;
            btnWarehouses.AllowFocus = false;
            btnWorkPeriods.AllowFocus = false;
            //use custom font
            //pfc.AddFontFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), fontNameblue));
            //menuStrip1.Font = new Font(pfc.Families[0], 9, FontStyle.Regular);
            //lblUserRoleMainForm.Font = new Font(pfc.Families[0], 7, FontStyle.Bold);
            //lblDateTimeMainForm.Font = new Font(pfc.Families[0], 9, FontStyle.Regular);
            //lblUserNameMainForm.Font = new Font(pfc.Families[0], 9, FontStyle.Regular);
            //lblCopyRightsMainForm.Font = new Font(pfc.Families[0], 9, FontStyle.Regular);
            var pfc = new PrivateFontCollection();
            const string fontNameblue = "recharge bd.ttf";
            const string fontNamerechargebd = "blue.ttf";
            if (File.Exists(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), fontNamerechargebd)) && File.Exists(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), fontNameblue)))
            {
                foreach (Control control in Controls)
                {
                    if (control.Name.ToLower().Contains("split"))
                    {
                        foreach (Control subControl in control.Controls[0].Controls)
                        {
                            pfc.AddFontFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), fontNamerechargebd));
                            subControl.Font = new Font(pfc.Families[0], 28, FontStyle.Regular);
                        }
                        foreach (Control subControl in control.Controls[1].Controls)
                        {
                            if (subControl.Name.ToLower().Contains("role"))
                            {
                                pfc.AddFontFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), fontNameblue));
                                subControl.Font = new Font(pfc.Families[0], 8, FontStyle.Regular);
                            }
                            pfc.AddFontFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), fontNameblue));
                            subControl.Font = new Font(pfc.Families[0], 9, FontStyle.Regular);
                        }
                    }
                    if (control.Name.ToLower().Contains("menu"))
                    {
                        pfc.AddFontFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), fontNameblue));
                        control.Font = new Font(pfc.Families[0], 9, FontStyle.Regular);
                    }
                }
            }
            else
            {
                if (systemLang == "En")
                    XtraMessageBox.Show(messagesEn.fontsError, system.restName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    XtraMessageBox.Show(messagesAr.fontsError, system.restName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }}

        private void FrmMainForm_Activated(object sender, EventArgs e)
        {
            timerIdle.Stop();
            _duration = 0;
            timerIdle.Start();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        
        private void timerIdle_Tick(object sender, EventArgs e){
            //lblCopyRights.Text = (_duration/60).ToString();
            _duration++;
            if (_duration / 60 > 5)
                Application.Restart();
        }

        private void timerTimeDate_Tick(object sender, EventArgs e)
        {
            //lblDateTimeMainForm.Text = DateTime.Now.ToString("dd MMMM yyyy hh:mm:ss tt");
        }

        private void menuStrip1_Click(object sender, EventArgs e)
        {
            timerIdle.Stop();
            _duration = 0;
            timerIdle.Start();
        }

        #region buttons clicks
        private void btnWorkPeriods_Click(object sender, EventArgs e)
        {
            timerIdle.Stop();
            _duration = 0;
            timerIdle.Start();
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            timerIdle.Stop();
            _duration = 0;
            timerIdle.Start();

            var posCatObj = new POSCategories();
            posCatObj.Show();
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            timerIdle.Stop();
            _duration = 0;
            timerIdle.Start();
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            timerIdle.Stop();
            _duration = 0;
            timerIdle.Start();
        }

        private void btnWarehouses_Click(object sender, EventArgs e)
        {
            timerIdle.Stop();
            _duration = 0;
            timerIdle.Start();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            timerIdle.Stop();
            _duration = 0;
            timerIdle.Start();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            timerIdle.Stop();
            _duration = 0;
            timerIdle.Start();
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            timerIdle.Stop();
            _duration = 0;

            if (Application.OpenForms["FrmManage"] != null)
            {
                Application.OpenForms["FrmManage"].Show();
                Hide();
            }
            else
            {
                var frm1Obj = new FrmManage();
                frm1Obj.Show(this);
                Hide();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        #endregion

        #region menu items clicks
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnLogout_Click(sender,e);
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnReports_Click(sender,e);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnManage_Click(sender, e);
        }
        #endregion

        
        private void checkPermissions()
        {
            int auth = db.checkRoleAuth((int)role.Rows[0]["role_id"], systemAuth.manage).Rows.Count;
            if (auth <= 0)
                btnManage.Enabled = false;

            auth = db.checkRoleAuth((int)role.Rows[0]["role_id"], systemAuth.accounts).Rows.Count;
            if (auth <= 0)
                btnAccounts.Enabled = false;

            auth = db.checkRoleAuth((int)role.Rows[0]["role_id"], systemAuth.pos).Rows.Count;
            if (auth <= 0)
                btnPOS.Enabled = false;

            auth = db.checkRoleAuth((int)role.Rows[0]["role_id"], systemAuth.reports).Rows.Count;
            if (auth <= 0)
                btnReports.Enabled = false;

            auth = db.checkRoleAuth((int)role.Rows[0]["role_id"], systemAuth.tickets).Rows.Count;
            if (auth <= 0)
                btnTickets.Enabled = false;

            auth = db.checkRoleAuth((int)role.Rows[0]["role_id"], systemAuth.warhouses).Rows.Count;
            if (auth <= 0)
                btnWarehouses.Enabled = false;

            auth = db.checkRoleAuth((int)role.Rows[0]["role_id"], systemAuth.workPeriods).Rows.Count;
            if (auth <= 0)
                btnWorkPeriods.Enabled = false;

            auth = db.checkRoleAuth((int)role.Rows[0]["role_id"], systemAuth.menu).Rows.Count;
            if (auth <= 0)
                btnMenu.Enabled = false;
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["AboutForm"] != null)
            {
                Application.OpenForms["AboutForm"].Show();
                //Hide();
            }
            else
            {
                var aboutFormObj = new AboutForm();
                aboutFormObj.Show(this);
                //Hide();
            }
        }

        private void addTipsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string tipsAmount = Microsoft.VisualBasic.Interaction.InputBox("Insert Amount of Tips", "Tips", "0.0");
            if (Regex.IsMatch(tipsAmount, @"\D+"))
            {
                MessageBox.Show(@"Error: Must enter digits only !!",@"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

    }
}