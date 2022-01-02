using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class Audi : MainCar
    {
        public override void NeedsRepair()
        {
            if (Mileage > 75000)
                Console.WriteLine("Go to service");
            else
                Console.WriteLine("If your car does not any problem, you should not go to car service");
        }
    }
}
