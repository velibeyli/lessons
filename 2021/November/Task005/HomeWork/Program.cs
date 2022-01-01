using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Honda newCar = new Honda();
            newCar.Brand = "Honda";
            newCar.Body = BodyType.Sedan;
            newCar.Wheel = 4;
            newCar.Door = 5;
            newCar.Color = "white";
            newCar.Model = "CR-V";
            newCar.TransmissionBox = Transmission.Automatic;
            newCar.CarYear = 2018;
            newCar.Price = 30000;
            newCar.Mileage = 49000;
            newCar.IsDisCount = true;

            newCar.CarInfo();

            Console.WriteLine("------------------------------");

            Mercedes newCar2 = new Mercedes();
            newCar2.Brand = "Mercedes";
            newCar2.Body = BodyType.Sedan;
            newCar2.Wheel = 4;
            newCar2.Door = 5;            
            newCar2.Color = "Grey";
            newCar2.Model = "C-Class";
            newCar2.TransmissionBox = Transmission.Manual;
            newCar2.CarYear = 1980;
            newCar2.Price = 130000;
            newCar2.Mileage = 400000;
            newCar2.IsDisCount = false;

            newCar2.CarInfo();

            Console.WriteLine("------------------------------");

            Tesla newCar3 = new Tesla();
            newCar3.Brand = "Tesla";
            newCar3.Body = BodyType.Coupe;
            newCar3.Wheel = 4;
            newCar3.Door = 4;            
            newCar3.Color = "Grey";
            newCar3.Model = "Model 3";
            newCar3.TransmissionBox = Transmission.Automatic;
            newCar3.CarYear = 2019;
            newCar3.Price = 68000;
            newCar3.Mileage = 57000;
            newCar3.IsDisCount = true;

            newCar3.CarInfo();
            newCar3.SelfDrice();


            Console.ReadLine();
        }
    }
}
