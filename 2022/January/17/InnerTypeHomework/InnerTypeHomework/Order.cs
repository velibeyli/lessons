using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerTypeHomework
{
    public class Order
    {
        public int Id { get; set; }
        public string OrderDetails { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? EditDate { get; set; }
        public void ShowOrder()
        {
            Console.WriteLine("Order Id: {0}",Id);
            Console.WriteLine("Order details: {0}",OrderDetails);
            Console.WriteLine("Order created date {0}",CreateDate);
        }
    }
}
