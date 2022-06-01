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
        Task<IList<Movie>> getMovieList(string username);

        Task  addMovieToList(Movielist movielist);
       
        Task<User> RegisterUser(User user);

    }
}
