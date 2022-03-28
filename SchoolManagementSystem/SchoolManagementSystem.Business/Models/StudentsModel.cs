using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Business.Models
{
    public class StudentsModel
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }    
        public string email { get; set; }
        public string phone { get; set; }
        public string grade { get; set; }
        public DateTime birthday { get; set; }

    }
}
