using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExampleHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            // IStudent student = new IStudent(); Interface-in instance-i yaradila bilmez
            IStudent student = new Student(); //Polimorfizme girir. 
            Student student1 = new Student();
            student1.Id = 1;
            student1.Name = "Ruslan";
            student1.Surname = "Velibeyli";
            student1.ShowFullname();

            Console.ReadLine();
        }
    }
}
