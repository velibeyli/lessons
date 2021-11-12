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
            get { return _practise + 5; }
            set {
                if (value > 1 && value <= 3)
                    _salary = 600;
                else if (value > 3 && value <= 6)
                    _salary = 850;
                else if (value > 6 && value <= 10)
                    _salary = 1200;
                else if (value > 10)
                    _salary = 1500;
                _practise = value;
            }
        }
        public override string Work()
        {
            return "Teacher teaches science to student. Salary: " + _salary;
        }
    }
}
