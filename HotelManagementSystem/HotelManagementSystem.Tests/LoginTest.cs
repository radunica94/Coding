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
            // Arrange
            string username = "admin";
            string password = "password";

            // Act
            UserOperations userOp = new UserOperations();

            UserModel user = userOp.Login(username);
            //Assert
            Assert.Equal(user.username,username);
        }
    }
}
