using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape
    {
        private string name { get; set; }
        public Shape(string id)
        {
            Id = id;
        }
        public string Id
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public abstract double Area { get; }
        public override string ToString()
        {
            return Id + " Area = " + string.Format("{0:F2}", Area);
        }
    }
}
