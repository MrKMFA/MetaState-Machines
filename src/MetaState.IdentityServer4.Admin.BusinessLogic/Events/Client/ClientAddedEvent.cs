using Skoruba.AuditLogging.Events;
using MetaState.IdentityServer4.Admin.BusinessLogic.Dtos.Configuration;

namespace MetaState.IdentityServer4.Admin.BusinessLogic.Events.Client
{
    public class ClientAddedEvent : AuditEvent
    {
        public ClientDto Client { get; set; }

        public ClientAddedEvent(ClientDto client)
        {
            Client = client;
        }
    }
}