using eCommerce.Data.Mappings;
using eCommerce.Entity;
using eCommerce.Entity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace eCommerce.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {


        public AppDbContext(DbContextOptions<AppDbContext> options)
           : base(options)
        {
        }


        public AppDbContext() : base(GetOption("Data Source=.\\SQLEXPRESS;Initial Catalog=eCommerceDB;Integrated Security=true"))
        {
        }


        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }


        private static DbContextOptions GetOption(string connString)
        {
            return SqlServerDbContextOptionsExtensions.UseSqlServer(new DbContextOptionsBuilder(), connString).Options;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddConfiguration(new CategoryMap());

            base.OnModelCreating(modelBuilder);
        }
        public EntityState GetState(ObjectState state)
        {
            switch (state)
            {
                case ObjectState.Added:
                    return EntityState.Added;
                case ObjectState.Modified:
                    return EntityState.Modified;
                case ObjectState.Deleted:
                    return EntityState.Deleted;
                default:
                    return EntityState.Unchanged;
            }
        }

    }
}
