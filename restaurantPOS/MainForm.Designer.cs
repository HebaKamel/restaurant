namespace restaurantPOS
{
    partial class FrmMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.timerTimeDate = new System.Windows.Forms.Timer(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnWorkPeriods = new DevExpress.XtraEditors.SimpleButton();
            this.btnPOS = new DevExpress.XtraEditors.SimpleButton();
            this.btnTickets = new DevExpress.XtraEditors.SimpleButton();
            this.btnAccounts = new DevExpress.XtraEditors.SimpleButton();
            this.btnWarehouses = new DevExpress.XtraEditors.SimpleButton();
            this.btnMenu = new DevExpress.XtraEditors.SimpleButton();
            this.btnReports = new DevExpress.XtraEditors.SimpleButton();
            this.btnManage = new DevExpress.XtraEditors.SimpleButton();
            this.btnLogout = new DevExpress.XtraEditors.SimpleButton();
            this.lblCopyRightsMainForm = new DevExpress.XtraEditors.LabelControl();
            this.lblDateTimeMainForm = new DevExpress.XtraEditors.LabelControl();
            this.lblUserRoleMainForm = new DevExpress.XtraEditors.LabelControl();
            this.lblUserNameMainForm = new DevExpress.XtraEditors.LabelControl();
            this.timerIdle = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Click += new System.EventHandler(this.menuStrip1_Click);
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem1.ForeColor = System.Drawing.Color.Maroon;
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Enabled = false;
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Enabled = false;
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Enabled = false;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Enabled = false;
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Enabled = false;
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logoutToolStripMenuItem.Image")));
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.logoutToolStripMenuItem.Text = "&Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Enabled = false;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Enabled = false;
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(141, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Enabled = false;
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Enabled = false;
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Enabled = false;
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(141, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Enabled = false;
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.toolsToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Enabled = false;
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Enabled = false;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.reportsToolStripMenuItem.Text = "&Reports";
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("settingsToolStripMenuItem.Image")));
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.settingsToolStripMenuItem.Text = "&Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem1});
            this.helpToolStripMenuItem1.ForeColor = System.Drawing.Color.Maroon;
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem1.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Enabled = false;
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Enabled = false;
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Enabled = false;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(119, 6);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.aboutToolStripMenuItem1.Text = "&About...";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // timerTimeDate
            // 
            this.timerTimeDate.Enabled = true;
            this.timerTimeDate.Interval = 1000;
            this.timerTimeDate.Tick += new System.EventHandler(this.timerTimeDate_Tick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel2.Controls.Add(this.lblCopyRightsMainForm);
            this.splitContainer1.Panel2.Controls.Add(this.lblDateTimeMainForm);
            this.splitContainer1.Panel2.Controls.Add(this.lblUserRoleMainForm);
            this.splitContainer1.Panel2.Controls.Add(this.lblUserNameMainForm);
            this.splitContainer1.Size = new System.Drawing.Size(984, 637);
            this.splitContainer1.SplitterDistance = 599;
            this.splitContainer1.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnWorkPeriods);
            this.flowLayoutPanel1.Controls.Add(this.btnPOS);
            this.flowLayoutPanel1.Controls.Add(this.btnTickets);
            this.flowLayoutPanel1.Controls.Add(this.btnAccounts);
            this.flowLayoutPanel1.Controls.Add(this.btnWarehouses);
            this.flowLayoutPanel1.Controls.Add(this.btnMenu);
            this.flowLayoutPanel1.Controls.Add(this.btnReports);
            this.flowLayoutPanel1.Controls.Add(this.btnManage);
            this.flowLayoutPanel1.Controls.Add(this.btnLogout);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(984, 599);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnWorkPeriods
            // 
            this.btnWorkPeriods.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnWorkPeriods.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.btnWorkPeriods.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnWorkPeriods.Appearance.Font = new System.Drawing.Font("Tahoma", 30F);
            this.btnWorkPeriods.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnWorkPeriods.Appearance.Options.UseBackColor = true;
            this.btnWorkPeriods.Appearance.Options.UseBorderColor = true;
            this.btnWorkPeriods.Appearance.Options.UseFont = true;
            this.btnWorkPeriods.Appearance.Options.UseForeColor = true;
            this.btnWorkPeriods.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWorkPeriods.BackgroundImage")));
            this.btnWorkPeriods.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWorkPeriods.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnWorkPeriods.Location = new System.Drawing.Point(3, 3);
            this.btnWorkPeriods.Name = "btnWorkPeriods";
            this.btnWorkPeriods.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnWorkPeriods.Size = new System.Drawing.Size(321, 189);
            this.btnWorkPeriods.TabIndex = 17;
            this.btnWorkPeriods.TabStop = false;
            this.btnWorkPeriods.Click += new System.EventHandler(this.btnWorkPeriods_Click);
            // 
            // btnPOS
            // 
            this.btnPOS.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnPOS.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.btnPOS.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnPOS.Appearance.Font = new System.Drawing.Font("Tahoma", 30F);
            this.btnPOS.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnPOS.Appearance.Options.UseBackColor = true;
            this.btnPOS.Appearance.Options.UseBorderColor = true;
            this.btnPOS.Appearance.Options.UseFont = true;
            this.btnPOS.Appearance.Options.UseForeColor = true;
            this.btnPOS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPOS.BackgroundImage")));
            this.btnPOS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPOS.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnPOS.Location = new System.Drawing.Point(330, 3);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnPOS.Size = new System.Drawing.Size(321, 189);
            this.btnPOS.TabIndex = 14;
            this.btnPOS.TabStop = false;
            this.btnPOS.Click += new System.EventHandler(this.btnPOS_Click);
            // 
            // btnTickets
            // 
            this.btnTickets.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnTickets.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.btnTickets.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnTickets.Appearance.Font = new System.Drawing.Font("Tahoma", 30F);
            this.btnTickets.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnTickets.Appearance.Options.UseBackColor = true;
            this.btnTickets.Appearance.Options.UseBorderColor = true;
            this.btnTickets.Appearance.Options.UseFont = true;
            this.btnTickets.Appearance.Options.UseForeColor = true;
            this.btnTickets.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTickets.BackgroundImage")));
            this.btnTickets.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTickets.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnTickets.Location = new System.Drawing.Point(657, 3);
            this.btnTickets.Name = "btnTickets";
            this.btnTickets.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnTickets.Size = new System.Drawing.Size(321, 189);
            this.btnTickets.TabIndex = 12;
            this.btnTickets.TabStop = false;
            this.btnTickets.Click += new System.EventHandler(this.btnTickets_Click);
            // 
            // btnAccounts
            // 
            this.btnAccounts.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnAccounts.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.btnAccounts.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnAccounts.Appearance.Font = new System.Drawing.Font("Tahoma", 30F);
            this.btnAccounts.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnAccounts.Appearance.Options.UseBackColor = true;
            this.btnAccounts.Appearance.Options.UseBorderColor = true;
            this.btnAccounts.Appearance.Options.UseFont = true;
            this.btnAccounts.Appearance.Options.UseForeColor = true;
            this.btnAccounts.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAccounts.BackgroundImage")));
            this.btnAccounts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAccounts.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnAccounts.Location = new System.Drawing.Point(3, 198);
            this.btnAccounts.Name = "btnAccounts";
            this.btnAccounts.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnAccounts.Size = new System.Drawing.Size(321, 189);
            this.btnAccounts.TabIndex = 16;
            this.btnAccounts.TabStop = false;
            this.btnAccounts.Click += new System.EventHandler(this.btnAccounts_Click);
            // 
            // btnWarehouses
            // 
            this.btnWarehouses.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnWarehouses.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.btnWarehouses.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnWarehouses.Appearance.Font = new System.Drawing.Font("Tahoma", 30F);
            this.btnWarehouses.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnWarehouses.Appearance.Options.UseBackColor = true;
            this.btnWarehouses.Appearance.Options.UseBorderColor = true;
            this.btnWarehouses.Appearance.Options.UseFont = true;
            this.btnWarehouses.Appearance.Options.UseForeColor = true;
            this.btnWarehouses.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWarehouses.BackgroundImage")));
            this.btnWarehouses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWarehouses.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnWarehouses.Location = new System.Drawing.Point(330, 198);
            this.btnWarehouses.Name = "btnWarehouses";
            this.btnWarehouses.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnWarehouses.Size = new System.Drawing.Size(321, 189);
            this.btnWarehouses.TabIndex = 13;
            this.btnWarehouses.TabStop = false;
            this.btnWarehouses.Click += new System.EventHandler(this.btnWarehouses_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.btnMenu.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnMenu.Appearance.Font = new System.Drawing.Font("Tahoma", 30F);
            this.btnMenu.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnMenu.Appearance.Options.UseBackColor = true;
            this.btnMenu.Appearance.Options.UseBorderColor = true;
            this.btnMenu.Appearance.Options.UseFont = true;
            this.btnMenu.Appearance.Options.UseForeColor = true;
            this.btnMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMenu.BackgroundImage")));
            this.btnMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMenu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnMenu.Location = new System.Drawing.Point(657, 198);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnMenu.Size = new System.Drawing.Size(321, 189);
            this.btnMenu.TabIndex = 11;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnReports
            // 
            this.btnReports.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnReports.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.btnReports.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnReports.Appearance.Font = new System.Drawing.Font("Tahoma", 30F);
            this.btnReports.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnReports.Appearance.Options.UseBackColor = true;
            this.btnReports.Appearance.Options.UseBorderColor = true;
            this.btnReports.Appearance.Options.UseFont = true;
            this.btnReports.Appearance.Options.UseForeColor = true;
            this.btnReports.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReports.BackgroundImage")));
            this.btnReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReports.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnReports.Location = new System.Drawing.Point(3, 393);
            this.btnReports.Name = "btnReports";
            this.btnReports.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnReports.Size = new System.Drawing.Size(321, 189);
            this.btnReports.TabIndex = 15;
            this.btnReports.TabStop = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnManage
            // 
            this.btnManage.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnManage.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.btnManage.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnManage.Appearance.Font = new System.Drawing.Font("Tahoma", 30F);
            this.btnManage.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnManage.Appearance.Options.UseBackColor = true;
            this.btnManage.Appearance.Options.UseBorderColor = true;
            this.btnManage.Appearance.Options.UseFont = true;
            this.btnManage.Appearance.Options.UseForeColor = true;
            this.btnManage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnManage.BackgroundImage")));
            this.btnManage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnManage.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnManage.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnManage.Location = new System.Drawing.Point(330, 393);
            this.btnManage.Name = "btnManage";
            this.btnManage.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnManage.Size = new System.Drawing.Size(321, 189);
            this.btnManage.TabIndex = 18;
            this.btnManage.TabStop = false;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.Appearance.BackColor2 = System.Drawing.Color.Transparent;
            this.btnLogout.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.btnLogout.Appearance.Font = new System.Drawing.Font("Tahoma", 30F);
            this.btnLogout.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btnLogout.Appearance.Options.UseBackColor = true;
            this.btnLogout.Appearance.Options.UseBorderColor = true;
            this.btnLogout.Appearance.Options.UseFont = true;
            this.btnLogout.Appearance.Options.UseForeColor = true;
            this.btnLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.BackgroundImage")));
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnLogout.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnLogout.Location = new System.Drawing.Point(657, 393);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnLogout.Size = new System.Drawing.Size(321, 189);
            this.btnLogout.TabIndex = 19;
            this.btnLogout.TabStop = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblCopyRightsMainForm
            // 
            this.lblCopyRightsMainForm.Appearance.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyRightsMainForm.Appearance.ForeColor = System.Drawing.Color.IndianRed;
            this.lblCopyRightsMainForm.Location = new System.Drawing.Point(707, 9);
            this.lblCopyRightsMainForm.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.lblCopyRightsMainForm.Name = "lblCopyRightsMainForm";
            this.lblCopyRightsMainForm.Size = new System.Drawing.Size(163, 11);
            this.lblCopyRightsMainForm.TabIndex = 2;
            this.lblCopyRightsMainForm.Text = "Copy rights reserved to Estoda @ 2016";
            // 
            // lblDateTimeMainForm
            // 
            this.lblDateTimeMainForm.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTimeMainForm.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.lblDateTimeMainForm.Location = new System.Drawing.Point(328, 9);
            this.lblDateTimeMainForm.Name = "lblDateTimeMainForm";
            this.lblDateTimeMainForm.Size = new System.Drawing.Size(130, 13);
            this.lblDateTimeMainForm.TabIndex = 0;
            this.lblDateTimeMainForm.Text = "01 June 2016 12:00:00 AM";
            // 
            // lblUserRoleMainForm
            // 
            this.lblUserRoleMainForm.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserRoleMainForm.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.lblUserRoleMainForm.Location = new System.Drawing.Point(23, 14);
            this.lblUserRoleMainForm.Name = "lblUserRoleMainForm";
            this.lblUserRoleMainForm.Size = new System.Drawing.Size(21, 13);
            this.lblUserRoleMainForm.TabIndex = 0;
            this.lblUserRoleMainForm.Text = "Role";
            // 
            // lblUserNameMainForm
            // 
            this.lblUserNameMainForm.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserNameMainForm.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.lblUserNameMainForm.Location = new System.Drawing.Point(9, 2);
            this.lblUserNameMainForm.Name = "lblUserNameMainForm";
            this.lblUserNameMainForm.Size = new System.Drawing.Size(70, 13);
            this.lblUserNameMainForm.TabIndex = 0;
            this.lblUserNameMainForm.Text = "Ahmed Hisham";
            // 
            // timerIdle
            // 
            this.timerIdle.Enabled = true;
            this.timerIdle.Interval = 1000;
            this.timerIdle.Tick += new System.EventHandler(this.timerIdle_Tick);
            // 
            // FrmMainForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = global::restaurantPOS.Properties.Resources.Untitled_11;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoda Cheese King";
            this.Activated += new System.EventHandler(this.FrmMainForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.FrmMainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Timer timerTimeDate;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.LabelControl lblCopyRightsMainForm;
        private DevExpress.XtraEditors.LabelControl lblDateTimeMainForm;
        private DevExpress.XtraEditors.LabelControl lblUserNameMainForm;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.Timer timerIdle;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private DevExpress.XtraEditors.LabelControl lblUserRoleMainForm;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton btnWorkPeriods;
        private DevExpress.XtraEditors.SimpleButton btnPOS;
        private DevExpress.XtraEditors.SimpleButton btnTickets;
        private DevExpress.XtraEditors.SimpleButton btnAccounts;
        private DevExpress.XtraEditors.SimpleButton btnWarehouses;
        private DevExpress.XtraEditors.SimpleButton btnMenu;
        private DevExpress.XtraEditors.SimpleButton btnReports;
        private DevExpress.XtraEditors.SimpleButton btnManage;
        private DevExpress.XtraEditors.SimpleButton btnLogout;

    }
}