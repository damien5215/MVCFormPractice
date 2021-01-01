using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFormPractice.Models
{
    public class Book
    {
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