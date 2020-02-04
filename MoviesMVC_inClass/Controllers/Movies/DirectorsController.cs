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
    public class DirectorsController : Controller
    {
        MoviesContext db = new MoviesContext();
        private IMoviesService<Director> directorService;
        public DirectorsController()
        {
            directorService = new MoviesService<Director>(db);
        }
        // GET: Directors
        public ActionResult Index()
        {
            var model = directorService.Get();

            return View(model);
        }
    }
}