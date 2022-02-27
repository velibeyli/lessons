using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerDataBase
{
    public class VirtualDataBase
    {
        public static List<Customer> CustomerInfo = new List<Customer>()
        {
            new Customer()
            {
                Id = 1,
                Name = "aaaaa",
                Surname = "AaaaaAaaA",
                Gender = "Kişi",
                Country = "Azerbaijan",
                City = "Baku",
                Address = "Şəfaət Mehtiyev 127",
                Phone = "+994552221133",
                Email = "asda@gmail.com"
            },            
            new Customer()
            {
                Id = 2,
                Name = "Bbbbb",
                Surname = "BbbbBbbB",
                Gender = "Qadın",
                Country = "Norway",
                City = "Oslo",
                Address = "Shojmdcfcck",
                Phone = "+99625625622222",
                Email = "Bbbsbbbsb@mail.ru"
            },
            new Customer()
            {
                Id = 3,
                Name = "Ccdgvgf",
                Surname = "ghbfvdcxs",
                Gender = "Kişi",
                Country = "Turkey",
                City = "Istanbul",
                Address = "Bilinmeyen Cadde",
                Phone = "+99232626262",
                Email = "sdfgbnhgbfvcdcfv02215f@yahoo.com"
            },
            new Customer()
            {
                Id = 4,
                Name = "HHhhhhhhh",
                Surname = "okmjnbhgtf",
                Gender = "Qadın",
                Country = "BƏƏ",
                City = "Dubai",
                Address = "kjbhvçmhvsg,21254",
                Phone = "+12565565",
                Email = "ertghgbfvd@yandex.com"
            }

        };
    }
}
