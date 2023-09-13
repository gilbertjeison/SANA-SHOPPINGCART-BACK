using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SANA_SHOPPINGCART_BACK.Domain.Entities;

namespace SANA_SHOPPINGCART_BACK.Infrastructure.DataSource.ModelConfig;

public class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
{
    public void Configure(EntityTypeBuilder<ProductCategory> builder)
    {
        builder.ToTable("ProductCategories");
        builder.HasKey(p => p.Id);
        builder.Property(p => p.CategoryName).IsRequired().HasMaxLength(255);
        builder.HasIndex(p => p.CategoryName).IsUnique();
    }
}
