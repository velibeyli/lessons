using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTaskWithAbstract
{
    public class Doctor :BaseEmployee
    {
        public string  HospitalName { get; set; }
        public override int Practice
        {
            get { return Practice; }
            set
            {
                if (value > 1 && value <= 2)
                    _salary = 900;
                else if (value > 2 && value <= 5)
                    _salary = 1500;
                else if (value > 5 && value <= 10)
                    _salary = 2100;
                else if (value > 10)
                    _salary = 2800;
            }
        }
        public override string Work()
        {
            return "Doctors operates surgery. Salary: " + _salary;
        }
    }
}
