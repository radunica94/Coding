using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Business.Models
{
    public class TestModel
    {
        public int Id { get; set; }
        public string Test { get; set; }
        public DateTime Date { get; set; }
        public byte[] Picture { get; set; }
    }
}
