using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SANA_SHOPPINGCART_BACK.Domain.Entities;

namespace SANA_SHOPPINGCART_BACK.Infrastructure.DataSource.ModelConfig;

public class ProductCategoryProductConfiguration : IEntityTypeConfiguration<ProductCategoryProduct>
{
    public void Configure(EntityTypeBuilder<ProductCategoryProduct> builder)
    {
        builder.ToTable("ProductCategoryProducts");
        builder.HasKey(pcp => new { pcp.ProductCategoryID, pcp.ProductID });
    }
}
