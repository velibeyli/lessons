using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList elements = new ArrayList();
           
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1 - Element elave et");
                Console.WriteLine("2 - Elementleri goster");
                Console.WriteLine("3 - Element axtar");
                Console.WriteLine("4 - Element editle");
                Console.WriteLine("5 - Element sil");
                Console.WriteLine("6 - Exit");
                Console.WriteLine("Emeliyyat novunu secin:");
                Console.WriteLine();
                int userInput = int.Parse(Console.ReadLine());
                
                switch (userInput)
                {
                    case 1:
                        Console.WriteLine("Zehmet olmasa elave etmek istediyiniz elementi daxil edin:");
                        object element = Console.ReadLine();
                        elements.Add(element);
                        Console.WriteLine("Element elave olundu!");
                        break;
                    case 2:
                        for (int i = 0; i < elements.Count; i++)
                        {
                            Console.WriteLine("{0}.Element = {1}",i+1,elements[i]);
                        }
                        
                        break;
                    case 3:
                        Console.WriteLine("Axtarmaq istediyiniz elementi daxil edin: ");
                        object findElement = Console.ReadLine();
                        for (int i = 0; i < elements.Count; i++)
                        {
                            if (findElement == elements)
                                Console.WriteLine("Element tapildi: index - {0} Deyer {1}", i + 1, elements[i]);
                            else
                                Console.WriteLine("Axtardiginiz element tapilmadi");
                        }
                        Console.WriteLine("Davam etmek ucun entere basin");
                        string backToMenu = Console.ReadLine();
                        break;
                    default:
                        break;
                }
            } while (true);

            Console.ReadLine();
        }
    }
}
