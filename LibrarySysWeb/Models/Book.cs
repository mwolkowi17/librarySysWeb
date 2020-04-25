using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySysWeb.Models
{
    public class Book
    {
        public Book(int bookid, string title, string author)
        {
            BookID = bookid;
            Title = title;
            Author = author;
        }

        public Book()
        {

        }

        public int BookID{ get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public bool Rented { get; set; }
        public int ReaderIDRent { get; set; }
        public int DateofRent { get; set; }
        public int DateofReturn { get; set; }
    }
}
