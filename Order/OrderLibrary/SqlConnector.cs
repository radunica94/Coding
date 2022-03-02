using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderLibrary
{
    public class SqlConnector
    {
        public static void RegisterUser(UserModel user)
        {
            using(IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Users (FirstName,LastName,Email,Password,ConfirmPassword) values (@FirstName, @LastName, @Email, @Password, @ConfirmPassword", user);
                
            } 

        }
        private static string LoadConnectionString(string id = "Order")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
