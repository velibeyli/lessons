using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerTypeHomework
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int DocumentNo { get; set; }
        public DateTime BirthDate { get; set; }
        public Contact[] Contacts;
        public Order[] Orders;
        public Address[] Addresses;
        public DateTime CreateDate { get; set; }
        public DateTime? EditDate { get; set; }
        public void ShowCustomerInfo()
        {
            Console.WriteLine("Customer  Id: {0}", Id);
            Console.WriteLine("Customer  Name: {0}", Name);
            Console.WriteLine("Customer  Surname: {0}", Surname);
            Console.WriteLine("Customer  Document No: {0}", DocumentNo);
            Console.WriteLine("Customer  Birth of date: {0}", BirthDate);
            Console.WriteLine("Customer  Create date: {0}", CreateDate);
            Console.WriteLine("Customer  Edited date: {0}", EditDate);
        }
        public Customer()
        {
            this.Contacts = new Contact[100];
            this.Orders = new Order[100];
            this.Addresses = new Address[100];
        }
        public void ShowContact()
        {
            foreach (Contact contact in Contacts)
            {
                if (contact != null)
                    contact.ShowContactInfo();
            }
        }
        public void ShowAddressesInfo()
        {
            foreach (Address adress in Addresses)
            {
                if (adress != null)
                    adress.ShowAddress();
            }
        }
        public void ShowOrderInfo()
        {
            foreach (Order order in Orders)
            {
                if (order != null)
                    order.ShowOrder();
            }
        }
    }
}
