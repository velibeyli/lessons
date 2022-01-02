using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapitalBankApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            WebApp();
            MobileApp();
            API();
            Console.ReadLine();
        }
        public static void WebApp()
        {
            Console.WriteLine("This is WebApplication.");
        }
        public static void MobileApp()
        {
            Console.WriteLine("This is MobileApp.");
        }
        public static void API()
        {
            Console.WriteLine("This is API.");
        }
        public static void BirBankApp()
        {
            Console.WriteLine("1-ci ay");
            Console.WriteLine("2-ci ay");
            Console.WriteLine("3-cu ay");
            Console.WriteLine("4-cu ay");
        }
        public static void Reklam()
        {
            Console.WriteLine("This is ReklamApp.");
        }
        public static void SendMessage()
        {
            Console.WriteLine("Hi man");
        }

        public static void SendMail()
        {
            Console.WriteLine("Hi man");
        }

        public static void SendCoorporateMail()
        {
            Console.WriteLine("Hi man");
        }
    }
}
