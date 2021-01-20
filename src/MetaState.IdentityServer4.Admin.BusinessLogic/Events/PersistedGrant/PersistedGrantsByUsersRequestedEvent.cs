using Skoruba.AuditLogging.Events;
using MetaState.IdentityServer4.Admin.BusinessLogic.Dtos.Grant;

namespace MetaState.IdentityServer4.Admin.BusinessLogic.Events.PersistedGrant
{
    public class PersistedGrantsByUsersRequestedEvent : AuditEvent
    {
        public PersistedGrantsDto PersistedGrants { get; set; }

        public PersistedGrantsByUsersRequestedEvent(PersistedGrantsDto persistedGrants)
        {
            PersistedGrants = persistedGrants;
        }
    }
}