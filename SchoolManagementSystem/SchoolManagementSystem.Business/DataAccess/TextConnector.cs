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
        public StudentsModel AddStudents(StudentsModel students)
        {
            throw new NotImplementedException();
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
