//using ECommerce.Entities;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace ECommerce.DataAccess.Configurations
//{
//    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
//    {
//        public void Configure(EntityTypeBuilder<Customer> builder)
//        {
//            builder.HasKey(w => w.CustomerId);
//            builder.Property(w => w.CustomerId).UseIdentityColumn();
//            builder.HasOne(w => w.Supplier).WithMany(w => w.Customers).HasForeignKey(w => w.CustomerId);
//            builder.ToTable("Customers");
//        }
//    }
//}
