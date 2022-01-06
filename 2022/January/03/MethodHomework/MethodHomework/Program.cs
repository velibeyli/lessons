using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student();

            Console.WriteLine("Telebenin adini daxil edin:");
            string stName = Console.ReadLine();

            Console.WriteLine("Telebenin soyadini daxil edin:");
            string stSurname = Console.ReadLine();

            Console.WriteLine("Telebinin birinci qiymetini daxil edin:");
            st.Result1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Telebinin ikinci qiymetini daxil edin:");
            st.Result2 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Telebinin ucuncu qiymetini daxil edin:");
            st.Result3 = decimal.Parse(Console.ReadLine());

            
            st.CalcAverage(st.Result1,st.Result2,st.Result3,stName,stSurname);

            st.RateAverage(st.Result1, st.Result2, st.Result3, stName,stSurname);

            Console.ReadLine();


        }
    }
}
