using SchoolManagementSystem.Business.Models;
using System.Configuration;

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
                p.Gender = cols[7];

                output.Add(p);
            }
            return output;
        }

        public static List<UsersModel> ConvertToUsersModels(this List<string> lines)
        {
            List<UsersModel> output = new List<UsersModel>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                UsersModel u = new UsersModel();
                u.Id = int.Parse(cols[0]);
                u.UserName = cols[1];
                u.Password = cols[2];
                u.FirstName = cols[3];
                u.LastName = cols[4];
                u.Email = cols[5];
                u.Phone = cols[6];               
                u.Role = cols[7];
                u.Birthday = Convert.ToDateTime(cols[8]);
                u.Street = cols[9];
                u.Apartment = cols[10];
                u.City = cols[11];
                u.Country = cols[12];                
                u.ZipCode = cols[13];

                output.Add(u);
            }
            return output;
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

        public static List<SubjectModel> ConvertToSubjectModels(this List<string> lines, string userFileName)
        {
            List<SubjectModel> output = new List<SubjectModel>();
            List<UsersModel> users = userFileName.FullFilePatch().LoadFile().ConvertToUsersModels();
            foreach(string line in lines)
            {
                string[] cols = line.Split(',');

                SubjectModel s = new SubjectModel();
                s.Id = int.Parse(cols[0]);
                s.SubjectName = cols[1];
                s.Year = int.Parse(cols[2]);
                s.Semester = int.Parse(cols[3]);

                string[] userIds = cols[4].Split('|');

                foreach (string userId in userIds)
                {
                    s.Teachers.Add(users.Find(x => x.Id == int.Parse(userId)));
                }

                output.Add(s);
            }
            return output;
        }

        public static void SaveToSubjectFile(this List<SubjectModel> subjects, string fileName)
        {
            List<string> lines = new List<string>();
            foreach (SubjectModel s in subjects)
            {
                lines.Add($"{s.Id},{s.SubjectName},{s.Year},{s.Semester},{ConvertSubjectListToString(s.Teachers)}");
            }
            File.WriteAllLines(fileName.FullFilePatch(), lines);
        }

        private static string ConvertSubjectListToString(List<UsersModel> users)
        {
            string output = "";
            if (users.Count == 0)
            {
                return "";
            }
            foreach (UsersModel u in users)
            {
                output += $"{u.Id}|";
            }
            output = output.Substring(0, output.Length - 1);
            return output;
        }
        
        public static void SaveToStudentsFile(this List<StudentsModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (StudentsModel p in models)
            {
                lines.Add($"{ p.Id },{ p.FirstName },{ p.LastName },{ p.Email },{ p.Phone },{p.Grade},{p.Birthday},{p.Gender}");
            }
            File.WriteAllLines(fileName.FullFilePatch(), lines);
        }
        
        public static void SaveToUsersFile(this List<UsersModel> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (UsersModel u in models)
            {
                lines.Add($"{ u.Id },{ u.UserName },{ u.Password },{ u.FirstName },{ u.LastName },{u.Email},{u.Phone}," +
                    $"{u.Role},{u.Birthday},{u.Street},{u.Apartment},{u.City},{u.Country},{u.ZipCode}");
            }
            File.WriteAllLines(fileName.FullFilePatch(), lines);
        }
    }
}
