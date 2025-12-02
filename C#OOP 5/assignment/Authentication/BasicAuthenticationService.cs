using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment.Authentication
{
    class BasicAuthenticationService : IAuthenticationService
    {
        public bool AuthenticateUser(string username, string password)
        {
            if (username != null && password != null)
            {
                if (username == "ola" && password == "123")
                {
                    return true;
                }
                else
                return false;
            }return false;
        }

        public bool AuthorizeUser(string username, string role)
        {
            if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(role)) { 
            if(username == "ola" &&  role == "admin")
                {
                    return true;
                }
                else {  return false; }
            
            }return false;
        }


        public override string ToString()
        {
            return base.ToString();
        }
    }
}
