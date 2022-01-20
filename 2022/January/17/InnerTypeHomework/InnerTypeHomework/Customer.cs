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
            Console.WriteLine("Id: {0}", Id);
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Surname: {0}", Surname);
            Console.WriteLine("Document No: {0}", DocumentNo);
            Console.WriteLine("Birth of date: {0}", BirthDate);
            Console.WriteLine("Create date: {0}", CreateDate);
            Console.WriteLine("Edited date: {0}", EditDate);
        }
        public Customer()
        {
            this.Contacts = new Contact[100];
            this.Orders = new Order[100];
            this.Addresses = new Address[100];
        }
        public void ShowContacts()
        {
            foreach (var contact in Contacts)
            {
                Console.WriteLine(contact);
            }
        }
    }
}
