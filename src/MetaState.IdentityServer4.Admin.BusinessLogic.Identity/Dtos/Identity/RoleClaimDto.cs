﻿using System.ComponentModel.DataAnnotations;
using MetaState.IdentityServer4.Admin.BusinessLogic.Identity.Dtos.Identity.Base;
using MetaState.IdentityServer4.Admin.BusinessLogic.Identity.Dtos.Identity.Interfaces;

namespace MetaState.IdentityServer4.Admin.BusinessLogic.Identity.Dtos.Identity
{
    public class RoleClaimDto<TKey> : BaseRoleClaimDto<TKey>, IRoleClaimDto
    {
        [Required]
        public string ClaimType { get; set; }


        [Required]
        public string ClaimValue { get; set; }
    }
}
