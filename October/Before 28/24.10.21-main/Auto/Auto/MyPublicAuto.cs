using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto
{
    public class MyPublicAuto
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Door { get; set; }
        public string Engine { get; set; }
        public void ShowAutoInfo()
        {
            Console.WriteLine("Brand name: " + Brand);
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Year: " + Year);
            Console.WriteLine("Door: " + Door);
            Console.WriteLine("Engine: " + Engine);
        }
    }
}
