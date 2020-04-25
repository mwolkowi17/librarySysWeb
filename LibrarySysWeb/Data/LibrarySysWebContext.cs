using LibrarySysWeb.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibrarySysWeb.Data
{
    public class LibrarySysWebContext: DbContext
    {
        public LibrarySysWebContext(DbContextOptions<LibrarySysWebContext> options)
            : base(options)
        {
        }

        public DbSet<Book>Book { get; set; }
        public DbSet<Reader>Reader { get; set; }
        public DbSet<BookB>BookB { get; set; }
    }
}
