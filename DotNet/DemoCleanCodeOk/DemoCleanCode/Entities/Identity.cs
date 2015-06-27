using DemoCleanCode.Enums;

namespace DemoCleanCode.Entities
{
    public class Identity
    {
        public User User { get; set; }

        public UserRoles UserRole { get; set; }

        public string SessionToken { get; set; }
    }
}
