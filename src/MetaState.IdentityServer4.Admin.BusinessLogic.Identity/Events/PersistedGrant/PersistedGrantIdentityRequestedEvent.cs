﻿using Skoruba.AuditLogging.Events;
using MetaState.IdentityServer4.Admin.BusinessLogic.Identity.Dtos.Grant;

namespace MetaState.IdentityServer4.Admin.BusinessLogic.Identity.Events.PersistedGrant
{
    public class PersistedGrantIdentityRequestedEvent : AuditEvent
    {
        public PersistedGrantDto PersistedGrant { get; set; }

        public PersistedGrantIdentityRequestedEvent(PersistedGrantDto persistedGrant)
        {
            PersistedGrant = persistedGrant;
        }
    }
}