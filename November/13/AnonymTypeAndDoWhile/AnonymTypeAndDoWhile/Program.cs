using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymTypeAndDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student()
            {
                Name = "Aydin",
                Surname = "Aliyev",
                StudentInfo = new StudentContactDetail
                {
                    Email = new List<string>
                    {
                        "aydin.aliyev1@mail.ru",
                        "aydin.aliyev1@gmail.com"
                    },
                    Phone = new List<string>
                    {
                        "+99456431423",
                        "+99470568552"
                    }
                }
            };

            object studentTypeObject = student1;
            dynamic studentTypeDynamic = student1;

            student1.Name = "Cavid";

            var student2 = new
            {
                Name = "Samir",
                Surname = "Cabbarov",
                StudentContactInfo = new
                {
                    Email = new List<string>
                    {
                        "54564s56dssds@mail.ru",
                        "54564s56dssds@mail.ru"
                    },
                    Phone = new List<string>
                    {
                        "+994556664640",
                        "+994545645111"
                    }
                }
            };

            Console.WriteLine(student2.Name + " " + student2.Surname);
            Console.WriteLine(student2.Name + " " + student2.Surname);


            //student2.Name = "" can not change value property of anonymous type

            int a = 0;

            while (a < 5)
            {
                Console.WriteLine(a);
                a++;
            }

            Console.WriteLine("---------------------");

            int i = 5;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.WriteLine("---------------------");

            int b = 5;
            do
            {
                Console.WriteLine(b);
                b++;
            } while (b < 5);

            Console.WriteLine("---------------------");

            int c = 0;
            do
            {
                Console.WriteLine(c);
                c++;
            } while (c < 5);

            Console.ReadLine();
        }
    }
}
