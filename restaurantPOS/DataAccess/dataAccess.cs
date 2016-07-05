﻿using System;
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
        public int addClient(string clientNameEn, string clientNameAr, string clientAddressEn, string clientAddressAr, string clientTelephoneNo, string clientMobileNo)
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
                cmd.Parameters.Add("@clientMobileNo", SqlDbType.NVarChar);
                cmd.Parameters.Add("@clientId", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.Parameters["@clientNameEn"].Value = clientNameEn;
                cmd.Parameters["@clientNameAr"].Value = clientNameAr;
                cmd.Parameters["@clientAddressEn"].Value = clientAddressEn;
                cmd.Parameters["@clientAddressAr"].Value = clientAddressAr;
                cmd.Parameters["@clientTelephoneNo"].Value = clientTelephoneNo;
                cmd.Parameters["@clientMobileNo"].Value = clientMobileNo;
                if (con.State != ConnectionState.Open)
                    con.Open();
                cmd.ExecuteNonQuery();
                clientId = Convert.ToInt32(cmd.Parameters["@clientId"].Value);
                if (con.State != ConnectionState.Closed)
                    con.Close();
            }
            return clientId;
        }

        public DataTable getClient(string clientNameEn, string clientNameAr, string clientAddressEn, string clientAddressAr, string clientTelephoneNo, string clientMobileNo, int? clientId = 0)
        {
            if (clientId == 0) clientId = null;
            if(clientNameEn == "") clientNameEn = null;
            if(clientNameAr == "") clientNameAr = null;
            if(clientAddressEn == "") clientAddressEn = null;
            if(clientAddressAr == "") clientAddressAr = null;
            if(clientTelephoneNo == "") clientTelephoneNo = null;
            if (clientMobileNo == "") clientMobileNo = null;
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
                cmd.Parameters["@clientId"].Value = clientId;
                cmd.Parameters["@clientNameEn"].Value = clientNameEn;
                cmd.Parameters["@clientNameAr"].Value = clientNameAr;
                cmd.Parameters["@clientAddressEn"].Value = clientAddressEn;
                cmd.Parameters["@clientAddressAr"].Value = clientAddressAr;
                cmd.Parameters["@clientTelephoneNo"].Value = clientTelephoneNo;
                cmd.Parameters["@clientMobileNo"].Value = clientMobileNo;
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

        public int updateClient(string clientNameEn, string clientNameAr, string clientAddressEn, string clientAddressAr, string clientTelephoneNo, string clientMobileNo, int? clientId = 0)
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
                cmd.Parameters["@clientId"].Value = clientId;
                cmd.Parameters["@clientNameEn"].Value = clientNameEn;
                cmd.Parameters["@clientNameAr"].Value = clientNameAr;
                cmd.Parameters["@clientAddressEn"].Value = clientAddressEn;
                cmd.Parameters["@clientAddressAr"].Value = clientAddressAr;
                cmd.Parameters["@clientTelephoneNo"].Value = clientTelephoneNo;
                cmd.Parameters["@clientMobileNo"].Value = clientMobileNo;
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
        public int addUnit(string unitNameEn, string unitNameAr)
        {
            //transaction = con.BeginTransaction("SampleTransaction");
            int unitId;
            using (SqlCommand cmd = new SqlCommand("addUnit", con))
            {
                //cmd.Transaction = transaction;
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
                cmd.Parameters["@goodsNameEn"].Value = goodsNameEn;
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
            using (SqlCommand cmd = new SqlCommand("updateUnit", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@goodsId", SqlDbType.Int);
                cmd.Parameters.Add("@unitId", SqlDbType.Int);
                cmd.Parameters.Add("@goodsNameEn", SqlDbType.NVarChar);
                cmd.Parameters.Add("@unitNameAr", SqlDbType.NVarChar);
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
    }
}