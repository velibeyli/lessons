using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndConstructorsAndInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //A class without constructor
            Person person = new Person()
            {
                Name = "Ali"
            };
            //Console.WriteLine("Person Name: " + person.Name);
            //Console.WriteLine("----------");

            //A class with constructor which takes 3 arguments
            Book chemister = new Book("Chemister", 200, CoverType.Paper);
            chemister.ShowBookInfo();

            Console.WriteLine("----------");

            //A class with second constructor which takes 2 arguments (argument count is optional)
            Book mollaNasraddin = new Book("Molla Nesreddin", 360);
            mollaNasraddin.ShowBookInfo();
            
            
            Console.ReadLine();
        }
    }
}
