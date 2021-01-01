using MVCFormPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFormPractice.Data
{
    public class BookRepository
    {
        private static Book[] _books = new Book[]
        {
            new Book()
            {
                Id = 1,
                Title = "Nausea",
                Author = "Jean Paul Sartre",
                Description = "Nausea is a philosophical novel by the existentialist philosopher Jean-Paul Sartre, published in 1938. It is Sartre's first novel and, in his own opinion, one of his best works.",
                BookID = 3241
            },

            new Book()
            {
                Id = 2,
                Title = "The Bell Jar",
                Author = "Sylvia Plath",
                Description = "The Bell Jar is the only novel written by the American writer and poet Sylvia Plath. Originally published under the pseudonym \"Victoria Lucas\" in 1963, the novel is semi-autobiographical, with the names of places and people changed.",
                BookID = 2699
            }
        };

        public Book GetBook(int id) 
        {
            Book bookToReturn = null;

            foreach (var book in _books) 
            {
                if (book.Id == id) 
                {
                    bookToReturn = book;
                    break;
                }
            }
            return bookToReturn;

        }
    }
}