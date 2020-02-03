using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MoviesMVC_inClass.Entites
{
    public class Review
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int Rating { get; set; }
        [Required]
        [StringLength(200)]
        public string Reviewer { get; set; }
        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }

    }
}