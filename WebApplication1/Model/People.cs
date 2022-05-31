using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Model
{
    public class People
    {
        public String name { get; set; }
        public int birth { get; set; }
        public int id { set; get; }

        public People(string name,int birth,int id )
        {
            this.name = name;
            this.birth = birth;
            this.id = id;
        }
    }
}
