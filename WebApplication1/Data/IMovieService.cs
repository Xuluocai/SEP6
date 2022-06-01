using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Model;

namespace WebApplication1.Data
{
    interface IMovieService
    {
        IList<Movie> test(string title);
        Task<Movie> getMovieById(int Id);
        Task<IList<Movie>> getMoviesByYear(int minYear,int maxYear);
        Task<IList<Movie>> getMoviesByTitle(String title);
        Task<IList<People>> getStasById(int id);
        Task<IList<People>> getDirectorsById(int id);
        Task<IList<Movie>> getMoviesByStar(int personid);
        Task<IList<Movie>> getMoviesByDirector(int personid);
        Task<People> getPeopleById(int id);
        Task<Double> getRatingById(int id);
        Task<Double> getVotesById(int id);
        
    }
}
