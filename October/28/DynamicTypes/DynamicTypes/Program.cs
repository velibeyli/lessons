using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            string auto = "BMW";
            //a = "audi"; Error
            dynamic myDynamic = 1;
            myDynamic = "audi";
            var b = 5;
            Console.WriteLine(myDynamic.GetType());
            Console.ReadLine();
        }
    }
}
