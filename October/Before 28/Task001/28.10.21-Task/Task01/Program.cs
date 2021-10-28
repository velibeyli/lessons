using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Zehmet olmasa simvol yazin: ");
            //string symbol = Console.ReadLine();
            //Console.WriteLine("Reqemi yazin: ");
            //int number = Int32.Parse(Console.ReadLine());
            //string b = symbol;

            //for (int i = 0; i < number; i++)
            //{
            //    Console.WriteLine(symbol);
            //    symbol += b;
            //}
            

            // Yash oyrenme kodu
            //DateTime today = DateTime.Now;
            //string name = "Ruslan";
            //string lastname = "Velibeyli";
            //DateTime birthdate = new DateTime(1989, 01, 24);
            //int age = today.Year - birthdate.Year;
            //Console.WriteLine(age);
            //Console.ReadLine();
            ////////////////////////////////////////////////

            //Havanin temperaturuna gore sherhler
            Console.WriteLine("Havanin temperaturunu yazin: ");
            int temperature = Int32.Parse(Console.ReadLine());

            if (temperature <= -11)
            {
                Console.WriteLine("Cox dondurucu soyuqdur");
            }
            else if(temperature >= -10 && temperature <= -6)
            {
                Console.WriteLine("Dondurucu soyuqdur");
            }
            else if(temperature >=-5 && temperature <= -1)
            {
                Console.WriteLine("Saxtali hava");
            }
            else if(temperature >= 0 && temperature <= 4)
            {
                Console.WriteLine("Cox soyuqdur");
            }
            else if(temperature >= 5 && temperature <= 14)
            {
                Console.WriteLine("Soyuqdur");
            }
            else if(temperature >= 15 && temperature <= 24)
            {
                Console.WriteLine("Normal");
            }
            else if(temperature >= 25 && temperature <= 34)
            {
                Console.WriteLine("Istidir");
            }
            else if(temperature >= 35 && temperature <= 44)
            {
                Console.WriteLine("Cox istidir");
            }
            Console.ReadLine();
            //////////////////////////////////////////////////////////          
            

        }
    }
}
