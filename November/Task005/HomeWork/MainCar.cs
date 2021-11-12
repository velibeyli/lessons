using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public abstract class MainCar
    {
        protected int _wheel { get; set; }
        protected int _door { get; set; }
        protected Transmission _transmissionBox { get; set; }
        protected int _price { get; set; }
        protected int _mileage { get; set; }
        protected bool _isDiscount { get; set; }
        protected int _carYear { get; set; }
        public abstract int Wheel { get; set; }
        public abstract int Door { get; set; }
        public BodyType Body { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public abstract Transmission TransmissionBox { get; set; }
        public string OilChangePeriod { get; set; }
        public abstract int CarYear { get; set; }
        public abstract int Price { get; set; }
        public abstract int Mileage { get; set; }
        public bool IsNew { get; set; }
        public abstract bool IsDisCount { get; set; }
        public int Discount { get; set; }
        public bool IsLuxCar { get; set; }
        public bool IsRetroCar { get; set; }
        public void Drive() 
        {
            Console.WriteLine("Car is moving");
        }
        public abstract void NeedsRepair();
        public void SelfDrice()
        {
            Console.WriteLine("Car is driving itself");
        }
        public void CarInfo()
        {
            Console.WriteLine("Marka: " + Brand);
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("Teker sayi: " + Wheel);
            Console.WriteLine("Qapi sayi: " + Door);
            Console.WriteLine("Ban novu: " + Body);
            Console.WriteLine("Reng: " + Color);
            Console.WriteLine("Suretler qutusu: " + TransmissionBox);
            Console.WriteLine("Yagdeyisme periodu: " + OilChangePeriod);
            Console.WriteLine("Buraxilis ili: " + CarYear);
            Console.WriteLine("Qiymeti: " + Price);
            Console.WriteLine("Yurus: " + Mileage);
            Console.Write("Yenidirmi: ");
            if (IsNew == true)
                Console.WriteLine("Beli");
            else
                Console.WriteLine("Xeyr");
            Console.Write("Endirimdedirmi: ");
            if (IsDisCount == true)
                Console.WriteLine("Beli");
            else
                Console.WriteLine("Xeyr");
            Console.WriteLine("Endirim meblegi: " + Discount);
            Console.Write("Luks avtomobildirmi: ");
            if (IsLuxCar == true)
                Console.WriteLine("Beli");
            else
                Console.WriteLine("Xeyr");
            Console.Write("Retro avtomobildirmi: ");
            if (IsRetroCar == true)
                Console.WriteLine("Beli");
            else
                Console.WriteLine("Xeyr");
            Drive();
            NeedsRepair();
        }
    }
}
