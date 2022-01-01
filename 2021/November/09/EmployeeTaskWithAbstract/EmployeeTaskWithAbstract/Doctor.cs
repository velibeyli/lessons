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
                if (Practice > 1 && Practice <= 2)
                    Salary = 900;
                else if (Practice > 2 && Practice <= 5)
                    Salary = 1500;
                else if (Practice > 5 && Practice <= 10)
                    Salary = 2100;
                else if (Practice > 10)
                    Salary = 2800;
            }
        }
        public override string Work()
        {
            return "Doctors operates surgery.";
        }
    }
}
