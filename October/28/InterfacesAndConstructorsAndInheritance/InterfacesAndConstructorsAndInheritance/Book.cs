using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndConstructorsAndInheritance
{
    public class Book : BaseBook, IBook
    {
        public Book(string name, int page, CoverType coverType)
        {
            Name = name;
            Page = page;
            CoverType = coverType;
        }
        public Book(string name, int page)
        {
            Name = name;
            Page = page;
            CoverType = CoverType.Plastic;
        }
        public void ShowBookInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Page: " + Page);
            Console.WriteLine("Covertype: " + CoverType);
            Console.WriteLine("Covertype in Number format: " + (int)CoverType);
        }
        public void ShowText(string word)
        {
            Console.WriteLine("Hello");
        }
    }
}
