using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookstore
{
    public class NewBook
    {
        protected string BookName { get; set; }
        protected int Page { get; set; }
        protected string Author { get; set; }
        protected CoverType CoverType { get; set; }
        protected int Price { get; set; }
        protected bool IsDiscount { get; set; }
        protected int? DiscountNumber { get; set; }
    }
}