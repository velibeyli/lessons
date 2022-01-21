using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerTypeHomework
{
    public class Address
    {
        public int Id { get; set; }
        public int No { get; set; }
        public string Building { get; set; }
        public string Street { get; set; }
        public string Distinct { get; set; }
        public City City { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? EditDate { get; set; }
        public void ShowAddress()
        {
            Console.WriteLine("Address Id: {0}",Id);
            Console.WriteLine("Address No: {0}", No);
            Console.WriteLine("Address Building: {0}", Building);
            Console.WriteLine("Address Street: {0}", Street);
            Console.WriteLine("Address Distinct: {0}", Distinct);
            Console.WriteLine("Address Create Date: {0}", CreateDate);
            Console.WriteLine();
            City.ShowCity();
        }
    }
}
