using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore
{
    class Program
    {
        static void Main(string[] args)
        {
            int option = Beginning.Beginning();

            switch (option)
            {
                case 1:
                    //User 1 secimi edende. Yeni Kitab elave etmek
                    string bookName = Console.ReadLine();
                    int page = Int32.Parse(Console.ReadLine());
                    string author = Console.ReadLine();
                    CoverType coverType = CoverType.Cardboard;
                    int price = Int32.Parse(Console.ReadLine());
                    bool isDiscount = bool.Parse(Console.ReadLine());
                    int? disCountNumber = Int32.Parse(Console.ReadLine());
                    BookList book1 = new BookList(bookName, page, author,coverType, price,isDiscount,disCountNumber);
                    book1.EnterBookInfo();

                    Console.Clear();
                    Beginning.begining();

                    break;
                case 2:
                    //User 2 secimi edende
                    break;
                case 3:
                    //User 3secimi edende
                    break;
                case 4:
                    //User 4 secimi edende
                    break;
                default:
                    Console.WriteLine("Xahis olunur duzgun secim edin");
                    break;
            }

            Console.ReadLine();
        }
    }
}
