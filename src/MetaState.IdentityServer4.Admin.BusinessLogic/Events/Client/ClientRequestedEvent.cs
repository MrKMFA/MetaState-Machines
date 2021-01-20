using Skoruba.AuditLogging.Events;
using MetaState.IdentityServer4.Admin.BusinessLogic.Dtos.Configuration;

namespace Skoruba.IdentityServer4.Admin.BusinessLogic.Events.Client
{
    public class ClientRequestedEvent : AuditEvent
    {
        public ClientDto ClientDto { get; set; }

        public ClientRequestedEvent(ClientDto clientDto)
        {
            ClientDto = clientDto;
        }
    }
}