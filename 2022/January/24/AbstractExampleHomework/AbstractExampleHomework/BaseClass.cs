using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExampleHomework
{
    public abstract class BaseClass
    {
        // Abstrakt klasslarda abstakt olan ve olmayan property ve metodlar ola biler
        public int Id { get; set; }
        public string Name { get; set; }
        // public abstract string Surname; // abstract field yaradila bilmez
        public abstract string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? EditDate { get; set; }

        public void ShowTime()
        {
            CreateDate = DateTime.Now;
            Console.WriteLine(CreateDate);
        }
        public abstract void ShowInformation(); // Body-si qeyd edilmir,yalniz imzasi yazilir.
                                                // Derived class terefde bu metod override edilerek body-si yazilir.
                                                // abstract property ve metodlarin access modifierleri private ola bilmez.
        public BaseClass() // Abstrakt klaslarda konstructor yaradila biler
        {
            Console.WriteLine("Id: {0}",Id);
            Console.WriteLine("Name: {0}",Name);
            Console.WriteLine("Created date: {0}",CreateDate);
        }
    }
}
