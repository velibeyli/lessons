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
        public int Wheel
        {
            get { return _wheel; }
            set
            {
                if (value < 4)
                    Body = BodyType.SpecialCar;
                _wheel = value;
            }
        }

        public int Door
        {
            get { return _door; }
            set
            {
                if (value < 2 || value > 5)
                    Body = BodyType.SpecialCar;
                _door = value;
            }
        }
        public BodyType Body { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public Transmission TransmissionBox
        {
            get { return _transmissionBox; }
            set
            {
                if (value == Transmission.Manual)
                    OilChangePeriod = "5000 km";
                else if (value == Transmission.Automatic)
                    OilChangePeriod = "30000 km";
                _transmissionBox = value;
            }
        }
        public string OilChangePeriod { get; set; }
        public int CarYear
        {
            get { return _carYear; }
            set
            {
                if ((DateTime.Now.Year - value) > 30)
                    IsRetroCar = true;
                else
                    IsRetroCar = false;
                _carYear = value;
            }
        }
        public int Price
        {
            get { return _price; }
            set
            {
                if (value > 100000)
                    IsLuxCar = true;
                else
                    IsLuxCar = false;
                _price = value;
            }
        }
        public int Mileage
        {
            get { return _mileage; }
            set
            {
                if (value == 0)
                    IsNew = true;
                else if (value > 0)
                    IsNew = false;
                _mileage = value;
            }
        }
        public bool IsNew { get; set; }
        public bool IsDisCount
        {
            get { return _isDiscount; }
            set
            {
                if (value == true)
                    Discount = Price - (((int)DateTime.Now.Year - CarYear) * Price / 100);
                _isDiscount = value;
            }
        }
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
