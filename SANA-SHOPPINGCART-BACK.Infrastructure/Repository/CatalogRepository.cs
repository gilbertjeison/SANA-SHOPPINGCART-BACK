using SANA_SHOPPINGCART_BACK.Domain.Entities;
using SANA_SHOPPINGCART_BACK.Domain.Interfaces;

namespace SANA_SHOPPINGCART_BACK.Infrastructure.Repository;

[Repository]
public class CatalogRepository : ICatalogRepository
{
    private readonly IRepository<Product> dataSource;

    public CatalogRepository(IRepository<Product> _dataSource)
    {
        dataSource = _dataSource;
    }

    public async Task<IEnumerable<Product>> GetAllProductsAsync()
    {
        return await dataSource.GetManyAsync();
    }
}
