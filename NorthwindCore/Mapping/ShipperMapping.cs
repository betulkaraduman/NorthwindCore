using ConsoleApp2.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace NorthwindCore.Mapping
{
    public class ShipperMapping : IEntityTypeConfiguration<Shipper>
    {
        public void Configure(EntityTypeBuilder<Shipper> builder)
        {
            builder.Property(t => t.CompanyName).HasMaxLength(40);
        }
    }
}
