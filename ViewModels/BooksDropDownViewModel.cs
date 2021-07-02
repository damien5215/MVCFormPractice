using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFormPractice.ViewModels
{
    public class BooksDropDownViewModel
    {
        public int GenreId { get; set; } 
        public SelectList GenreSelectListItems { get; set; }

        public BooksDropDownViewModel()
        {

        }
    }
}