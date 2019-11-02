using ConsoleApp2.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace NorthwindCore.Mapping
{
    public class CutomerMapping : IEntityTypeConfiguration<Custumer>
    {
        public void Configure(EntityTypeBuilder<Custumer> builder)
        {
            builder.Property(t => t.CompanyName).HasMaxLength(100);
        }
    }
}
