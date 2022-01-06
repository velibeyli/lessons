using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHomework
{
    public class Student
    {
        public decimal Result1;
        public decimal Result2;
        public decimal Result3;
        public void CalcAverage(decimal result1,decimal result2, decimal result3,string name,string surname)
        {
            decimal average = (result1 + result2 + result3) / 3;
            Console.WriteLine("Telebe {0} {1}  3 imtahan qiymetinin ortalamasi: {2}",name,surname,average);
        }

        public void RateAverage(decimal result1, decimal result2, decimal result3, string name, string surname)
        {
            decimal average = (result1 + result2 + result3) / 3;
            if (average >= 45)
                Console.WriteLine("{0} {1} Imtahandan kecdi",name, surname);
            else
                Console.WriteLine("{0} {1} Imtahandan kece bilmedi",name,surname);
        }
        private void CalcAverage(decimal result1,decimal result2, decimal result3)
        {
            result1 = Result1;
            result2 = Result2;
            result3 = Result3;
        }
    }
}
