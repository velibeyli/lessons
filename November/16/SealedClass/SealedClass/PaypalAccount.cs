using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClass
{
    public class PaypalAccount : MasterCard
    {
        public override int Pin { get; set; } = 124;
        public override void ShowCardInfo()
        {
            Console.WriteLine("Welcome to Paypal Account");
        }

        //protected sealed override int GetCVV() //you cannot override sealed method in nested inherited class
        //{
        //    return this.CVV;
        //}
    }
}
