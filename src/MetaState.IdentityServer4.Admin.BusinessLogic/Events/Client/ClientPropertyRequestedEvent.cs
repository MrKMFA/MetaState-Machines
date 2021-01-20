using Skoruba.AuditLogging.Events;
using MetaState.IdentityServer4.Admin.BusinessLogic.Dtos.Configuration;

namespace MetaState.IdentityServer4.Admin.BusinessLogic.Events.Client
{
    public class ClientPropertyRequestedEvent : AuditEvent
    {
        public ClientPropertiesDto ClientProperties { get; set; }

        public ClientPropertyRequestedEvent(ClientPropertiesDto clientProperties)
        {
            ClientProperties = clientProperties;
        }
    }
}