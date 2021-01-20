using Skoruba.AuditLogging.Events;
using MetaState.IdentityServer4.Admin.BusinessLogic.Dtos.Configuration;

namespace MetaState.IdentityServer4.Admin.BusinessLogic.Events.ApiResource
{
    public class ApiScopeDeletedEvent : AuditEvent
    {
        public ApiScopesDto ApiScope { get; set; }

        public ApiScopeDeletedEvent(ApiScopesDto apiScope)
        {
            ApiScope = apiScope;
        }
    }
}