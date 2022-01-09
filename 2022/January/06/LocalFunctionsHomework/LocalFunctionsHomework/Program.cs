using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalFunctionsHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Calculate("10", "300", "%%");

            Console.ReadLine();
        }
        static void Calculate(int a,int b,string oper)
        {
            switch (oper)
            {
                case "+":
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, Addition(a, b));
                    break;
                case "-":
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, Subtruction(a, b));
                    break;
                case "*":
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, Multiplication(a, b));
                    break;
                case "/":
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, Divide(a, b));
                    break;
                case "%":
                    Console.WriteLine("{0}-in {1} {2}-i {3} bərabərdir.", a, b, oper, Percent(a, b));
                    break;
                case "%%":
                    Console.WriteLine("{0} {1}-in {2} faizinə bərabərdir.", a, b, Rate(a, b));
                    break;
                default:
                    break;
            }
            
        }
        static void Calculate(decimal a, decimal b, string oper)
        {
            switch (oper)
            {
                case "+":
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, Addition(a, b));
                    break;
                case "-":
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, Subtruction(a, b));
                    break;
                case "*":
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, Multiplication(a, b));
                    break;
                case "/":
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, Divide(a, b));
                    break;
                case "%":
                    Console.WriteLine("{0}-in {1} {2}-i {3} bərabərdir.", a, oper, b, Percent(a, b));
                    break;
                case "%%":
                    Console.WriteLine("{0} {1}-in {2} faizinə bərabərdir.", a, b, Rate(a, b));
                    break;
                default:
                    break;
            }

        }
        static void Calculate(string a, string b, string oper)
        {
            switch (oper)
            {
                case "+":
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, Addition(decimal.Parse(a), decimal.Parse(b)));
                    break;
                case "-":
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, Subtruction(decimal.Parse(a), decimal.Parse(b)));
                    break;
                case "*":
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, Multiplication(decimal.Parse(a), decimal.Parse(b)));
                    break;
                case "/":
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, Divide(decimal.Parse(a), decimal.Parse(b)));
                    break;
                case "%":
                    Console.WriteLine("{0}-in {1} {2}-i {3} bərabərdir.", a, oper, b, Percent(decimal.Parse(a), decimal.Parse(b)));
                    break;
                case "%%":
                    Console.WriteLine("{0} {1}-in {2} faizinə bərabərdir.", a, b, Rate(decimal.Parse(a), decimal.Parse(b)));
                    break;
                default:
                    break;
            }

        }
        static void Calculate(int a, decimal b, string oper)
        {
            switch (oper)
            {
                case "+":
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, Addition(a, b));
                    break;
                case "-":
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, Subtruction(a, b));
                    break;
                case "*":
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, Multiplication(a, b));
                    break;
                case "/":
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, Divide(a, b));
                    break;
                case "%":
                    Console.WriteLine("{0}-in {1} {2}-i {3} bərabərdir.", a, oper, b, Percent(a, b));
                    break;
                case "%%":
                    Console.WriteLine("{0} {1}-in {2} faizinə bərabərdir.", a, b, Rate(a, b));
                    break;
                default:
                    break;
            }

        }
        static void Calculate(decimal a, int b, string oper)
        {
            switch (oper)
            {
                case "+":
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, Addition(a, b));
                    break;
                case "-":
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, Subtruction(a, b));
                    break;
                case "*":
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, Multiplication(a, b));
                    break;
                case "/":
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, Divide(a, b));
                    break;
                case "%":
                    Console.WriteLine("{0}-in {1} {2}-i {3} bərabərdir.", a, oper, b, Percent(a, b));
                    break;
                case "%%":
                    Console.WriteLine("{0} {1}-in {2} faizinə bərabərdir.", a, b, Rate(a, b));
                    break;
                default:
                    break;
            }

        }
        static void Calculate(int a, string b, string oper)
        {
            switch (oper)
            {
                case "+":
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, Addition(a, decimal.Parse(b)));
                    break;
                case "-":
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, Subtruction(a, decimal.Parse(b)));
                    break;
                case "*":
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, Multiplication(a, decimal.Parse(b)));
                    break;
                case "/":
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, Divide(a, decimal.Parse(b)));
                    break;
                case "%":
                    Console.WriteLine("{0}-in {1} {2}-i {3} bərabərdir.", a, oper, b, Percent(a, decimal.Parse(b)));
                    break;
                case "%%":
                    Console.WriteLine("{0} {1}-in {2} faizinə bərabərdir.", a, b, Rate(a, decimal.Parse(b)));
                    break;
                default:
                    break;
            }

        }
        static void Calculate(string a, int b, string oper)
        {
            switch (oper)
            {
                case "+":
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, Addition(decimal.Parse(a), b));
                    break;
                case "-":
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, Subtruction(decimal.Parse(a), b));
                    break;
                case "*":
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, Multiplication(decimal.Parse(a), b));
                    break;
                case "/":
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, Divide(decimal.Parse(a), b));
                    break;
                case "%":
                    Console.WriteLine("{0}-in {1} {2}-i {3} bərabərdir.", a, oper, b, Percent(decimal.Parse(a), b));
                    break;
                case "%%":
                    Console.WriteLine("{0} {1}-in {2} faizinə bərabərdir.", a, b, Rate(decimal.Parse(a), b));
                    break;
                default:
                    break;
            }

        }
        static void Calculate(string a, decimal b, string oper)
        {
            switch (oper)
            {
                case "+":
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, Addition(decimal.Parse(a), b));
                    break;
                case "-":
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, Subtruction(decimal.Parse(a), b));
                    break;
                case "*":
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, Multiplication(decimal.Parse(a), b));
                    break;
                case "/":
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, Divide(decimal.Parse(a), b));
                    break;
                case "%":
                    Console.WriteLine("{0}-in {1} {2}-i {3} bərabərdir.", a, oper, b, Percent(decimal.Parse(a), b));
                    break;
                case "%%":
                    Console.WriteLine("{0} {1}-in {2} faizinə bərabərdir.", a, b, Rate(decimal.Parse(a), b));
                    break;
                default:
                    break;
            }

        }
        static void Calculate(decimal a, string b, string oper)
        {
            switch (oper)
            {
                case "+":
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, Addition(a, decimal.Parse(b)));
                    break;
                case "-":
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, Subtruction(a, decimal.Parse(b)));
                    break;
                case "*":
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, Multiplication(a, decimal.Parse(b)));
                    break;
                case "/":
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, Divide(a, decimal.Parse(b)));
                    break;
                case "%":
                    Console.WriteLine("{0}-in {1} {2}-i {3} bərabərdir.", a, oper, b, Percent(a, decimal.Parse(b)));
                    break;
                case "%%":
                    Console.WriteLine("{0} {1}-in {2} faizinə bərabərdir.", a, b, Rate(a, decimal.Parse(b)));
                    break;
                default:
                    break;
            }

        }


        static decimal Addition(decimal addA,decimal addB)
        {
            decimal resultAdd = addA + addB;
            return resultAdd;
        }
        static decimal Subtruction(decimal subA, decimal subB)
        {
            decimal resultSub = subA - subB;
            return resultSub;
        }
        static decimal Multiplication(decimal mulA,decimal mulB)
        {
            decimal resultMul = mulA * mulB;
            return resultMul;
        }
        static decimal Divide(decimal divA,decimal divB)
        {
            if (divB != 0)
            {
                decimal resultDiv = divA / divB;
                return resultDiv;
            }
            else
                Console.WriteLine("Bölən 0 ola bilməz!");
            return 0;            
        }
        static decimal Percent(decimal perA,decimal perB)
        {
            decimal resultPer = (perA * perB) / 100;
            return resultPer;
        }
        static decimal Rate(decimal rateA, decimal rateB)
        {
            decimal resultRate = (rateA * 100) / rateB;
            return resultRate;
        }
    }
}
