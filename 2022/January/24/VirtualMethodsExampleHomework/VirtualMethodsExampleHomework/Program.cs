using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethodsExampleHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Id = 1;
            student.Name = "Ruslan";
            student.Surname = "Velibeyli";
            student.ShowFullname();

            Console.ReadLine();
        }
    }
}
