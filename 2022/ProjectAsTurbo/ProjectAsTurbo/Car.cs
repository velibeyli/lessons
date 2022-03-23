using ProjectAsTurbo.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectAsTurbo
{
    public partial class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string BodyType { get; set; }
        public string Color { get; set; }
        public string City { get; set; }
        public string FuelType { get; set; }
        public Transmission Transmission { get; set; }
        public int Mileage { get; set; }
        public DateTime Year { get; set; }
        public int Engine { get; set; }
        public decimal Price { get; set; }
        public bool isCredit { get; set; }
        public bool isBarter { get; set; }

    }
}
