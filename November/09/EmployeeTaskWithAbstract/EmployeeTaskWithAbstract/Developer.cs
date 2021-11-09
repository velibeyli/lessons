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
                if (Practice > 1 && Practice <= 4)
                    Salary = 1000;
                else if (Practice > 4 && Practice <= 7)
                    Salary = 2500;
                else if (Practice > 7 && Practice <= 12)
                    Salary = 3700;
                else if (Practice > 12)
                    Salary = 4600;
            }
        }
        public override string Work() {
            return "Developers writes code.";
        }
    }
}
