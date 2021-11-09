using Pets;
using Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTaskWithAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            //Teacher teacher = new Teacher();
            //teacher.Id = 1;
            //teacher.Name = "Sabir";
            //teacher.Surname = "Aliyev";
            //teacher.Work();

            //Police police = new Police();
            //police.Id = 1;
            //police.Name = "Mammad";
            //police.Surname = "Mammadov";
            //police.Work();

            //Doctor doctor = new Doctor();
            //doctor.Id = 1;
            //doctor.Name = "Etibar";
            //doctor.Surname = "Huseynov";
            //doctor.Work();

            //Developer developer = new Developer();
            //developer.Id = 1;
            //developer.Name = "Orxan";
            //developer.Surname = "Farajov";
            //developer.Work();

            //Square square = new Square(20, "dortbucaq");
            //Console.WriteLine(square.Area);
            //Circle circle = new Circle(15, "yumru");
            //Console.WriteLine(circle.Area);

            Cat cats = new Cat();
            cats.AnimalSound();
            cats.Sleep();

            Dog dogs = new Dog();
            dogs.AnimalSound();
            dogs.Sleep();

            Console.ReadLine();
        }
    }
}
