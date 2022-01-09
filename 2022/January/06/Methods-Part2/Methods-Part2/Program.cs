using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Method overloading
            AdditionNums(10, 20);
            AdditionNums(2.4M, 20.1M);
            AdditionNums("10.2", "15.8");
            #endregion

            Console.ReadLine();
        }
        #region Method overloading
        static void AdditionNums(int num1, int num2)
        {
            int total = num1 + num2;
            Console.WriteLine("Integer toplam: " + total);
        }

        static void AdditionNums(decimal num1, decimal num2)
        {
            decimal total = num1 + num2;
            Console.WriteLine("Decimal toplam: " + total);
        }
        static void AdditionNums(string num1, string num2)
        {
            string total = (Convert.ToDecimal(num1) + Convert.ToDecimal(num2)).ToString();
            Console.WriteLine("Decimal toplam: " + total);
        }
        #endregion

    }
}
