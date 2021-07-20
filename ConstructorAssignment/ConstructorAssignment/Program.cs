using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            const string libraryBranch = "Belmont Sunnyside Library";

            var Books = new List<Book>();

            Book bnw = new Book("'Brave New World'", "Aldous Huxley", 3);
            Book it = new Book("'It'", "Stephen King", 2);
            Book dracula = new Book("'Dracula'", "Bram Stoker", 1);
            

            Books.Add(bnw);
            Books.Add(it);
            Books.Add(dracula);

            Console.WriteLine("Wecome to the {0}. The following books are in short supply:\n ", libraryBranch);

            foreach (Book book in Books)
            {
                Console.WriteLine("{0} by {1}, copies: {2}", book.Title, book.Author, book.Copies);
            }

            Console.WriteLine("\nGet them while they last!");

            Console.ReadLine();
        }
    }
}
