using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethods
{
    public class MyPublicClass
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public void ShowPersonInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Surname: " + Surname);
            Console.WriteLine("Age: " + Age);
        }
    }
}
