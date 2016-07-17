using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using restaurantPOS.userMessages;
using System.Configuration;

namespace restaurantPOS.DataAccess
{
    class dataAccess
    {
        private userMessages.messagesEn msgEn = new messagesEn();
        string command = null;
        public SqlCommand cmd;
        DataTable dataTable = new DataTable();
        public SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["restaurantDB"].ConnectionString);

        #region userSetting
        public int addUsersRole(string roleName)
        {
            //transaction = con.BeginTransaction("SampleTransaction");
            int roleID;
            using (SqlCommand cmd = new SqlCommand("addUsersRole", con))
            {
                //cmd.Transaction = transaction;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@roleNameEn", SqlDbType.NVarChar);
                cmd.Parameters.Add("@roleId", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters["@roleNameEn"].Value = roleName;
                if (con.State != ConnectionState.Open)
                    con.Open();
                cmd.ExecuteNonQuery();
                roleID = Convert.ToInt32(cmd.Parameters["@roleId"].Value);
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
            return roleID;
        }

        public void addRoleAuth(int roleId, int authId)
        {
            using (SqlCommand cmd = new SqlCommand("addRoleAuth", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@roleId", SqlDbType.Int);
                cmd.Parameters.Add("@authId", SqlDbType.Int);
                cmd.Parameters["@roleId"].Value = roleId;
                cmd.Parameters["@authId"].Value = authId;
                if (con.State != ConnectionState.Open)
                    con.Open(); 
                cmd.ExecuteNonQuery();
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
        }

        public DataTable getUser(string userName, string userPass)
        {
            DataTable dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand("getUser", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@userName", SqlDbType.NVarChar);
                cmd.Parameters.Add("@userPass", SqlDbType.NVarChar);
                cmd.Parameters["@userName"].Value = userName;
                cmd.Parameters["@userPass"].Value = userPass;
                if (con.State != ConnectionState.Open)
                    con.Open();
                dt.Load(cmd.ExecuteReader());
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
            return dt;
        }

        public DataTable getRole(int roleId)
        {
            DataTable dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand("getRole", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@roleId", SqlDbType.Int);
                cmd.Parameters["@roleId"].Value = roleId;
                if (con.State != ConnectionState.Open)
                    con.Open();
                dt.Load(cmd.ExecuteReader());
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
            return dt;
        }

        public DataTable checkRoleAuth(int roleId, int authId)
        {
            DataTable dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand("getRoleAuth", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@roleId", SqlDbType.Int);
                cmd.Parameters.Add("@authId", SqlDbType.Int);
                cmd.Parameters["@roleId"].Value = roleId;
                cmd.Parameters["@authId"].Value = authId;
                if (con.State != ConnectionState.Open)
                    con.Open();
                dt.Load(cmd.ExecuteReader());
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
            return dt;
        }
        #endregion

        #region clients
        public int addClient(string clientNameEn, string clientNameAr, string clientAddressEn, string clientAddressAr, string clientTelephoneNo, string clientMobileNo, int isVIP, string clientEmail)
        {
            //transaction = con.BeginTransaction("SampleTransaction");
            int clientId;
            using (SqlCommand cmd = new SqlCommand("addClient", con))
            {
                //cmd.Transaction = transaction;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@clientNameEn", SqlDbType.NVarChar);
                cmd.Parameters.Add("@clientNameAr", SqlDbType.NVarChar);
                cmd.Parameters.Add("@clientAddressEn", SqlDbType.NVarChar);
                cmd.Parameters.Add("@clientAddressAr", SqlDbType.NVarChar);
                cmd.Parameters.Add("@clientTelephoneNo", SqlDbType.NVarChar);
                cmd.Parameters.Add("@clientMobileNo", SqlDbType.NVarChar);cmd.Parameters.Add("@clientIsVIP", SqlDbType.Int);
                cmd.Parameters.Add("@clientEmail", SqlDbType.NVarChar);
                cmd.Parameters.Add("@clientId", SqlDbType.Int).Direction = ParameterDirection.Output;

                cmd.Parameters["@clientNameEn"].Value = clientNameEn;
                cmd.Parameters["@clientNameAr"].Value = clientNameAr;
                cmd.Parameters["@clientAddressEn"].Value = clientAddressEn;
                cmd.Parameters["@clientAddressAr"].Value = clientAddressAr;
                cmd.Parameters["@clientTelephoneNo"].Value = clientTelephoneNo;
                cmd.Parameters["@clientMobileNo"].Value = clientMobileNo;
                cmd.Parameters["@clientIsVIP"].Value = isVIP;
                cmd.Parameters["@clientEmail"].Value = clientEmail;
                if (con.State != ConnectionState.Open)
                    con.Open();
                cmd.ExecuteNonQuery();
                clientId = Convert.ToInt32(cmd.Parameters["@clientId"].Value);
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
            return clientId;
        }

        public DataTable getClient(string clientNameEn, string clientNameAr, string clientAddressEn, string clientAddressAr, string clientTelephoneNo, string clientMobileNo, string clientEmail, int? clientId = 0, int? isVip = 0)
        {
            if (clientId == 0) clientId = null;
            if(clientNameEn == "") clientNameEn = null;
            if(clientNameAr == "") clientNameAr = null;
            if(clientAddressEn == "") clientAddressEn = null;
            if(clientAddressAr == "") clientAddressAr = null;
            if(clientTelephoneNo == "") clientTelephoneNo = null;
            if (clientMobileNo == "") clientMobileNo = null;
            if (clientMobileNo == "") clientMobileNo = null;
            if (isVip == 0) isVip = null;
            if (clientEmail == "") clientEmail = null;
            DataTable dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand("SearchClient", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@clientId", SqlDbType.Int);
                cmd.Parameters.Add("@clientNameEn", SqlDbType.NVarChar);
                cmd.Parameters.Add("@clientNameAr", SqlDbType.NVarChar);
                cmd.Parameters.Add("@clientAddressEn", SqlDbType.NVarChar);
                cmd.Parameters.Add("@clientAddressAr", SqlDbType.NVarChar);
                cmd.Parameters.Add("@clientTelephoneNo", SqlDbType.NVarChar);
                cmd.Parameters.Add("@clientMobileNo", SqlDbType.NVarChar);
                cmd.Parameters.Add("@clientIsVIP", SqlDbType.Int);
                cmd.Parameters.Add("@clientEmail", SqlDbType.NVarChar);
                cmd.Parameters["@clientId"].Value = clientId;
                cmd.Parameters["@clientNameEn"].Value = clientNameEn;
                cmd.Parameters["@clientNameAr"].Value = clientNameAr;
                cmd.Parameters["@clientAddressEn"].Value = clientAddressEn;
                cmd.Parameters["@clientAddressAr"].Value = clientAddressAr;
                cmd.Parameters["@clientTelephoneNo"].Value = clientTelephoneNo;
                cmd.Parameters["@clientMobileNo"].Value = clientMobileNo;
                cmd.Parameters["@clientIsVIP"].Value = isVip;
                cmd.Parameters["@clientEmail"].Value = clientEmail;
                if (con.State != ConnectionState.Open)
                    con.Open();
                dt.Load(cmd.ExecuteReader());
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
            return dt;
        }

        public int deleteClient(int clientId)
        {
            int deleted = 0;
            using (SqlCommand cmd = new SqlCommand("deleteClient", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@clientId", SqlDbType.Int);
                cmd.Parameters["@clientId"].Value = clientId;
                if (con.State != ConnectionState.Open)
                    con.Open();
                SqlParameter returnParameter = cmd.Parameters.Add("RetVal", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;
                cmd.ExecuteNonQuery();
                if(returnParameter.Value != null)
                    deleted = (int) returnParameter.Value;
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
            return deleted;
        }

        public int updateClient(string clientNameEn, string clientNameAr, string clientAddressEn, string clientAddressAr, string clientTelephoneNo, string clientMobileNo, string clientEmail, int? clientId = 0, int? isVip = 0)
        {
            int updated = 0;
            if (clientId == 0) clientId = null;
            if (clientNameEn == "") clientNameEn = null;
            if (clientNameAr == "") clientNameAr = null;
            if (clientAddressEn == "") clientAddressEn = null;
            if (clientAddressAr == "") clientAddressAr = null;
            if (clientTelephoneNo == "") clientTelephoneNo = null;
            if (clientMobileNo == "") clientMobileNo = null;
            using (SqlCommand cmd = new SqlCommand("updateClient", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@clientId", SqlDbType.Int);
                cmd.Parameters.Add("@clientNameEn", SqlDbType.NVarChar);
                cmd.Parameters.Add("@clientNameAr", SqlDbType.NVarChar);
                cmd.Parameters.Add("@clientAddressEn", SqlDbType.NVarChar);
                cmd.Parameters.Add("@clientAddressAr", SqlDbType.NVarChar);
                cmd.Parameters.Add("@clientTelephoneNo", SqlDbType.NVarChar);
                cmd.Parameters.Add("@clientMobileNo", SqlDbType.NVarChar);
                cmd.Parameters.Add("@clientIsVIP", SqlDbType.Int);
                cmd.Parameters.Add("@clientEmail", SqlDbType.NVarChar);

                cmd.Parameters["@clientId"].Value = clientId;
                cmd.Parameters["@clientNameEn"].Value = clientNameEn;
                cmd.Parameters["@clientNameAr"].Value = clientNameAr;
                cmd.Parameters["@clientAddressEn"].Value = clientAddressEn;
                cmd.Parameters["@clientAddressAr"].Value = clientAddressAr;
                cmd.Parameters["@clientTelephoneNo"].Value = clientTelephoneNo;
                cmd.Parameters["@clientMobileNo"].Value = clientMobileNo;
                cmd.Parameters["@clientIsVIP"].Value = isVip;
                cmd.Parameters["@clientEmail"].Value = clientEmail;
                if (con.State != ConnectionState.Open)
                    con.Open();
                SqlParameter returnParameter = cmd.Parameters.Add("RetVal", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;
                cmd.ExecuteReader();
                if(returnParameter.Value != null)
                    updated = (int)returnParameter.Value;
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
            return updated;
        }
        #endregion

        #region units
        public int addUnit(string unitNameEn, string unitNameAr){
            //transaction = con.BeginTransaction("SampleTransaction");
            int unitId;
            using (SqlCommand cmd = new SqlCommand("addUnit", con))
            {//cmd.Transaction = transaction;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@unitNameEn", SqlDbType.NVarChar);
                cmd.Parameters.Add("@unitNameAr", SqlDbType.NVarChar);
                cmd.Parameters.Add("@unitId", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters["@unitNameEn"].Value = unitNameEn;
                cmd.Parameters["@unitNameAr"].Value = unitNameAr;
                if (con.State != ConnectionState.Open)
                    con.Open();
                cmd.ExecuteNonQuery();
                unitId = Convert.ToInt32(cmd.Parameters["@unitId"].Value);
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
            return unitId;
        }

        public DataTable getUnit(string unitNameEn, string unitNameAr, int? unitId = 0)
        {
            if (unitId == 0) unitId = null;
            if (unitNameEn == "") unitNameEn = null;
            if (unitNameAr == "") unitNameAr = null;
            DataTable dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand("SearchUnit", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@unitId", SqlDbType.Int);
                cmd.Parameters.Add("@unitNameEn", SqlDbType.NVarChar);
                cmd.Parameters.Add("@unitNameAr", SqlDbType.NVarChar);
                cmd.Parameters["@unitId"].Value = unitId;
                cmd.Parameters["@unitNameEn"].Value = unitNameEn;
                cmd.Parameters["@unitNameAr"].Value = unitNameAr;
                if (con.State != ConnectionState.Open)
                    con.Open();
                dt.Load(cmd.ExecuteReader());
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
            return dt;
        }

        public int deleteUnit(int unitId)
        {
            int deleted = 0;
            using (SqlCommand cmd = new SqlCommand("deleteUnit", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@unitId", SqlDbType.Int);
                cmd.Parameters["@unitId"].Value = unitId;
                if (con.State != ConnectionState.Open)
                    con.Open();
                SqlParameter returnParameter = cmd.Parameters.Add("RetVal", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;
                cmd.ExecuteNonQuery();
                if (returnParameter.Value != null)
                    deleted = (int)returnParameter.Value;
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
            return deleted;
        }

        public int updateUnit(string unitNameEn, string unitNameAr, int? unitId = 0)
        {
            int updated = 0;
            if (unitId == 0) unitId = null;
            if (unitNameEn == "") unitNameEn = null;
            if (unitNameAr == "") unitNameAr = null;
            using (SqlCommand cmd = new SqlCommand("updateUnit", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@unitId", SqlDbType.Int);
                cmd.Parameters.Add("@unitNameEn", SqlDbType.NVarChar);
                cmd.Parameters.Add("@unitNameAr", SqlDbType.NVarChar);
                cmd.Parameters["@unitId"].Value = unitId;
                cmd.Parameters["@unitNameEn"].Value = unitNameEn;
                cmd.Parameters["@unitNameAr"].Value = unitNameAr;
                if (con.State != ConnectionState.Open)
                    con.Open();
                SqlParameter returnParameter = cmd.Parameters.Add("RetVal", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;
                cmd.ExecuteReader();
                if (returnParameter.Value != null)
                    updated = (int)returnParameter.Value;
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
            return updated;
        }
        #endregion

        #region goods
        public int addGoods(string goodsNameEn, string goodsNameAr, int unitId)
        {
            //transaction = con.BeginTransaction("SampleTransaction");
            int goodsId;
            using (SqlCommand cmd = new SqlCommand("addGoods", con))
            {
                //cmd.Transaction = transaction;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@goodsNameEn", SqlDbType.NVarChar);
                cmd.Parameters.Add("@goodsNameAr", SqlDbType.NVarChar);
                cmd.Parameters.Add("@unitId", SqlDbType.Int);
                cmd.Parameters.Add("@goodsId", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters["@goodsNameEn"].Value = goodsNameEn;
                cmd.Parameters["@goodsNameAr"].Value = goodsNameAr;
                cmd.Parameters["@unitId"].Value = unitId;
                if (con.State != ConnectionState.Open)
                    con.Open();
                cmd.ExecuteNonQuery();
                goodsId = Convert.ToInt32(cmd.Parameters["@goodsId"].Value);
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
            return unitId;
        }

        public DataTable getGoods(string goodsNameEn, string goodsNameAr, int? unitId = 0, int? goodsId = 0)
        {
            if (goodsId == 0) goodsId = null;
            if (unitId == 0) unitId = null;
            if (goodsNameEn == "") goodsNameEn = null;
            if (goodsNameAr == "") goodsNameAr = null;
            DataTable dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand("SearchGoods", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@goodsId", SqlDbType.Int);
                cmd.Parameters.Add("@unitId", SqlDbType.Int);
                cmd.Parameters.Add("@goodsNameEn", SqlDbType.NVarChar);
                cmd.Parameters.Add("@goodsNameAr", SqlDbType.NVarChar);
                cmd.Parameters["@goodsId"].Value = goodsId;
                cmd.Parameters["@unitId"].Value = unitId;
                cmd.Parameters["@goodsNameEn"].Value = goodsNameEn;
                cmd.Parameters["@goodsNameAr"].Value = goodsNameAr;
                if (con.State != ConnectionState.Open)
                    con.Open();
                dt.Load(cmd.ExecuteReader());
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
            return dt;
        }

        public int deleteGoods(int goodsId)
        {
            int deleted = 0;
            using (SqlCommand cmd = new SqlCommand("deleteGoods", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@goodsId", SqlDbType.Int);
                cmd.Parameters["@goodsId"].Value = goodsId;
                if (con.State != ConnectionState.Open)
                    con.Open();
                SqlParameter returnParameter = cmd.Parameters.Add("RetVal", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;
                cmd.ExecuteNonQuery();
                if (returnParameter.Value != null)
                    deleted = (int)returnParameter.Value;
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
            return deleted;
        }

        public int updateGoods(string goodsNameEn, string goodsNameAr, int? unitId = 0, int? goodsId = 0)
        {
            int updated = 0;
            if (goodsId == 0) goodsId = null;
            if (unitId == 0) unitId = null;
            if (goodsNameEn == "") goodsNameEn = null;
            if (goodsNameAr == "") goodsNameAr = null;
            using (SqlCommand cmd = new SqlCommand("updateGoods", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@goodsId", SqlDbType.Int);
                cmd.Parameters.Add("@unitId", SqlDbType.Int);
                cmd.Parameters.Add("@goodsNameEn", SqlDbType.NVarChar);
                cmd.Parameters.Add("@goodsNameAr", SqlDbType.NVarChar);
                cmd.Parameters["@goodsId"].Value = goodsId;
                cmd.Parameters["@unitId"].Value = unitId;
                cmd.Parameters["@goodsNameEn"].Value = goodsNameEn;
                cmd.Parameters["@goodsNameAr"].Value = goodsNameAr;
                if (con.State != ConnectionState.Open)
                    con.Open();
                SqlParameter returnParameter = cmd.Parameters.Add("RetVal", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;
                cmd.ExecuteReader();
                if (returnParameter.Value != null)
                    updated = (int)returnParameter.Value;
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
            return updated;
        }
        #endregion

        #region suppliers
        public int addSupplier(string supplierNameEn, string supplierNameAr, string supplierAddressEn, string supplierAddressAr, string supplierTelephoneNo, string supplierMobileNo)
        {
            //transaction = con.BeginTransaction("SampleTransaction");
            int clientId;
            using (SqlCommand cmd = new SqlCommand("addSupplier", con))
            {
                //cmd.Transaction = transaction;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@supplierNameEn", SqlDbType.NVarChar);
                cmd.Parameters.Add("@supplierNameAr", SqlDbType.NVarChar);
                cmd.Parameters.Add("@supplierAddressEn", SqlDbType.NVarChar);
                cmd.Parameters.Add("@supplierAddressAr", SqlDbType.NVarChar);
                cmd.Parameters.Add("@supplierTelephoneNo", SqlDbType.NVarChar);
                cmd.Parameters.Add("@supplierMobileNo", SqlDbType.NVarChar);
                cmd.Parameters.Add("@supplierId", SqlDbType.Int).Direction = ParameterDirection.Output;

                cmd.Parameters["@supplierNameEn"].Value = supplierNameEn;
                cmd.Parameters["@supplierNameAr"].Value = supplierNameAr;
                cmd.Parameters["@supplierAddressEn"].Value = supplierAddressEn;
                cmd.Parameters["@supplierAddressAr"].Value = supplierAddressAr;
                cmd.Parameters["@supplierTelephoneNo"].Value = supplierTelephoneNo;
                cmd.Parameters["@supplierMobileNo"].Value = supplierMobileNo;
                if (con.State != ConnectionState.Open)
                    con.Open();
                cmd.ExecuteNonQuery();
                clientId = Convert.ToInt32(cmd.Parameters["@supplierId"].Value);
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
            return clientId;
        }

        public DataTable getSupplier(string supplierNameEn, string supplierNameAr, string supplierAddressEn, string supplierAddressAr, string supplierTelephoneNo, string supplierMobileNo, int? supplierId = 0)
        {
            if (supplierId == 0) supplierId = null;
            if (supplierNameEn == "") supplierNameEn = null;
            if (supplierNameAr == "") supplierNameAr = null;
            if (supplierAddressEn == "") supplierAddressEn = null;
            if (supplierAddressAr == "") supplierAddressAr = null;
            if (supplierTelephoneNo == "") supplierTelephoneNo = null;
            if (supplierMobileNo == "") supplierMobileNo = null;
            DataTable dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand("SearchSupplier", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@supplierId", SqlDbType.Int);
                cmd.Parameters.Add("@supplierNameEn", SqlDbType.NVarChar);
                cmd.Parameters.Add("@supplierNameAr", SqlDbType.NVarChar);
                cmd.Parameters.Add("@supplierAddressEn", SqlDbType.NVarChar);
                cmd.Parameters.Add("@supplierAddressAr", SqlDbType.NVarChar);
                cmd.Parameters.Add("@supplierTelephoneNo", SqlDbType.NVarChar);
                cmd.Parameters.Add("@supplierMobileNo", SqlDbType.NVarChar);

                cmd.Parameters["@supplierId"].Value = supplierId;
                cmd.Parameters["@supplierNameEn"].Value = supplierNameEn;
                cmd.Parameters["@supplierNameAr"].Value = supplierNameAr;
                cmd.Parameters["@supplierAddressEn"].Value = supplierAddressEn;
                cmd.Parameters["@supplierAddressAr"].Value = supplierAddressAr;
                cmd.Parameters["@supplierTelephoneNo"].Value = supplierTelephoneNo;
                cmd.Parameters["@supplierMobileNo"].Value = supplierMobileNo;
                if (con.State != ConnectionState.Open)
                    con.Open();
                dt.Load(cmd.ExecuteReader());
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
            return dt;
        }

        public int deleteSupplier(int supplierId)
        {
            int deleted = 0;
            using (SqlCommand cmd = new SqlCommand("deleteSupplier", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@supplierId", SqlDbType.Int);
                cmd.Parameters["@supplierId"].Value = supplierId;
                if (con.State != ConnectionState.Open)
                    con.Open();
                SqlParameter returnParameter = cmd.Parameters.Add("RetVal", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;
                cmd.ExecuteNonQuery();
                if (returnParameter.Value != null)
                    deleted = (int)returnParameter.Value;
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
            return deleted;
        }

        public int updateSupplier(string supplierNameEn, string supplierNameAr, string supplierAddressEn, string supplierAddressAr, string supplierTelephoneNo, string supplierMobileNo, int? supplierId = 0)
        {
            int updated = 0;
            if (supplierId == 0) supplierId = null;
            if (supplierNameEn == "") supplierNameEn = null;
            if (supplierNameAr == "") supplierNameAr = null;
            if (supplierAddressEn == "") supplierAddressEn = null;
            if (supplierAddressAr == "") supplierAddressAr = null;
            if (supplierTelephoneNo == "") supplierTelephoneNo = null;
            if (supplierMobileNo == "") supplierMobileNo = null;
            using (SqlCommand cmd = new SqlCommand("updateSupplier", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@supplierId", SqlDbType.Int);
                cmd.Parameters.Add("@supplierNameEn", SqlDbType.NVarChar);
                cmd.Parameters.Add("@supplierNameAr", SqlDbType.NVarChar);
                cmd.Parameters.Add("@supplierAddressEn", SqlDbType.NVarChar);
                cmd.Parameters.Add("@supplierAddressAr", SqlDbType.NVarChar);
                cmd.Parameters.Add("@supplierTelephoneNo", SqlDbType.NVarChar);
                cmd.Parameters.Add("@supplierMobileNo", SqlDbType.NVarChar);

                cmd.Parameters["@supplierId"].Value = supplierId;
                cmd.Parameters["@supplierNameEn"].Value = supplierNameEn;
                cmd.Parameters["@supplierNameAr"].Value = supplierNameAr;
                cmd.Parameters["@supplierAddressEn"].Value = supplierAddressEn;
                cmd.Parameters["@supplierAddressAr"].Value = supplierAddressAr;
                cmd.Parameters["@supplierTelephoneNo"].Value = supplierTelephoneNo;
                cmd.Parameters["@supplierMobileNo"].Value = supplierMobileNo;
                if (con.State != ConnectionState.Open)
                    con.Open();
                SqlParameter returnParameter = cmd.Parameters.Add("RetVal", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;
                cmd.ExecuteReader();
                if (returnParameter.Value != null)
                    updated = (int)returnParameter.Value;
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
            return updated;
        }
        #endregion

        #region Status
        public int addStatus(string statusNameEn, string statusNameAr, string statusColor)
        {
            //transaction = con.BeginTransaction("SampleTransaction");
            int statusId;
            using (SqlCommand cmd = new SqlCommand("addStatus", con))
            {
                //cmd.Transaction = transaction;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@statusNameEn", SqlDbType.NVarChar);
                cmd.Parameters.Add("@statusNameAr", SqlDbType.NVarChar);
                cmd.Parameters.Add("@statusColor", SqlDbType.NVarChar);
                cmd.Parameters.Add("@statusId", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters["@statusNameEn"].Value = statusNameEn;
                cmd.Parameters["@statusNameAr"].Value = statusNameAr;
                cmd.Parameters["@statusColor"].Value = statusColor;

                if (con.State != ConnectionState.Open)
                    con.Open();
                cmd.ExecuteNonQuery();
                statusId = Convert.ToInt32(cmd.Parameters["@statusId"].Value);
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
            return statusId;
        }

        public DataTable getStatus(string statusNameEn, string statusNameAr, string statusColor, int? statusId = 0)
        {
            if (statusId == 0) statusId = null;
            if (statusNameEn == "") statusNameEn = null;
            if (statusNameAr == "") statusNameAr = null;
            if (statusColor == "") statusColor = null;
            DataTable dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand("SearchStatus", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@statusId", SqlDbType.Int);
                cmd.Parameters.Add("@statusNameEn", SqlDbType.NVarChar);
                cmd.Parameters.Add("@statusNameAr", SqlDbType.NVarChar);
                cmd.Parameters.Add("@statusColor", SqlDbType.NVarChar);
                cmd.Parameters["@statusId"].Value = statusId;
                cmd.Parameters["@statusNameEn"].Value = statusNameEn;
                cmd.Parameters["@statusNameAr"].Value = statusNameAr;
                cmd.Parameters["@statusColor"].Value = statusColor;
                if (con.State != ConnectionState.Open)
                    con.Open();
                dt.Load(cmd.ExecuteReader());
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
            return dt;
        }

        public int DeleteStatus(int statusId)
        {
            int deleted = 0;
            using (SqlCommand cmd = new SqlCommand("deleteStatus", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@statusId", SqlDbType.Int);
                cmd.Parameters["@statusId"].Value = statusId;
                if (con.State != ConnectionState.Open)
                    con.Open();
                SqlParameter returnParameter = cmd.Parameters.Add("RetVal", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;
                cmd.ExecuteNonQuery();
                if (returnParameter.Value != null)
                    deleted = (int)returnParameter.Value;
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
            return deleted;
        }

        public int UpdateStatus(string statusNameEn, string statusNameAr, string statusColor, int? statusId = 0)
        {
            int updated = 0;
            if (statusId == 0) statusId = null;
            if (statusNameEn == "") statusNameEn = null;
            if (statusNameAr == "") statusNameAr = null;
            using (SqlCommand cmd = new SqlCommand("updateStatus", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@statusId", SqlDbType.Int);
                cmd.Parameters.Add("@statusNameEn", SqlDbType.NVarChar);
                cmd.Parameters.Add("@statusNameAr", SqlDbType.NVarChar);
                cmd.Parameters.Add("@statusColor", SqlDbType.NVarChar);
                cmd.Parameters["@statusId"].Value = statusId;
                cmd.Parameters["@statusNameEn"].Value = statusNameEn;
                cmd.Parameters["@statusNameAr"].Value = statusNameAr;
                cmd.Parameters["@statusColor"].Value = statusColor;
                if (con.State != ConnectionState.Open)
                    con.Open();
                SqlParameter returnParameter = cmd.Parameters.Add("RetVal", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;
                cmd.ExecuteReader();
                if (returnParameter.Value != null)
                    updated = (int)returnParameter.Value;
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
            return updated;
        }
        #endregion


        #region Tables
        public int addTable(string tableNameEn, string tableNameAr, int tableChairNumber, bool tableIsVip, int tableStatusId)
        {
            //transaction = con.BeginTransaction("SampleTransaction");
            int tableId;
            using (SqlCommand cmd = new SqlCommand("addTable", con))
            {
                //cmd.Transaction = transaction;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@tableNameEn", SqlDbType.NVarChar);
                cmd.Parameters.Add("@tableNameAr", SqlDbType.NVarChar);
                cmd.Parameters.Add("@tableChairNumber", SqlDbType.Int);
                cmd.Parameters.Add("@tableIsVip", SqlDbType.Bit);
                cmd.Parameters.Add("@tableStatusId", SqlDbType.Int);
                cmd.Parameters.Add("@tableId", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters["@tableNameEn"].Value = tableNameEn;
                cmd.Parameters["@tableNameAr"].Value = tableNameAr;
                cmd.Parameters["@tableChairNumber"].Value = tableChairNumber;
                cmd.Parameters["@tableIsVip"].Value = tableIsVip;
                cmd.Parameters["@tableStatusId"].Value = tableStatusId;

                if (con.State != ConnectionState.Open)
                    con.Open();
                cmd.ExecuteNonQuery();
                tableId = Convert.ToInt32(cmd.Parameters["@tableId"].Value);
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
            return tableId;
        }

        public DataTable getTable(string tableNameEn, string tableNameAr, string tableChairNumber, bool? tableIsVip = null, int? tableStatusId = 0, int? tableId = 0)
        {
            if (tableId == 0) tableId = null;
            if (tableNameEn == "") tableNameEn = null;
            if (tableNameAr == "") tableNameAr = null;
            if (tableChairNumber == "") tableChairNumber = null;
            if (tableIsVip == null) tableIsVip = null;
            if (tableStatusId == 0) tableStatusId = null;
            DataTable dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand("SearchTable", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@tableId", SqlDbType.Int);
                cmd.Parameters.Add("@tableNameEn", SqlDbType.NVarChar);
                cmd.Parameters.Add("@tableNameAr", SqlDbType.NVarChar);
                cmd.Parameters.Add("@tableChairNumber", SqlDbType.Int);
                cmd.Parameters.Add("@tableIsVip", SqlDbType.Bit);
                cmd.Parameters.Add("@tableStatusId", SqlDbType.Int);
                cmd.Parameters["@tableId"].Value = tableId;
                cmd.Parameters["@tableNameEn"].Value = tableNameEn;
                cmd.Parameters["@tableNameAr"].Value = tableNameAr;
                cmd.Parameters["@tableChairNumber"].Value = tableChairNumber;
                cmd.Parameters["@tableIsVip"].Value = @tableIsVip;
                cmd.Parameters["@tableStatusId"].Value = @tableStatusId;
                if (con.State != ConnectionState.Open)
                    con.Open();
                dt.Load(cmd.ExecuteReader());
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
            return dt;
        }

        public int DeleteTable(int tableId)
        {
            int deleted = 0;
            using (SqlCommand cmd = new SqlCommand("deleteTable", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@tableId", SqlDbType.Int);
                cmd.Parameters["@tableId"].Value = tableId;
                if (con.State != ConnectionState.Open)
                    con.Open();
                SqlParameter returnParameter = cmd.Parameters.Add("RetVal", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;
                cmd.ExecuteNonQuery();
                if (returnParameter.Value != null)
                    deleted = (int)returnParameter.Value;
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
            return deleted;
        }

        public int UpdateStatus(string tableNameEn, string tableNameAr, string tableChairNumber, bool? tableIsVip = null, int? tableStatusId = 0, int? tableId = 0)
        {
            int updated = 0;
            if (tableId == 0) tableId = null;
            if (tableNameEn == "") tableNameEn = null;
            if (tableNameAr == "") tableNameAr = null;
            if (tableChairNumber == "") tableChairNumber = null;
            if (tableIsVip == null) tableIsVip = null;
            if (tableStatusId == 0) tableStatusId = null;
            using (SqlCommand cmd = new SqlCommand("updateTable", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@tableId", SqlDbType.Int);
                cmd.Parameters.Add("@tableNameEn", SqlDbType.NVarChar);
                cmd.Parameters.Add("@tableNameAr", SqlDbType.NVarChar);
                cmd.Parameters.Add("@tableChairNumber", SqlDbType.Int);
                cmd.Parameters.Add("@tableIsVip", SqlDbType.Bit);
                cmd.Parameters.Add("@tableStatusId", SqlDbType.Int);
                cmd.Parameters["@tableId"].Value = tableId;
                cmd.Parameters["@tableNameEn"].Value = tableNameEn;
                cmd.Parameters["@tableNameAr"].Value = tableNameAr;
                cmd.Parameters["@tableChairNumber"].Value = tableChairNumber;
                cmd.Parameters["@tableIsVip"].Value = tableIsVip;
                cmd.Parameters["@tableStatusId"].Value = tableStatusId;
                if (con.State != ConnectionState.Open)
                    con.Open();
                SqlParameter returnParameter = cmd.Parameters.Add("RetVal", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;
                cmd.ExecuteReader();
                if (returnParameter.Value != null)
                    updated = (int)returnParameter.Value;
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
            return updated;
        }
        #endregion

        #region ProgSetting
        public DataTable getProg()
        {
            DataTable dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand("SearchProg", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                if (con.State != ConnectionState.Open)
                    con.Open();
                dt.Load(cmd.ExecuteReader());
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
            return dt;
        }

        public int updateProg(string nameEn, string nameAr, string addressEn, string addressAr, string telephoneNo, string mobileNo, string website, string resetFooter, string logoPath)
        {
            int updated = 0;
            if (nameEn == "") nameEn = null;
            if (nameAr == "") nameAr = null;
            if (addressEn == "") addressEn = null;
            if (addressAr == "") addressAr = null;
            if (telephoneNo == "") telephoneNo = null;
            if (mobileNo == "") mobileNo = null;
            if (website == "") website = null;
            if (resetFooter == "") resetFooter = null;
            if (logoPath == "") logoPath = null;

            using (SqlCommand cmd = new SqlCommand("updateProg", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@nameEn", SqlDbType.NVarChar);
                cmd.Parameters.Add("@nameAr", SqlDbType.NVarChar);
                cmd.Parameters.Add("@addressEn", SqlDbType.NVarChar);
                cmd.Parameters.Add("@addressAr", SqlDbType.NVarChar);
                cmd.Parameters.Add("@telephoneNo", SqlDbType.NVarChar);
                cmd.Parameters.Add("@mobileNo", SqlDbType.NVarChar);
                cmd.Parameters.Add("@website", SqlDbType.NVarChar);
                cmd.Parameters.Add("@resetFooter", SqlDbType.NVarChar);
                cmd.Parameters.Add("@logoPath", SqlDbType.NVarChar);

                cmd.Parameters["@nameEn"].Value = nameEn;
                cmd.Parameters["@nameAr"].Value = nameAr;
                cmd.Parameters["@addressEn"].Value = addressEn;
                cmd.Parameters["@addressAr"].Value = addressAr;
                cmd.Parameters["@telephoneNo"].Value = telephoneNo;
                cmd.Parameters["@mobileNo"].Value = mobileNo;
                cmd.Parameters["@website"].Value = website;
                cmd.Parameters["@resetFooter"].Value = resetFooter;
                cmd.Parameters["@logoPath"].Value = logoPath;

                if (con.State != ConnectionState.Open)
                    con.Open();
                SqlParameter returnParameter = cmd.Parameters.Add("RetVal", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;
                cmd.ExecuteReader();
                if (returnParameter.Value != null)
                    updated = (int)returnParameter.Value;
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
            return updated;
        }
        #endregion
    }
}