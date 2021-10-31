using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOperators
{
    public interface IOperators
    {
        bool GreaterThan(int a, int b);
        bool LessThan(int a, int b);
        int Increment(int a);
        int Decrement(int a);
        int Multiplication(int a, int n);
        int Divide(int a, int n);
        bool IsEqual(int a, int b);
        bool IsNotEqual(int a, int b);
        bool AndOperator(int x, int y, int z, int t);
        bool OrOperator(int x, int y, int z, int t);
        bool GreaterEqual(int x, int y);
        bool LessEqual(int x, int y);
        void StartEnd(int start, int end);
        void MultipleTernaryOperator(int x, int y, int z);
    }
}
