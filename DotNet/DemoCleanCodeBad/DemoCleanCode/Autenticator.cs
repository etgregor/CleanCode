using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using DemoCleanCode.Entities;
using DemoCleanCode.Persistence;

namespace DemoCleanCode
{
    public class Autenticator
    {
        UserPersistance persistance;

        public Autenticator()
        {
            this.persistance = new UserPersistance();
        }

        public Identity Validate(string username, string password, bool keepSessionAlive) 
        {
            Identity identity = null;

            var user = this.persistance.GetUser(username);

            if (string.IsNullOrEmpty(password))
            {
                identity = new Identity();

                identity.Username = user.Username;

                CreateSession(identity);

                if (keepSessionAlive)
                {
                    this.KeepSessionAlive(identity);
                }

                identity = new Identity();
            }

            return identity;
        }

        public bool IsInRole(Identity identity)
        {
            return true;
        }

        private void CreateSession(Identity identity)
        { 
        }

        private void KeepSessionAlive(Identity identity)
        {
        }
    }
}
