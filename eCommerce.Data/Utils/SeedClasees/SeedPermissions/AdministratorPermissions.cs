using eCommerce.Data.Utils.Config;
using eCommerce.Data.Utils.PartialPermissions;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;

namespace eCommerce.Data.Utils.SeedClasees.SeedPermissions
{
    class AdministratorPermissions
    {
        public static void Add(RoleManager<IdentityRole> roleManager, IdentityRole role)
        {
            //User
            roleManager.AddClaimAsync(role, new Claim(CustomClaimTypes.Permission, Permissions.User.View)).Wait();
            roleManager.AddClaimAsync(role, new Claim(CustomClaimTypes.Permission, Permissions.User.Add)).Wait();
            roleManager.AddClaimAsync(role, new Claim(CustomClaimTypes.Permission, Permissions.User.Edit)).Wait();
            roleManager.AddClaimAsync(role, new Claim(CustomClaimTypes.Permission, Permissions.User.Delete)).Wait();
            roleManager.AddClaimAsync(role, new Claim(CustomClaimTypes.Permission, Permissions.User.Profile)).Wait();

            //Category
            roleManager.AddClaimAsync(role, new Claim(CustomClaimTypes.Permission, Permissions.Category.View)).Wait();
            roleManager.AddClaimAsync(role, new Claim(CustomClaimTypes.Permission, Permissions.Category.Add)).Wait();
            roleManager.AddClaimAsync(role, new Claim(CustomClaimTypes.Permission, Permissions.Category.Edit)).Wait();
            roleManager.AddClaimAsync(role, new Claim(CustomClaimTypes.Permission, Permissions.Category.Delete)).Wait();

            //Product
            roleManager.AddClaimAsync(role, new Claim(CustomClaimTypes.Permission, Permissions.Product.View)).Wait();
            roleManager.AddClaimAsync(role, new Claim(CustomClaimTypes.Permission, Permissions.Product.Add)).Wait();
            roleManager.AddClaimAsync(role, new Claim(CustomClaimTypes.Permission, Permissions.Product.Edit)).Wait();
            roleManager.AddClaimAsync(role, new Claim(CustomClaimTypes.Permission, Permissions.Product.Delete)).Wait();
        }

    }
}
