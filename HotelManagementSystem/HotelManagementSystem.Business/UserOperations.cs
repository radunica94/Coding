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
    public class UserOperations : IUserOperations
    {
        public HotelManagementSystemDB db = new HotelManagementSystemDB();
        private readonly IUserOperations users;

        public DataTable Login(UserModel users)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Register where username = '" + users.username + "' and password = '" + users.password + "'";
            return db.ExeReader(cmd);
        }
        public int InsertEmployee(UserModel users)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Register VALUES('" + users.firstName + "','" + users.lastName + "','" + users.email + "','" + users.username + "','" + users.password + "','" + users.userType + "','" + "')";
            return db.ExeNonQuery(cmd);
        }
    }
}
