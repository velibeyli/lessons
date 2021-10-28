using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string CardNumber = "1234 5678 9876 5432";
            string CardExpiryDate = "08/25";
            string CardHolderName = "Orkhan Farajov";
            string CardCVV = "316";
            string balance = "356,75";
            

            Console.WriteLine("Zehmet olmasa meblegi daxil edin: ");
            string inputMebleg = Console.ReadLine();
            Console.WriteLine("Zehmet olmasa kartin uzerindeki 16 reqemi daxil edin: ");
            string inputCardNumber = Console.ReadLine();
            Console.WriteLine("Kartin bitme tarixini qeyd edin: ");
            string inputCardExpiryDate = Console.ReadLine();
            Console.WriteLine("Kart sahibinin adini qeyd edin: ");
            string inputCardHolderName = Console.ReadLine();
            Console.WriteLine("Kartin CVV kodunu daxil edin: ");
            string inputCardCVV = Console.ReadLine();

            string qaliqMebleg = (float.Parse(balance) - float.Parse(inputMebleg)).ToString();

            if (CardNumber == inputCardNumber &&
                CardExpiryDate == inputCardExpiryDate &&
                CardHolderName == inputCardHolderName &&
                CardCVV == inputCardCVV)
            {
                Console.WriteLine("Emeliyyat tamamlandi, qaliq mebleg: " + qaliqMebleg); 
            }
            else
            {
                Console.WriteLine("Kart melumatları sehvdir");
            }

            Console.ReadLine();
        }
    }
}
