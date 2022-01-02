using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyramidNumbers
{
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthdate { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public int Gender2 { get; set; }
        public Gender Gender3 { get; set; }

        public string Branch { get; set; }
        public Branch Branch2 { get; set; }
    }

    public enum Gender
    {
        Male,
        Female
    }

    public enum Branch
    { 
        Police = 1,
        IT = 2,
        Geology = 3,
        Architect = 4,
        Designer = 5,
        Doctor = 6,
        Finance = 7
    }


    //public enum Gender
    //{
    //    Male = 1,
    //    Female = 2
    //}
}
