using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class BaseMachine
    {
        abstract public void Move();
        abstract public void Stop();
        abstract public void Park();
        public abstract string Colour { get; set; }
        public abstract string Weight { get; set; }
        public abstract string PassengerCapacity { get; set; }

    }
}
