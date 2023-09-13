using MediatR;
using SANA_SHOPPINGCART_BACK.Domain.Dto;
using SANA_SHOPPINGCART_BACK.Domain.Services;

namespace SANA_SHOPPINGCART_BACK.Application.Catalog;

public class CatalogQueryHandler : IRequestHandler<CatalogQuery, IEnumerable<ProductDto>>
{
    private readonly CatalogService _catalogService;

    public CatalogQueryHandler(CatalogService catalogService)
    {
        _catalogService = catalogService;
    }

    public Task<IEnumerable<ProductDto>> Handle(CatalogQuery request, CancellationToken cancellationToken)
    {
        return _catalogService.GetCatalogAsync();
    }
}