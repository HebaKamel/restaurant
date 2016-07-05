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
using restaurantPOS.Properties;
using restaurantPOS.SystemSetting;
using restaurantPOS.userMessages;

namespace restaurantPOS
{
    public partial class POSCategories : Form
    {

        public string systemLang, userName;
        public POSCategories()
        {
            InitializeComponent();
            this.systemLang = Settings.Default.Language;
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
                //if (systemLang == "En")
                //    XtraMessageBox.Show(messagesEn.fontsError, system.restName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //else
                //    XtraMessageBox.Show(messagesAr.fontsError, system.restName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //don't allow focus
            btnDelivery.AllowFocus = false;
            btnDineIn.AllowFocus = false;
            btnPickUp.AllowFocus = false;
            btnTakeAway.AllowFocus = false;
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {

        }

        private void btnDineIn_Click(object sender, EventArgs e)
        {

        }

        private void btnTakeAway_Click(object sender, EventArgs e)
        {

        }

        private void btnPickUp_Click(object sender, EventArgs e)
        {

        }
    }
}
