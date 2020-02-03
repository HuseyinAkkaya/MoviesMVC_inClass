using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using MoviesMVC_inClass.Entites;

namespace MoviesMVC_inClass.Contexts
{
    public class MoviesContext :DbContext
    {
        public MoviesContext():base("DefaultConnection")
        {
            
        }

        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Director> Directors { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<MovieDirector> MovieDirectors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            //modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }
    }
}