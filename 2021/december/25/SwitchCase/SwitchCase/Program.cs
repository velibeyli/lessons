using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter language: ");
            string langG = Console.ReadLine();

            if (langG == "C#" || langG == "ASP.NET" || langG == "F#" || langG == "Java")
            {
                switch (langG)
                {
                    case "ASP.NET":
                        Console.WriteLine("Microsoft");
                        break;
                    case "F#":
                        Console.WriteLine("Microsoft");
                        break;
                    case "C#":
                        Console.WriteLine("Microsoft");
                        break;
                    case "Java":
                        Console.WriteLine("Oracle");
                        break;
                    default:
                        break;
                }
            }
            else if (langG == "German" || langG == "English (USA)" || langG == "English (GB)" || langG == "Turkish")
            {
                switch (langG)
                {
                    case "German":
                        Console.WriteLine("+49");
                        break;
                    case "English (USA)":
                        Console.WriteLine("+1");
                        break;
                    case "English (GB)":
                        Console.WriteLine("+44");
                        break;
                    case "Turkish":
                        Console.WriteLine("+90");
                        break;
                    default:
                        break;
                }
            }

            Console.ReadLine();
        }
    }
}
