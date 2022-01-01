using BookStore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class BookStoreLogic : IBookStoreLogic
    {
        public void ShowMainMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Hansi emeliyyati icra etmek isteyirsiniz?");
            Console.WriteLine("1. Yeni kitab elave et.");
            Console.WriteLine("2. Butun kitablari goster.");
            Console.WriteLine("3. Kitabxanada olan butun kitablarin sayini goster.");
            Console.WriteLine("4. Ada gore Kitab axtar.");
            Console.WriteLine();

            int userInput = Int32.Parse(Console.ReadLine());
            switch (userInput)
            {
                case (int)MainMenuChoice.AddNewBook:
                    AddNewBook();
                    break;
                case (int)MainMenuChoice.GetAllBooks:
                    GetAllBooks();
                    break;
                case (int)MainMenuChoice.GetAllBooksCount:
                    GetAllBooksCount();
                    break;
                case (int)MainMenuChoice.SearchForName:
                    Console.WriteLine("Axtarmaq istediyiniz kitabin adini yazin: ");
                    string searchInput = Console.ReadLine();
                    SearchForName(searchInput);
                    break;
                default:
                    Console.WriteLine("Duzgun reqem daxil etmediniz!");
                    ShowMainMenu();
                    break;
            }
            Console.ReadLine();

        }
        public void AskToGoMainMenu()
        {
            Console.WriteLine("Ana menyuya qayitmaq ucun 1-i, proqramdan cixis etmek ucun 2-ni secin: ");
            YesNoQuestion yesNoInput = (YesNoQuestion)Int32.Parse(Console.ReadLine());
            if (yesNoInput == YesNoQuestion.Yes)
                ShowMainMenu();
            else
                Environment.Exit(0);
        }
        public void WriteBookDataToScreen(Book book)
        {
            Console.WriteLine("Kitabin ID nomresi: " + book.Id);
            Console.WriteLine("Kitabin adi: " + book.BookName);
            Console.WriteLine("Kitabin sehife sayi: " + book.Page);
            Console.WriteLine("Kitabin muellifi: " + book.Author);
            Console.WriteLine("Kitabin uz qapagi: " + book.CoverType);
            Console.WriteLine("Kitabin qiymeti: " + book.Price);
            if (book.IsDiscount == YesNoQuestion.Yes)
                Console.WriteLine("Kitabin endirimli qiymeti: " + (book.Price - ((book.Price / 100) * book.DiscountPercent)).ToString());
        }
        public void AddNewBook()
        {
            Book book = new Book();            
            book.Id = Program.autoIncrement;
            Program.autoIncrement++;

            Console.Write("Kitabin adi: ");
            book.BookName = Console.ReadLine();

            Console.Write("Sehife sayi: ");
            book.Page = Int32.Parse(Console.ReadLine());

            Console.Write("Muellifi: ");
            book.Author = Console.ReadLine();

            Console.Write("Kitabin uz qapaginin materiali. (Karton ucun - 1, Plastik ucun - 2, Deri ucun - 3, Taxta ucun - 4): ");
            book.CoverType = (CoverType)Int32.Parse(Console.ReadLine());

            Console.Write("Qiymeti: ");
            book.Price = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Kitab Endirimdedir? He/Yox (He ucun - 1, Yox ucun - 2): ");
            book.IsDiscount = (YesNoQuestion)Int32.Parse(Console.ReadLine());

            if (book.IsDiscount == YesNoQuestion.Yes)
            {
                Console.Write("Endirim meblegi faizle daxil edin: ");
                book.DiscountPercent = Int32.Parse(Console.ReadLine());
            }

            Program.books.Add(book);

            Console.Clear();
            Console.WriteLine("Kitabiniz muveffeqiyyetle elave olundu.");
            AskToGoMainMenu();
        }
        public void GetAllBooks()
        {
            Console.Clear();

            int countOfBooks = Program.books.Count;
            if (countOfBooks > 0)
            {
                foreach (var item in Program.books)
                {
                    WriteBookDataToScreen(item);
                    Console.WriteLine("----------------------------------------");
                }
            }                
            else
                Console.WriteLine("Kitabxananizda kitab yoxdur.");
            AskToGoMainMenu();
        }
        public void GetAllBooksCount()
        {
            Console.Clear();

            int countOfBooks = Program.books.Count;
            if (countOfBooks > 0)
                Console.WriteLine("Kitabxananizda " + countOfBooks + " eded kitab var.");
            else
                Console.WriteLine("Kitabxananizda kitab yoxdur.");
            AskToGoMainMenu();
        }
        public void SearchForName(string name)
        {
            //Returns null if list is null
            //Book noError = Program.books.Where(m => m.BookName == name).FirstOrDefault();
            //same as
            //Book noError1 = Program.books.FirstOrDefault(m => m.BookName == name);

            //Occurs error if list is null
            //Book error = Program.books.Where(m => m.BookName == name).First();
            //same as
            //Book error1 = Program.books.First(m => m.BookName == name);

            //Don't need to use FirstOrDefault() after Where() method
            //IEnumerable<Book> book = Program.books.Where(m => m.BookName == name);

            //Need to use FirstOrDefault() after Where() method
            //Book book2 = Program.books.Where(m => m.BookName == name).FirstOrDefault();
            //Book book3 = Program.books.FirstOrDefault(m => m.BookName == name);

            //Multiple parameters in Where clause
            //Book book4 = Program.books.Where(m => m.BookName == name && m.CoverType == CoverType.Cardboard).FirstOrDefault();
            Book book = Program.books.FirstOrDefault(m => m.BookName == name);

            if(book == null)
                Console.WriteLine("Axtardiginiz kitab movcud deyil.");
            else
                WriteBookDataToScreen(book);
        }
    }
}
