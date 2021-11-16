using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClass
{
    public class MasterCard : BankCard
    {
        public CardType CardTypeId { get; set; } = CardType.MasterCard;
        public override int Pin { get; set; } = 124;
        public override int CvvCode { get; set; } = 444;
        public void ShowCvvCode(int pin)
        {
            var cvv = this.GetCvvCode(pin);
            Console.WriteLine(cvv == null ? "Incorrect PIN!" : "Your Master Cards CVV: " + cvv);
        }
        protected sealed override int? GetCvvCode(int pin)
        {
            if (this.Pin == pin)
                return CvvCode;

            return null;
        }
    }
}
