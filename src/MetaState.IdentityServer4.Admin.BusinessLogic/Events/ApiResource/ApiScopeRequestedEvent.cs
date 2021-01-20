using Skoruba.AuditLogging.Events;
using MetaState.IdentityServer4.Admin.BusinessLogic.Dtos.Configuration;

namespace MetaState.IdentityServer4.Admin.BusinessLogic.Events.ApiResource
{
    public class ApiScopeRequestedEvent : AuditEvent
    {
        public ApiScopesDto ApiScopes { get; set; }

        public ApiScopeRequestedEvent(ApiScopesDto apiScopes)
        {
            ApiScopes = apiScopes;
        }
    }
}