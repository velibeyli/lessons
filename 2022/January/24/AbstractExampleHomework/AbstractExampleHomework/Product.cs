using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExampleHomework
{
    public class Product : BaseClass
    {
        public override string Description { get; set; }
        public override void ShowInformation()
        {
            Console.WriteLine("Id: {0} ve Name: {1}",Id,Name);
        }
    }
}
