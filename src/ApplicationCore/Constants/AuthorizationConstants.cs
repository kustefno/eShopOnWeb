namespace Microsoft.eShopWeb.ApplicationCore.Constants;

public class AuthorizationConstants
{
    public const string AUTH_KEY = "AuthKeyOfDoomThatMustBeAMinimumNumberOfBytes";

    // TODO: Don't use this in production
    public const string DEFAULT_PASSWORD = "Pass@word1";

    // TODO: Change this to an environment variable adding my command JK - 1/4/2023
    public const string JWT_SECRET_KEY = "SecretKeyOfDoomThatMustBeAMinimumNumberOfBytes";
}
