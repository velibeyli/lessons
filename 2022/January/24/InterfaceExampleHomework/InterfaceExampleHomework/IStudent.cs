using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExampleHomework
{
    public interface IStudent
    {
        int Id { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
        void ShowFullname();
        //public IStudent()  Interface-in konstruktoru yaradila bilmez.
        //{

        //}
    }
}
