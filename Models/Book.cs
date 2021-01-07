using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCFormPractice.Models
{
    public class Book
    {
        public enum FictionEnum
        {
            Fiction,
            NonFiction
        }

        // default constructor
        public Book() 
        { 
        }

        public Book(int id, Genre.GenreType genreType, string title, string author,
            string description, bool inStock, FictionEnum fiction, int bookID)
        {
            Id = id;
            GenreId = (int)genreType;     
            Title = title;
            Author = author;
            Description = description;
            Fiction = fiction;
            InStock = inStock;
            BookID = bookID;
        }

        public int Id { get; set; }

        [Display(Name = "Genre")]            
        public int GenreId { get; set; }     
        public Genre Genre { get; set; }     
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public FictionEnum Fiction { get; set; }   // dsssssssssssd
        public bool InStock { get; set; }
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