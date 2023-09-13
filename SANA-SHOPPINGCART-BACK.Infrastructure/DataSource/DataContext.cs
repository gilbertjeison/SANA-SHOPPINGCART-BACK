using Microsoft.EntityFrameworkCore;
using SANA_SHOPPINGCART_BACK.Domain.Entities;
using SANA_SHOPPINGCART_BACK.Infrastructure.DataSource.Data;

namespace SANA_SHOPPINGCART_BACK.Infrastructure.DataSource;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        if (modelBuilder is null)
        {
            return;
        }

        //Load all entity config from current assembly
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);

        modelBuilder.Entity<ProductCategory>();
        modelBuilder.Entity<Product>();
        modelBuilder.Entity<Customer>();
        modelBuilder.Entity<Order>();
        modelBuilder.Entity<OrderDetail>();
        modelBuilder.Entity<ProductCategoryProduct>();

        //Seed data
        modelBuilder.Entity<ProductCategory>().HasData(SeedData.ProductCategories);
        modelBuilder.Entity<Product>().HasData(SeedData.Products);
        modelBuilder.Entity<Customer>().HasData(SeedData.Customers);
        modelBuilder.Entity<Order>().HasData(SeedData.Orders);
        modelBuilder.Entity<OrderDetail>().HasData(SeedData.OrderDetails);
        modelBuilder.Entity<ProductCategoryProduct>().HasData(SeedData.ProductCategoryProducts);

        //Auditory properties
        foreach (var entityType in modelBuilder.Model.GetEntityTypes())
        {
            var t = entityType.ClrType;
            if (typeof(DomainEntity).IsAssignableFrom(t))
            {
                modelBuilder.Entity(entityType.Name).Property<DateTime>("CreatedOn").HasDefaultValue(DateTime.Now);
                modelBuilder.Entity(entityType.Name).Property<DateTime>("UpdatedOn").HasDefaultValue(DateTime.Now);
            }
        }

        base.OnModelCreating(modelBuilder);
    }
}
