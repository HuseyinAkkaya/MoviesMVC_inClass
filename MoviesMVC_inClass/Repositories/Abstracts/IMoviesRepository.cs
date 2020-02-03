using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesMVC_inClass.Repositories.Abstracts
{
    public interface IMoviesRepository<T>
    {
        List<T> Get();

    }
}
