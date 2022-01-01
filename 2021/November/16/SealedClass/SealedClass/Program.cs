using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Id = 1;
            customer.Name = "Qurban";
            customer.Surname = "Qurbanov";

            MasterCard masterCard = new MasterCard();
            masterCard.Customer = customer;
            masterCard.Id = 1;
            masterCard.CardNumber = "4656 6564 1233 7955";
            masterCard.HolderName = "Qurban Qurbanov";
            masterCard.Balance = 625.60;

            VisaCard visaCard = new VisaCard();
            visaCard.Customer = customer;
            visaCard.Id = 1;
            visaCard.CardNumber = "4656 6564 1233 7955";
            visaCard.HolderName = "Qurban Qurbanov";
            visaCard.Balance = 1500;

            masterCard.ShowCardInfo();
            masterCard.ShowCvvCode(124);
            Console.WriteLine(masterCard.ShowBalance());

            /*
             Task:
            1. BankCard classindaki HolderName Customerdeki name ve surname-den gotursun ve HolderName'e beraber etsin.
            2. BankCard class'inin icinde GetCash methodu olsun ve o methoda oturulen deyer qeder balansdan pul cixib cixardilan meblegi, qaligi gostersin.
            pul cixilan zaman, mastercard 3, Visa card ise 2 faiz komissiya haqqi tutsun.
            Meselen Balans 100 manatdirsa ve user 20 manat pul nagdlasdirirsa, 100-20 - 0.40 = 79.60 olsun
            3. CardNumber ekrana yazilanda 1234 1234 **** **** formatinda olsun.

             */

            //Task 1:

            BankCard card = new MasterCard();
            card.Customer = customer;
            //card.HolderName = customer.Name + " " + customer.Surname;
            card.HolderName = card.Customer.Name + " " + card.Customer.Surname;
            Console.WriteLine(card.HolderName);
            Console.WriteLine("---------------------------");

            //Task 2:

            Console.WriteLine("Master kartda:");
            masterCard.GetCash(100);
            Console.WriteLine("---------------------------");
            Console.WriteLine("Visa kartda:");
            visaCard.GetCash(200);

            //Task 3:

            string hideLastDigit = masterCard.CardNumber.Remove(10, 9).Insert(10, "**** ****").ToString();
            Console.WriteLine(hideLastDigit);


            Console.ReadLine();
        }
    }
}
