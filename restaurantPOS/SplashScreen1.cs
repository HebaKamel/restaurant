using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

namespace restaurantPOS
{
    public partial class SplashScreen1 : SplashScreen
    {
        public SplashScreen1()
        {
            InitializeComponent();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        private void SplashScreen1_Load(object sender, EventArgs e)
        {
            labelDate.ForeColor = Color.LightSalmon;
            labelDate.Text = string.Format("{0} {1} {2}{3}{4}",DateTime.Now.ToString("dd"),DateTime.Now.ToString("MMMM"),DateTime.Now.ToString("yyyy"),Environment.NewLine,DateTime.Now.ToString("hh:mm tt"));
        }

    }
}