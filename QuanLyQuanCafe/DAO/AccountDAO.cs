﻿using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get
            {
                if (instance == null) instance = new AccountDAO();
                return instance;
            }

            set
            {
                instance = value;
            }
        }
        private AccountDAO() { }
        public bool checkLogin(string userName, string passWord)
        {
            string query = string.Format("select * from F_Login ('{0}','{1}')",userName,passWord);
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            Globals.setGlobalsUserName(result.Rows[0][0].ToString());
            return result.Rows.Count > 0;


        }
        public bool UpdateAccount(string userName, string dis, string pass, string newpass)
        {
            int count = DataProvider.Instance.ExecuteNonQuery("exec USP_UpdateAccount @userName , @displayName , @password , @newPassword", new object[] { userName,dis, pass, newpass});

            return count > 0;
        }
        public Account GetAccountByUserName(string userName)
        {
            string query = "Select * from account where userName = N'" + userName + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }
        public DataTable GetListAccount()
        {
            string query = "select userName, displayName , type from dbo.Account ";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public bool InsertAccount(string name, string displayName, int type)
        {
            string query = string.Format("INSERT dbo.Account ( UserName, DisplayName, Type )VALUES  ( N'{0}', N'{1}', {2})", name, displayName, type);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateAccount(string name, string displayName, int type)
        {
            string query = string.Format("UPDATE dbo.Account SET DisplayName = N'{0}', Type = {1} WHERE UserName = N'{2}'", displayName, type, name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteAccount(string name)
        {
            string query = string.Format("Delete Account where UserName = N'{0}'", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public DataTable getAccount(string username)
        {          
            string query = string.Format("select * from F_GetAccount(N'{0}')",username);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public DataTable GetAccountNoMember()
        {
           
            string query = "select * from F_GetAccountNoMember()";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
    }
}
