using HomeworkWithLinq.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkWithLinq
{
    public class Car
    {
        public string City { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public ColorEnum Color { get; set; }
        public int EngineVolume { get; set; }
        public int HorsePower { get; set; }
        public int Mileage { get; set; }
        public TransmissionEnum Transmission { get; set; }
        public int Price { get; set; }
        public Car(string city, string brand, string model, int year, ColorEnum color, int engine, int horsePower, int mileage, TransmissionEnum transmission,int price)
        {
            this.City = city;
            this.Brand = brand;
            this.Model = model;
            this.Year = year;
            this.Color = color;
            this.EngineVolume = engine;
            this.HorsePower = horsePower;
            this.Mileage = mileage;
            this.Transmission = transmission;
            this.Price = price;
        }

    }
}
