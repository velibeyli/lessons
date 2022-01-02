using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DateTimeApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2010, 12, 30);
            long a = dt.Ticks,b = DateTime.Now.Ticks;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(b-a);
            //Console.WriteLine(DateTime.Now);
            //Console.WriteLine(DateTime.UtcNow);
            //Console.WriteLine(DateTime.Today);
            //Console.WriteLine(dt.Year);
            //Console.WriteLine(dt.Month);
            //Console.WriteLine(dt.Day);
            //DateTime utcDate = new DateTime(1998, 5, 14, 16, 38, 56, DateTimeKind.Utc);
            //Console.WriteLine(utcDate.Hour);
            //Console.WriteLine(utcDate.Minute);
            //Console.WriteLine(utcDate.Second);

            //DateTime minValue = DateTime.MinValue;
            //DateTime maxValue = DateTime.MaxValue;
            //Console.WriteLine(minValue);
            //Console.WriteLine(maxValue);


            TimeSpan ts = new TimeSpan(12, 03, 16);

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(DateTime.Now.Ticks);
            //    Thread.Sleep(500);
            //}
            Console.ReadLine();

        }
    }
}
