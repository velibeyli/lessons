using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    public class IdCard
    {
        private string documentSerial;
        private string documentNumber;
        public string DocumentSerial 
        { 
            get
            {
                return documentSerial;
            }
            set
            {
                documentSerial = value;
                if (documentSerial.Length == 2)
                    if (int.TryParse(documentSerial,out int result))
                        Console.WriteLine("Vesiqenin seriyasi sadece herflerden ibaret olmalidir!");
                    else
                        this.documentSerial = string.Format("{0}", documentSerial.ToUpper());
                else
                    Console.WriteLine("Vesiqenin seriyasinin uzunlugu 2 olmalidir!");
                
            }
        }
        public string DocumentNumber 
        {
            get
            {
                return documentNumber;
            }
            set 
            { 
                documentNumber = value;
                if (documentNumber.Length == 8)
                    if (int.TryParse(documentNumber, out int result))
                        this.documentNumber = string.Format("{0}",documentNumber);
                    else
                        Console.WriteLine("Vesiqenin nomresi sadece reqemlerden ibaret olmalidir!");
                else
                    Console.WriteLine("Vesiqenin nomresinin uzunlugu 8 olmalidir");
            }
        }
    }
}
