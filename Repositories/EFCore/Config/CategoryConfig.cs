﻿using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.EFCore.Config
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.CategoryId); //PK
            builder.Property(c => c.CategoryName).IsRequired();
            builder.HasData(
                new Category() { CategoryId = 1, CategoryName = "Science Fiction" },
                new Category() { CategoryId = 2, CategoryName = "Mystery" },
                new Category() { CategoryId = 3, CategoryName = "Horror" }
            );
        }
    }
}