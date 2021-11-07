using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractAndInterfaces
{
    public class Employee : BaseEmployee
    {
        public override void MakeRaise(int percent)
        {
            var raiseValue = (Salary / 100) * percent;
            Salary += raiseValue;
        }
    }
}
