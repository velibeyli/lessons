using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class Book
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public int Page { get; set; }
        public string Author { get; set; }
        public CoverType CoverType { get; set; }
        public int Price { get; set; }
        public YesNoQuestion IsDiscount { get; set; }
        public int? DiscountPercent { get; set; }
    }
}
