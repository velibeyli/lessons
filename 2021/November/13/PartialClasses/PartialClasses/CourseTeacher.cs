using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClasses
{
    public partial class Course
    {
        public void AddTeacher()
        {
            Console.WriteLine("New Teacher added");
        }
        public void GetTeacherById()
        {
            Console.WriteLine("Teacher info select by Id");
        }
        public void DeleteTeacherInfo()
        {
            Console.WriteLine("Some teacher info deleted");
        }
        partial void TeacherInfo()
        {
            Console.WriteLine("Some teacher");
        }
        public void GetTeacherInfo()
        {
            TeacherInfo();
        }
    }
}
