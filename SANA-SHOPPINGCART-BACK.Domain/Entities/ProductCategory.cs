namespace SANA_SHOPPINGCART_BACK.Domain.Entities
{
    public class ProductCategory : DomainEntity
    {
        public string? CategoryName { get; set; }

        public ICollection<ProductCategoryProduct>? ProductCategoryProducts { get; set; }
    }
}
