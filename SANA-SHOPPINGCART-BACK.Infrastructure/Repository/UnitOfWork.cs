using Microsoft.EntityFrameworkCore;
using SANA_SHOPPINGCART_BACK.Domain.Interfaces;
using SANA_SHOPPINGCART_BACK.Infrastructure.DataSource;

namespace SANA_SHOPPINGCART_BACK.Infrastructure.Repository;

public class UnitOfWork : IUnitOfWork
{
    private readonly DataContext _context;
    public UnitOfWork(DataContext context)
    {
        _context = context;
    }

    public async Task SaveAsync(bool isUpdate = false, CancellationToken? cancellationToken = null)
    {
        var token = cancellationToken ?? new CancellationTokenSource().Token;

        _context.ChangeTracker.DetectChanges();

        var entryStatus = new Dictionary<EntityState, string>
        {
            {EntityState.Modified, "UpdatedOn"}
        };

        if (!isUpdate)
        {
            entryStatus.Add(EntityState.Added, "CreatedOn");
        }

        foreach (var entry in from entry in _context.ChangeTracker.Entries()
                              where entryStatus.ContainsKey(entry.State)
                              select entry)
        {
            entry.Property(entryStatus[entry.State]).CurrentValue = DateTime.Now;
        }

        await _context.SaveChangesAsync(token);
    }
}
