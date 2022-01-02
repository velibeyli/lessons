using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Operators _operator = new Operators();
            bool resultOfGreaterThan = _operator.GreaterThan(5, 13);
            Console.WriteLine("Result of GreaterThan(5, 13) = " + resultOfGreaterThan);

            bool resultOfLessThan = _operator.LessThan(5, 13);
            Console.WriteLine("Result of LessThan(5, 13) = " + resultOfLessThan);

            int resulOfIncrement = _operator.Increment(40);
            Console.WriteLine("Result of Increment(40) = " + resulOfIncrement);

            int resulOfDecrement = _operator.Decrement(40);
            Console.WriteLine("Result of Decrement(40) = " + resulOfDecrement);

            int resulOfIncrementWithN = _operator.Increment(40, 15);
            Console.WriteLine("Result of Increment(40, 15) = " + resulOfIncrementWithN);

            int resulOfDecrementWithN = _operator.Decrement(40, 15);
            Console.WriteLine("Result of Decrement(40, 15) = " + resulOfDecrementWithN);

            int resulOfMultiplication = _operator.Multiplication(40, 15);
            Console.WriteLine("Result of Multiplication(40, 15) = " + resulOfMultiplication);

            int resulOfDivide = _operator.Divide(40, 15);
            Console.WriteLine("Result of Divide(40, 15) = " + resulOfDivide);

            bool resulOfIsEqual = _operator.IsEqual(74, 65);
            Console.WriteLine("Result of IsEqual(74, 65) = " + resulOfIsEqual);

            bool resulOfIsNotEqual = _operator.IsNotEqual(44, 44);
            Console.WriteLine("Result of IsNotEqual(44, 44) = " + resulOfIsNotEqual);

            bool resulOfAndOperator = _operator.AndOperator(44, 50, 89, 156);
            Console.WriteLine("Result of AndOperator(44, 50, 89, 156) = " + resulOfAndOperator);

            bool resulOfOrOperator = _operator.OrOperator(44, 50, 89, 156);
            Console.WriteLine("Result of OrOperator(44, 50, 89, 156) = " + resulOfOrOperator);

            bool resulOfGreaterEqual = _operator.GreaterEqual(250, 160);
            Console.WriteLine("Result of GreaterEqual(250, 160) = " + resulOfGreaterEqual);

            bool resulOfLessEqual = _operator.LessEqual(250, 160);
            Console.WriteLine("Result of LessEqual(250, 160) = " + resulOfLessEqual);

            //_operator.StartEnd(40, 50);
            _operator.DividedN(0, 100, 5);

            _operator.MultipleTernaryOperator(6, 8, 10);

            Console.ReadLine();
        }
    }
}
