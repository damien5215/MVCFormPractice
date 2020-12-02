﻿using MVCFormPractice.Data;
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
    }
}