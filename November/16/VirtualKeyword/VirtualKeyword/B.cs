using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualKeyword
{
    public class B : A
    {
        public string BName { get; set; }
        public string BSurname { get; set; }
        public string Common { get; set; }
        public override void ShowMyClassName()
        {
            Console.WriteLine("This method called from class B");
        }
        public override void ZMethod()
        {
            Console.WriteLine("ZMethod in B class");
        }
    }
}
