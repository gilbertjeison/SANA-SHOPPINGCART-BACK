namespace SANA_SHOPPINGCART_BACK.Domain.Entities
{
    public class OrderDetail : DomainEntity
    {
        public long OrderID { get; set; }
        public long ProductID { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public Order? Order { get; set; }
        public Product? Product { get; set; }
    }
}
