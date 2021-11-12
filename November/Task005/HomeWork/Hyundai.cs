using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class Hyundai : MainCar 
    {
        public override int Wheel
        {
            get { return _wheel; }
            set
            {
                if (value < 4)
                    Body = BodyType.SpecialCar;
            }
        }
        public override int Door
        {
            get { return _door; }
            set
            {
                if (value < 2 || value > 5)
                    Body = BodyType.SpecialCar;
            }
        }
        public override Transmission TransmissionBox
        {
            get { return _transmissionBox; }
            set
            {
                if (value == Transmission.Manual)
                    OilChangePeriod = "5000 km";
                else if (value == Transmission.Automatic)
                    OilChangePeriod = "30000 km";
            }
        }
        public override int Price
        {
            get { return _price; }
            set
            {
                if (value > 100000)
                    IsLuxCar = true;
                else
                    IsLuxCar = false;
            }
        }
        public override int Mileage
        {
            get { return _mileage; }
            set
            {
                if (value == 0)
                    IsNew = true;
                else if (value > 0)
                    IsNew = false;
            }
        }
        public override bool IsDisCount
        {
            get { return _isDiscount; }
            set
            {
                if (value == true)
                    Discount = Price - (((int)DateTime.Now.Year - CarYear) * Price / 100);
                _isDiscount = value;
            }
        }
        public override int CarYear
        {
            get { return _carYear; }
            set
            {
                if (value > 30)
                    IsRetroCar = true;
                else
                    IsRetroCar = false;
                _carYear = value;
            }
        }
        public override void NeedsRepair()
        {
            if (Mileage > 50000)
                Console.WriteLine("Go to service");
            else
                Console.WriteLine("If your car does not any problem, you should not go to car service");
        }
    }
}
