using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeacherAdder
{
    public static class Contact
    {
        public static void ContactAdder()
        {
            Console.WriteLine("Müellimin elaqe nömreleri elave olunsun? He/Yox");
            string contact = Console.ReadLine();
            if (contact == "H" || contact == "h")
            {
                int contactCounter = 1;
                while (contactCounter > 0)
                {
                    Console.WriteLine(contactCounter + ". Nömrenin ölke kodunu daxil edin");
                    string countryCode = Console.ReadLine();
                    Console.WriteLine(contactCounter + ". Nömrenin prefixini daxil edin");
                    string prefix = Console.ReadLine();
                    Console.WriteLine(contactCounter + ". Nömreni daxil edin");
                    string number = Console.ReadLine();
                    Console.WriteLine("Basqa nömre elave olunsun? He/Yox");
                    string newContact = Console.ReadLine();
                    if (newContact == "H" || newContact == "h")
                    {
                        contactCounter++;
                    }
                    else if (newContact == "Y" || newContact == "y")
                    {
                        Student.StudentAdder();
                    }
                }
            }
            else if (contact == "Y" || contact == "y")
            {
                Student.StudentAdder();
            }
        }
    }
}
