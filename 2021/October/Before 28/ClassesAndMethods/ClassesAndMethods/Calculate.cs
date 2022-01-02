using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethods
{
    public static class Calculate
    {
        public static int Addition(int a, int b)
        {
            return a + b;
        }

        public static int Subtraction(int a, int b)
        {
            return a - b;
        }

        public static int Multiplication(int a, int b)
        {
            return a * b;
        }

        public static int Division(int a, int b)
        {
            return a / b;
        }

        public static void CalculateNums(string operatorValue, char typeOfOperator)
        {
            Console.WriteLine(operatorValue + " ilk reqemi daxil edin: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(operatorValue + " ikinci reqemi daxil edin: ");
            int y = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            if (typeOfOperator == '+')
                sum = Addition(x, y);

            else if (typeOfOperator == '-')
                sum = Subtraction(x, y);

            else if (typeOfOperator == '*')
                sum = Multiplication(x, y);

            else if (typeOfOperator == '/')
                sum = Division(x, y);

            //switch (typeOfOperator)
            //{
            //    case '+':
            //        sum = Addition(x, y);
            //        break;

            //    case '-':
            //        sum = Subtraction(x, y);
            //        break;

            //    case '*':
            //        sum = Multiplication(x, y);
            //        break;

            //    case '/':
            //        sum = Division(x, y);
            //        break;

            //    default:
            //        Console.WriteLine("Sehv operator yazdiniz!");
            //        break;
            //}


            Console.WriteLine(operatorValue + " cemi: " + sum);
            Console.ReadLine();
        }
    }
}