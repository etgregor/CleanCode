using DemoCleanCode.Entities;

namespace DemoCleanCode.Security
{
    public class SessionManager
    {
        public void CreateSession(Identity identity, bool keepAliveSession)
        {
            this.KeepSessionAlive(identity);
        }

        public void CloseSession(Identity identity)
        {
        }

        private void KeepSessionAlive(Identity identity)
        {
        }
    }
}
