using SchoolManagementSystem.Business.Models;

namespace SchoolManagementSystem.Business.DataAccess
{
    public class TextConnector : IDataConnection
    {      
        private const string StudentTxt = "Student.txt";
        private const string UserTxt = "User.txt";
        public StudentsModel AddStudents(StudentsModel students)
        {
            List<StudentsModel> std = StudentTxt.FullFilePatch().LoadFile().ConvertToStudentModels();

            int currentId = 1;
            if (std.Count > 0)
            {
                currentId = std.OrderByDescending(x => x.Id).First().Id + 1;
            }
            students.Id = currentId;
            std.Add(students);
            std.SaveToStudentsFile(StudentTxt);

            return students;
        }

        public UsersModel AddUsers(UsersModel users)
        {
            List<UsersModel> usr = UserTxt.FullFilePatch().LoadFile().ConvertToUsersModels();

            int currentId = 1;
            if (usr.Count > 0)
            {
                currentId = usr.OrderByDescending(x => x.Id).First().Id + 1;
            }
            users.Id = currentId;
            usr.Add(users);
            usr.SaveToUsersFile(UserTxt);

            return users;
        }

        public StudentsModel DeleteStudent(StudentsModel students)
        {
            throw new NotImplementedException();
        }

        public List<StudentsModel> GetAllStudents()
        {
            throw new NotImplementedException();
        }

        public List<UsersModel> LoginAsAdmin()
        {
            throw new NotImplementedException();
        }

        public List<UsersModel> LoginAsStudent()
        {
            throw new NotImplementedException();
        }

        public List<UsersModel> LoginAsTeacher()
        {
            throw new NotImplementedException();
        }

        public StudentsModel UpdateStudents(StudentsModel students)
        {
            throw new NotImplementedException();
        }
    }
}
