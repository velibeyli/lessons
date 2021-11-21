using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualKeyword
{
    public class C : B
    {
        public string CName { get; set; }
        public string CSurname { get; set; }
        public override string Common { get; set; }
        public override void ShowMyClassName()
        {
            Console.WriteLine("This method called from class C");
            Console.WriteLine("Hello C");
        }
        public sealed override void ZMethod()
        {
            Console.WriteLine("ZMethod in C class");
        }
        public override void Hello(string letter)
        {
            Common += letter;
            Console.WriteLine(Common);
        }
    }
}
