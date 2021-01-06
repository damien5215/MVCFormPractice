using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFormPractice.Models
{
    public class Genre
    {
        public enum GenreType
        {
            Literary = 1,
            General = 2,
            Horror = 3,
            Crime = 4,
            Romance = 5,
            Comedy = 6,
        }

        public Genre(GenreType genreType, string name = null)
        {
            Id = (int)genreType;

            // If we don't have a name argument, 
            // then use the string representation of the genre type for the name.
            Name = name ?? genreType.ToString();
        }

        /// The ID of the genre.
        public int Id { get; set; }

        /// The name of the genre.
        public string Name { get; set; }
    }
}