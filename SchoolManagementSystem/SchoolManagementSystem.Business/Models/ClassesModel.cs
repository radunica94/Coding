using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Business.Models
{
    public class ClassesModel
    {
        public int Id { get; set; }
        StudentsModel students { get; set; }
        SubjectModel subject { get; set; }  
    }
}
