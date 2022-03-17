using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.Models
{
    public class UserModel
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string username { get; set; }
        public string userType { get; set; }

        public UserModel (string userName,string passWord)
        {
            username = userName;
            password = passWord;
        }
        public UserModel()
        {

        }
    }
}
