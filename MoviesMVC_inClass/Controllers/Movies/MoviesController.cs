using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using MoviesMVC_inClass.Contexts;
using MoviesMVC_inClass.Entites;
using MoviesMVC_inClass.Models.Movies;
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
            return RedirectToAction("GetMovies");


        }

        public ActionResult GetMovies()
        {
            var model = moviesService.Get();
            return View("Index",model);
        }
        public ContentResult CreatedBy()
        {
            //  return Content("<h3>Created by Hüseyin AKKAYA</h3>", "text/plain;charset=utf-8;");
            //  return Content("<h3>Created by Hüseyin AKKAYA</h3>", "text/html;charset=utf-8;");
            return Content("<h2>Created by Hüseyin AKKAYA</h2>", "text/html", Encoding.UTF8);
        }

        public ActionResult ExportMoviesToXML()
        {
            var movies = moviesService.Get();
            var xml = "";
            xml += "<movies>";
            foreach (var movie in movies)
            {
                xml += "<movie>";
                xml += "<name>" + movie.Name + "</name>";
                xml += "<productionYear>" + movie.ProductionYear + "</productionYear>";
                xml += "<boxOfficeReturn>" + (movie.BoxOfficeReturn ?? 0)  + "</boxOfficeReturn>";
                xml += "</movie>";
            }
            xml += "</movies>";
            //return Content(xml, "text/xml");
            return Content(xml, "application/xml");
        }

        public JsonResult ExportMoviesToJson()
        {
            var movies = moviesService.Get().Select(m=> new MovieExportToJsonViewModel()
            {
                Name = m.Name,
                BoxOfficeReturn = m.BoxOfficeReturn ?? 0 ,
                ProductionYear = m.ProductionYear

            }).ToList();

            return Json(movies, JsonRequestBehavior.AllowGet);
        }
    }
}