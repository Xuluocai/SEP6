using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Model
{
    public class User
    {
        public User()
        {

        }

        public User(String username, String password,int age) { }

        public string username { get; set; }

        public string password { get; set; }

        public int age { get; set; }

    }
}

