using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndConstructorsAndInheritance
{
    public class BaseBook
    {
        protected string Name { get; set; }
        protected int Page { get; set; }
        protected CoverType CoverType { get; set; }
    }
}
