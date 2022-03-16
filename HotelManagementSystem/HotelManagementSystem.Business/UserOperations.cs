using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagementSystem.DataAccess;
using HotelManagementSystem.Models;

namespace HotelManagementSystem.Business
{
    public class UserOperations
    {
        public HotelManagementSystemDB db = new HotelManagementSystemDB();
        public UserModel user = new UserModel();

        public DataTable Login(UserModel users)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Register where username = '" + users.username + "' and password = '" + users.password + "'";
            return db.ExeReader(cmd);
        }

    }
}
