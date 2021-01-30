using MetaState.STS.Identity.Configuration;
using System.ComponentModel.DataAnnotations;
using MetaState.Shared.Configuration.Identity;

namespace MetaState.STS.Identity.ViewModels.Account
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






