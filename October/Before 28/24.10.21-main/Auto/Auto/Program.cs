using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyPublicAuto Audi = new MyPublicAuto();
            //Audi.Brand = "Audi";
            //Audi.Model = "A8";
            //Audi.Year = 2018;
            //Audi.Door = 4;
            //Audi.Engine = "3.0 L";
            //Audi.ShowAutoInfo();
            //Console.ReadLine();

            //MyPublicAuto Mercedes = new MyPublicAuto();
            //Mercedes.Brand = "Mercedenz-Benz";
            //Mercedes.Model = "S500";
            //Mercedes.Year = 2021;
            //Mercedes.Door = 4;
            //Mercedes.Engine = "5.0 L";
            //Mercedes.ShowAutoInfo();
            //Console.ReadLine();

            List<Student> classA = new List<Student>()
            {
                new Student{ 
                    Name = "Samir",
                    Surname = "Samirov",
                    Age = 23
                },
                new Student
                {
                    Name = "Ceyhun",
                    Surname = "Ceyhunov",
                    Age = 26
                }
            };

            Student orxan = new Student
            {
                Name = "Orxan",
                Surname = "Aliyev",
                Age = 27
            };

            Student vugar = new Student
            {
                Name = "Vugar",
                Surname = "Guliyev",
                Age = 35
            };
            List<Student> classB = new List<Student>();
            classB.Add(orxan);
            classB.Add(vugar);

            Teacher neriman = new Teacher
            {
                Name = "Neriman",
                Surname = "Memmedov",
                Age = 56,
                Branch = "C#",
                Students = classA
            };

            Teacher vagif = new Teacher
            {
                Name = "Vagif",
                Surname = "Abdullayev",
                Age = 63,
                Branch = "PHP",
                /*Students = classB*/
                Students = new List<Student>
                {
                    new Student
                    {
                        Name = "Orxan",
                        Surname = "Aliyev",
                        Age = 27
                    },
                    new Student
                    {
                        Name = "Vugar",
                        Surname = "Guliyev",
                        Age = 35
                    }
                }
            };

            neriman.AddPhoneNumber("+994", "55", "5468585");
            neriman.AddPhoneNumber("+994", "51", "3332244");
            neriman.AddPhoneNumber("+994", "50", "4447788");

            vagif.AddPhoneNumber("+994", "99", "6694988");
            vagif.AddPhoneNumber("+994", "77", "7788999");
            vagif.AddPhoneNumber("+994", "70", "1144222");

            List<Teacher> teachers = new List<Teacher>();
            teachers.Add(neriman);
            teachers.Add(vagif);
            

            foreach (var item in teachers)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Surname);
                Console.WriteLine(item.Age);
                Console.WriteLine(item.Branch);
                foreach (var number in item.GetPhoneNumbers())
                {
                    Console.WriteLine(number);
                }
                Console.WriteLine("----------");
                Console.WriteLine("Telebeler: ");
                foreach (var student in item.Students)
                {
                    Console.WriteLine(student.Name);
                    Console.WriteLine(student.Surname);
                    Console.WriteLine(student.Age);
                }                
                Console.WriteLine("-------------------------------");
            }
            Console.ReadLine();
        }
    }
}
