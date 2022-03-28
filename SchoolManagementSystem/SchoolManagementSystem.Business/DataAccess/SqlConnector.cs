
using Dapper;
using SchoolManagementSystem.Business;
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
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("SchoolManagementSystem")))
            {
                var p = new DynamicParameters();
                p.Add("@FirstName", students.firstName);
                p.Add("@LastName",students.lastName);
                p.Add("@Email",students.email);
                p.Add("@Phone", students.phone);
                p.Add("@Grade", students.grade);
                p.Add("@Birthday", students.birthday);
                p.Add("@id",0,dbType: DbType.Int32,direction: ParameterDirection.Output);

                connection.Execute("dbo.spStudents", p, commandType: CommandType.StoredProcedure);

                students.id = p.Get<int>("@id");

                return students;
            }
        }
    }
}
