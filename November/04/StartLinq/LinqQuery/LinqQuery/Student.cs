using System;

namespace LinqQuery
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Gender Gender { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Group Group { get; set; }
        public double Point { get; set; }
    }
}
