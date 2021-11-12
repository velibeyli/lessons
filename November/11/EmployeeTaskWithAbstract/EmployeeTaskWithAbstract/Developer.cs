using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTaskWithAbstract
{
    public class Developer :BaseEmployee
    {
        public string ComputerModel { get; set; }
        public override int Practice
        {
            get { return Practice; }
            set
            {
                if (value > 1 && value <= 4)
                    _salary = 1000;
                else if (value > 4 && value <= 7)
                    _salary = 2500;
                else if (value > 7 && value <= 12)
                    _salary = 3700;
                else if (value > 12)
                    _salary = 4600;
            }
        }
        public override string Work()
        {
            return "Developers writes code. Salary: " + _salary;
        }
    }
}
