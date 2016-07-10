using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace restaurantPOS
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            picClose.Properties.AllowFocused = false;
            picDeleteSign.Properties.AllowFocused = false;
            picMinusSign.Properties.AllowFocused = false;
            picPlusSign.Properties.AllowFocused = false;
            picVoid.Properties.AllowFocused = false;

            var pfc = new PrivateFontCollection();
            const string fontNameblue = "recharge bd.ttf";
            const string fontNamerechargebd = "blue.ttf";
            pfc.AddFontFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), fontNamerechargebd));
            pfc.AddFontFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), fontNameblue));
            //Font = new Font(pfc.Families[0],7);
            AllSubControls(this).OfType<TabControl>().ToList().ForEach(o => o.Font = new Font(pfc.Families[0], (float)8.5));
            AllSubControls(this).OfType<GelButton>().ToList().ForEach(o => o.Font = new Font(pfc.Families[1], (float)10));
        }
        private static List<Control> AllSubControls(Control control)
        {
            var list = control.Controls.OfType<Control>().ToList();
            var deep = list.Where(o => o.Controls.Count > 0).SelectMany(AllSubControls).ToList();
            list.AddRange(deep);
            return list;
        }
        private void btnMainForm_Click(object sender, EventArgs e)
        {

            var fc = Application.OpenForms["FrmMainForm"];
            if (fc != null)
            {
                fc.Show();
                Hide();
            }
        }
    }
}
