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
                new Student(2, "Arif", "Arifov", "arif.arifov@mail.ru", 0705651245, new DateTime(1997,01,22), 58.5),
                new Student(3, "Ceyhun", "Hikmeteliyev", "ceyhuncey@mail.ru", 0995656565, new DateTime(1987,11,22), 68.5),
                new Student(4, "Hasan", "Memmedquliyev", "hasanov@gmail.com", 0512652655, new DateTime(1967,11,27), 574.9),
                new Student(5, "Sabir", "sabirov", "sabirovdd@mail.ru", 0760565652, new DateTime(2007,06,16), 48.6),
                new Student(7, "Aydin", "Aydinov", "Aydinovaa@mail.ru", 0556565654, new DateTime(2005,09,22), 35.4)
            };

            students.ForEach(m => Console.WriteLine(m.Id + ": " + m.Name + " " + m.Surname));



            Console.ReadLine();
        }
    }
}
