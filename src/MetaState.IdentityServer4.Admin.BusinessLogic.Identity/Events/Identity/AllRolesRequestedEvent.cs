﻿using System.Collections.Generic;
using Skoruba.AuditLogging.Events;

namespace MetaState.IdentityServer4.Admin.BusinessLogic.Identity.Events.Identity
{
    public class AllRolesRequestedEvent<TRoleDto> : AuditEvent
    {
        public List<TRoleDto> Roles { get; set; }

        public AllRolesRequestedEvent(List<TRoleDto> roles)
        {
            Roles = roles;
        }
    }
}