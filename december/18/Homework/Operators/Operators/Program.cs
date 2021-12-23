using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            #region HomeWork 1
            string[] values = { null, "1526", "911.0", "Orkhan", "   - ", "+000", "(100)", true.ToString(), 000.ToString() };

            foreach (var value in values)
            {
                int no;
                bool changeAble = int.TryParse(value, out no);
                Console.WriteLine("Conversion result for value: '" + value + "'" + " is " + changeAble);
                //Conversion result for value: '1526' is true/false
                //Conversion result for value: '+000' is true/false
            }
            #endregion

            #region Homework 2
            //Console app yazın.
            //İstifadəçidən Ad, Soyad, Ata Adı, Doğulduğu ölkənin adı və yaşını soruşsun. Sonra bütün bu məlumatları ekranda göstərsin.
            //Yaşını əgər adam hərf olaraq daxil edibsə, ekranda boş görsənsin. Əgər doğru (rəqəm) olaraq daxil edibsə o zaman yaşını göstərsin.
            //Məlumatları aldıqdan sonra məlumatları göstərmədən öncə ekranı təmizləyin.
            Console.WriteLine("Adinizi daxil edin: ");
            string name = Console.ReadLine();

            Console.WriteLine("Soyadinizi daxil edin: ");
            string lastname = Console.ReadLine();

            Console.WriteLine("Ata adini daxil edin: ");
            string middleName = Console.ReadLine();

            Console.WriteLine("Doguldugunuz yeri daxil edin: ");
            string country = Console.ReadLine();

            Console.WriteLine("Yasinizi daxil edin: ");
            string age = Console.ReadLine();

            Console.Clear();

            Console.WriteLine(name);
            Console.WriteLine(lastname);
            Console.WriteLine(middleName);
            Console.WriteLine(country);
            int output;
            bool resultOfAge = int.TryParse(age, out output);
            if (!resultOfAge)
            {
                age = "";
                Console.WriteLine(age);
            }
            else
            {
                Console.WriteLine(age);
            }
            #endregion

            #region HomeWork 3
            string textBool = "True";
            //Yuxarıdakı textBool dəyişənini iki ayrı conversion növü ilə convert etməyə çalışın.
            //bool a =
            //bool b =

            //Int tipində bir dəyişəniniz olsun dəyəri 158. Bu rəqəmi byte və float tiplərinə çevirin. Ancaq sadəcə 1 dəfə helper classdan,
            //və ya parsing dən istifadə etmək haqqınız var.

            //İki ayrı byte tipində olan dəyişənləri toplayıb bir başqa byte dəyişəninə verin.

            bool a = Convert.ToBoolean(textBool);
            Console.WriteLine(a);

            bool b = bool.Parse(textBool);
            Console.WriteLine(b);

            int number = 158;
            byte numberToByte = Convert.ToByte(number);
            //also byte numberToByte = (byte)number;
            Console.WriteLine(numberToByte);

            float numberToFloat = number;
            Console.WriteLine(numberToFloat);

            byte bt1 = 123;
            byte bt2 = 132;
            byte sum = (byte)(bt1 + bt2);
            Console.WriteLine(sum);

            #endregion

            #region HomeWork (Ruslan)
            {
                var stringVar = "Hello";
                object stringObject = "Hello";

                //Answer is : stringObject.ToString().

            }
            #endregion


            Console.ReadLine();

        }
    }
}
