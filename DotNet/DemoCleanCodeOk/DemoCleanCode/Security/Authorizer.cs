using DemoCleanCode.Entities;

namespace DemoCleanCode.Security
{
    public class Authorizer
    {
        public bool IsInRole(Identity identity)
        {
            return true;
        }
    }
}
