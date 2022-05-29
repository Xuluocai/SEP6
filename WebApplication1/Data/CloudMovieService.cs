using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using WebApplication1.Model;

namespace WebApplication1.Data
{
    public class CloudMovieService : IMovieService
    {
        private string url = "https://sep6-v2.ey.r.appspot.com";
        private readonly HttpClient client;

        public CloudMovieService()
        {
            client = new HttpClient();
        }
        public async Task<Movie> getMovieById(int Id)
        {
            HttpResponseMessage response = await client.GetAsync($"{url}/movie/getMovieById?id={Id}");
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Error");
            }
            string message = await response.Content.ReadAsStringAsync();
            Movie movie = JsonSerializer.Deserialize<Movie>(message);
            Console.WriteLine(movie);
            return movie;
        }

        public async Task<IList<Movie>> GetMovies()
        {
            HttpResponseMessage response = await client.GetAsync(url + "/movie/getAllMovies");
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Error");
            }
            string message = await response.Content.ReadAsStringAsync();
            List<Movie> result = JsonSerializer.Deserialize<List<Movie>>(message);
            return result;
        }

      
        public async Task<IList<Movie>> getMoviesByYear(int minYear, int maxYear)
        {
            HttpResponseMessage response = await client.GetAsync($"{url}/movie/getMoviesByYear?minYear={minYear}&&maxYear={maxYear}");
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Error");
            }
            string message = await response.Content.ReadAsStringAsync();
            List<Movie> result = JsonSerializer.Deserialize<List<Movie>>(message);
            return result;
        }

        public async Task<IList<Movie>> getMoviesByTitle(string title)
        {
           HttpResponseMessage response=await client.GetAsync($"{url}/movie/getMovieByTitle?title={title}");
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Error");
            }
            string message = await response.Content.ReadAsStringAsync();
            List<Movie> result = JsonSerializer.Deserialize<List<Movie>>(message);
            return result;


        }
    }
}
