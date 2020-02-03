using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MoviesMVC_inClass.Contexts;
using MoviesMVC_inClass.Entites;
using MoviesMVC_inClass.Repositories;
using MoviesMVC_inClass.Repositories.Abstracts;

namespace MoviesMVC_inClass.Services
{
    public class MoviesService<T> : IMoviesService<T> where T : class, new()
    {
        private IMoviesRepository<T> _repository;

        public MoviesService(DbContext db)
        {
            _repository = new MoviesRepository<T>(db);
        }

        public List<T> Get()
        {
            return _repository.Get();
        }
    }
}