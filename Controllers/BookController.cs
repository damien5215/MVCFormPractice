using MVCFormPractice.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFormPractice.Controllers
{
    public class BookController : Controller
    {
        private BookRepository _bookRepository = null;

        public BookController() 
        {
            _bookRepository = new BookRepository();
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
            //var entry = new Entry();

            return View();
        }

        [HttpPost]
        public ActionResult AddBook(string title, string author, int? bookID)
        {
            //ViewBag.BookTitle = title;
            //ViewBag.Author = author;
            //ViewBag.BookID = bookID;

            return View();
        }

    }
}