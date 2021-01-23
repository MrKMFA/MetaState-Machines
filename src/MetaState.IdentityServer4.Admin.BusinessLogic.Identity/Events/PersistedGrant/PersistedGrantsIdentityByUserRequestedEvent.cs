﻿using Skoruba.AuditLogging.Events;
using MetaState.IdentityServer4.Admin.BusinessLogic.Identity.Dtos.Grant;

namespace MetaState.IdentityServer4.Admin.BusinessLogic.Identity.Events.PersistedGrant
{
    public class PersistedGrantsIdentityByUserRequestedEvent : AuditEvent
    {
        public PersistedGrantsDto PersistedGrants { get; set; }

        public PersistedGrantsIdentityByUserRequestedEvent(PersistedGrantsDto persistedGrants)
        {
            PersistedGrants = persistedGrants;
        }
    }
}