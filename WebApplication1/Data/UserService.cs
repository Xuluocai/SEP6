using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WebApplication1.Model;

namespace WebApplication1.Data
{
    public class UserService : IUserService
    {
        private string url = "https://sep6-v2.ey.r.appspot.com";
        private readonly HttpClient client;

        public UserService()
        {
            client = new HttpClient();
        }
        public async Task<List<Movie>> getTopMoviesByUsename(string username)
        {
            
            HttpResponseMessage response = await client.GetAsync($"{url}/user/getMoviesByTitle?title={username}");
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Error" + response);
            }
            string message = await response.Content.ReadAsStringAsync();
            List<Movie> result = JsonSerializer.Deserialize<List<Movie>>(message);
            Console.WriteLine("this is" + result);
            return result;
        }

        public async Task<User> getUserByUsername(string username)
        {
            HttpResponseMessage response = await client.GetAsync($"{url}/user/getUserByUsername?username={username}");

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Error");
            }

            string message = await response.Content.ReadAsStringAsync();
            User user = JsonSerializer.Deserialize<User>(message);
            Console.WriteLine(response);
            return user;
        }

        public Task<Movie> addMovieByUsername(string username, int movieId)
        {
            throw new NotImplementedException();
        }

        public Task<User> RegisterUserAsync(string username, string password)
        {
            throw new NotImplementedException();
        }

        /*public async Task<User> RegisterUserAsync(string username, string password)
        { var payload = "{\"username\": {username},\"password\": {password}}";
            HttpContent httpContent = new StringContent(payload,Encoding.UTF8, "application/json");
            HttpRequestMessage response = await client.PostAsync（$"{url}/user/AddUser",httpContent);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Error");
            }
            string message = await response.Content.ReadAsStringAsync();
            User user = JsonSerializer.Deserialize<User>(message);
            Console.WriteLine(response);
            return user;
        }*/
    }
}
