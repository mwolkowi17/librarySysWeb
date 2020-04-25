using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySysWeb.Models
{
    public class LibraryViewModel
    {
        public List<Book> Books { get; set; }
        public List<Reader> Readers { get; set; }
        public List<BookB> BookBs { get; set; }

        public void AddBook(  string title, string author)
        {
            BookB newbook = new BookB( title, author)
            {
                
                TitleB = title,
                AuthorB = author
            };

            BookBs.Add(newbook);
        }       
    }
}
