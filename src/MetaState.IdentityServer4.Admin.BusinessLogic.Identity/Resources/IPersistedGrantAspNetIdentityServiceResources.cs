using MetaState.IdentityServer4.Admin.BusinessLogic.Identity.Helpers;

namespace MetaState.IdentityServer4.Admin.BusinessLogic.Identity.Resources
{
    public interface IPersistedGrantAspNetIdentityServiceResources
    {
        ResourceMessage PersistedGrantDoesNotExist();

        ResourceMessage PersistedGrantWithSubjectIdDoesNotExist();
    }
}
