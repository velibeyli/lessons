using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Square : Shape
    {
        private int side;
        public Square(int side, string id) : base(id)
        {
            this.side = side;
        }

        public override double Area
        {
            get
            {
                return side * side
            }
        }
    }
}
