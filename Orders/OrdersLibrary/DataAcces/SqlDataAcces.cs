using Dapper;
using OrdersLibrary.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersLibrary
{
    public class SqlDataAcces
    {
       
        public static List<RoleModel> GetUserTypeClient()
        {            
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<RoleModel>("SELECT * FROM Role WHERE id='2'", new DynamicParameters());
                return output.ToList();
            }
        }
        
        public static void RegisterUsers(UsersModel users)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute(" insert into Register(FirstName,LastName,UserName,Email,Password,RoleId) values(@FirstName,@LastName,@UserName,@Email,@Password,@RoleId)", users);

            }
        }
        private static string LoadConnectionString(string id = "Database")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
