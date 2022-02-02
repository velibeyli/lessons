using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExampleHomework
{
    public class Student : IStudent
    {
        // butun property ve metodlari yazmaq mecburiyyeti qarshisinda buraxir
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public void ShowFullname ()
        {
            Console.WriteLine("Name: {0}",Name);
            Console.WriteLine("Surname: {0}",Surname);
        }

    }
}
