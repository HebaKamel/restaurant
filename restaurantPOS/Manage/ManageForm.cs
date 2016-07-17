using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using restaurantPOS.Manage;
using restaurantPOS.Manage.Tables;
using restaurantPOS.Properties;
using restaurantPOS.SystemSetting;
using restaurantPOS.userMessages;

//using DevExpress.DXCore.Controls.LookAndFeel;

namespace restaurantPOS
{
    public partial class FrmManage : Form
    {
        private SystemSetting.system system = new system();
        private userMessages.messagesEn messagesEn = new messagesEn();

        #region fromsDeclaration
        Manage.Client.AddClients addClient  = new Manage.Client.AddClients();
        Manage.Client.SearchClients searchClient = new Manage.Client.SearchClients();
        Manage.Units.AddUnits addUnit = new Manage.Units.AddUnits();
        Manage.Units.SearchUnits searchUnits = new Manage.Units.SearchUnits();
        Manage.Goods.AddGoods addGoods = new Manage.Goods.AddGoods();
        Manage.Goods.SearchGoods searchGoods = new Manage.Goods.SearchGoods();
        Manage.Supplier.AddSupplier addSupplier = new Manage.Supplier.AddSupplier();
        Manage.Supplier.SearchSupplier searchSupplier = new Manage.Supplier.SearchSupplier();
        Manage.Tables.AddTablesStatus addTablesStatus = new Manage.Tables.AddTablesStatus();
        Manage.ProgramSetting.ProgSetting progSetting = new Manage.ProgramSetting.ProgSetting();
        Manage.Tables.SearchStatus searchStatus = new SearchStatus();
        Manage.Tables.AddTable addTable = new AddTable();
        SearchTable searchTable = new SearchTable();
        #endregion

        public FrmManage()
        {
            InitializeComponent();
            lblUserRoleMainForm.Text = Settings.Default.UserRole;
            lblUserNameManage.Text = Properties.Settings.Default.UserName;
            menuStripLeft.Renderer = new MyRenderer();
            menuStripRight.Renderer = new MyRenderer();
            //use custom font
            var pfc = new PrivateFontCollection();
            const string fontNamerechargebd = "recharge bd.ttf";
            const string fontNameblue = "blue.ttf";
            //if (File.Exists(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), fontNamerechargebd)) && File.Exists(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), fontNameblue)))
            //{

                //pfc.AddFontFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), fontNameblue));
                //menuStripLeft.Font = new Font(pfc.Families[0], 9, FontStyle.Regular);
                //menuStripRight.Font = new Font(pfc.Families[0], 9, FontStyle.Regular);
                //lblUserNameManage.Font = new Font(pfc.Families[0], 10, FontStyle.Regular);
                //lblDateTimeManage.Font = new Font(pfc.Families[0], 10, FontStyle.Regular);
                //lblCopyRightsManage.Font = new Font(pfc.Families[0], 8, FontStyle.Regular);
                //foreach (Control control in Controls)
                //{
                //    if (control.Name.ToLower().Contains("menu"))
                //    {
                //        pfc.AddFontFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), fontNameblue));
                //        control.Font = new Font(pfc.Families[0], 9, FontStyle.Regular);
                //    }
                //    if (control.Name.ToLower().Contains("groupControlBottom"))
                //    {
                //        foreach (Control grpControl in control.Controls)
                //        {
                //            if (grpControl.Name.ToLower().Contains("role"))
                //            {
                //                pfc.AddFontFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), fontNameblue));
                //                grpControl.Font = new Font(pfc.Families[0], 8, FontStyle.Regular);
                //            }
                //            pfc.AddFontFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), fontNameblue));
                //            grpControl.Font = new Font(pfc.Families[0], 9, FontStyle.Regular);
                //        }

                //    }
                //}
            //}
            //else
            //    XtraMessageBox.Show(messagesEn.fontsError, system.restName, MessageBoxButtons.OK, MessageBoxIcon.Error);

            //#region customize nav bar fonts
            //foreach (DevExpress.XtraNavBar.NavBarGroup group in navBarControlLeft.Groups)
            //{
            //    pfc.AddFontFile(Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), fontNameblue));
            //    group.Appearance.Font = new Font(pfc.Families[0], 9, FontStyle.Regular);
                
            //}

            //foreach (DevExpress.XtraNavBar.NavBarItem item in navBarControlLeft.Items)
            //{
            //    item.Appearance.Font = new Font(pfc.Families[0], 9, FontStyle.Regular);
            //}
            //#endregion
        }

