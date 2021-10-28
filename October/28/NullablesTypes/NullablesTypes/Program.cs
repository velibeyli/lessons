using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullablesTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student()
            {
                Name = "Ali",
                Surname = "Aliyev",
                Age = 35,
                IsGoodStudent = true,
                Birthdate = new DateTime(1990, 12, 25),
                Branch = new Branch()
                {
                    Branchtype = Branchtype.Police
                }
            };

            Student st2 = new Student()
            {
                Name = "Ali",
                Surname = "Aliyev",
                Age = 35,
                IsGoodStudent = false,
                Birthdate = null
            };

            ShowStudentProperties(st1);
            ShowStudentProperties(st2);
            Console.ReadLine();


        }

        public static void ShowStudentProperties(Student student)
        {
            Nullable<int> n = null;
            Nullable<int> n2 = 5;
            int? a = null;
            DateTime? f = null;
            Console.WriteLine(student.Name);
            Console.WriteLine(student.Surname);
            Console.WriteLine(student.Age);
            Console.WriteLine(student.Birthdate);
            Console.WriteLine(student.Branch?.Branchtype);

            if (student.IsGoodStudent.HasValue && student.IsGoodStudent.Value)
                Console.WriteLine("Yaxsi telebedir");
            else
                Console.WriteLine("Pis telebedir");
            Console.WriteLine("---------------------------------------");

        }
    }
    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public bool? IsGoodStudent { get; set; } = true;
        public DateTime? Birthdate { get; set; }
        public Branch Branch { get; set; }
    }
    public class Branch
    {
        public Branchtype Branchtype { get; set; }
    }
    public enum Branchtype
    {
        Police = 1,
        Doctor = 2,
        Programmer = 3
    }
}
