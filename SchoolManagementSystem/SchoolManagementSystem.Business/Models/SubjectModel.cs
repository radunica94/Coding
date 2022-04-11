using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Business.Models
{
    public class SubjectModel
    {
        public int Id { get; set; }
        public string? SubjectName { get; set; }
        public int Year { get; set; }
        public int Semester { get; set; }
        public List<UsersModel> Teachers { get; set; } = new List<UsersModel>();
    }
}
