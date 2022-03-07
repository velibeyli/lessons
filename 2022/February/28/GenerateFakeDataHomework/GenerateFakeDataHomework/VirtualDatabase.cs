using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace GenerateFakeDataHomework
{
    public class VirtualDatabase
    {
        public List<Person> People = new List<Person>();
        public List<Person> GetPerson(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Person person = new Person();

                person.Id = i + 1;
                person.Name = FakeData.NameData.GetFirstName();
                person.Surname = FakeData.NameData.GetSurname();
                person.Email = FakeData.NetworkData.GetEmail();
                person.Country = FakeData.PlaceData.GetCountry();

                People.Add(person);
            }
            return People;
        }
    }
}
