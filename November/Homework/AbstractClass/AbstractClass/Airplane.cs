using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Airplane : BaseMachine
    {
        public override string Colour { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Weight { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string PassengerCapacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Move()
        {
            Console.WriteLine("Teyyare - Havada ucur");
        }

        public override void Park()
        {
            Console.WriteLine("Teyyare - Hava limaninda xususi ayrilmis yerlerde park edilir.");
        }

        public override void Stop()
        {
            Console.WriteLine("Teyyare - qanadlarindaki demirler saquli veziyyete getirilir," +
                "bu da kuleyin muqavimetinin eksine getdiyine gore stop edir .");
        }
    }
}
