using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClasses
{
    public partial class Course
    {
        public void AddNewStudent()
        {
            Console.WriteLine("New student added");
        }
        public void GetStudentById()
        {
            Console.WriteLine("Student info select by Id");
        }
        public void DeleteStudentInfo()
        {
            Console.WriteLine("Some student info deleted");
        }
        //public partial int GetStudent()
        //{
        //    return 1;
        //}
    }
}
