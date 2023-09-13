namespace SANA_SHOPPINGCART_BACK.Domain.Entities;

public  class Product : DomainEntity
{
    public string? ProductName { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public string? Image { get; set; }

    public ICollection<ProductCategoryProduct>? ProductCategoryProducts { get; set; }
    public ICollection<OrderDetail>? OrderDetails { get; set; }
}
