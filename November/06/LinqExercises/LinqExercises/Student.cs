using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExercises
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double Point { get; set; }
        public Student(int id, string name, string surname, string email, int phone, DateTime dateOfBirth, double point)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Email = email;
            Phone = phone;
            DateOfBirth = dateOfBirth;
            Point = point;
        }
    }

}
