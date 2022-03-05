using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace OrderSystemLibrary
{
    public class SqlDataAcces
    {
        public static void SaveUser(UsersModel user)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Register (FirstName, LastName, Email, Password, ConfirmPassword) VALUES(@FirstName, @LastName, @Email, @Password, @ConfirmPassword)", user);
            }
        }

        private static string LoadConnectionString(string id = "OrderSystem")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
