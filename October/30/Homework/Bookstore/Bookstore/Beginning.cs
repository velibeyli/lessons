using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore
{
    public class Beginning
    {
        public static int Beginning()
        {
            Console.WriteLine("Hansi emeliyyatlari icra etmek isteyirsiniz? (Ana Menyu)");
            Console.WriteLine(" ");
            Console.WriteLine("1.Yeni kitab elave et.");
            Console.WriteLine("2.Butun kitablari goster.");
            Console.WriteLine("3.Kitabxanada olan butun kitablarin sayini goster.");
            Console.WriteLine("4.Ada gore kitab axtar");
            Console.WriteLine(" ");
            return Int32.Parse(Console.ReadLine());
        }
    }
}
