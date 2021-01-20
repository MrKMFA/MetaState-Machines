﻿using Skoruba.AuditLogging.Events;
using MetaState.IdentityServer4.Admin.BusinessLogic.Dtos.Grant;

namespace MetaState.IdentityServer4.Admin.BusinessLogic.Events.PersistedGrant
{
    public class PersistedGrantRequestedEvent : AuditEvent
    {
        public PersistedGrantDto PersistedGrant { get; set; }

        public PersistedGrantRequestedEvent(PersistedGrantDto persistedGrant)
        {
            PersistedGrant = persistedGrant;
        }
    }
}