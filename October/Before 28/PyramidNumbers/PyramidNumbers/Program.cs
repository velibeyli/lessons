using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyramidNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("bir simvol daxil edin: ");
            //string symbol = Console.ReadLine();
            //Console.WriteLine("reqem daxil edin: ");
            //int number = Int32.Parse(Console.ReadLine());

            //string b = symbol;

            //for (int i = 0; i < number; i++)
            //{
            //    Console.WriteLine(symbol);
            //    symbol += b;
            //}


            //for (int a = number; a >0  ; a--)
            //{
            //    Console.WriteLine(symbol);
            //    symbol+=
            //}
            //Console.ReadLine();

            Student student = new Student()
            {
                Name = "Ali",
                Surname = "Aliyev",
                Age = 35,
                Gender = "Male",
                Branch = "Mechanical",
                Branch2 = Branch.Geology,
                Birthdate = new DateTime(1990, 12, 25),
                Gender2 = (int)Gender.Male,//0, //0: Qadin - 1: Kisi
                Gender3 = Gender.Male
            };            
        }
    }
}
