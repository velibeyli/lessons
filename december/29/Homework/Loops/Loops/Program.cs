using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            #region Homework1

            /*Homework #1
            Random yaranan bir dəyəri istifadəçinin tapması (while döngüsü istifadə edərək edin bunu)
            Bir random dəyər yaransın məsələn 1-10 arasında.
            İstifadəçidən 
            "1. Cəhd - Zəhmət olmasa rəqəmi yazın: " yazaraq rəqəmi tapmasını istəyin.
            Düz olsa, 
            "1. cəhdinizdə rəqəmi tapdınız" yazsın.
            Səhv olsa, 
            "1. Cəhdiniz uğursuz!"
            "2. Cəhd - Zəhmət olmasa rəqəmi yazın: " deyə ikinci dəfə soruşsun və bu tapana qədər davam etsin
             */

            Random rnd = new Random();
            int counter = 1;

            while (true)
            {
                int randomNumber = rnd.Next(1, 10);
                Console.WriteLine("{0}. Cəhd - Zəhmət olmasa rəqəmi yazın: ", counter);
                Console.WriteLine();
                int userInput = int.Parse(Console.ReadLine());
                Console.WriteLine("-----------------------------------------------");

                if (userInput == randomNumber)
                {
                    Console.WriteLine("{0}. Cəhdində rəqəmi tapdınız.", counter);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("{0}. Cəhdiniz uğursuz.", counter);
                    Console.WriteLine("Təsadüfi alınan ədəd: {0}", randomNumber);
                    Console.WriteLine();
                }
                counter++;
            }
            #endregion

            #region Homework2

            /*Homework #2
            App'ın işləmə prinsipi: istifadəçidən username və password soruşulacaq. Əgər username və password kodda əlnən müəyyən edəcəyimiz demo/demo olarsa 
            Sistemə daxil olundu mesajı yazılacaq. Yox yanlış username və ya pass daxil edilərsə, o zaman ekrana Username və ya password yanlışdır mesajı çıxacaq.
            Bu tapşırığı do while istifadə edərək etməlisiniz.
             */

            Console.WriteLine("Username daxil edin: ");
            string username = Console.ReadLine();

            Console.WriteLine("Password daxil edin: ");
            string password = Console.ReadLine();

            do
            {
                if (username == "demo" && password == "demo")
                {
                    Console.WriteLine("sistemə daxil olundu!");
                    break;
                }
                else
                {
                    Console.WriteLine("Username və ya password yanlışdır!");
                    break;
                }
            } while (true);

            #endregion

            #region Homework3

            /*Homework #3
            App'ın işləmə prinsipi: İlk öncə istifadəçidən "Texmin oyunu ucun en yuksek deyeri daxil edin: " yazısı
            ilə bir rəqəm alınmalıdır. Sonra 1 ilə bu rəqəm arasında random bir rəqəm generate edilməlidir və 
            istifadəçidən generate olunan rəqəmi tapmağı istənməlidir. "1. Cəhdiniz! Zəhmət olmasa rəqəmi təxmin edin:
            " mesajı ilə istifadəçidən random dəyər soruşulur. Hər səhv daxil edilən dəyərdə eyni şey təkrar göstərilir.
            Sadəcə hər dəfə index artır...1. 2. 3. və s. İstifadəçi random rəqəmi tapdığı zaman "5. Cəhdinizdə düzgün rəqəmi
            tapdınız!" mesajı göstərilməlidir. Bunu do while istifadə edərək yazmalısınız.
             */

            Console.WriteLine("Təxmin oyunu üçün ən yüksək dəyəri daxil edin: ");
            int input = int.Parse(Console.ReadLine());

            Random random = new Random();            

            int counterNum = 1;

            do
            {
                int randomNum = random.Next(1, input);
                Console.WriteLine("{0}. Cəhdiniz! Zəhmət olmasa rəqəmi təxmin edin: ", counterNum);
                int tryNumber = int.Parse(Console.ReadLine());

                if (tryNumber == randomNum)
                {
                    Console.WriteLine("{0}. Cəhdinizdə düzgün rəqəmi tapdınız!", counterNum);
                    break;
                }
                counterNum++;
            } while (true);

            #endregion

            Console.ReadLine();
        }
    }
}
