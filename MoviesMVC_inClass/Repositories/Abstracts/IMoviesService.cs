using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoviesMVC_inClass.Contexts;

namespace MoviesMVC_inClass.Repositories.Abstracts
{
    public interface IMoviesService<T>
    {
        List<T> Get();
    }
}
