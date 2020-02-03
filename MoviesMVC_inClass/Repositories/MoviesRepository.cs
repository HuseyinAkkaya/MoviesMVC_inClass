using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MoviesMVC_inClass.Contexts;
using MoviesMVC_inClass.Entites;
using MoviesMVC_inClass.Repositories.Abstracts;

namespace MoviesMVC_inClass.Repositories
{

    public class MoviesRepository<T> : IMoviesRepository<T> where T : class, new()
    {
        private DbContext _db;
        public MoviesRepository(DbContext db)
        {
            _db = db;
        }


        public List<T> Get()
        {
            return _db.Set<T>().ToList();

        }

    }
}