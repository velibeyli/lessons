using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Aşağıdakı kodlardan birini daxil edin: ");
            Console.WriteLine("AA, BB, CC, DD, FF, GG, HH, II, JJ");
            Console.WriteLine();
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "AA":
                case "BB":
                case "CC":
                    Console.WriteLine("Admin");
                    break;
                case "DD":
                case "FF":
                    Console.WriteLine("Editor");
                    break;
                case "GG":
                case "HH":
                    Console.WriteLine("Registered User");
                    break;
                case "II":
                case "JJ":
                    Console.WriteLine("Standart User");
                    break;
                default:
                    break;
            }

            Console.ReadLine();
        }
    }
}
