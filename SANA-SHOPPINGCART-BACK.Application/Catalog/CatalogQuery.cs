using MediatR;
using SANA_SHOPPINGCART_BACK.Domain.Dto;

namespace SANA_SHOPPINGCART_BACK.Application.Catalog;

public record CatalogQuery() : IRequest<IEnumerable<ProductDto>>;
