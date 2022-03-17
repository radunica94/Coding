using System.Data;
using System.Data.SqlClient;

namespace HotelManagementSystem.DataAccess
{
    public interface IHotelManagementSystemDB
    {
        int ExeNonQuery(SqlCommand cmd);
        DataTable ExeReader(SqlCommand cmd);
        SqlConnection getcon();
    }
}