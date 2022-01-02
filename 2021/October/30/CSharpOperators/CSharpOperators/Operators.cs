using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOperators
{
    public class Operators : IOperators
    {
        public bool GreaterThan(int a, int b)
        {
            return (a > b);
        }

        public bool LessThan(int a, int b)
        {
            return (a < b);
        }
        public int Increment(int a)
        {
            a++;
            return a;
        }
        public int Decrement(int a)
        {
            a--;
            return a;
        }
        public int Increment(int a, int n)
        {
            return a += n;
        }
        public int Decrement(int a, int n)
        {
            return a -= n;
        }
        public int Multiplication(int a, int n)
        {
            return a *= n;
        }
        public int Divide(int a, int n)
        {
            return a /= n;
        }
        public bool IsEqual(int a, int b)
        {
            return (a == b);
        }
        public bool IsNotEqual(int a, int b)
        {
            return (a != b);
        }
        public bool AndOperator(int x, int y, int z, int t)
        {
            return (x > y && z < t);
        }
        public bool OrOperator(int x, int y, int z, int t)
        {
            return (x > y || z < t);
        }
        public bool GreaterEqual(int x, int y)
        {
            return (x >= y);
        }
        public bool LessEqual(int x, int y)
        {
            return (x <= y);
        }
        public void StartEnd(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine(i);
            }
        }
        public void StartEnd(int start, int end, int n)
        {
            for (int i = start; i <= (end+n); i+=n)
            {
                Console.WriteLine(i);
            }

        }
        public void DividedN(int start, int end, int n)
        {
            for (int i = start; i <= end; i++)
            {
                //if (i % n == 0)
                //    Console.WriteLine(i);

                var result = (i % n == 0) ? i.ToString() : "a";
                Console.WriteLine(result);
            }
        }

        public void MultipleTernaryOperator(int x, int y, int z)
        {
            var result = ((x * 2) > y) //if
                ?
                x /*if condition*/ : (y > z) //else if
                ? 
                y /*if condition*/ : z /*else condition*/;

            if ((x * 2) > y)
                result = x;
            else if (y > z)
                result = y;
            else
                result = z;

            Console.WriteLine(result);
        }
    }
}
