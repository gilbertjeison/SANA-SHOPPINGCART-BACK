using SANA_SHOPPINGCART_BACK.Domain.Entities;

namespace SANA_SHOPPINGCART_BACK.Domain.Interfaces;

public interface ICatalogRepository
{
    Task<IEnumerable<Product>> GetAllProductsAsync();
}
