using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class Mercedes : MainCar
    {
        public override void NeedsRepair()
        {
            if (Mileage > 100000)
                Console.WriteLine("Go to service");
            else
                Console.WriteLine("If your car does not any problem, you should not go to car service");
        }
    }
}
