using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            IdCard card = new IdCard();
            card.DocumentSerial = "AA";
            card.DocumentNumber = "12345678";
            Console.WriteLine("Document info: {0} {1}",card.DocumentSerial, card.DocumentNumber);
            Console.ReadLine();
        }
    }
}
