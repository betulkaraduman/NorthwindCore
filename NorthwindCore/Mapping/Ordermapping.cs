using ConsoleApp2.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace NorthwindCore.Mapping
{
    public class Ordermapping : IEntityTypeConfiguration<Orders>
    {
        public void Configure(EntityTypeBuilder<Orders> builder)
        {
            builder.HasOne(t => t.Employee).WithMany(t => t.Orders).HasForeignKey(t => t.OrdersId);

            builder.HasOne(t => t.Custumer).WithMany(t => t.Orders).HasForeignKey(t => t.CustomerId);
            builder.HasOne(t => t.Shipper).WithMany(t => t.Orders).HasForeignKey(t => t.ShipVia);
        }
    }
}
