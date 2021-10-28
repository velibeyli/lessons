using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate.CalculateNums("Toplamanin", '+');
            Calculate.CalculateNums("Cixmanin", '-');
            Calculate.CalculateNums("Vurmanin", '*');
            Calculate.CalculateNums("Bolmenin", '/');
            int a = 0;

            MyPublicClass publicClass = new MyPublicClass();
            publicClass.Name = "Orkhan";
            publicClass.Surname = "Farajov";
            publicClass.Age = 26;
            publicClass.ShowPersonInfo();
            Console.ReadLine();

            MyPrivateClass privateClass = new MyPrivateClass();
            privateClass.SetPersonInfo("Orkhan", "Farajov", 26);
            privateClass.ShowPersonInfo();
            Console.ReadLine();
        }
    }
}
