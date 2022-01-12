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

            Calculate("150","350", "+");

            Console.ReadLine();
        }
        static void Calculate(int a,int b,string oper)
        {
            switch (oper)
            {
                case "+":
                    decimal Addition(decimal addA, decimal addB)
                    {
                        decimal resultAdd = addA + addB;
                        return resultAdd;
                    }
                    decimal resultAdditions = Addition(a, b);
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultAdditions);
                    break;
                case "-":
                    decimal Subtruction(decimal subA, decimal subB)
                    {
                        decimal resultSub = subA - subB;
                        return resultSub;
                    }
                    decimal resultSubtructions = Subtruction(a, b);
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultSubtructions);
                    break;
                case "*":
                    decimal Multiplication(decimal mulA, decimal mulB)
                    {
                        decimal resultMul = mulA * mulB;
                        return resultMul;
                    }
                    decimal resultMultiply = Multiplication(a, b);
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultMultiply);
                    break;
                case "/":
                    decimal Divide(decimal divA, decimal divB)
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
                    decimal resultDivide = Divide(a, b);
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultDivide);
                    break;
                case "%":
                    decimal Percent(decimal perA, decimal perB)
                    {
                        decimal resultPer = (perA * perB) / 100;
                        return resultPer;
                    }
                    decimal resultPercent = Percent(a, b);
                    Console.WriteLine("{0}-in {1} {2}-i {3} bərabərdir.", a, b, oper, resultPercent);
                    break;
                case "%%":
                    decimal Rate(decimal rateA, decimal rateB)
                    {
                        decimal resultRate = (rateA * 100) / rateB;
                        return resultRate;
                    }
                    decimal resultOfRate = Rate(a, b);
                    Console.WriteLine("{0} {1}-in {2} faizinə bərabərdir.", a, b, resultOfRate);
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
                    decimal Addition(decimal addA, decimal addB)
                    {
                        decimal resultAdd = addA + addB;
                        return resultAdd;
                    }
                    decimal resultAdditions = Addition(a, b);
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultAdditions);
                    break;
                case "-":
                    decimal Subtruction(decimal subA, decimal subB)
                    {
                        decimal resultSub = subA - subB;
                        return resultSub;
                    }
                    decimal resultSubtructions = Subtruction(a, b);
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultSubtructions);
                    break;
                case "*":
                    decimal Multiplication(decimal mulA, decimal mulB)
                    {
                        decimal resultMul = mulA * mulB;
                        return resultMul;
                    }
                    decimal resultMultiply = Multiplication(a, b);
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultMultiply);
                    break;
                case "/":
                    decimal Divide(decimal divA, decimal divB)
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
                    decimal resultDivide = Divide(a, b);
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultDivide);
                    break;
                case "%":
                    decimal Percent(decimal perA, decimal perB)
                    {
                        decimal resultPer = (perA * perB) / 100;
                        return resultPer;
                    }
                    decimal resultPercent = Percent(a, b);
                    Console.WriteLine("{0}-in {1} {2}-i {3} bərabərdir.", a, b, oper, resultPercent);
                    break;
                case "%%":
                    decimal Rate(decimal rateA, decimal rateB)
                    {
                        decimal resultRate = (rateA * 100) / rateB;
                        return resultRate;
                    }
                    decimal resultOfRate = Rate(a, b);
                    Console.WriteLine("{0} {1}-in {2} faizinə bərabərdir.", a, b, resultOfRate);
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
                    decimal Addition(decimal addA, decimal addB)
                    {
                        decimal resultAdd = addA + addB;
                        return resultAdd;
                    }
                    decimal resultAdditions = Addition(Decimal.Parse(a), Decimal.Parse(b));
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultAdditions);
                    break;
                case "-":
                    decimal Subtruction(decimal subA, decimal subB)
                    {
                        decimal resultSub = subA - subB;
                        return resultSub;
                    }
                    decimal resultSubtructions = Subtruction(Decimal.Parse(a), Decimal.Parse(b));
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultSubtructions);
                    break;
                case "*":
                    decimal Multiplication(decimal mulA, decimal mulB)
                    {
                        decimal resultMul = mulA * mulB;
                        return resultMul;
                    }
                    decimal resultMultiply = Multiplication(Decimal.Parse(a), Decimal.Parse(b));
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultMultiply);
                    break;
                case "/":
                    decimal Divide(decimal divA, decimal divB)
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
                    decimal resultDivide = Divide(Decimal.Parse(a), Decimal.Parse(b));
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultDivide);
                    break;
                case "%":
                    decimal Percent(decimal perA, decimal perB)
                    {
                        decimal resultPer = (perA * perB) / 100;
                        return resultPer;
                    }
                    decimal resultPercent = Percent(Decimal.Parse(a), Decimal.Parse(b));
                    Console.WriteLine("{0}-in {1} {2}-i {3} bərabərdir.", a, b, oper, resultPercent);
                    break;
                case "%%":
                    decimal Rate(decimal rateA, decimal rateB)
                    {
                        decimal resultRate = (rateA * 100) / rateB;
                        return resultRate;
                    }
                    decimal resultOfRate = Rate(Decimal.Parse(a), Decimal.Parse(b));
                    Console.WriteLine("{0} {1}-in {2} faizinə bərabərdir.", a, b, resultOfRate);
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
                    decimal Addition(decimal addA, decimal addB)
                    {
                        decimal resultAdd = addA + addB;
                        return resultAdd;
                    }
                    decimal resultAdditions = Addition(a, b);
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultAdditions);
                    break;
                case "-":
                    decimal Subtruction(decimal subA, decimal subB)
                    {
                        decimal resultSub = subA - subB;
                        return resultSub;
                    }
                    decimal resultSubtructions = Subtruction(a, b);
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultSubtructions);
                    break;
                case "*":
                    decimal Multiplication(decimal mulA, decimal mulB)
                    {
                        decimal resultMul = mulA * mulB;
                        return resultMul;
                    }
                    decimal resultMultiply = Multiplication(a, b);
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultMultiply);
                    break;
                case "/":
                    decimal Divide(decimal divA, decimal divB)
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
                    decimal resultDivide = Divide(a, b);
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultDivide);
                    break;
                case "%":
                    decimal Percent(decimal perA, decimal perB)
                    {
                        decimal resultPer = (perA * perB) / 100;
                        return resultPer;
                    }
                    decimal resultPercent = Percent(a, b);
                    Console.WriteLine("{0}-in {1} {2}-i {3} bərabərdir.", a, b, oper, resultPercent);
                    break;
                case "%%":
                    decimal Rate(decimal rateA, decimal rateB)
                    {
                        decimal resultRate = (rateA * 100) / rateB;
                        return resultRate;
                    }
                    decimal resultOfRate = Rate(a, b);
                    Console.WriteLine("{0} {1}-in {2} faizinə bərabərdir.", a, b, resultOfRate);
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
                    decimal Addition(decimal addA, decimal addB)
                    {
                        decimal resultAdd = addA + addB;
                        return resultAdd;
                    }
                    decimal resultAdditions = Addition(a, b);
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultAdditions);
                    break;
                case "-":
                    decimal Subtruction(decimal subA, decimal subB)
                    {
                        decimal resultSub = subA - subB;
                        return resultSub;
                    }
                    decimal resultSubtructions = Subtruction(a, b);
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultSubtructions);
                    break;
                case "*":
                    decimal Multiplication(decimal mulA, decimal mulB)
                    {
                        decimal resultMul = mulA * mulB;
                        return resultMul;
                    }
                    decimal resultMultiply = Multiplication(a, b);
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultMultiply);
                    break;
                case "/":
                    decimal Divide(decimal divA, decimal divB)
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
                    decimal resultDivide = Divide(a, b);
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultDivide);
                    break;
                case "%":
                    decimal Percent(decimal perA, decimal perB)
                    {
                        decimal resultPer = (perA * perB) / 100;
                        return resultPer;
                    }
                    decimal resultPercent = Percent(a, b);
                    Console.WriteLine("{0}-in {1} {2}-i {3} bərabərdir.", a, b, oper, resultPercent);
                    break;
                case "%%":
                    decimal Rate(decimal rateA, decimal rateB)
                    {
                        decimal resultRate = (rateA * 100) / rateB;
                        return resultRate;
                    }
                    decimal resultOfRate = Rate(a, b);
                    Console.WriteLine("{0} {1}-in {2} faizinə bərabərdir.", a, b, resultOfRate);
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
                    decimal Addition(decimal addA, decimal addB)
                    {
                        decimal resultAdd = addA + addB;
                        return resultAdd;
                    }
                    decimal resultAdditions = Addition(a, decimal.Parse(b));
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultAdditions);
                    break;
                case "-":
                    decimal Subtruction(decimal subA, decimal subB)
                    {
                        decimal resultSub = subA - subB;
                        return resultSub;
                    }
                    decimal resultSubtructions = Subtruction(a, decimal.Parse(b));
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultSubtructions);
                    break;
                case "*":
                    decimal Multiplication(decimal mulA, decimal mulB)
                    {
                        decimal resultMul = mulA * mulB;
                        return resultMul;
                    }
                    decimal resultMultiply = Multiplication(a, decimal.Parse(b));
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultMultiply);
                    break;
                case "/":
                    decimal Divide(decimal divA, decimal divB)
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
                    decimal resultDivide = Divide(a, decimal.Parse(b));
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultDivide);
                    break;
                case "%":
                    decimal Percent(decimal perA, decimal perB)
                    {
                        decimal resultPer = (perA * perB) / 100;
                        return resultPer;
                    }
                    decimal resultPercent = Percent(a, decimal.Parse(b));
                    Console.WriteLine("{0}-in {1} {2}-i {3} bərabərdir.", a, b, oper, resultPercent);
                    break;
                case "%%":
                    decimal Rate(decimal rateA, decimal rateB)
                    {
                        decimal resultRate = (rateA * 100) / rateB;
                        return resultRate;
                    }
                    decimal resultOfRate = Rate(a, decimal.Parse(b));
                    Console.WriteLine("{0} {1}-in {2} faizinə bərabərdir.", a, b, resultOfRate);
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
                    decimal Addition(decimal addA, decimal addB)
                    {
                        decimal resultAdd = addA + addB;
                        return resultAdd;
                    }
                    decimal resultAdditions = Addition(decimal.Parse(a), b);
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultAdditions);
                    break;
                case "-":
                    decimal Subtruction(decimal subA, decimal subB)
                    {
                        decimal resultSub = subA - subB;
                        return resultSub;
                    }
                    decimal resultSubtructions = Subtruction(decimal.Parse(a), b);
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultSubtructions);
                    break;
                case "*":
                    decimal Multiplication(decimal mulA, decimal mulB)
                    {
                        decimal resultMul = mulA * mulB;
                        return resultMul;
                    }
                    decimal resultMultiply = Multiplication(decimal.Parse(a), b);
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultMultiply);
                    break;
                case "/":
                    decimal Divide(decimal divA, decimal divB)
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
                    decimal resultDivide = Divide(decimal.Parse(a), b);
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultDivide);
                    break;
                case "%":
                    decimal Percent(decimal perA, decimal perB)
                    {
                        decimal resultPer = (perA * perB) / 100;
                        return resultPer;
                    }
                    decimal resultPercent = Percent(decimal.Parse(a), b);
                    Console.WriteLine("{0}-in {1} {2}-i {3} bərabərdir.", a, b, oper, resultPercent);
                    break;
                case "%%":
                    decimal Rate(decimal rateA, decimal rateB)
                    {
                        decimal resultRate = (rateA * 100) / rateB;
                        return resultRate;
                    }
                    decimal resultOfRate = Rate(decimal.Parse(a), b);
                    Console.WriteLine("{0} {1}-in {2} faizinə bərabərdir.", a, b, resultOfRate);
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
                    decimal Addition(decimal addA, decimal addB)
                    {
                        decimal resultAdd = addA + addB;
                        return resultAdd;
                    }
                    decimal resultAdditions = Addition(a, decimal.Parse(b));
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultAdditions);
                    break;
                case "-":
                    decimal Subtruction(decimal subA, decimal subB)
                    {
                        decimal resultSub = subA - subB;
                        return resultSub;
                    }
                    decimal resultSubtructions = Subtruction(a, decimal.Parse(b));
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultSubtructions);
                    break;
                case "*":
                    decimal Multiplication(decimal mulA, decimal mulB)
                    {
                        decimal resultMul = mulA * mulB;
                        return resultMul;
                    }
                    decimal resultMultiply = Multiplication(a, decimal.Parse(b));
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultMultiply);
                    break;
                case "/":
                    decimal Divide(decimal divA, decimal divB)
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
                    decimal resultDivide = Divide(a, decimal.Parse(b));
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultDivide);
                    break;
                case "%":
                    decimal Percent(decimal perA, decimal perB)
                    {
                        decimal resultPer = (perA * perB) / 100;
                        return resultPer;
                    }
                    decimal resultPercent = Percent(a, decimal.Parse(b));
                    Console.WriteLine("{0}-in {1} {2}-i {3} bərabərdir.", a, b, oper, resultPercent);
                    break;
                case "%%":
                    decimal Rate(decimal rateA, decimal rateB)
                    {
                        decimal resultRate = (rateA * 100) / rateB;
                        return resultRate;
                    }
                    decimal resultOfRate = Rate(a, decimal.Parse(b));
                    Console.WriteLine("{0} {1}-in {2} faizinə bərabərdir.", a, b, resultOfRate);
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
                    decimal Addition(decimal addA, decimal addB)
                    {
                        decimal resultAdd = addA + addB;
                        return resultAdd;
                    }
                    decimal resultAdditions = Addition(decimal.Parse(a), b);
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultAdditions);
                    break;
                case "-":
                    decimal Subtruction(decimal subA, decimal subB)
                    {
                        decimal resultSub = subA - subB;
                        return resultSub;
                    }
                    decimal resultSubtructions = Subtruction(decimal.Parse(a), b);
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultSubtructions);
                    break;
                case "*":
                    decimal Multiplication(decimal mulA, decimal mulB)
                    {
                        decimal resultMul = mulA * mulB;
                        return resultMul;
                    }
                    decimal resultMultiply = Multiplication(decimal.Parse(a), b);
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultMultiply);
                    break;
                case "/":
                    decimal Divide(decimal divA, decimal divB)
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
                    decimal resultDivide = Divide(decimal.Parse(a), b);
                    Console.WriteLine("{0} {1} {2} = {3}", a, oper, b, resultDivide);
                    break;
                case "%":
                    decimal Percent(decimal perA, decimal perB)
                    {
                        decimal resultPer = (perA * perB) / 100;
                        return resultPer;
                    }
                    decimal resultPercent = Percent(decimal.Parse(a), b);
                    Console.WriteLine("{0}-in {1} {2}-i {3} bərabərdir.", a, b, oper, resultPercent);
                    break;
                case "%%":
                    decimal Rate(decimal rateA, decimal rateB)
                    {
                        decimal resultRate = (rateA * 100) / rateB;
                        return resultRate;
                    }
                    decimal resultOfRate = Rate(decimal.Parse(a), b);
                    Console.WriteLine("{0} {1}-in {2} faizinə bərabərdir.", a, b, resultOfRate);
                    break;
                default:
                    break;
            }
        }
    }
}
