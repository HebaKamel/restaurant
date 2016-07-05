using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using restaurantPOS.DataAccess;
using restaurantPOS.SystemSetting;
using restaurantPOS.userMessages;
using System.Data;
using System.Data.SqlClient;


namespace restaurantPOS.Manage
{
    public partial class usersGroupsAuth : Form
    {
        private userMessages.messagesEn messagesEn = new messagesEn(); 
        private DataAccess.dataAccess db = new dataAccess();
        private SystemSetting.system system = new system();
        private SystemSetting.systemAuth systemAuth = new systemAuth();
        public usersGroupsAuth()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtGroupName.Text))
            {
                if(!chkManage.Checked && !chkPos.Checked && !chkTickets.Checked && !chkWorkPeriods.Checked && !chkMenu.Checked)
                    XtraMessageBox.Show(messagesEn.chooseGroupAuth, system.restName);
                else
                {
                    try
                    {
                        //insert into users_role
                        int roleId = db.addUsersRole(txtGroupName.Text);
                        if (roleId != 0)
                        {
                            //insert into role_auth
                            if (chkPos.Checked)
                                db.addRoleAuth(roleId, systemAuth.pos);

                            if (chkTickets.Checked)
                                db.addRoleAuth(roleId, systemAuth.tickets);

                            if (chkWorkPeriods.Checked)
                                db.addRoleAuth(roleId, systemAuth.workPeriods);

                            if (chkMenu.Checked)
                                db.addRoleAuth(roleId, systemAuth.menu);
                            
                            if (chkManage.Checked)
                                db.addRoleAuth(roleId, systemAuth.manage);

                            if (chkManage.Checked)
                                db.addRoleAuth(roleId, systemAuth.warhouses);

                            if (chkPos.Checked)
                                db.addRoleAuth(roleId, systemAuth.reports);

                            if (chkTickets.Checked)
                                db.addRoleAuth(roleId, systemAuth.accounts);
                        }
                        else
                            XtraMessageBox.Show(messagesEn.insertedError, system.restName);
                    }
                    catch (Exception ex) { XtraMessageBox.Show(messagesEn.insertedError, system.restName); }
                }
            }
            else
                XtraMessageBox.Show(messagesEn.enterGroupName, system.restName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
