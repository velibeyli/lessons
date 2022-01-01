using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Course course1 = new Course()
            {
                Id = 1,
                Name = "Course1",
                Address = "Baki sheheri",
                Phone = "+99455123456"
            };

            course1.CourseInfo();
            course1.AddNewStudent();
            course1.GetStudentById();
            course1.DeleteStudentInfo();
            course1.AddTeacher();
            course1.GetTeacherById();
            course1.DeleteTeacherInfo();
            course1.GetTeacherInfo();

            Console.ReadLine();

        }
    }
}
