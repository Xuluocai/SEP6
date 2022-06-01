using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Model
{
    public class Movielist
    {
        public string username { set; get; }
        public int id { set; get; }
        public Movielist(string username,int id)
        {
            this.username = username;
            this.id = id;
        }
    }
}
