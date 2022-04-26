﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolManagementAPI.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int? GradeId { get; set; }

        public virtual Grade Grade { get; set; }
    }
}