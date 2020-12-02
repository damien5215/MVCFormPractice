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

        // GET: Book
        public ActionResult Index()
        {
            return View();
        }
    }
}