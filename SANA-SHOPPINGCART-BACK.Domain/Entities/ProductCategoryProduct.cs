namespace SANA_SHOPPINGCART_BACK.Domain.Entities;

public class ProductCategoryProduct
{
    public long ProductCategoryID { get; set; }
    public long ProductID { get; set; }
    public ProductCategory? ProductCategory { get; set; }
    public Product? Product { get; set; }
}
