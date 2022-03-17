using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem.DataAccess
{
    public class HotelManagementSystemDB
    {
        public SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Coding\HotelManagementSystem\HotelManagementSystem.DataAccess\HotelManagementSystem.DB.mdf;Integrated Security=True");
        private SqlDataAdapter myAdapter;

        /// <summary>
        /// check whether the db is open or not
        /// if it's closed, than open it
        /// </summary>
        /// <returns></returns>
        public SqlConnection getcon()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }
        /// <summary>
        /// functon to perform select query
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
        public DataTable ExeReader(SqlCommand cmd)
        {
            cmd.Connection = getcon();
            SqlDataReader sdr;
            DataTable dt = new DataTable();

            sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            conn.Close();
            return dt;
        }

        public int ExeNonQuery(SqlCommand cmd)
        {
            cmd.Connection = getcon();
            int rowsaffected = -1;
            rowsaffected = cmd.ExecuteNonQuery();
            conn.Close();
            return rowsaffected;
        }
    }
}
