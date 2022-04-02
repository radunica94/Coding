
using Dapper;
using SchoolManagementSystem.Business;
using SchoolManagementSystem.Business.Models;
using SchoolManagementSystem.Business.Models.TestModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Business.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        private const string db = "SchoolManagementSystem";
        public StudentsModel AddStudents(StudentsModel students)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@FirstName", students.FirstName);
                p.Add("@LastName",students.LastName);
                p.Add("@Email",students.Email);
                p.Add("@Phone", students.Phone);
                p.Add("@Grade", students.Grade);
                p.Add("@Birthday", students.Birthday);
                p.Add("@id",0,dbType: DbType.Int32,direction: ParameterDirection.Output);

                connection.Execute("dbo.spStudents", p, commandType: CommandType.StoredProcedure);

                students.Id = p.Get<int>("@id");

                return students;
            }
        }

        public List<TestModel> GetTest()
        {
            List<TestModel> output;
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output=connection.Query<TestModel>("dbo.spTable_1_SELECT").ToList();
            }
            return output;
        }

        public TestModel2 Test2DB(TestModel2 test)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@Name", test.Name);

                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.spTest2_Insert", p, commandType: CommandType.StoredProcedure);

                test.Id = p.Get<int>("@id");

                return test;
            }
        }

        public TestModel TestDB(TestModel test)
        {
           using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
           {
                var p = new DynamicParameters();
                p.Add("@Test", test.Test);
                p.Add("@Date",test.Date);
                p.Add("@Picture",test.Picture);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTest", p, commandType: CommandType.StoredProcedure);

                test.Id = p.Get<int>("@id");

                return test;
           }
        }
    }
}
