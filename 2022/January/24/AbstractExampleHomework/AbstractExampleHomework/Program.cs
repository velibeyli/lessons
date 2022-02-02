using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExampleHomework
{
    public class Program
    {
        static void Main(string[] args)
        {
            // BaseClass baseClass = new BaseClass(); //abstract classin instance-i yaradila bilmez
            Product product = new Product();
            product.Id = 1;
            product.Name = "product";
            product.CreateDate = DateTime.Now;
            product.ShowInformation();
            product.ShowTime();

            Console.ReadLine();
        }
    }
}
