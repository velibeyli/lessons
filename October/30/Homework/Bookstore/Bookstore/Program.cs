using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class Program
    {
        public static List<Book> books = new List<Book>();
        public static int autoIncrement = 1;
        static void Main(string[] args)
        {
            BookStoreLogic logic = new BookStoreLogic();
            logic.ShowMainMenu();           

        }
    }
}
