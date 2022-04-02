using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.Data.Utils.SeedClasees
{
    public static partial class InitializeDB
    {
        public static void Seed(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, AppDbContext dbContext)
        {
            Roles.Seed(roleManager);
            Users.Seed(userManager);
        }
    }
}
