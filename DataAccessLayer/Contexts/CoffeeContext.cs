using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Contexts
{
    public class CoffeeContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-2CKF4CQ\\SQLEXPRESS; database=DbCoffeeShop;integrated security=true;TrustServerCertificate=true");
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Home> Homes { get; set; }
        public DbSet<Product> Proudcts { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<HomeContent> HomeContents { get; set; }
    }
}
