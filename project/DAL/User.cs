using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class User
    {
        public string UserName { get; set; }
        public int UserId { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }//תפקיד
    }
}
