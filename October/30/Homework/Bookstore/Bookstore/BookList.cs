using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore
{
   public class BookList: NewBook
    {    
        public BookList(string bookName, int page, string author, CoverType coverType, int price, bool isDiscount, int? disCountNumber)
        {
            BookName = bookName;
            Page = page;
            Author = author;
            CoverType = coverType;
            Price = price;
            IsDiscount = isDiscount;
            DiscountNumber = disCountNumber;
        }
        public void EnterBookInfo()
        {
            Console.Write("Kitabin adi: " + BookName);
            Console.Write("Sehife sayi: " + Page);
            Console.Write("Muellifi: " + Author);
            Console.Write("Uz qabiginin materiali: " + CoverType);
            Console.Write("Qiymeti: " + Price);
            Console.WriteLine("Kitab endirimdedirmi? He/Yox " + IsDiscount);
        }
    }
}
