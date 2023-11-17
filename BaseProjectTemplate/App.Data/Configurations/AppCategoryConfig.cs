using App.Data.Entities;
using App.Share.Consts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Configurations
{
    internal class AppCategoryConfig : IEntityTypeConfiguration<AppCategory>
    {
        public void Configure(EntityTypeBuilder<AppCategory> builder)
        {
            builder.ToTable(DB.AppCategory.TABLE_NAME);

            // Khóa chính
            builder.HasKey(m => m.Id);
            // Tên đăng nhập là varchar, bắt buộc & không trùng lặp
            builder.Property(m => m.Name)
                .HasMaxLength(DB.AppCategory.NAME)
                .IsUnicode(false)   // varchar (không chứa unicode)
                .IsRequired();
        }
    }
}
