﻿using MVCFormPractice.Data;
using MVCFormPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

        public ActionResult AddBook()
        {
            var entry = new Book();

            SetupGenreSelectListItems();

            return View(entry);
        }

        [HttpPost]
        public ActionResult AddBook(Book entry)
        {
            if (ModelState.IsValidField("BookID") && entry.BookID <= 0) 
            {
                ModelState.AddModelError("BooKID","The BookID field value must be greater than '0'.");
            }

            if (ModelState.IsValid) 
            {
                _bookRepository.AddEntry(entry);

                TempData["Message"] = "The entry was successfully added!";

                return RedirectToAction("Index");
            }

            SetupGenreSelectListItems();

            return View(entry);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Book entry = _bookRepository.GetBook((int)id);


            if (entry == null)
            {
                return HttpNotFound();
            }

            SetupGenreSelectListItems();

            return View(entry);
        }

        [HttpPost]
        public ActionResult Edit(Book entry)
        {
            ValidateEntry(entry);

            if (ModelState.IsValid)
            {
                _bookRepository.UpdateEntry(entry);

                TempData["Message"] = "The entry was successfully updated!";

                return RedirectToAction("Index");
            }

            SetupGenreSelectListItems();

            return View(entry);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Book entry = _bookRepository.GetBook((int)id);

            if (entry == null)
            {
                return HttpNotFound();
            }
            SetupGenreSelectListItems();

            return View(entry);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            _bookRepository.DeleteEntry(id);

            TempData["Message"] = "The entry was successfully deleted!";

            return RedirectToAction("Index");
        }

        public ActionResult Test()
        {
            List<Book> entries = _bookRepository.GetEntries();
            return View(entries);
        }


        private void ValidateEntry(Book entry)
        {
            if (ModelState.IsValidField("BookID") && entry.BookID <= 0)
            {
                ModelState.AddModelError("BooKID", "The BookID field value must be greater than '0'.");
            }
        }

        private void SetupGenreSelectListItems()
        {
            ViewBag.GenreSelectListItems = new SelectList(Data.Data.Genres, "Id", "Name");
        }

    }
}