using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;

namespace restaurantPOS
{
    class CustomFunctions
    {
        static readonly PrivateFontCollection pfc = new PrivateFontCollection();
        const string fontNameblue = "recharge bd.ttf";
        const string fontNamerechargebd = "blue.ttf";

        public static void ChangeTabControlFontTo12(Control thisForm)
        {
            pfc.AddFontFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), fontNamerechargebd));
            pfc.AddFontFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), fontNameblue));
            AllSubControls(thisForm).OfType<TabControl>().ToList().ForEach(o => o.Font = new Font(pfc.Families[0], (float)12));
        }

        public static void ChangeLabelControlFontTo85(Control thisForm)
        {
            pfc.AddFontFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), fontNamerechargebd));
            pfc.AddFontFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), fontNameblue));
            AllSubControls(thisForm).OfType<LabelControl>().ToList().ForEach(o => o.Font = new Font(pfc.Families[0], (float)8.5));
        }

        public static void ChangeLabelControlFontTo12(Control thisForm)
        {
            pfc.AddFontFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), fontNamerechargebd));
            pfc.AddFontFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), fontNameblue));
            AllSubControls(thisForm).OfType<LabelControl>().ToList().ForEach(o => o.Font = new Font(pfc.Families[0], (float)12));
        }

        public static void ChangeLabelControlFontTo11(Control thisForm)
        {
            pfc.AddFontFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), fontNamerechargebd));
            pfc.AddFontFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), fontNameblue));
            AllSubControls(thisForm).OfType<LabelControl>().ToList().ForEach(o => o.Font = new Font(pfc.Families[0], (float)11));
        }

        public static void ChangeGelButtonFontTo10(Control thisForm)
        {
            pfc.AddFontFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), fontNamerechargebd));
            pfc.AddFontFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), fontNameblue));
            AllSubControls(thisForm).OfType<GelButton>().ToList().ForEach(o => o.Font = new Font(pfc.Families[1], (float)10));
        }

        public static void ChangeToolStripMenuItemFontTo9(Control thisForm)
        {
            pfc.AddFontFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), fontNamerechargebd));
            pfc.AddFontFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), fontNameblue));
            foreach (Control control in thisForm.Controls)
            {
                if (control.Name.ToLower().Contains("group"))
                {
                    foreach (Control control1 in control.Controls)
                    {
                        if (control1.Name.ToLower().Contains("menu"))
                        {
                            //pfc.AddFontFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), fontNameblue));
                            control.Font = new Font(pfc.Families[1], 9, FontStyle.Regular);
                        }
                    }
                }

            }
        }

        private static List<Control> AllSubControls(Control control)
        {
            var list = control.Controls.OfType<Control>().ToList();
            var deep = list.Where(o => o.Controls.Count > 0).SelectMany(AllSubControls).ToList();
            list.AddRange(deep);
            return list;
        }
    }
}
