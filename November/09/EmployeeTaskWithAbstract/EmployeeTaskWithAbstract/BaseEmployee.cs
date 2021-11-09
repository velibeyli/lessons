using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeTaskWithAbstract
{
    public abstract class BaseEmployee
    {
        public abstract int Id { get; set; }
        public abstract string Name { get; set; }
        public abstract string Surname { get; set; }

        public abstract string Work();
    }
}
