using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            //A a = new A();
            //a.ShowMyClassName();

            //B b = new B();
            //b.ShowMyClassName();

            //C c = new C();
            //c.ShowMyClassName();

            A test1 = new B();
            test1.ShowMyClassName();
            //test1.NotVirtualMethod();
            test1.ZMethod();
            A test2 = new C();
            test2.ZMethod();
            //test2.ShowMyClassName();
            A test3 = new D();
            test3.ZMethod();
            D test4 = new D();
            test4.ZMethod();
            //test3.ShowMyClassName();

            /*
             Homework:
            1. Common A dan set olan zaman (meselen "Salam Ruslan") ekrana sadece "Salam Ruslan" yazsin.
            2. A tipinde deyisen yaradib instance'ni B, C ve D classlarindan yaratdigim zaman ise, "Salam Ruslan (B)" qaydasinda herflerile
            birlikde yazsin.
            "Salam Ruslan (B)"
            "Salam Ruslan (C)"
            "Salam Ruslan (D)"
            3. Arasdir: difference between abstract and virtual
             */

            // Task 1:
            var x = "Salam Ruslan";
            A helloFromA = new A();
            helloFromA.Common = x;
            helloFromA.Hello();

            //Task 2:

            A helloFromB = new B();
            helloFromB.Common = x;
            helloFromB.Hello("B");

            A helloFromC = new C();
            helloFromC.Common = x;
            helloFromC.Hello("C");

            A helloFromD = new D();
            helloFromD.Common = x;
            helloFromD.Hello("D");





            Console.ReadLine();
        }
    }  
}
