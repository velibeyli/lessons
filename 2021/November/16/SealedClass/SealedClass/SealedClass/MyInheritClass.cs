using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClass.SealedClass
{
    public class MyInheritClass : MyNotSealedClass
    {
        public MyInheritClass(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }

    //public class MySecondInheritClass : MySealedClass //you cannot inherit from a sealed class
    //{
    //    public MySecondInheritClass()
    //    {

    //    }
    //}
}
