using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : Shape
    {
        private int radius;
        public Circle(int radius, string id) : base(id)
        {
            this.radius = radius;
        }

        public override double Area
        {
            get
            {
                return radius * radius * Math.PI;
            }
        }
    }
}
