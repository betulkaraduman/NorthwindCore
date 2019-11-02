using ConsoleApp2.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace NorthwindCore.Mapping
{
    class OrdersMapping: IEntityTypeConfiguration<Employee>
    {
    

        public void Configure(EntityTypeBuilder<Employee> builder)
        {

            //builder.HasKey(t => t.EmployeeId);
            //builder.HasOne(t => t.employee).WithMany(t => t.GetEmployees).HasForeignKey(t => t.RepostTo);
        
        }
    }
}
