using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Interfaces
{
    interface IBookStoreLogic
    {
        void AddNewBook();
        void GetAllBooks();
        void GetAllBooksCount();
        void SearchForName(string name);
    }
}
