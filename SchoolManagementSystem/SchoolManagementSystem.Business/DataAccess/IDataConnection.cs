using SchoolManagementSystem.Business.Models;

namespace SchoolManagementSystem.Business.DataAccess
{
    public interface IDataConnection
    {
        StudentsModel AddStudents(StudentsModel students);
        StudentsModel UpdateStudents(StudentsModel students);
        List<StudentsModel> GetAllStudents();
        List<SubjectModel> GetAllSubjects();
        StudentsModel DeleteStudent(StudentsModel students);
        UsersModel AddUsers(UsersModel users);
        List<UsersModel> LoginAsAdmin();
        List<UsersModel> LoginAsStudent();
        List<UsersModel> LoginAsTeacher();
        ClassModel CreateClass(ClassModel classes);

        SubjectModel CreateSubject(SubjectModel subject);
        void AddGrade(GradeModel grade);
    }
}
