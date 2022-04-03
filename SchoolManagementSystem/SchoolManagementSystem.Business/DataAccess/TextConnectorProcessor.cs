using SchoolManagementSystem.Business.Models;
using SchoolManagementSystem.Business.Models.TestModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Business.DataAccess
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePatch(this string fileName)
        {
            return $"{ ConfigurationManager.AppSettings["filePatch"] }\\{ fileName } ";
        }
        // Load the text file and convert the text file to a List<PrizeModel>
        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }
        public static List<StudentsModel> ConvertToStudentModels(this List<string> lines)
        {
            List<StudentsModel> output = new List<StudentsModel>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                StudentsModel p = new StudentsModel();
                p.Id = int.Parse(cols[0]);
                p.FirstName = cols[1];
                p.LastName = cols[2];
                p.Email = cols[3];
                p.Phone = cols[4];
                p.Grade = cols[5];
                p.Birthday = Convert.ToDateTime(cols[6]);
              
                output.Add(p);
            }
            return output;
        }

        public static List<SubjectModel> ConvertToSubjectModels(this List<string> lines)
        {
            List<SubjectModel> output = new List<SubjectModel>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                SubjectModel p = new SubjectModel();
                p.Id = int.Parse(cols[0]);
                p.Professor = cols[1];
                p.Subject = cols[2];
                output.Add(p);
            }
            return output;
        }

        public static List<ClassesModel> ConvertToClassModels(this List<string> lines, string studentFileName, string subjectFileName)
        {
            List<ClassesModel> output = new List<ClassesModel>();
            List<StudentsModel> students = studentFileName.FullFilePatch().LoadFile().ConvertToStudentModels();
            List<SubjectModel> subjects = subjectFileName.FullFilePatch().LoadFile().ConvertToSubjectModels();
            foreach(string line in lines)
            {
                string[] cols = line.Split(',');

                ClassesModel c = new ClassesModel();
                c.Id = int.Parse(cols[0]);
                c.ClassName = cols[1];

                string[] studentIds = cols[2].Split('|');

                foreach(string id in studentIds)
                {
                    c.Students.Add(students.Where(x=>x.Id==int.Parse(id)).First());
                }
                

                string[] subjectIds = cols[3].Split('|');
                foreach (string id in studentIds)
                {
                    c.Subject.Add(subjects.Where(x => x.Id == int.Parse(id)).First());
                }

                output.Add(c);
            }


            return output;
        }
        public static void SaveToClassesFile(this List<ClassesModel> classes, string filename)
        {
            List<string> lines = new List<string>();

            foreach(ClassesModel c in classes)
            {
                lines.Add($"{c.Id},{c.ClassName},{ConvertStudentsToString(c.Students)},{ConvertSubjectsToString(c.Subject)}");
            }
            File.WriteAllLines(filename.FullFilePatch(), lines);
        }

        private static string ConvertStudentsToString(List<StudentsModel> students)
        {
            string output = "";

            if (students.Count == 0)
            {
                return "";
            }

            foreach (StudentsModel s in students)
            {
                output += $"{ s.Id }|";
            }

            output = output.Substring(0, output.Length - 1);

            return output;
        }

        private static string ConvertSubjectsToString(List<SubjectModel> subjects)
        {
            string output = "";

            if (subjects.Count == 0)
            {
                return "";
            }

            foreach (SubjectModel s in subjects)
            {
                output += $"{ s.Id }|";
            }

            output = output.Substring(0, output.Length - 1);

            return output;
        }

        public static void SaveToStudentsFile(this List<StudentsModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (StudentsModel p in models)
            {
                lines.Add($"{ p.Id },{ p.FirstName },{ p.LastName },{ p.Email },{ p.Phone },{p.Grade},{p.Birthday}");
            }
            File.WriteAllLines(fileName.FullFilePatch(), lines);
        }
        public static void SaveToSubjectsFile(this List<SubjectModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (SubjectModel p in models)
            {
                lines.Add($"{ p.Id },{ p.Professor },{ p.Subject }");
            }
            File.WriteAllLines(fileName.FullFilePatch(), lines);
        }

        public static List<TestModel> ConvertToTestModels(this List<string> lines)
        {
            List<TestModel> output = new List<TestModel>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                TestModel t = new TestModel();
                
                t.Id = int.Parse(cols[0]);
                t.Test = cols[1];
                t.Date = Convert.ToDateTime(cols[2]);
               
                output.Add(t);
            }
            return output;
        }
        public static List<TestModel2> ConvertToTest2Models(this List<string> lines)
        {
            List<TestModel2> output = new List<TestModel2>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                TestModel2 t = new TestModel2();

                t.Id = int.Parse(cols[0]);
                t.Name = cols[1];
              

                output.Add(t);
            }
            return output;
        }
        
        public static void SaveToTest2File(this List<TestModel2> test, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (TestModel2 p in test)
            {
                lines.Add($"{ p.Id },{ p.Name }");
            }
            File.WriteAllLines(fileName.FullFilePatch(), lines);
        }

        public static void SaveToTestFile(this List<TestModel> test, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (TestModel p in test)
            {
                lines.Add($"{ p.Id },{ p.Test },{p.Date}");
            }
            File.WriteAllLines(fileName.FullFilePatch(), lines);
        }
                
    }
}
