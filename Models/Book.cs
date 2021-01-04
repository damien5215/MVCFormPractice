using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCFormPractice.Models
{
    public class Book
    {
        // default constructor
        public Book() 
        { 
        }

        public Book(int id, string title, string author,
            string description, int bookID)
        {
            Id = id;
            Title = title;
            Author = author;
            Description = description;
            BookID = bookID;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public int BookID { get; set; }

        public string DisplayText 
        {
            get 
            {
                return Id + " - " + Title + " - " + Author;
            }
        }
    }
}