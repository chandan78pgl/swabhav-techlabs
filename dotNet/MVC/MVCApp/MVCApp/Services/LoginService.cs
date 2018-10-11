using MVCApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCApp.Models.Login
{
    public class LoginService
    {
        public Boolean AuthenticateUser(string name,string password)
        {
            ContactDBContext contactDBContext = new ContactDBContext();
            User user = contactDBContext.Users.Where((u) => u.Name == name).Single();

            if (user.Name == name && user.Password==password)
            {
                return true;
            }
            return false;
        }
    }
}