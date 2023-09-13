namespace SANA_SHOPPINGCART_BACK.Domain.Interfaces;

public interface IUnitOfWork
{
    Task SaveAsync(bool isUpdate = false, CancellationToken? cancellationToken = null);
}
