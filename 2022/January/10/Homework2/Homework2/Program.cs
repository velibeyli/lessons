﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            var autoGenerator = student.Id;
            Console.WriteLine(autoGenerator);
            Console.ReadLine();
        }
    }
}
