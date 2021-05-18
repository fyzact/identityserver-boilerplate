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
                new ApiResource("boilerplate","Identity server boiler plate")
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
                    AllowedScopes=new []{ "boilerplate" }
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
                    Username="boilerplate",
                    Password="test"
                }
            };
        }

    }
}
