using SANA_SHOPPINGCART_BACK.Domain.Dto;
using SANA_SHOPPINGCART_BACK.Domain.Interfaces;

namespace SANA_SHOPPINGCART_BACK.Domain.Services;

[DomainService]
public class CatalogService
{
    private readonly ICatalogRepository catalogRepository;

    public CatalogService(ICatalogRepository catalogRepository)
    {
        this.catalogRepository = catalogRepository;
    }

    public async Task<IEnumerable<ProductDto>> GetCatalogAsync()
    {
        var catalog = await catalogRepository.GetAllProductsAsync();

        return catalog.Select(product => new ProductDto
        {
            Description = product.Description,
            Id = product.Id,
            Image = product.Image,
            Price = product.Price,
            ProductName = product.ProductName
        });
    }
}
