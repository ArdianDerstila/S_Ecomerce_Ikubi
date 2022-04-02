using eCommerce.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eCommerce.Data.Mappings
{
    public class CategoryMap: EntityTypeConfiguration<Category>
    {
        public override void Map(EntityTypeBuilder<Category> builder)
        {
            builder.HasMany(x => x.Products).WithOne(x => x.Category).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
