using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibrarySysWeb.Data;
using LibrarySysWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LibrarySysWeb.Controllers
{
    public class BookListController : Controller
    {

        private readonly LibrarySysWebContext _context;
        public BookListController(LibrarySysWebContext context)
        {
            _context = context;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            
            var bookoflist = from m in _context.BookB
                             select m;
            var bookVM = new LibraryViewModel
            {
                BookBs = bookoflist.ToList()
            };
            return View(bookVM);
        }

        // GET: /new book/

        public IActionResult AddBook(string titlebook, string authorbook)
        {
            BookB nowa = new BookB(titlebook, authorbook);
            _context.BookB.Add(nowa);
            _context.SaveChanges();

            var bookoflist = from m in _context.BookB
                             select m;
            var bookVM = new LibraryViewModel
            {
                BookBs = bookoflist.ToList()
            };

            
            //bookVM.AddBook(titlebook,authorbook);
            
            

            return View(bookVM);

        }

        // GET: /delete book/

        public IActionResult Delete (int id)
        {
            var newbook = (from BookB item in _context.BookB
                             where item.BookBID == id
                             select item).FirstOrDefault();
            _context.BookB.Remove(newbook);
            _context.SaveChanges();

            var bookoflist = from m in _context.BookB
                             select m;
            var bookVM = new LibraryViewModel
            {
                BookBs = bookoflist.ToList()
            };

            return View(bookVM);
        }
    }
}
