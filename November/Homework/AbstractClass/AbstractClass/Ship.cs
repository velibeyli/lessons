using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Ship : BaseMachine
    {
        public override string Colour { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Weight { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string PassengerCapacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Move()
        {
            Console.WriteLine("Gemi - Suda hereket edir.");
        }

        public override void Park()
        {
            Console.WriteLine("Gemi - Limanda park edilir");
        }

        public override void Stop()
        {
            Console.WriteLine("Gemi - suretini azaltmaqla arxa arxaya gelerek sahildeki tekerlere deyerek stop edir.");
        }
    }
}
