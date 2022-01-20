﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerTypeHomework
{
    public class Address
    {
        public int Id { get; set; }
        public int No { get; set; }
        public string Building { get; set; }
        public string Street { get; set; }
        public string Distinct { get; set; }
        public City City { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? EditDate { get; set; }
    }
}
