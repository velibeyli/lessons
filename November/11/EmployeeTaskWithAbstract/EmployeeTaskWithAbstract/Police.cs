using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTaskWithAbstract
{
    public class Police :BaseEmployee
    {
        public string GunModel { get; set; }
        public override int Practice
        {
            get { return Practice; }
            set
            {
                if (value > 1 && value <= 5)
                    _salary = 550;
                else if (value > 5 && value <= 10)
                    _salary = 780;
                else if (value > 10 && value <= 15)
                    _salary = 1100;
                else if (value > 15)
                    _salary = 1450;
            }
        }
        public override string Work()
        {
            return "Police makes life secure. Salary: " + _salary;
        }
    }
}
