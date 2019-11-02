using ConsoleApp2.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace NorthwindCore.Mapping
{
   public class SupplierMapping : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.Property(t => t.CompanyName).HasMaxLength(40).IsRequired();
            builder.Property(t => t.ContactName).HasMaxLength(30);
            builder.Property(t => t.ContactTitle).HasMaxLength(30);
   
        }
    }
}
