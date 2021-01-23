using MetaState.IdentityServer4.STS.Identity.Configuration;
using System.ComponentModel.DataAnnotations;
using MetaState.IdentityServer4.Shared.Configuration.Identity;

namespace MetaState.IdentityServer4.STS.Identity.ViewModels.Account
{
    public class ForgotPasswordViewModel
    {
        [Required]
        public LoginResolutionPolicy? Policy { get; set; }
        //[Required]
        [EmailAddress]
        public string Email { get; set; }

        public string Username { get; set; }
    }
}
