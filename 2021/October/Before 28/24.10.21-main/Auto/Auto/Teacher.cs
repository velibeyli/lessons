using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto
{
    public class Teacher
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Branch { get; set; }

        public List<Student> Students { get; set; }
        private List<PhoneNumber> PhoneNumbers { get; set; } = new List<PhoneNumber>();

        private class PhoneNumber
        {
            public string CountryCode { get; set; }
            public string Prefix { get; set; }
            public string Number { get; set; }
        }
        public void AddPhoneNumber(string countryCode, string prefix, string number)
        {
            var phoneNumber = new PhoneNumber()
            {
                CountryCode = countryCode,
                Prefix = prefix,
                Number = number
            };
            PhoneNumbers.Add(phoneNumber);
        }
        public List<string> GetPhoneNumbers()
        {
            List<string> phoneNumbers = new List<string>();
            
            foreach (var item in PhoneNumbers)
            {
                var number = item.CountryCode + item.Prefix + item.Number;
                phoneNumbers.Add(number);
            }

            return phoneNumbers;
        }
    }
}
