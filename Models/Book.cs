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

        public Book(int id, int year, int month, int day, Genre.GenreType genreType, 
            string title, string author, string description, bool inStock, 
            FictionEnum fiction, int bookID)
        {
            Id = id;
            Date = new DateTime(year, month, day);
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

        public DateTime Date { get; set; } = DateTime.Now;
        public string Title { get; set; }
        public string Author { get; set; }
        
        [MaxLength(200, ErrorMessage = "The Description field cannot be longer than 200 characters.")]
        public string Description { get; set; }
        public FictionEnum Fiction { get; set; }
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