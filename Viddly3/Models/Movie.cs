using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Viddly3.Models
{
    public class Movie
    {

        public int Id { get; set; }
        public DateTime? ReleaseDate { get; set; }

        public DateTime? DateAdded { get; set; }

        public int NumberInStock { get; set; }

        public int GenreId { get; set; }

        public Genre Genres { get; set; }


        public string Name { get; set; }

    }
}