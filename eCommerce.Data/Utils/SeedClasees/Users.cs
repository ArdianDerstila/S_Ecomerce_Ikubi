using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.Data.Utils.SeedClasees
{
    public static partial class InitializeDB
    {
        public static class Users
        {
            public const string User_Administrator = "Administrator";
            public const string User_SimpleUser= "SimpleUser";

            public static void Seed(UserManager<ApplicationUser> userManager)
            {
                CreateUser(userManager, User_Administrator, Roles.Administrator);
                CreateUser(userManager, User_SimpleUser, Roles.SimpleUser);
            }


            public static void CreateUser(UserManager<ApplicationUser> userManager, string userName, string roleName)
            {
                if (userManager.FindByNameAsync(userName).Result == null)
                {
                    ApplicationUser user = new ApplicationUser();
                    user.UserName = userName;
                    user.Email = userName + "@gmail.com";

                    IdentityResult result = userManager.CreateAsync(user, userName + "_@123").Result;

                    if (result.Succeeded)
                        userManager.AddToRoleAsync(user, roleName).Wait();
                }
            }
        }

    }
}
