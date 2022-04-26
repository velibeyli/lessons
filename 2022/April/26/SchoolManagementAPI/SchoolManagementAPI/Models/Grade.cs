using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolManagementAPI.Models
{
    public class Grade
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}