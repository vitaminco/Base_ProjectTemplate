using App.Data.Entities;
using App.Share.Consts;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.DataSeeders
{
    public static class AppCategorySeeder
    {
        public static void SeedData(this EntityTypeBuilder<AppCategory> builder)
        {
            var now = new DateTime(year: 2021, month: 12, day: 10);


            // Tạo vai trò
            var listcategory = new List<AppCategory>() {
                new AppCategory
                {
                    Id = 1,
                    Name = "Laptop",
                    CreatedDate = now,
                    UpdatedDate = now,
                },
                new AppCategory
                {
                    Id = 2,
                    Name = "Điện thoại di động",
                    CreatedDate = now,
                    UpdatedDate = now,
                },
                new AppCategory
                {
                    Id = 3,
                    Name = "Sách",
                    CreatedDate = now,
                    UpdatedDate = now,
                }
        };

            builder.HasData(listcategory);
        }
    }
}
