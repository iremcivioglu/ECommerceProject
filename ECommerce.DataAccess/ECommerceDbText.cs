using ECommerce.Entities;
using ECommerce.Entities.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace ECommerce.DataAccess
{
    public class ECommerceDbText : IdentityDbContext<Users, AppRole, int> //Neden string dışında yapınca alıyoruz? Çünkü varsayılan tüm yapılanma string olarak tasarlanmıştır.
                                                                          //Aksi durumdaki tüm tipleri bu şekilde belirtmemiz gerekmektedir.
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //    optionsBuilder.UseSqlServer("DefaultConnection");
        //    //if (!optionsBuilder.IsConfigured)
        //    //{
        //    //    optionsBuilder.UseSqlServer("DefaultConnection");
        //    //}

        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.ApplyConfigurationsFromAssembly(typeof(ECommerceDbText).Assembly);
            //modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            //modelBuilder.ApplyConfiguration(new CategoryConfiguration());
        }
        public ECommerceDbText(DbContextOptions<ECommerceDbText> options) : base(options)
        {

        }
        public ECommerceDbText()
        {
        }


        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Shipment> Shipments { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        //public DbSet<Users> User { get; set; }

    }
}
