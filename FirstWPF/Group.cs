﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
namespace FirstWPF
{
    public class Group
    {
        public int Id { get; set; }
        public string? GroupName { get; set; }
        public int UniversityId { get; set; }

        public List<Student> Students = [];
        public int StudentId { get; set; }
        public string? Speciality { get; set; }
    }
}
