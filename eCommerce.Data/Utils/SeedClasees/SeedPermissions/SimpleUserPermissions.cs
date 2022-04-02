using eCommerce.Data.Utils.Config;
using eCommerce.Data.Utils.PartialPermissions;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace eCommerce.Data.Utils.SeedClasees.SeedPermissions
{
    public static class SimpleUserPermissions
    {
        public static void Add(RoleManager<IdentityRole> roleManager, IdentityRole role)
        {

            //User
            roleManager.AddClaimAsync(role, new Claim(CustomClaimTypes.Permission, Permissions.User.Profile)).Wait();

            //Comment
            roleManager.AddClaimAsync(role, new Claim(CustomClaimTypes.Permission, Permissions.Comment.View)).Wait();
            roleManager.AddClaimAsync(role, new Claim(CustomClaimTypes.Permission, Permissions.Comment.Add)).Wait();

            roleManager.AddClaimAsync(role, new Claim(CustomClaimTypes.Permission, Permissions.Category.View)).Wait();
            roleManager.AddClaimAsync(role, new Claim(CustomClaimTypes.Permission, Permissions.Product.View)).Wait();

        }
    }
}
