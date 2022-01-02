using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            numbers = numbers.Where(m => m > 4).ToList();

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            string name1 = "Gulmemmed";
            string name2 = "Gulmehemmed";
            string name3 = "Orxan";
            string name4 = "Gulmamed";
            string name5 = "Gul";

            List<string> names = new List<string>();
            names.Add(name1);
            names.Add(name2);
            names.Add(name3);
            names.Add(name4);
            names.Add(name5);

            string orxan = names.FirstOrDefault(m => m == "Orxan");
            Console.WriteLine(orxan);


            string gulMamed = names.Where(m => m == "Gulmamed").FirstOrDefault();
            Console.WriteLine(gulMamed);
            names
            string test = names.Where(m => m == "Samir").FirstOrDefault();

            Console.ReadLine();

        }
    }
}
