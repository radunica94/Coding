using SchoolManagementSystem.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Business.DataAccess
{
    public interface IDataConnection
    {
        StudentsModel AddStudents(StudentsModel students);
    }
}
