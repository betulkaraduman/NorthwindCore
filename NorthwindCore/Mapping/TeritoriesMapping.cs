using ConsoleApp2.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace NorthwindCore.Mapping
{
    public class TeritoriesMapping : IEntityTypeConfiguration<Territories>
    {
        public void Configure(EntityTypeBuilder<Territories> builder)
        {
            builder.HasOne(t => t.Region).WithMany(t => t.Territories).HasForeignKey(t => t.RegionId);
        }
    }
}
