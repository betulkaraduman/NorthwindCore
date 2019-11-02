using ConsoleApp2.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace NorthwindCore.Mapping
{
    class EmployeeTeritoriesMapping : IEntityTypeConfiguration<EmployeeTerritories>
    {

        public void Configure(EntityTypeBuilder<EmployeeTerritories> builder)
        {
            builder.HasKey(t => new { t.EmployeeId, t.TerritoriesId});
            builder.HasOne(t => t.Employee).WithMany(t => t.EmployeeTerritories).HasForeignKey(t => t.EmployeeId);
            builder.HasOne(t => t.Territories).WithMany(t => t.EmployeeTerritories).HasForeignKey(t => t.TerritoriesId);
        }
    }

}