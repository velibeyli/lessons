using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTaskWithAbstract
{
    public abstract class BaseEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        protected int _salary { get; set; }
        protected int _practise { get; set; }
        public abstract int Practice { get; set; }
        public int MyReadOnlyProperty { get { return _practise + 10; } }

        public abstract string Work();
    }
}
