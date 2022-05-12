using IdentityServer4.Models;

namespace Server
{
    public class Config
    {
        public static IEnumerable<IdentityResource> IdentityResources =>
            new[]
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                new IdentityResource
                {
                    Name="role",
                    UserClaims = new List<string>{"role"}
                }
            };
        public static IEnumerable<ApiScope> ApiScopes =>
            new[]
            {
                new ApiScope("Scope.Read"),
                new ApiScope("Scope.Write")
            };

        public static IEnumerable<ApiResource> ApiResources =>
            new[]
            {
                new ApiResource("StudentAPI")
                {
                    Scopes = new List<string> {"Scope.Read","Scope.Write"},
                    ApiSecrets = new List<Secret> {new Secret("ScopeSecret".Sha256())},
                    UserClaims = new List<string> {"role"}
                }
            };

        public static IEnumerable<Client> Clients =>
         new[]
         {
                new Client
                {
                    ClientId = "m2m.client",
                    ClientName = "Tin Admin",
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    ClientSecrets = {new Secret("ClientSecret1".Sha256())},
                    AllowedScopes = {"Scope.Read","Scope.Write"}
                },
                new Client
                {
                    ClientId = "interactive",
                    AllowedGrantTypes = GrantTypes.Code,
                    ClientSecrets = {new Secret("ClientSecret1".Sha256())},
                    AllowedScopes = {"openid","profile","Scope.Read"},
                    RedirectUris = {"https://localhost:8001/signin-oidc"},
                    FrontChannelLogoutUri = "https://localhost:8001/signout-oidc",
                    PostLogoutRedirectUris = {"https://localhost:8001/signout-callback-oidc"},
                    RequirePkce = true,
                    RequireConsent = true,
                    AllowPlainTextPkce = false,
                    AllowOfflineAccess = true,

                }
         };

    }
}
