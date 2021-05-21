using Microsoft.EntityFrameworkCore;
using System;
using ChainOfStores.EFCData.Entities;

namespace ChainOfStores.EFCData
{
    public class AppDBContext : DbContext
    {
        public AppDBContext()
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=chainOfStoresdb;Trusted_Connection=True;");
        }

        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }

    }
}
