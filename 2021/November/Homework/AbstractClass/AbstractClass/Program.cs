using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseMachine ship = new Ship();
            ship.Move();
            ship.Park();
            ship.Stop();

            Console.WriteLine("-------------------------");

            BaseMachine car = new Car();
            car.Move();
            car.Park();
            car.Stop();

            Console.WriteLine("-------------------------");

            BaseMachine airplane = new Airplane();
            airplane.Move();
            airplane.Park();
            airplane.Stop();

            Console.ReadLine();
        }
    }
}
