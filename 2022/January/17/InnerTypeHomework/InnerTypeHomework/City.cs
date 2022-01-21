using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerTypeHomework
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Country Country { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? EditDate { get; set; }
        public void ShowCity()
        {
            Console.WriteLine("City Id: {0}",Id);
            Console.WriteLine("City Name: {0}",Name);
            Console.WriteLine("City created date: {0}", CreateDate);
            Console.WriteLine();
            Country.ShowCountry();
        }
    }
}
