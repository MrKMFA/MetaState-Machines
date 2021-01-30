using MetaState.Shared.Configuration.Identity;
using MetaState.STS.Identity.Configuration;

namespace MetaState.STS.Identity.Helpers.Localization
{
    public static class LoginPolicyResolutionLocalizer
    {
        public static string GetUserNameLocalizationKey(LoginResolutionPolicy policy)
        {
            switch (policy)
            {
                case LoginResolutionPolicy.Username:
                    return "Username";
                case LoginResolutionPolicy.Email:
                    return "Email";
                default:
                    return "Username";
            }
        }
    }
}






