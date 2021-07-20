using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class Book
    {
        public Book(string title, string author) : this(title, author, 1)
        {
        }
        public Book(string title, string author, int copies)
        {
            Title = title;
            Author = author;
            Copies = copies;
        }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Copies { get; set; }
    }
}
