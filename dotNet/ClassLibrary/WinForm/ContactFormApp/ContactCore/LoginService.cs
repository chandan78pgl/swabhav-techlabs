using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactCore
{
    public class LoginService
    {
        private string _userName;
        private string _password;

        public Boolean AuthenticateUser(string userId,string password)
        {
            LoginRepository loginRepository = new LoginRepository();
            _userName = loginRepository.UserName;
            _password = loginRepository.Password;

            if (_userName==userId && _password==password)
            {
                return true;
            }

            return false;
        }
    }
}
