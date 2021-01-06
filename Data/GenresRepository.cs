using MVCFormPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFormPractice.Data
{
    public class GenresRepository
    {
        public List<Genre> GetGenres()
        {
            return Data.Genres
                .OrderBy(a => a.Name)
                .ToList();
        }
    }
}