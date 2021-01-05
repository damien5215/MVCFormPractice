using MVCFormPractice.Data;
using MVCFormPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFormPractice.Controllers
{
    public class BookController : Controller
    {
        private BookRepository2 _bookRepository = null;

        public BookController() 
        {
            _bookRepository = new BookRepository2();
        }

        public ActionResult Index()
        {
            List<Book> entries = _bookRepository.GetEntries();

            return View(entries);
        }

        public ActionResult Detail(int? id)
        {
            if (id == null) 
            {
                return HttpNotFound();
            }

            var book = _bookRepository.GetBook((int)id);
            return View(book);
        }

        // https://github.com/treehouse-projects/aspnet-fitness-frog/tree/master/src/Treehouse.FitnessFrog

        public ActionResult AddBook()
        {
            var entry = new Book();

            return View(entry);
        }

        [HttpPost]
        public ActionResult AddBook(Book entry)
        {
            if (ModelState.IsValid) 
            {
                _bookRepository.AddEntry(entry);
                //List<Book> entries = _bookRepository.GetEntries();

                return RedirectToAction("Index");
                //return View("Index", entries);
            }
            
            return View(entry);
        }

    }
}