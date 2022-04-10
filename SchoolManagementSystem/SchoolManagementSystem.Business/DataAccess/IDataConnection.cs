using SchoolManagementSystem.Business.Models;

namespace SchoolManagementSystem.Business.DataAccess
{
    public interface IDataConnection
    {
        StudentsModel AddStudents(StudentsModel students);
        StudentsModel UpdateStudents(StudentsModel students);
        List<StudentsModel> GetAllStudents();
        StudentsModel DeleteStudent(StudentsModel students);
        UsersModel AddUsers(UsersModel users);
        List<UsersModel> LoginAsAdmin();
        List<UsersModel> LoginAsStudent();
        List<UsersModel> LoginAsTeacher();
    }
}
