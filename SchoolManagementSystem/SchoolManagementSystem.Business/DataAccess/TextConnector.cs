using SchoolManagementSystem.Business.Models;

namespace SchoolManagementSystem.Business.DataAccess
{
    public class TextConnector : IDataConnection
    {      
        private const string StudentTxt = "Student.txt";
        private const string UserTxt = "User.txt";
        private const string SubjectTxt = "Subject.txt";
        private const string ClassTxt = "Class.txt";
        private const string GradeTxt = "Grade.txt";

        public void AddGrade(GradeModel grade)
        {
            List<GradeModel> grades = GradeTxt.FullFilePatch().LoadFile().ConvertToGradeModels(StudentTxt, SubjectTxt);

            int currentId = 1;
            if (grades.Count > 0)
            {
                currentId = grades.OrderByDescending(x => x.Id).First().Id + 1;
            }
            grade.Id = currentId;
            grades.Add(grade);
            grades.SaveToGradeFile(GradeTxt);
        }

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

        public ClassModel CreateClass(ClassModel classes)
        {
            List<ClassModel> cls = ClassTxt.FullFilePatch().LoadFile().ConvertToClassModels(StudentTxt);

            int currentId = 1;
            if (cls.Count > 0)
            {
                currentId = cls.OrderByDescending(x => x.Id).First().Id + 1;
            }
            classes.Id = currentId;
            cls.Add(classes);
            cls.SaveToClassFile(ClassTxt);

            return classes;
        }
        


        public SubjectModel CreateSubject(SubjectModel subject)
        {
            List<SubjectModel> subj = SubjectTxt.FullFilePatch().LoadFile().ConvertToSubjectModels(UserTxt);

            int currentId = 1;
            if (subj.Count > 0)
            {
                currentId = subj.OrderByDescending(x => x.Id).First().Id + 1;
            }
            subject.Id = currentId;
            subj.Add(subject);
            subj.SaveToSubjectFile(SubjectTxt);
            
            return subject;
        }

       
        

        public StudentsModel DeleteStudent(StudentsModel students)
        {
            throw new NotImplementedException();
        }

        public List<StudentsModel> GetAllStudents()
        {
            return StudentTxt.FullFilePatch().LoadFile().ConvertToStudentModels();
        }

        public List<SubjectModel> GetAllSubjects()
        {
            return SubjectTxt.FullFilePatch().LoadFile().ConvertToSubjectModels(UserTxt);
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
            return UserTxt.FullFilePatch().LoadFile().ConvertToUsersModels();
        }

        public StudentsModel UpdateStudents(StudentsModel students)
        {
            throw new NotImplementedException();
        }
    }
}
