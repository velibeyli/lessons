using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcase2
{
    class Program
    {
        static void Main(string[] args)
        {
            //string month = Console.ReadLine(); ;
            //switch (month)
            //{
            //    case "Yanvar":
            //        Console.WriteLine("01 " + month);
            //        break;
            //    case "Fevral":
            //        Console.WriteLine("02 " + month);
            //        break;
            //    case "Mart":
            //        Console.WriteLine("03 " + month);
            //        break;
            //    case "Aprel":
            //        Console.WriteLine("04 " + month);
            //        break;
            //    case "May":
            //        Console.WriteLine("05 " + month);
            //        break;
            //    case "Iyun":
            //        Console.WriteLine("06 " + month);
            //        break;
            //    case "Iyul":
            //        Console.WriteLine("07 " + month);
            //        break;
            //    case "Avqust":
            //        Console.WriteLine("08 " + month);
            //        break;
            //    case "Sentyabr":
            //        Console.WriteLine("09 " + month);
            //        break;
            //    case "Oktyabr":
            //        Console.WriteLine("10 " + month);
            //        break;
            //    case "Noyabr":
            //        Console.WriteLine("11 " + month);
            //        break;
            //    case "Dekabr":
            //        Console.WriteLine("12 " + month);
            //        break;
            //    default:
            //        Console.WriteLine("2021");
            //        break;
            //}

            Console.WriteLine("a deyerini daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("b deyerini daxil edin: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Etmek istediyiniz emeliyyat novunu daxil edin: ");
            string symbol = Console.ReadLine();

            switch (symbol)
            {
                case "+":
                    Console.WriteLine(a + " + " + b + " = " +  (a + b) );
                    break;
                case "-":
                    Console.WriteLine(a + " + " + b + " = " + (a - b));
                    break;
                case "*":
                    Console.WriteLine(a + " * " + b + " = " + (a * b));
                    break;
                case "/":
                    if (b == 0)
                    {
                        Console.WriteLine("bolen o ola bilmez");
                    }
                    else
                    {
                        Console.WriteLine(a + " / " + b + " = " + (a / b));
                    }
                    break;
                default:
                    break;
            };

            Console.ReadLine();
        }
    }
}
