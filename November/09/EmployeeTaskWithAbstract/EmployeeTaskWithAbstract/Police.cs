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
                if (Practice > 1 && Practice <= 5)
                    Salary = 550;
                else if (Practice > 5 && Practice <= 10)
                    Salary = 780;
                else if (Practice > 10 && Practice <= 15)
                    Salary = 1100;
                else if (Practice > 15)
                    Salary = 1450;
            }
        }
        public override string Work()
        {
            return "Police makes life secure.";
        }
    }
}
