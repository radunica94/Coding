using Dapper;
using SchoolManagementSystem.Business.Models;
using System.Data;

namespace SchoolManagementSystem.Business.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        private const string db = "SchoolManagementSystem";

        public void AddGrade(GradeModel grade)
        {
            throw new NotImplementedException();
        }

        public StudentsModel AddStudents(StudentsModel students)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@FirstName", students.FirstName);
                p.Add("@LastName", students.LastName);
                p.Add("@Email", students.Email);
                p.Add("@Phone", students.Phone);
                p.Add("@Grade", students.Grade);
                p.Add("@Birthday", students.Birthday);
                p.Add("@Gender", students.Gender);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spStudents_Insert", p, commandType: CommandType.StoredProcedure);

                students.Id = p.Get<int>("@id");

                return students;
            }
        }
       
        
        public UsersModel AddUsers(UsersModel users)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@Username", users.UserName);
                p.Add("@Password", users.Password);
                p.Add("@FirstName", users.FirstName);
                p.Add("@LastName", users.LastName);
                p.Add("@Email", users.Email);
                p.Add("@Phone", users.Phone);
                p.Add("@Street", users.Street);
                p.Add("@City", users.City);
                p.Add("@Country", users.Country);
                p.Add("@Role", users.Role);
                p.Add("@Birthday", users.Birthday);
                p.Add("@Apartment", users.Apartment);
                p.Add("@ZipCode", users.ZipCode);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spUsers_Insert", p, commandType: CommandType.StoredProcedure);

                users.Id = p.Get<int>("@id");

                return users;
            }
        }

        public ClassModel CreateClass(ClassModel classes)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@ClassName", classes.ClassName);
                p.Add("@ClassCapacity", classes.ClassCapacity);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spClass_Insert", p, commandType: CommandType.StoredProcedure);

                classes.Id = p.Get<int>("@id");

                foreach (StudentsModel sm in classes.StudentsList)
                {
                    p = new DynamicParameters();
                    p.Add("@ClassId", classes.Id);
                    p.Add("@StudentId", sm.Id);

                    connection.Execute("dbo.spCreateClass_Insert", p, commandType: CommandType.StoredProcedure);
                }

                return classes;
            }
        }

        public SubjectModel CreateSubject(SubjectModel subject)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@SubjectName", subject.SubjectName);
                p.Add("@Year", subject.Year);
                p.Add("@Semester", subject.Semester);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spSubject_Insert", p, commandType: CommandType.StoredProcedure);

                subject.Id = p.Get<int>("@id");

                foreach (UsersModel um in subject.Teachers)
                {
                    p = new DynamicParameters();
                    p.Add("@SubjectId", subject.Id);
                    p.Add("@UsersId", um.Id);

                    connection.Execute("dbo.spCreateSubject_Insert", p, commandType: CommandType.StoredProcedure);
                }

                return subject;
            }
        }

        public StudentsModel DeleteStudent(StudentsModel students)
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spStudents_Delete", p, commandType: CommandType.StoredProcedure);

                students.Id = p.Get<int>("@id");

                return students;
            }
        }



        public List<StudentsModel> GetAllStudents()
        {
            List<StudentsModel> students;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                students = connection.Query<StudentsModel>("dbo.spStudents_GetStudents").ToList();
            }
            return students;
        }

        public List<SubjectModel> GetAllSubjects()
        {
            List<SubjectModel> subject;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                subject = connection.Query<SubjectModel>("dbo.spSubject_GetSubjects").ToList();
            }
            return subject;
        }

        public List<UsersModel> LoginAsAdmin()
        {
            List<UsersModel> users;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                users = connection.Query<UsersModel>("dbo.spUser_GetAdmin").ToList();
            }
            return users;
        }

        public List<UsersModel> LoginAsStudent()
        {
            List<UsersModel> users;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                users = connection.Query<UsersModel>("dbo.spUser_GetSudent").ToList();
            }
            return users;
        }

        public List<UsersModel> LoginAsTeacher()
        {
            List<UsersModel> users;
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                users = connection.Query<UsersModel>("dbo.spUser_GetTeacher").ToList();
            }
            return users;
        }

        public StudentsModel UpdateStudents(StudentsModel students)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();

                p.Add("@FirstName", students.FirstName);
                p.Add("@LastName", students.LastName);
                p.Add("@Email", students.Email);
                p.Add("@Phone", students.Phone);
                p.Add("@Grade", students.Grade);
                p.Add("@Birthday", students.Birthday);
                p.Add("@Gender", students.Gender);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spStudents_Update", p, commandType: CommandType.StoredProcedure);

                students.Id = p.Get<int>("@id");

                return students;
            }
        }
    }
}
