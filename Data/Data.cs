using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCFormPractice.Models;

namespace MVCFormPractice.Data
{
    public static class Data
    {
        public static List<Book> Books { get; set; }

        /// <summary>
        /// Static constructor used to initialize the data.
        /// </summary>
        static Data()
        {
            InitData();
        }

        private static void InitData()
        {
            // Create the collection of activities first
            // so we can reference them when creating the entries collection.

            var entries = new List<Book>()
            {
                new Book(1, "Nausea", "Jean Paul Sartre", "blah blah blah.", 4526),
                new Book(2, "The Bell Jar", "Sylvia Plath", "blah blah blah.", 2526),
                new Book(3, "Brideshead Revisited", "Evelyn Waugh", "blah blah blah.", 4116),
                new Book(4, "A Moveable Feast", "Ernest Hemmingway", "blah blah blah.", 2704)
            };

            Books = entries;
        }
    }
}