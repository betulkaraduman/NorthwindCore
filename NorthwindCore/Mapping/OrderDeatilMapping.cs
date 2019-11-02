using ConsoleApp2.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace NorthwindCore.Mapping
{
    class OrderDeatilMapping : IEntityTypeConfiguration<OrdersDetail>
    {
        

        public void Configure(EntityTypeBuilder<OrdersDetail> builder)
        {
            builder.HasOne(t => t.Product).WithMany(t => t.OrdersDetails).HasForeignKey(t => t.ProductId);
            builder.HasOne(t => t.Orders).WithMany(t => t.OrdersDetails).HasForeignKey(t => t.OrderDetailId);
            
            

        }
    }
}
