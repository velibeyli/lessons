using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 5;
                int b = int.Parse(Console.ReadLine());
                throw new FormatException();
                Console.WriteLine(a/b);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format sehvdir!");
                Console.WriteLine(e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Deyer sifira bolune bilmez!");
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Hello finally");
            }

            Console.ReadLine();
        }
    }
}
