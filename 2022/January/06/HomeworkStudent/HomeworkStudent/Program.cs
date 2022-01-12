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
            string className = "", teacherName = "";
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Zəhmət olmasa sinif adını daxil edin: ");
            className = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Zəhmət olmasa sinif rəhbərinin adını daxil edin: ");
            teacherName = Console.ReadLine();
            Console.WriteLine();

            Console.Write("1.Telebe adi: ");
            string student1 = Console.ReadLine();

            Console.Write("2.Telebe adi: ");
            string student2 = Console.ReadLine();

            Console.Write("3.Telebe adi: ");
            string student3 = Console.ReadLine();

            Console.Write("4.Telebe adi: ");
            string student4 = Console.ReadLine();

            Console.Write("5.Telebe adi: ");
            string student5 = Console.ReadLine();

            Console.Write("6.Telebe adi: ");
            string student6 = Console.ReadLine();

            Console.Write("7.Telebe adi: ");
            string student7 = Console.ReadLine();

            Console.Write("8.Telebe adi: ");
            string student8 = Console.ReadLine();

            Console.Write("9.Telebe adi: ");
            string student9 = Console.ReadLine();

            Console.Write("10.Telebe adi: ");
            string student10 = Console.ReadLine();


            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write("Zəhmət olmasa {0}. tələbənin ad və soyadını daxil edin: ",i);
            //    studentName = Console.ReadLine();
            //    Console.WriteLine();
            //}


            Console.WriteLine("----------------------------");

            Student student = new Student();
            student.StudentInfo(className,teacherName,student1,student2,student3,student4,student5,student6,student7,student8,student9,student10);

            Console.ReadLine();
        }
        public class Student 
        {
            public void StudentInfo(string className,string teacherName,params string [] studentName)
            {
                Console.WriteLine("Sinfin adı: {0}",className);
                Console.WriteLine("Müəllimin adı: {0}", teacherName);
                foreach (var student in studentName)
                {
                    Console.WriteLine("Telebe adlari: {0}",student);
                }

                //StudentNameSurname(studentName);

            }
            //public void StudentNameSurname (string nameSurname)
            //{
            //    for (int i = 1; i <= 10; i++)
            //    {
            //        Console.WriteLine("{0}. tələbə adı və soyadı: {1}",i,nameSurname);
            //    }
            //}
        }



    }
}
