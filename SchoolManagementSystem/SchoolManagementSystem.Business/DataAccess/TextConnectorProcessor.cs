using SchoolManagementSystem.Business.Models;
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
               
                output.Add(t);
            }
            return output;
        }

        public static void SaveToTestFile(this List<TestModel> test, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (TestModel p in test)
            {
                lines.Add($"{ p.Id },{ p.Test }");
            }
            File.WriteAllLines(fileName.FullFilePatch(), lines);
        }
    }
}
