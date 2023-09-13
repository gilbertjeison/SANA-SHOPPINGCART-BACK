namespace SANA_SHOPPINGCART_BACK.Domain.Entities;

public class Customer : DomainEntity
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }

    public ICollection<Order>? Orders { get; set; }
}
