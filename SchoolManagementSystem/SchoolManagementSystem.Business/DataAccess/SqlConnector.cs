﻿
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
                p.Add("@Gender", students.Gender);
                p.Add("@id",0,dbType: DbType.Int32,direction: ParameterDirection.Output);

                connection.Execute("dbo.spStudents_Insert", p, commandType: CommandType.StoredProcedure);

                students.Id = p.Get<int>("@id");

                return students;
            }
        }

        public SubjectModel AddSubject(SubjectModel subject)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@Professor", subject.Professor);
                p.Add("@Subject", subject.Subject);
               
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spSubject_Insert", p, commandType: CommandType.StoredProcedure);

                subject.Id = p.Get<int>("@id");

                return subject;
            }
        }

        public ClassesModel CreateClasses(ClassesModel classes)
        {
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@ClassName",classes.ClassName);
                p.Add("@id",0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spClasses_Insert",p, commandType: CommandType.StoredProcedure);

                classes.Id = p.Get<int>("@id");
                foreach(StudentsModel student in classes.Students)
                {
                    foreach(SubjectModel subject in classes.Subject)
                    {
                        p = new DynamicParameters();
                        p.Add("@idStudent", student.Id);
                        p.Add("@idClasses", classes.Id);
                        p.Add("@idSubjects", subject.Id);

                        connection.Execute("dbo.spCreateClasses_Insert", p, commandType: CommandType.StoredProcedure);
                    }
                }
                
                return classes;
            }
        }

        public List<StudentsModel> DeleteStudent()
        {
            List<StudentsModel> std;
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                std = connection.Query<StudentsModel>("dbo.spStudents_Delete").ToList();
            }
            return std;
        }

        public List<StudentsModel> GetAllStudents()
        {
            List<StudentsModel> students;
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                students = connection.Query<StudentsModel>("dbo.spStudents_GetStudents").ToList();
            }
            return students;
        }

        public List<SubjectModel> GetAllSubjects()
        {
            List<SubjectModel> subjects;
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                subjects = connection.Query<SubjectModel>("dbo.spSubject_GetSubject").ToList();
            }
            return subjects;
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