        private class MyRenderer : ToolStripProfessionalRenderer
        {
            public MyRenderer() : base(new MyColors()) { }
        }

        private class MyColors : ProfessionalColorTable
        {
            public override Color MenuItemSelected
            {
                get { return ColorTranslator.FromHtml("#F7F6DE"); }
            }
            public override Color MenuItemSelectedGradientBegin
            {
                get { return ColorTranslator.FromHtml("#FFD00C"); }
            }
            public override Color MenuItemSelectedGradientEnd
            {
                get { return ColorTranslator.FromHtml("#F7F6DE"); }
            }
        }

        private void FrmManage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTimeManage.Text = DateTime.Now.ToString("dd MMMM yyyy hh:mm:ss tt");
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmManage_Load(object sender, EventArgs e)
        {
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Hide();
        }

        private void navBarItemBrandName_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ForeColor = Color.IndianRed;
        }

        private void navBarItemAddUser_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            var usersGroupsAuth = new Manage.usersGroupsAuth();
            usersGroupsAuth.Show();
            usersGroupsAuth.MdiParent = this;
        }
        

        private void navBarItemAddMerchandise_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ((DevExpress.XtraNavBar.NavBarItem)(sender)).Caption = @"(" + ((DevExpress.XtraNavBar.NavBarItem)(sender)).Caption + @")";
        }

        private void navBarControlLeft_Click(object sender, EventArgs e)
        {
            ActiveControl.ForeColor = Color.Tomato;
        }

        private void navBarControlLeft_ActiveGroupChanged(object sender, DevExpress.XtraNavBar.NavBarGroupEventArgs e)
        {
            int activeGroupIndex = navBarControlLeft.Groups.IndexOf(navBarControlLeft.ActiveGroup);
            navBarControlLeft.Groups[activeGroupIndex].AppearanceHotTracked.ForeColor = Color.Violet;
            //if (activeGroupIndex != 0)
            //    navBarControlLeft.ActiveGroup = navBarControlLeft.Groups[0];
        }
        
        private void navBarItemAddClient_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            searchClient.Close();
            searchUnits.Close();
            addUnit.Close();
            addClient.Close();
            addGoods.Close();
            searchGoods.Close();

            addClient = new Manage.Client.AddClients();
            addClient.Show();
            addClient.MdiParent = this;
            addClient.Dock = DockStyle.Right;
        }

        private void navBarItemSearchClient_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            addClient.Close();
            searchClient.Close();
            searchUnits.Close();
            addUnit.Close();
            addGoods.Close();searchGoods.Close();

            searchClient = new Manage.Client.SearchClients();
            searchClient.Show();
            searchClient.MdiParent = this;
            searchClient.Dock = DockStyle.Right;
        }

        private void navBarItemAddUnit_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            searchClient.Close();
            searchUnits.Close();
            addClient.Close();
            addClient.Close();
            addGoods.Close();
            searchGoods.Close();

            addUnit = new Manage.Units.AddUnits();
            addUnit.Show();
            addUnit.MdiParent = this;
            addUnit.Dock = DockStyle.Right;
        }

        private void navBarItemUpdateDeleteUnit_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            searchClient.Close();
            addUnit.Close();
            addClient.Close();
            addClient.Close();
            addGoods.Close();
            searchGoods.Close();

            searchUnits = new Manage.Units.SearchUnits();
            searchUnits.Show();
            searchUnits.MdiParent = this;
            searchUnits.Dock = DockStyle.Right;
        }
        private void navBarItemAddGoods_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            searchClient.Close();
            searchUnits.Close();
            addUnit.Close();
            addClient.Close();
            addClient.Close();
            searchGoods.Close();

            addGoods = new Manage.Goods.AddGoods();
            addGoods.Show();
            addGoods.MdiParent = this;
            addGoods.Dock = DockStyle.Right;
        }

        private void navBarItemUpdateDeleteGoods_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            searchClient.Close();
            searchUnits.Close();
            addUnit.Close();
            addClient.Close();
            addClient.Close();
            addGoods.Close();

            searchGoods = new Manage.Goods.SearchGoods();
            searchGoods.Show();
            searchGoods.MdiParent = this;
            searchGoods.Dock = DockStyle.Right;
        }
        private void navBarItemAddSupplier_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            searchClient.Close();
            searchUnits.Close();
            addUnit.Close();
            addClient.Close();
            addClient.Close();
            addGoods.Close();
            searchSupplier.Close();

            addSupplier = new Manage.Supplier.AddSupplier();
            addSupplier.Show();
            addSupplier.MdiParent = this;
            addSupplier.Dock = DockStyle.Right;
        }

        private void navBarItemSearchSupplier_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            searchClient.Close();
            searchUnits.Close();
            addUnit.Close();
            addClient.Close();
            addClient.Close();
            addGoods.Close();
            addSupplier.Close();

            searchSupplier = new Manage.Supplier.SearchSupplier();
            searchSupplier.Show();
            searchSupplier.MdiParent = this;
            searchSupplier.Dock = DockStyle.Right;
        }

        private void navBarItemTableStatus_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            searchClient.Close();
            searchUnits.Close();
            addUnit.Close();
            addClient.Close();
            addClient.Close();
            addGoods.Close();
            addSupplier.Close();

            addTablesStatus = new Manage.Tables.AddTablesStatus();
            addTablesStatus.Show();
            addTablesStatus.MdiParent = this;
            addTablesStatus.Dock = DockStyle.Right;
        }
        
        private void navBarItemUpdateDeleteStatus_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            searchClient.Close();
            searchUnits.Close();
            addUnit.Close();
            addClient.Close();
            addClient.Close();
            addGoods.Close();
            addSupplier.Close();


            searchStatus = new SearchStatus();
            searchStatus.Show();
            searchStatus.MdiParent = this;
            searchStatus.Dock = DockStyle.Right;
        }

        private void navBarItemProgram_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            searchClient.Close();
            searchUnits.Close();
            addUnit.Close();
            addClient.Close();
            addClient.Close();
            addGoods.Close();
            addSupplier.Close();

            progSetting = new Manage.ProgramSetting.ProgSetting();
            progSetting.Show();
            progSetting.MdiParent = this;progSetting.Dock = DockStyle.Right;
        }

        private void navBarItemAddTable_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            searchClient.Close();
            searchUnits.Close();
            addUnit.Close();
            addClient.Close();
            addClient.Close();
            addGoods.Close();
            addSupplier.Close();
            searchTable.Close();

            addTable = new AddTable();
            addTable.Show();
            addTable.MdiParent = this;
            addTable.Dock = DockStyle.Right;
        }

        private void navBarItemUpdateDeleteTable_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            searchClient.Close();
            searchUnits.Close();
            addUnit.Close();
            addClient.Close();
            addClient.Close();
            addGoods.Close();
            addSupplier.Close();
            addTable.Close();

            searchTable = new SearchTable();
            searchTable.Show();
            searchTable.MdiParent = this;
            searchTable.Dock = DockStyle.Right;
        }

        
    }
}