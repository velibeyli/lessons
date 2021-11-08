using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Car : BaseMachine
    {
        public override string Colour { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Weight { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string PassengerCapacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Move()
        {
            Console.WriteLine("Avtomobil - Quruda yolda surulur.");
        }

        public override void Park()
        {
            Console.WriteLine("Avtomobil - nezerde tutulan parking erazisinde park edilir.");
        }

        public override void Stop()
        {
            Console.WriteLine("Avtomobil - stop eylecini sixmaqla stop edilir.");
        }
    }
}
