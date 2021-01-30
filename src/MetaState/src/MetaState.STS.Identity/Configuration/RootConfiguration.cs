using MetaState.Shared.Configuration.Identity;
using MetaState.STS.Identity.Configuration.Interfaces;

namespace MetaState.STS.Identity.Configuration
{
    public class RootConfiguration : IRootConfiguration
    {      
        public AdminConfiguration AdminConfiguration { get; } = new AdminConfiguration();
        public RegisterConfiguration RegisterConfiguration { get; } = new RegisterConfiguration();
    }
}





