using System;
using System.Threading.Tasks;
using MetaState.IdentityServer4.Admin.BusinessLogic.Dtos.Log;

namespace MetaState.IdentityServer4.Admin.BusinessLogic.Services.Interfaces
{
    public interface IAuditLogService
    {
        Task<AuditLogsDto> GetAsync(AuditLogFilterDto filters);

        Task DeleteLogsOlderThanAsync(DateTime deleteOlderThan);
    }
}
