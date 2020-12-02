using MVCFormPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFormPractice.Data
{
    public class BookRepository
    {
        private static Book[] _book = new Book[]
        {
            new Book()
            {
                Id = 1,
                Title = "Nausea",
                Author = "Jean Paul Sartre",
                Description = "fddf ddfd"
            },

            new Book()
            {
                Id = 2,
                Title = "The Bell Jar",
                Author = "Sylvia Plath",
                Description = "fdd fd dfs ddd dds sdd"
            }
        };
    }
}