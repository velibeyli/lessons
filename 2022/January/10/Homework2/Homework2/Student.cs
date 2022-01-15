using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    public class Student
    {
        private int id;
        public int Id 
        { 
            get
            {
                return id = generate();
            }
            private set { }
        }
        private int generate()
        {
            Random rnd = new Random();
            this.id = rnd.Next(1, 1000);
            return id;
        }
    }
}
