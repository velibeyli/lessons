using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTaskWithAbstract
{
    public class Teacher :BaseEmployee
    {
        public string UniversityName { get; set; }
        public override int Practice
        {
            get { return Practice; }
            set {
                if (Practice > 1 && Practice <= 3)
                    Salary = 600;
                else if (Practice > 3 && Practice <= 6)
                    Salary = 850;
                else if (Practice > 6 && Practice <= 10)
                    Salary = 1200;
                else if (Practice > 10)
                    Salary = 1500;
            }
        }
        public override string Work()
        {
            return "Teacher teaches science to student.";
        }
    }
}
