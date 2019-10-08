using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Viddly3.Models;
using Viddly3.ViewModels;

namespace Viddly3.Controllers
{
    public class MovieController : Controller
    {

        private ApplicationDbContext _context;

        public MovieController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        // GET: Movie/New
        public ActionResult New()
        {
            
            var viewModel = new MovieFormViewModel
            {
                Genres = _context.Genres.ToList()
            };

            return View("MovieForm", viewModel);
        }

        // GET: Movie/Edit/id
        public ActionResult Edit(int id)
        {

            
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);

            if (movie == null)
            {
                return HttpNotFound();
            }
            

            var genres = _context.Genres.ToList();

            var viewModel = new MovieFormViewModel
            {
                Movie = movie,
                Genres = genres
                

            };

            return View("MovieForm", viewModel);
        }

        [HttpPost]
        public ActionResult Create( Movie movie)
        {

            if (movie.Id == 0)
            {
                //add to  database

                _context.Movies.Add(movie);
            }
            else
            {
                var movieFromDb = _context.Movies.Single(x => x.Id == movie.Id);

                movieFromDb.Name = movie.Name;
                movieFromDb.ReleaseDate = movie.ReleaseDate;
                movieFromDb.GenreId = movie.GenreId;
                movieFromDb.NumberInStock = movie.NumberInStock;
            }


            _context.SaveChanges();


            return RedirectToAction("Index", "Movie");
        }


        // GET: Movie/Index
        public ActionResult Index()
        {
            var movies = _context.Movies.Include(c => c.Genres).ToList();
            return View(movies);
        }



        // GET: Movie/Details
        public ActionResult Details(int id)
        {
            int cars = 3;
            var movies = _context.Movies.Include(c => c.Genres).ToList();
            var SelectedMovie = new Movie { };

            foreach(var movie in movies)
            {
                if(movie.Id == id)
                {
                    SelectedMovie = movie;
                   
                }
            }

            return View(SelectedMovie);
        }
    }
}