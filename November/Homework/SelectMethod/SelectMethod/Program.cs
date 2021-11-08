using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            #region tapsiriq 6
            List<Person> student = new List<Person>()
            {
                new Person
                {
                    Name = "Ruslan",
                    Surname = "Valibayli"
                },
                new Person
                {
                    Name = "Natig",
                    Surname = "Hajiyev"
                },
                new Person
                {
                    Name = "Elnur",
                    Surname = "Mammadov"
                },
                new Person
                {
                    Name = "Jeyhun",
                    Surname = "Rzayev"
                },
                new Person
                {
                    Name = "Zamiq",
                    Surname = "Guliyev"
                },
            };

            List<Person> teacher = new List<Person>()
            {
                new Person
                {
                    Name = "Samir",
                    Surname = "Gasimov"
                },
                new Person
                {
                    Name = "Karim",
                    Surname = "Veliyev"
                },
                new Person
                {
                    Name = "Ramiz",
                    Surname = "Sherifli"
                },
                new Person
                {
                    Name = "Polad",
                    Surname = "Alakbarov"
                },
                new Person
                {
                    Name = "Javid",
                    Surname = "Esgerli"
                },
            };

            Console.WriteLine("Teachers: ");
            Console.WriteLine();

            var teacherList = teacher.Select(s => s.Name + " " + s.Surname).ToList();
            foreach (var item in teacherList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------------------------------");

            Console.WriteLine("Students: ");
            Console.WriteLine();
            var studentList = student.Select(s => s.Name + " " + s.Surname).ToList();
            foreach (var item in studentList)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region tapsiriq 7

            List<int> numbers = new List<int>()
            { 1, 5, 16, 28, 7, 19, 23, 8, 15, 27, 4, 11, 24, 29, 18, 6, 18, 8, 2, 12 };

            //numbers which divided 3 between 10 and 20
            var betweenTenTwen = numbers.Where(m => m > 10 && m < 20 && (m % 3) == 0);
            foreach (var num in betweenTenTwen)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();

            //numbers between ten and twenty
            var tenTwenty = numbers.Where(m => m > 10 && m < 20);
            foreach (var num in tenTwenty)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();

            var betweenOrDivided = numbers.Where(m => m > 10 && m < 20 || (m % 3) == 0);
            foreach (var item in betweenOrDivided)
            {
                Console.Write(item + " ");
            }

            #endregion

            Console.ReadLine();
        }
    }
}
