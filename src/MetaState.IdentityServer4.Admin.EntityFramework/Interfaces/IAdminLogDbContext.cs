using Microsoft.EntityFrameworkCore;
using MetaState.IdentityServer4.Admin.EntityFramework.Entities;

namespace MetaState.IdentityServer4.Admin.EntityFramework.Interfaces
{
    public interface IAdminLogDbContext
    {
        DbSet<Log> Logs { get; set; }
    }
}
