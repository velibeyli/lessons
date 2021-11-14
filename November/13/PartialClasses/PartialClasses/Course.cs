using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClasses
{
    public partial class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public void CourseInfo()
        {
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Name " + Name);
            Console.WriteLine("Adress " + Address);
            Console.WriteLine("Phone " + Phone);
            TeacherInfo();
        }

        partial void TeacherInfo();
        //public partial int GetStudent();

    }
}
