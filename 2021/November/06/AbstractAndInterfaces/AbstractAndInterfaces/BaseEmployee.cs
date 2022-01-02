using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndInterfaces
{
    public abstract class BaseEmployee //Is a
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        private string Degree { get; set; }
        private int AnualPermit { get; set; }
        protected double Salary { get; set; }
        private string Currency { get; set; }

        public void SetInfo(string name, string surname, int salary, string currency) 
        {
            this.Name = name;
            this.Surname = surname;
            this.Salary = salary;
            this.Currency = currency;

            if (salary > 3000)
            {
                this.Degree = "Junior";
                this.AnualPermit = 14;
            }
            else if(salary > 4000)
            {
                this.Degree = "Medium";
                this.AnualPermit = 21;
            }
            else if (salary > 5000)
            {
                this.Degree = "Senior";
                this.AnualPermit = 28;
            }
        }
        public double GetSalary()
        {
            return this.Salary;
        }
        public void SetSalary(double salary)
        {
            this.Salary = salary;
        }
        public void MakeRaise() {
            this.Salary += 50;
        }
        public abstract void MakeRaise(int percent);

    }
}
