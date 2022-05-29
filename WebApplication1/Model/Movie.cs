using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Model
{
    public class Movie
    {
        public Movie(){}
        public Movie(String name, int id, string title) {
            name = name;
            id = id;
            title = title;
        }
       

        public int id { set; get; }
        public int year { set; get; }
        public string title { set; get; }

        /*        public string directorname { get; set; }
                public string starname { get; set; }
                public string category { get; set; }
                public double Rating { get; set; }
                public string publishdate { get; set; }*/


        public string toString()
        {
            return "name is " + title;
        }


    }

    

}
