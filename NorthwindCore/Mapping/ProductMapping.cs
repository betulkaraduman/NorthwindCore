using ConsoleApp2.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace NorthwindCore.Mapping
{
    public class ProductMapping : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {

            builder.HasOne(t => t.Supplier).WithMany(t => t.Products).HasForeignKey(t => t.ShipperId);
            builder.HasOne(t => t.Category).WithMany(t => t.Products).HasForeignKey(t => t.CategoryId);
        }
    }
}
