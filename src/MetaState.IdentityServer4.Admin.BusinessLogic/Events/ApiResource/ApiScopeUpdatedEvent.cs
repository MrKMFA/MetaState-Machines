﻿using Skoruba.AuditLogging.Events;
using MetaState.IdentityServer4.Admin.BusinessLogic.Dtos.Configuration;

namespace MetaState.IdentityServer4.Admin.BusinessLogic.Events.ApiResource
{
    public class ApiScopeUpdatedEvent : AuditEvent
    {
        public ApiScopesDto OriginalApiScope { get; set; }
        public ApiScopesDto ApiScope { get; set; }

        public ApiScopeUpdatedEvent(ApiScopesDto originalApiScope, ApiScopesDto apiScope)
        {
            OriginalApiScope = originalApiScope;
            ApiScope = apiScope;
        }
    }
}