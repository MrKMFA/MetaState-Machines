using System.ComponentModel.DataAnnotations;
using MetaState.IdentityServer4.Admin.BusinessLogic.Identity.Dtos.Identity.Base;
using MetaState.IdentityServer4.Admin.BusinessLogic.Identity.Dtos.Identity.Interfaces;

namespace MetaState.IdentityServer4.Admin.BusinessLogic.Identity.Dtos.Identity
{
    public class RoleDto<TKey> : BaseRoleDto<TKey>, IRoleDto
    {      
        [Required]
        public string Name { get; set; }
    }
}