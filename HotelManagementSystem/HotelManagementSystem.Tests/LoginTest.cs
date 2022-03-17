using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagementSystem.Business;
using HotelManagementSystem.Models;
using Xunit;

namespace HotelManagementSystem.Tests
{
    public class LoginTest
    {
        [Fact]
        public void Login_IfWorks()
        {
            string username = "admin";
            string password = "admin";

            UserModel users = new UserModel(username, password);

            UserOperations userOp = new UserOperations();

            UserModel user = userOp.Login(users);
            
            Assert.Equal(user.username,username);
        }
    }
}
