using HotelManagementSystem.Models;
using System.Data;

namespace HotelManagementSystem.Business
{
    public interface IUserOperations
    {
        int InsertEmployee(UserModel users);
        DataTable Login(UserModel users);
    }
}