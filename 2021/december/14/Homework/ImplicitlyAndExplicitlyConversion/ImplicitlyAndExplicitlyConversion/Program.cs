using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitlyAndExplicitlyConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "15654";

            int strToInt = str;

            //StringToIntConversion convertNum = new StringToIntConversion(1564);
            //int num = convertNum;
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
    public class StringToIntConversion
    {
        public int Number;
        public StringToIntConversion(int num)
        {
            this.Number = num;
        }
        public static implicit operator int (StringToIntConversion a) => a.Number;
    }
    //public class String
    //{
    //    public int Age { get; set; }
    //    public String(int age)
    //    {
    //        this.Age = age;
    //    }
    //    public static implicit operator int (String str) => str.Age;
    //}

    //public struct String
    //{
    //    public int numb1;
    //    public String(int a)
    //    {
    //        this.numb1 = a;
    //    }
    //    public static implicit operator int(String b) => b.numb1;
    //}
}
