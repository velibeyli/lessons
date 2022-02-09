using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Menu:");
            //Console.WriteLine("1 - Element əlavə et \n2 - Elementləri göstər \n3 - Element axtar \n4 - Element editlə \n5 - Element sil \n6 - Exit");
            Console.WriteLine("1 - Element əlavə et");
            Console.WriteLine("2 - Elementləri göstər");
            Console.WriteLine("3 - Element axtar");
            Console.WriteLine("4 - Element editlə");
            Console.WriteLine("5 - Element sil");
            Console.WriteLine("6 - Exit");

            Console.WriteLine();
            Console.WriteLine("Əməliyyat növünü seçin: ");
            int option = int.Parse(Console.ReadLine());

            ArrayList elements = new ArrayList();

            int counter = 0;


            switch (option)
            {
                case 1:
                    Console.WriteLine("Zehmet olmasa elave etmek istediyiniz elementi daxil edin: ");
                    string addElement = Console.ReadLine();
                    elements.Add(addElement);
                    Console.WriteLine("Element elave olundu!");
                    break;
                case 2:

                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                default:
                    break;
            }

            Console.ReadLine();
        }
        
    }
}
