using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Model;

namespace WebApplication1.Data
{
    interface IMovieService
    {
        Task<IList<Movie>> GetMovies();
        Task<Movie> getMovieById(int Id);
        Task<IList<Movie>> getMoviesByYear(int minYear,int maxYear);
        Task<IList<Movie>> getMoviesByTitle(String title);

    }
}
