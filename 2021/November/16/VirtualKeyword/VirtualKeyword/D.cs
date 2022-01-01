using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualKeyword
{
    public class D : C
    {
        public string DName { get; set; }
        public string DSurname { get; set; }
        public override string Common { get; set; }
        public override void ShowMyClassName()
        {
            Console.WriteLine("This method called from class D");
            Console.WriteLine("Hello D");
        }
        public void ZMethod()
        {
            Console.WriteLine("ZMethod in D class");
        }
        public override void Hello(string letter)
        {
            Common += letter;
            Console.WriteLine(Common);
        }
    }
}
