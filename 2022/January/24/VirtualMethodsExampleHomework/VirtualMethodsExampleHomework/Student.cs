using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethodsExampleHomework
{
    public class Student : BaseClass
    {
        public override string Surname { get; set; }
        public override void ShowFullname()  // Eger baseClass icerisinde virtual metodda her hansi bir parametr oturulmeyibse
                                             // override edilmis derived classda hec bir parametr oturmek olmaz
        {
            Console.WriteLine("Id: {0}, Name: {1}, Surname: {2}",Id,Name,Surname);
        }
    }
}
