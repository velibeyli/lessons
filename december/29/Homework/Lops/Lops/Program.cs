using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            /* Homework #1
        Random yaranan bir dəyəri istifadəçinin tapması (while döngüsü istifadə edərək edin bunu)
        Bir random dəyər yaransın məsələn 1-10 arasında.
        İstifadəçidən 
        "1. Cəhd - Zəhmət olmasa rəqəmi yazın: " yazaraq rəqəmi tapmasını istəyin.
        Düz olsa, 
        "1. cəhdinizdə rəqəmi tapdınız" yazsın.
        Səhv olsa, 
        "1. Cəhdiniz uğursuz!"
        "2. Cəhd - Zəhmət olmasa rəqəmi yazın: " deyə ikinci dəfə soruşsun və bu tapana qədər davam etsin
        Homework #2
        App'ın işləmə prinsipi: istifadəçidən username və password soruşulacaq. Əgər username və password kodda əlnən müəyyən edəcəyimiz demo/demo olarsa 
        Sistemə daxil olundu mesajı yazılacaq. Yox yanlış username və ya pass daxil edilərsə, o zaman ekrana Username və ya password yanlışdır mesajı çıxacaq.
        Bu tapşırığı do while istifadə edərək etməlisiniz.
        Homework #3
        App'ın işləmə prinsipi: İlk öncə istifadəçidən "Texmin oyunu ucun en yuksek deyeri daxil edin: " yazısı ilə bir rəqəm alınmalıdır. Sonra 1 ilə bu rəqəm arasında random bir
            rəqəm generate edilməlidir və istifadəçidən generate olunan rəqəmi tapmağı istənməlidir. "1. Cəhdiniz! Zəhmət olmasa rəqəmi təxmin edin: " mesajı ilə istifadəçidən random 
            dəyər soruşulur. Hər səhv daxil edilən dəyərdə eyni şey təkrar göstərilir. Sadəcə hər dəfə index artır...1. 2. 3. və s. İstifadəçi random rəqəmi tapdığı zaman "5. Cəhdinizdə 
            düzgün rəqəmi tapdınız!" mesajı göstərilməlidir.
        Bunu do while istifadə edərək yazmalısınız.
        3-cü tapşırıqda 1-ci tapşırıqdan fərqli olaraq, səhv tapanda sadəcə yenidən 
        "2. Cəhdiniz! Zəhmət olmasa rəqəmi təxmin edin: " 
        yazılacaq əgər yenə səhv rəqəm yazsa yenə 
        "3. Cəhdiniz! Zəhmət olmasa rəqəmi təxmin edin: " 
        yazılacaq. Düz tapanda isə 4. Cəhdinizdə düzgün rəqəmi tapdınız! yazacaq.
             */

            #region Homework 1

            Random rnd = new Random();

            int counter = 1;

            while (true)
            {
                int rndNumber = rnd.Next(1, 10);
                Console.WriteLine("{0}. Cəhd - Zəhmət olmasa rəqəmi yazın: ", counter);
                int input = int.Parse(Console.ReadLine());

                if (input == rndNumber)
                {
                    Console.WriteLine("{0}. Cəhdinizdə rəqəmi tapdınız. ", counter);
                    break;
                }
                else
                {
                    Console.WriteLine("{0}. Cəhdiniz uğursuz!", counter);
                }
                counter++;
            }

            #endregion

            #region Homework 2

            Console.WriteLine("Username daxil edin: ");
            string username = Console.ReadLine();

            Console.WriteLine("Password daxil edin: ");
            string password = Console.ReadLine();

            do
            {
                if (username == "demo" && password == "demo")
                {
                    Console.WriteLine("Sistemə daxil olundu!");
                    break;
                }
                else
                {
                    Console.WriteLine("Username və ya password yalnışdır!");
                    break;
                }

            } while (true);

            #endregion

            #region Homework 3

            Console.WriteLine("Təxmin oyunu üçün ən yüksək dəyəri daxil edin: ");
            int prediction = int.Parse(Console.ReadLine());

            int counterNumber = 1;

            Random random = new Random();

            do
            {
                int randomNum = random.Next(1, prediction);
                Console.WriteLine("{0}. Cəhdiniz! Zəhmət olmasa rəqəmi daxil edin: ", counterNumber);
                int predictionNumber = int.Parse(Console.ReadLine());

                if (predictionNumber == randomNum)
                {
                    Console.WriteLine("{0}. Cəhdinizdə rəqəmi tapdınız! ", counterNumber);
                    Console.WriteLine("Təxmin olunan rəqəm {0}", randomNum);
                    break;
                }
                else
                {
                    Console.WriteLine("{0}. Cəhdiniz uğursuz! ", counterNumber);
                    Console.WriteLine("Təxmin olunan rəqəm {0}", randomNum);
                }
                counterNumber++;
            } while (true);


            #endregion

            Console.ReadLine();
        }
    }
}
