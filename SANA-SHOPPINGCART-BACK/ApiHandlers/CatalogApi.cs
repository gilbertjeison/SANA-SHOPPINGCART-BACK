using MediatR;
using SANA_SHOPPINGCART_BACK.Application.Catalog;

namespace SANA_SHOPPINGCART_BACK.ApiHandlers;

public static class CatalogApi
{
    public static RouteGroupBuilder MapCatalog(this IEndpointRouteBuilder routeHandler)
    {
        routeHandler.MapGet("", async (IMediator mediator) =>
        {
            return Results.Ok(await mediator.Send(new CatalogQuery()));

        }).Produces(StatusCodes.Status200OK, null);

        return (RouteGroupBuilder)routeHandler;
    }
}
