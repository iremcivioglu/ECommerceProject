//using ECommerce.Entities.Model;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace ECommerce.DataAccess.Configurations
//{
//    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
//    {
//        public void Configure(EntityTypeBuilder<Category> builder)
//        {
//            builder.HasKey(w => w.CategoryId);
//            builder.Property(w => w.CategoryId).UseIdentityColumn();
//            builder.HasOne(w => w.Products).WithMany(w => w.Categories).HasForeignKey(a => a.CategoryId);
//            builder.ToTable("Categories");
//        }
//    }
//}
