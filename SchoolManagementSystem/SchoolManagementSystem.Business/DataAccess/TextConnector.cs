using SchoolManagementSystem.Business.Models;
using SchoolManagementSystem.Business.Models.TestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Business.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string TestFile = "Test.txt";
        private const string TestFile2 = "Test2.txt";
        private const string SubjectTxt = "Subject.txt";
        private const string StudentTxt = "Student.txt";
        private const string ClassesTxt = "Classes.txt";
        public StudentsModel AddStudents(StudentsModel students)
        {
            List<StudentsModel> std = StudentTxt.FullFilePatch().LoadFile().ConvertToStudentModels();

            int currentId = 1;
            if(std.Count > 0)
            {
                currentId = std.OrderByDescending(x => x.Id).First().Id + 1;
            }
            students.Id = currentId;
            std.Add(students);
            std.SaveToStudentsFile(StudentTxt);

            return students;
        }

        public SubjectModel AddSubject(SubjectModel subject)
        {
            List<SubjectModel> sbj = SubjectTxt.FullFilePatch().LoadFile().ConvertToSubjectModels();

            int currentId = 1;
            if (sbj.Count > 0)
            {
                currentId = sbj.OrderByDescending(x => x.Id).First().Id + 1;
            }
            subject.Id = currentId;
            sbj.Add(subject);
            sbj.SaveToSubjectsFile(SubjectTxt);

            return subject;
        }

        public ClassesModel CreateClasses(ClassesModel classes)
        {
            List<ClassesModel> cls = ClassesTxt.FullFilePatch().LoadFile().ConvertToClassModels(SubjectTxt, StudentTxt);
            int currentId = 1;
            if(cls.Count > 0)
            {
                currentId = cls.OrderByDescending(x => x.Id).First().Id + 1;
            }
            classes.Id = currentId;
            cls.Add(classes);
            cls.SaveToClassesFile(ClassesTxt);

            return classes;
        }

        public List<StudentsModel> DeleteStudent()
        {
            throw new NotImplementedException();
        }

        public List<StudentsModel> GetAllStudents()
        {
            return null;
        }

        public List<SubjectModel> GetAllSubjects()
        {
            return null;
        }

        public List<TestModel> GetTest()
        {
            return null;
        }

        public TestModel2 Test2DB(TestModel2 test)
        {
            List<TestModel2> tests = TestFile2.FullFilePatch().LoadFile().ConvertToTest2Models();

            int currentId = 1;
            if (tests.Count > 0)
            {
                currentId = tests.OrderByDescending(x => x.Id).First().Id + 1;
            }
            test.Id = currentId;

            tests.Add(test);

            ////Save the list<string> to the text file
            tests.SaveToTest2File(TestFile);

            return test;
        }

        public TestModel TestDB(TestModel test)
        {
            List<TestModel> tests = TestFile.FullFilePatch().LoadFile().ConvertToTestModels();
                        
            int currentId = 1;
            if (tests.Count > 0)
            {
                currentId = tests.OrderByDescending(x => x.Id).First().Id + 1;
            }
            test.Id = currentId;
            
            tests.Add(test);

            ////Save the list<string> to the text file
            tests.SaveToTestFile(TestFile);

            return test;
        }
    }
}
