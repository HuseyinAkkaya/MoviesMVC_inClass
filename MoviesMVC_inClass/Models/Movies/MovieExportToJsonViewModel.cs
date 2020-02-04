using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoviesMVC_inClass.Models.Movies
{
    public class MovieExportToJsonViewModel
    {
        public string Name { get; set; }
        public string ProductionYear { get; set; }
        public double? BoxOfficeReturn { get; set; }
    }
}