using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTaskWithAbstract
{
    public class Teacher :BaseEmployee
    {
        private int id;
        private string name;
        private string surname;
        public override int Id
        {
            get { return id; }
            set { id = value; }
        }

        public override string Name
        {
            get { return name; }
            set { name = value; }
        }

        public override string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public override string Work()
        {
            return "Teacher teaches science to student.";
        }
    }
}
