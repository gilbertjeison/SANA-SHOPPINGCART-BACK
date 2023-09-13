using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SANA_SHOPPINGCART_BACK.Domain.Entities;

namespace SANA_SHOPPINGCART_BACK.Infrastructure.DataSource.ModelConfig;

public class ProductConfiguration : IEntityTypeConfiguration<Product>

{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Products");
        builder.HasKey(p => p.Id);
        builder.Property(p => p.ProductName).IsRequired().HasMaxLength(255);
        builder.Property(od => od.Price).HasColumnType("decimal(18, 2)");
    }
}
