using Project_ENTITIES.Models;
using Project_MAPS.Options;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DAL.Context
{
    public class MyContext : DbContext
    {
        public MyContext(): base("MyConnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AppUserMap());
            modelBuilder.Configurations.Add(new OrderMap());
            modelBuilder.Configurations.Add(new OrderDetailsMap());
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new ShipperMap());
            modelBuilder.Configurations.Add(new UserProfileMap());
        }

        public DbSet<AppUser> AppUSers { get; set;}
        public DbSet<Order> Orders { get; set;}
        public DbSet<OrderDetail> OrderDetails { get; set;}
        public DbSet<Product> Products { get; set;}
        public DbSet<Category> Categories { get; set;}
        public DbSet<Shipper> Shippers { get; set;}
        public DbSet<AppUserProfile> AppUserProfiles { get; set;}
    }
}
