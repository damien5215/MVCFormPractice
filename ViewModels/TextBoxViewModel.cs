using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFormPractice.ViewModels
{
    public class TextBoxViewModel
    {
        public string Message { get; set; }
        
        public TextBoxViewModel(string input)
        {
            Message = input;
        }
    }
}