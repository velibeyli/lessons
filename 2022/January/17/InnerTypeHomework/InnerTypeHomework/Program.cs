﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerTypeHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customers = new Customer()
            {
                Id = 1,
                Name = "Ruslan",
                Surname = "Valibayli",
                DocumentNo = 56544,
                BirthDate = DateTime.Now,
                CreateDate = DateTime.Now,
                EditDate = DateTime.Now,
            };
            Country country = new Country()
            {
                Id = 20,
                Name = "Azerbaijan",
                CreateDate = DateTime.Now,
                EditDate = DateTime.Now
            };

            City city = new City()
            {
                Id = 10,
                Name = "Baki",
                Country = country,
                CreateDate= DateTime.Now,
                EditDate= DateTime.Now
            };
            Contact contact1 = new Contact()
            {
                Id = 100,
                PhoneNumber = "94518120292",
                Email = "velibeyli91@mail.ru",
                CreateDate = DateTime.Now
            };
            customers.Contacts[0] = contact1;
            customers.Orders[0] = new Order()
            {
                Id = 110,
                OrderDetails = "Samsung",
                CreateDate = DateTime.Now,
                EditDate = DateTime.Now
            };
            customers.Addresses[0] = new Address()
            {
                Id = 120,
                No = 4564,
                Building = "building",
                Street = "street",
                Distinct = "garadagh",
                City = city,
                CreateDate = DateTime.Now
            };

            customers.ShowCustomerInfo();

            Console.ReadLine();
        }
    }
}
