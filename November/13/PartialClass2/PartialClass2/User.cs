using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass2
{
    public class User :  BaseClass, Test, IUser, IBaseClass
    {
        public int Age { get; set; }
        public string Surname { get; set; }
    }
}
