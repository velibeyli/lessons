using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            string className = "", teacherName = "", studentName = "";
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Zəhmət olmasa sinif adını daxil edin: ");
            className = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Zəhmət olmasa sinif rəhbərinin adını daxil edin: ");
            teacherName = Console.ReadLine();
            Console.WriteLine();

            
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Zəhmət olmasa {0}. tələbənin ad və soyadını daxil edin: ",i);
                studentName = Console.ReadLine();
                Console.WriteLine();
            }


            Console.WriteLine("----------------------------");

            Student student = new Student();
            student.StudentInfo(className,teacherName,studentName);

            Console.ReadLine();
        }
        public class Student 
        {
            public void StudentInfo(string className,string teacherName,string studentName)
            {
                Console.WriteLine("Sinfin adı: {0}",className);
                Console.WriteLine("Müəllimin adı: {0}", teacherName);

                StudentNameSurname(studentName);

            }
            public void StudentNameSurname (string nameSurname)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("{0}. tələbə adı və soyadı: {1}",i,nameSurname);
                }
            }
        }



    }
}
