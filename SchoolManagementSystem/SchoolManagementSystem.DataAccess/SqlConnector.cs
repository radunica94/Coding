
using SchoolManagementSystem.Business.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        public StudentsModel AddStudents(StudentsModel students)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig))
        }
    }
}
