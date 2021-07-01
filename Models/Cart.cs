using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFormPractice.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }

        public Cart() 
        { 
        
        }

        public Cart(int id, string author, string title)
        {
            Id = id;
            Author = author;
            Title = title;
        }
    }
}