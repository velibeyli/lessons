using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherAdder
{
    public static class Student
    {
        public static void StudentAdder()
        {
            Console.WriteLine("Muellimin telebeleri elave olunsun? He/Yox");
            string student = Console.ReadLine();
            if (student == "H" || student == "h")
            {
                int studentCounter = 1;
                while (studentCounter > 0)
                {
                    Console.WriteLine(studentCounter + ". Telebenin adini daxil edin: ");
                    string studentName = Console.ReadLine();
                    Console.WriteLine(studentCounter + ". Telebenin soyadini daxil edin: ");
                    string studentSurname = Console.ReadLine();
                    Console.WriteLine(studentCounter + ". Telebenin yashini daxil edin: ");
                    string studentAge = Console.ReadLine();
                    Console.WriteLine(studentCounter + ". Telebenin cinsini daxil edin: K/Q");
                    string studentGender = Console.ReadLine();
                    Console.WriteLine("Basqa telebe elave olunsun? He/Yox");
                    string newStudent = Console.ReadLine();
                    if (newStudent == "H" || newStudent == "h")
                    {
                        studentCounter++;
                    }
                    else if (newStudent == "Y" || newStudent == "y")
                    {
                        Teacher.NewTeacherAdder();
                    }
                }
            }
            else if (student == "Y" || student == "y")
            {
                Teacher.NewTeacherAdder();
            }
        }
    }
}
