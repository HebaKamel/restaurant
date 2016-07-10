using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurantPOS.userMessages
{
    class messagesEn
    {
        public string ErrorMessae = "Error, Please enter : ";

        public string insertedError = "Error, not inserted";

        public string insertedSuccessfully = "Inserted Successfully";

        public string deleteConfirm = "Are you sure to delete";

        public string deletedError = "Error, not deleted";

        public string deletedSuccessfully = "Deleted Successfully";

        public string updatedError = "Error, not updated";

        public string updatedSuccessfully = "Updated Successfully";

        public string connectionError = "cannot open connection";

        public string fontsError = "Error, Fonts Not Found!!";

        public string loginError = "Error, Please enter user name and password correctly";

        public string chooseRow = "Error, Please Choose a Row First or may be this recored used in other operations";

        #region authAndUsers
        public string enterGroupName = "Please enter Group Name";
        public string chooseGroupAuth = "Please choose Group Auth";
        public string authError = "Error, You haven't this permissions";
        #endregion

        #region clients
        public string chooseClientRow = "Error, Please Choose a Client First";
        #endregion

        #region units
        public string chooseUnitRow = "Error, Please Choose a Unit First";
        public string fillUnits = "Error, Please Fill Units First";
        public string errorFillUnits = "Error occured in fill units";
        #endregion
    }
}
