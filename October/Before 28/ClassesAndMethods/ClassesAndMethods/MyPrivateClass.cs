using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndMethods
{
    public class MyPrivateClass
    {
        private string _name { get; set; }
        private string _surname { get; set; }
        private int _age { get; set; }

        public void SetPersonInfo(string name, string surname, int age)
        {
            if(name=="Orkhan")
                _name = name;

            if (surname == "Farajov")
                _surname = surname;

            if (age == 26)
                _age = age;
        }

        public void ShowPersonInfo()
        {
            Console.WriteLine("Name: " + _name);
            Console.WriteLine("Surname: " + _surname);
            Console.WriteLine("Age: " + _age);
        }
    }
}
