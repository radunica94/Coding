using SchoolManagementSystem.Business.Models;
using SchoolManagementSystem.Business.Models.TestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Business.DataAccess
{
    public interface IDataConnection
    {
        StudentsModel AddStudents(StudentsModel students);
        List<StudentsModel> GetAllStudents();
        List<StudentsModel> DeleteStudent();
        SubjectModel AddSubject(SubjectModel subject);
        List<SubjectModel> GetAllSubjects();
        ClassesModel CreateClasses(ClassesModel classes);
        // Just Testing 
        TestModel TestDB (TestModel test );
        List<TestModel> GetTest();
        TestModel2 Test2DB(TestModel2 test);
    }
}
