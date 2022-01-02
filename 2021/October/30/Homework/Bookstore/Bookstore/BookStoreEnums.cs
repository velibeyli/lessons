using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public enum CoverType
    {
        Cardboard = 1,
        Plastic = 2,
        Leather = 3,
        Wood = 4
    }
    public enum MainMenuChoice
    {
        AddNewBook = 1,
        GetAllBooks = 2,
        GetAllBooksCount = 3,
        SearchForName = 4
    }
    public enum YesNoQuestion
    {
        Yes = 1,
        No = 2
    }
}
