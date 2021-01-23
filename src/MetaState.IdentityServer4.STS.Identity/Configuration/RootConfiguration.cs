using MetaState.IdentityServer4.Shared.Configuration.Identity;
using MetaState.IdentityServer4.STS.Identity.Configuration.Interfaces;

namespace MetaState.IdentityServer4.STS.Identity.Configuration
{
    public class RootConfiguration : IRootConfiguration
    {      
        public AdminConfiguration AdminConfiguration { get; } = new AdminConfiguration();
        public RegisterConfiguration RegisterConfiguration { get; } = new RegisterConfiguration();
    }
}