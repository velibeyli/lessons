using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student(1, "Ruslan", "Valibayli", "ruslna.velibeyli@mail.ru", 0505050505, new DateTime(1991,12,12), 78.5),
                new Student(2, "Arif", "Arifov", "arif.arifov@mail.ru", 0705651245, new DateTime(1997,12,22), 58.5),
                new Student(3, "Ceyhun", "Hikmeteliyev", "ceyhuncey@mail.ru", 0995656565, new DateTime(1987,11,22), 68.5),
                new Student(4, "Hasan", "Memmedquliyev", "hasanov@gmail.com", 0512652655, new DateTime(1967,10,27), 574.9),
                new Student(5, "Sabir", "sabirov", "sabirovdd@mail.ru", 0760565652, new DateTime(2007,06,16), 48.6),
                new Student(7, "Aydin", "Aydinov", "Aydinovaa@mail.ru", 0556565654, new DateTime(2005,09,22), 35.4)
            };

            //students.ForEach(m => Console.WriteLine(m.Id + ": " + m.Name + " " + m.Surname));

            #region tapsiriq 1
            students.ForEach(m => Console.WriteLine("Student name and surname: {0} {1}",m.Name,m.Surname));

            Console.WriteLine("-------------------------------------");

            var nameSurname = students.Select(m => m.Name + " " + m.Surname);

            foreach (var item in nameSurname)
            {
                if (item.Length > 15)
                    Console.WriteLine(item.First() + "." + item.Split(' ').Last());
                else
                    Console.WriteLine(item);
            }
            #endregion

            Console.WriteLine("-------------------------------------");

            #region tapsiriq 2
            List<string> fruit1 = new List<string>()
            {
                "Alma",
                "Armud",
                "Kivi",
                "Ciyelek",
                "Banan",
                "Heyva",
                "Nar",
                "Xurma",
                "Ezgil",
                "Feyxoa"
            };

            List<string> fruit2 = new List<string>()
            {
                "Apelsin",
                "Mandarin",
                "Kinkan",
                "Tut",
                "Gilas",
                "Visne",
                "Gavali",
                "Erik",
                "Saftali",
                "Banan",
                "Heyva",
                "Nar",
                "Xurma"
            };

            var fruits = fruit1.Concat(fruit2);

            foreach (var allFrt in fruits)
            {
                Console.WriteLine(allFrt);
            }

            Console.WriteLine("-------------------------------------");

            var exceptFruits1 = fruit1.Except(fruit2);
            foreach (var excFruit in exceptFruits1)
            {
                Console.WriteLine(excFruit);
            }

            Console.WriteLine("-------------------------------------");

            var exceptFruit2 = fruit2.Except(fruit1);
            foreach (var excFruit2 in exceptFruit2)
            {
                Console.WriteLine(excFruit2);
            }
            #endregion

            Console.WriteLine("-------------------------------------");

            #region tapsiriq 3
            List<int> numbers = new List<int>()
            {1, 12, 9, 17, 11, 8, 14, 5, 19, 2, 7, 18, 4, 16, 3, 10, 6, 13, 20, 15 };

            var oddNumber = numbers.Where(m => m % 2 == 0).OrderBy(m => m).ToList();
            var evenNumber = numbers.Where(m => m % 2 == 1).OrderBy(m => m).ToList();

            foreach (var item in oddNumber)
            {
                Console.WriteLine(item);
            }

            foreach (var item in evenNumber)
            {
                Console.WriteLine(item);
            }
            #endregion

            Console.WriteLine("-------------------------------------");

            #region tapsiriq 4
            students.RemoveAll(s => Convert.ToDateTime(s.DateOfBirth).Month == 12);
            students.ForEach(m => Console.WriteLine("Student name and surname: {0} {1}", m.Name, m.Surname));
            #endregion

            Console.WriteLine("-------------------------------------");

            Console.ReadLine();
        }
    }
}
