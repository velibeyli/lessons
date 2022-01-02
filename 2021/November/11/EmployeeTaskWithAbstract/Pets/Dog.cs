using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    public class Dog : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("It hurur");
        }
    }
}
