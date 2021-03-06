using ChainOfStores.EFData.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfStores.EFData
{
    public class EFAppDBContext : DbContext
    {
        public EFAppDBContext() : base("chainOfStoresdb")
        {
        }

        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<BookingDuration> bookingDuration { get; set; }
    }
}
