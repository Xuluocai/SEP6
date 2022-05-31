using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Model;

namespace WebApplication1.Data
{
    interface IUserService
    {
        Task<User> getUserByUsername(string username);
        Task<List<Movie>> getTopMoviesByUsename(string username);

        Task<Movie> addMovieByUsername(string username, int movieId);
        Task<User> RegisterUserAsync(string username, string password);

    }
}
