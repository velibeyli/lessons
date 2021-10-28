using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherAdder
{
    public static class Teacher
    {
        public static void NewTeacherAdder()
        {
            Console.WriteLine("Yeni muellim elave olunsun? He/Yox");
            string newTeacher = Console.ReadLine();
            if (newTeacher == "H" || newTeacher == "h")
            {
                Console.WriteLine("Müellimin adını daxil edin: ");
                string teacherName = Console.ReadLine();
                Console.WriteLine("Müellimin soyadını daxil edin: ");
                string teacherSurname = Console.ReadLine();
                Console.WriteLine("Müellimin yaşını daxil edin: ");
                string teacherAge = Console.ReadLine();
                Contact.ContactAdder();
            }
            else if (newTeacher == "Y" || newTeacher == "y")
                Environment.Exit(0);
            else
            {
                Console.WriteLine("Yalnis secim, H (he ucun) ve ya Y (yox ucun) herflerini yazin");
                Console.ReadLine();
            }
        }
    }
}
