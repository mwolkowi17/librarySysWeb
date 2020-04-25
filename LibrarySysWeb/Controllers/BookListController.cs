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


            return RedirectToAction(nameof(Index));
            

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

            //return View(bookVM
            return RedirectToAction(nameof(Index));
        }

        //GET: /Rent book/

        public IActionResult RentBook (int idofbook, int idofreader)
        {
            var newbook = (from BookB item in _context.BookB
                           where item.BookBID == idofbook
                           select item).FirstOrDefault();
            var newreader = (from Reader n in _context.Reader
                             where n.ReaderID == idofreader
                             select n).FirstOrDefault();
            newbook.RentedbyReader = newreader.ReaderID;
            newbook.Rented = true;
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        //GET: /Drop off/

        public IActionResult DropOff (int id)
        {
            var newbook = (from BookB item in _context.BookB
                           where item.BookBID == id
                           select item).FirstOrDefault();

            newbook.RentedbyReader = 0;
            newbook.Rented = false;
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
