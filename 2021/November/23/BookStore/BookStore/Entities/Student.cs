using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Entities
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Surname { get; set; }
    }
}
