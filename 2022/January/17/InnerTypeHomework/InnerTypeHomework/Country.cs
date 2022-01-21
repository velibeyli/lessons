using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerTypeHomework
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? EditDate { get; set; }
        public void ShowCountry()
        {
            Console.WriteLine("Country Id: {0}",Id);
            Console.WriteLine("Country Name: {0}",Name);
            Console.WriteLine("Country created date: {0}",CreateDate);
        }
    }
}
