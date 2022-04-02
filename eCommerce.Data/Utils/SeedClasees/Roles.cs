using eCommerce.Data.Utils.SeedClasees.SeedPermissions;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.Data.Utils.SeedClasees
{
    public static partial class InitializeDB
    {
        public static partial class Roles
        {
            public const string Administrator = nameof(Administrator);
            public const string SimpleUser = nameof(SimpleUser);

            public static void Seed(RoleManager<IdentityRole> roleManager)
            {
                CreateRole(roleManager, Administrator);
                CreateRole(roleManager, SimpleUser);
            }
            public static void CreateRole(RoleManager<IdentityRole> roleManager, string roleName)
            {
                if (!roleManager.RoleExistsAsync(roleName).Result)
                {
                    IdentityRole role = new IdentityRole();
                    role.Name = roleName;

                    IdentityResult roleResult = roleManager.CreateAsync(role).Result;


                    // roleManager.AddClaimAsync(role, new Claim(CustomClaimTypes.Permission, Permissions.Dashboard.View));

                    switch (roleName)
                    {
                        case Administrator: AdministratorPermissions.Add(roleManager, role); break;
                        case SimpleUser: SimpleUserPermissions.Add(roleManager, role); break;
                    }
                }
            }
        }
    }
}
