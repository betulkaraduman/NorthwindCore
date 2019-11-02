using ConsoleApp2.Domain;
using Microsoft.EntityFrameworkCore;
using NorthwindCore.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace NorthwindCore
{
  public  class MyDb:DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new OrdersMapping());
            modelBuilder.ApplyConfiguration(new CutomerMapping()); 
            modelBuilder.ApplyConfiguration(new CategoryMapping()); 
            modelBuilder.ApplyConfiguration(new EmployeeTeritoriesMapping()); 
            modelBuilder.ApplyConfiguration(new OrdersMapping()); 
            modelBuilder.ApplyConfiguration(new OrderDeatilMapping()); 
            modelBuilder.ApplyConfiguration(new ProductMapping());
            modelBuilder.ApplyConfiguration(new ShipperMapping()); 
            modelBuilder.ApplyConfiguration(new SupplierMapping()); 
            modelBuilder.ApplyConfiguration(new TeritoriesMapping());


        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=NorthwindDb;Trusted_Connection=True;");
            optionsBuilder.UseSqlServer("server=KDK-402-PC16-YZ;database=MyNorthwind;user id=sa;password=123");
        }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<Employee>Employees { get; set; }
        public virtual DbSet<Custumer> Custumers { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> GetProducts { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<OrdersDetail> OrdersDetails { get; set; }
        public virtual DbSet<Shipper> Shippers { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Territories>Territories { get; set; }
        public virtual DbSet<EmployeeTerritories> EmployeeTerritories { get; set; }
    }
}
