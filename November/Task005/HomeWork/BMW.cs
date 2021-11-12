using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class BMW : MainCar
    {
        public override int Wheel
        {
            get { return _wheel; }
            set
            {
                if (value < 4)
                    Body = BodyType.SpecialCar;
                _wheel = value;
            }
        }
        public override int Door
        {
            get { return _door; }
            set
            {
                if (value < 2 || value > 5)
                    Body = BodyType.SpecialCar;
                _door = value;
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
                _transmissionBox = value;
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
                _price = value;
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
                _mileage = value;
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
            if (Mileage > 65000)
                Console.WriteLine("Go to service");
            else
                Console.WriteLine("If your car does not any problem, you should not go to car service");
        }
    }
}
