using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MoviesMVC_inClass.Contexts;
using MoviesMVC_inClass.Entites;
using MoviesMVC_inClass.Repositories.Abstracts;
using MoviesMVC_inClass.Services;

namespace MoviesMVC_inClass.Controllers.Movies
{
    public class MoviesController : Controller
    {
        private MoviesContext db = new MoviesContext();
        IMoviesService<Movie> moviesService;

        public MoviesController()
        {
            moviesService = new MoviesService<Movie>(db);

        }
        // GET: Movies
        public ActionResult Index()
        {
            var model = moviesService.Get();
            return View(model);
        }
    }
}