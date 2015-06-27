using System.Collections.Generic;
using DemoCleanCode.Entities;
using DemoCleanCode.Persistence;

namespace DemoCleanCode.Security
{
    public class Autenticator
    {
        public Identity Validate(string username, string password)
        {
            UserPersistance persistance = new UserPersistance();

            var user = persistance.GetUser(username);

            var identity = new Identity();
            
            return identity;
        }

        public List<User> GetUsers()
        {
            return new List<User>();
        }

        public bool IsAuthenticated()
        {
            return true;
        }

        public bool PasswordIsNotExpired()
        {
            return false;
        }

        public void CreateSession(Identity identity)
        {
        }
    }
}
