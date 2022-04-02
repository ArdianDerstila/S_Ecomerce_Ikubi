using eCommerce.Data.Utils.Config;
using eCommerce.Data.Utils.PartialPermissions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce.Web.Utils.Config
{
    public class ConfigPermissions
    {
        public static void AddAuthorization(ref IServiceCollection services)
        {
            services.AddAuthorization(options =>
            {
                AddPolicy(ref options, Permissions.User.View);
                AddPolicy(ref options, Permissions.User.Add);
                AddPolicy(ref options, Permissions.User.Edit);
                AddPolicy(ref options, Permissions.User.Delete);
                AddPolicy(ref options, Permissions.User.Profile);

                AddPolicy(ref options, Permissions.Category.View);
                AddPolicy(ref options, Permissions.Category.Add);
                AddPolicy(ref options, Permissions.Category.Edit);
                AddPolicy(ref options, Permissions.Category.Delete);

                AddPolicy(ref options, Permissions.Product.View);
                AddPolicy(ref options, Permissions.Product.Add);
                AddPolicy(ref options, Permissions.Product.Edit);
                AddPolicy(ref options, Permissions.Product.Delete);

                AddPolicy(ref options, Permissions.Comment.View);
                AddPolicy(ref options, Permissions.Comment.Add);
                AddPolicy(ref options, Permissions.Comment.Edit);
                AddPolicy(ref options, Permissions.Comment.Delete);


            });
        }




        private static void AddPolicy(ref AuthorizationOptions option, string permissionName)
        {
            option.AddPolicy(permissionName, builder =>
            {
                builder.AddRequirements(new PermissionRequirement(permissionName));
            });
        }
    }
}
