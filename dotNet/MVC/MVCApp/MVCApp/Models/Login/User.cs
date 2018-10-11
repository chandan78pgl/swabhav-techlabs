using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCApp.Models.Login
{
    public class User
    {
        public int Id { set; get; }
        public String Name { set; get; }
        public String Password { set; get; }
    }
}