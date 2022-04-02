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
