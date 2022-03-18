using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkWithLinq
{
    public class VirtualDatabase
    {
        List<Person> People = new List<Person>();
        public void GetFullname()
        {
            for (int i = 0; i < 1000; i++)
            {
                Person person = new Person();
                person.Name = FakeData.NameData.GetFirstName();
                person.Surname = FakeData.NameData.GetSurname();

                People.Add(person);


                person.Fullname = person.Name + " " + person.Surname;

                Console.WriteLine(person.Fullname);
            }

        }
    }
}
