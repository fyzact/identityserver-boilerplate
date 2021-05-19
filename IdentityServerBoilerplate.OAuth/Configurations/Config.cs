using IdentityServer4.Models;
using IdentityServer4.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServerBoilerplate.OAuth.Configurations
{
    public class Config
    {
        public static IEnumerable<ApiResource> ApiResources()
        {
            return new[]
            {
                new ApiResource("boilerplate", "Identity server boiler plate")
            };
        }

        public static IEnumerable<Client> Clients()
        {

            return new[]
            {
                new Client
                {
                    ClientId="boilerplate",
                    ClientSecrets=new []{new Secret( "boilersecret".Sha256())},
                    AllowedGrantTypes=GrantTypes.ResourceOwnerPasswordAndClientCredentials,
                    AllowedScopes=new []{ "api" }
                }
            };

        }

        public static IEnumerable<TestUser> Users()
        {
            return new TestUser[]
            {
                new TestUser
                {
                    SubjectId="1",
                    Username="feyyaz",
                    Password="password"
                }
            };
        }

        //public static IEnumerable<IdentityResource> IdentityResources =>
        //    new[]
        //    {
        //        new IdentityResources.OpenId(),
        //        new IdentityResources.Profile(),
        //        new IdentityResource
        //        {
        //          Name = "role",
        //          UserClaims = new List<string> {"role"}
        //        }
        //    };


        public static IEnumerable<ApiScope> ApiScopes =>
          new[]
          {
        new ApiScope("api"),
        new ApiScope("web"),
          };
    }
}
