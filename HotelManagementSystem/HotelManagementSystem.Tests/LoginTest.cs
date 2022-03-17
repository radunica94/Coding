using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManagementSystem.Business;
using HotelManagementSystem.Models;
using Moq;
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

            //var login = new Mock<IUserOperations>();
           // login.Setup(x => x.Login(users)).RetursAsync


            //var calculator = new Mock<ICalculator>();
            //calculator.Setup(x => x.Add(2, 2)).Returns(4);
            //Assert.Equal(4, calculator.Object.Add(2, 2));
        }        
    }
}
