using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClass
{
    public class BankCard
    {
        public Customer Customer { get; set; }
        public int Id { get; set; }
        public string CardNumber { get; set; }
        public virtual int CvvCode { get; set; }
        public virtual int Pin { get; set; }
        public string HolderName { get; set; }
        public double Balance { get; set; }
        public virtual void ShowCardInfo()
        {
            Console.WriteLine("Card Id: " + Id);
            Console.WriteLine("Card number: " + CardNumber);
            Console.WriteLine("Card holder name: " + HolderName);
        }
        protected sealed virtual int? GetCvvCode(int pin)
        {
            return Pin;
        }
        public double ShowBalance()
        {
            return Balance;
        }
    }
}
