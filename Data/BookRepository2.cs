using MVCFormPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFormPractice.Data
{
    public class BookRepository2
    {
        /// <summary>
        /// Returns a collection of entries.
        /// </summary>
        /// <returns>A list of entries.</returns>
        public List<Book> GetEntries()
        {
            return Data.Books
                .OrderByDescending(e => e.Id)
                //.ThenByDescending(e => e.Id)
                .ToList();
        }

        public Book GetBook(int id) 
        { 
            Book book = Data.Books
                .Where(e => e.Id == id)
                .SingleOrDefault();

            return book;
        }

    }
}