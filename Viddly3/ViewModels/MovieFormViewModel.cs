using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Viddly3.Models;

namespace Viddly3.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }

        public Movie Movie { get; set; }
    }
}