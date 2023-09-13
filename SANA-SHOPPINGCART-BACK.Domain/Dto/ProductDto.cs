namespace SANA_SHOPPINGCART_BACK.Domain.Dto;

public  class ProductDto
{
    public long Id { get; set; }
    public string? ProductName { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    public string? Image { get; set; }
}
