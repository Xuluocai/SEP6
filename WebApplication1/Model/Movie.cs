using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Model
{
    public class Movie
    {
        public Movie(){}
        public Movie(String moviename,string directorname,string starname,string category) { }
        public string moviename { get; set; }
        public string directorname { get; set; }
        public string starname { get; set; }
        public string category { get; set; }
        public double Rating { get; set; }
        public string publishdate { get; set; }
    }
}
