namespace SANA_SHOPPINGCART_BACK.Domain.Entities;

public class Order : DomainEntity
{
    public long CustomerID { get; set; }
    public DateTime OrderDate { get; set; }

    public ICollection<OrderDetail>? OrderDetails { get; set; }
}
