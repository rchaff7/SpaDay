using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.Models
{
    public class User
    {
        public string Username { get; }
        public string Email { get; set; }
        private string Password { get; set; }


    }
}
