﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Business.Models
{
    public class ClassModel
    {
        public int Id { get; set; }
        public string? ClassName { get; set; }
        public int ClassCapacity { get; set; }
        public List<StudentsModel> StudentsList { get; set; } = new List<StudentsModel>();
    }
}
