using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolManagementAPI.Models
{
    public class ClassRoom
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ClassRoom()
        {
            this.Students = new HashSet<Student>();
        }

        public virtual ICollection<Student> Students { get; set; }
    }
}