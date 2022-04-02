using eCommerce.Data;
using eCommerce.Data.Utils.Config;
using eCommerce.Repository;
using eCommerce.Service.Interfaces;
using eCommerce.Service.Services;
using eCommerce.Web.Utils.Config;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
              options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            //services.AddMvc(options =>
            //{
            //    options.MaxModelValidationErrors = 50;
            //    options.ModelBindingMessageProvider.SetValueMustNotBeNullAccessor(
            //     (_) => "The field is required.");
            //});


            //services.Configure<FormOptions>(options =>
            //{
            //    options.ValueCountLimit = int.MaxValue;
            //    //options.ValueCountLimit = 200; // 200 items max
            //    options.ValueLengthLimit = 1024 * 1024 * 100; // 100MB max len form data
            //});

            services.AddIdentity<ApplicationUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = false)
            .AddEntityFrameworkStores<AppDbContext>();

            services.AddControllersWithViews();

            //services.ConfigureApplicationCookie(config =>
            //{
            //    config.Cookie.Name = "Identity.Cookie";
            //    config.LoginPath = "/Home/Index";
            //});

            services.AddControllers(config =>
            {
                // using Microsoft.AspNetCore.Mvc.Authorization;
                // using Microsoft.AspNetCore.Authorization;
                var policy = new AuthorizationPolicyBuilder()
                                 .RequireAuthenticatedUser()
                                 .Build();
                config.Filters.Add(new AuthorizeFilter(policy));
            });

            services.AddScoped<AppDbContext>();
            services.AddScoped<IBaseService, BaseService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            // services.AddScoped<IUserService, UserService>();
            ConfigPermissions.AddAuthorization(ref services);
            services.AddScoped<IAuthorizationHandler, PermissionAuthorizationHandler>();
        
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
