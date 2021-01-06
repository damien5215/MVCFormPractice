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
        public static List<Genre> Genres { get; set; }


        /// <summary>
        /// Static constructor used to initialize the data.
        /// </summary>
        static Data()
        {
            InitData();
        }

        private static void InitData()
        {
            // Create the collection of genres first
            // so we can reference them when creating the entries collection.

            var genres = new List<Genre>()
            {
                new Genre(Genre.GenreType.Comedy),
                new Genre(Genre.GenreType.Crime),
                new Genre(Genre.GenreType.General),
                new Genre(Genre.GenreType.Horror),
                new Genre(Genre.GenreType.Literary),
                new Genre(Genre.GenreType.Romance)
            };

            var entries = new List<Book>()
            {
                new Book(1, Genre.GenreType.Literary, "Nausea", "Jean Paul Sartre", "blah blah blah.", 4526),
                new Book(2, Genre.GenreType.Literary, "The Bell Jar", "Sylvia Plath", "blah blah blah.", 2526),
                new Book(3, Genre.GenreType.Literary, "Brideshead Revisited", "Evelyn Waugh", "blah blah blah.", 4116),
                new Book(4, Genre.GenreType.Comedy, "A Moveable Feast", "Ernest Hemmingway", "blah blah blah.", 2704)
            };

            Genres = genres;
            Books = entries;
        }
    }
}