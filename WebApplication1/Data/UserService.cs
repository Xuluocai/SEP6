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
        private string url = "https://sep6-backend-v1-dpni2kwoia-ey.a.run.app";
        private readonly HttpClient client;

        public UserService()
        {
            client = new HttpClient();
        }
        public async Task<IList<Movie>> getMovieList(string username)
        {
            HttpResponseMessage response = await client.GetAsync($"{url}/user/getMovieList?username={username}");

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Error");
            }

            string message = await response.Content.ReadAsStringAsync();
            List<Movie> result = JsonSerializer.Deserialize<List<Movie>>(message);
            Console.WriteLine(result);
            Console.WriteLine(response);
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


        public async Task<User> RegisterUser(User user)
        {
            string userAsJson = JsonSerializer.Serialize(user);
            HttpContent content = new StringContent(userAsJson,
                Encoding.UTF8,
                "application/json");
            Console.WriteLine("this is");
            HttpResponseMessage response = await client.PostAsync(url+ "/user/registerUser", content);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Error, {response.StatusCode}, {response.ReasonPhrase}");
            }
            Console.WriteLine("hhhh");
            string message = await response.Content.ReadAsStringAsync();
            User user1 = JsonSerializer.Deserialize<User>(message);
            Console.WriteLine(response);
            return user1;
        }

        public async Task addMovieToList(Movielist movielist)
        {
            string movielistAsJson = JsonSerializer.Serialize(movielist);
            HttpContent content = new StringContent(movielistAsJson,
                Encoding.UTF8,
                "application/json");
            Console.WriteLine("this is");
            HttpResponseMessage response = await client.PostAsync(url +"/user/addMovieToList", content);
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception($"Error, {response.StatusCode}, {response.ReasonPhrase}");
            }
            Console.WriteLine("hhhh");
            

        }
    }
}
