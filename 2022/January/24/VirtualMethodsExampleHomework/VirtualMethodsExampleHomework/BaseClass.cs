using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethodsExampleHomework
{
    public class BaseClass
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public virtual string Surname { get; set; }
        public virtual void ShowFullname() // Abstract classdan ferqli olaraq mutleq body-si yazilmalidir
        {
            Console.WriteLine("Id: {0}",Id);
            Console.WriteLine("Name: {0}",Name);
            Console.WriteLine("Surname: {0}",Surname);
        }
    }
}
