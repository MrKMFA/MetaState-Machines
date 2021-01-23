using System.Collections.Generic;
using MetaState.IdentityServer4.Admin.Configuration.Identity;

namespace MetaState.IdentityServer4.Admin.Configuration.IdentityServer
{
    public class Client : global::IdentityServer4.Models.Client
    {
        public List<Claim> ClientClaims { get; set; } = new List<Claim>();
    }
}
