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
        public List<StudentsModel> Students { get; set; } = new List<StudentsModel>();
        public List<SubjectModel> Subject { get; set; } = new List<SubjectModel>();
    }
}
