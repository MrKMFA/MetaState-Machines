using Skoruba.AuditLogging.Events;

namespace MetaState.IdentityServer4.Admin.BusinessLogic.Identity.Events.Identity
{
    public class UserPasswordChangedEvent : AuditEvent
    {
        public string UserName { get; set; }

        public UserPasswordChangedEvent(string userName)
        {
            UserName = userName;
        }
    }
}