using SANA_SHOPPINGCART_BACK.Domain.Entities;

namespace SANA_SHOPPINGCART_BACK.Infrastructure.DataSource.Data;

public class SeedData
{
    public static List<ProductCategory> ProductCategories { get; } = new List<ProductCategory>()
    {
        new ProductCategory { Id = 1, CategoryName = "Electronics" },
        new ProductCategory { Id = 2, CategoryName = "Computing" },
    };

    public static List<Product> Products { get; } = new List<Product>()
    {
        new Product { Id = 1, ProductName = "Smartphone", 
            Description="A pocket-sized, multifunctional device that combines the features of a mobile phone with advanced computing capabilities", 
            Price = 1500.10M, Image = "smartphone.webp" },

        new Product { Id = 2, ProductName = "Laptop", 
            Description="A portable personal computer that provides the convenience of a desktop computer in a compact form", 
            Price = 3600.99M, Image = "laptop.webp" },

        new Product { Id = 3, ProductName = "Clock", 
            Description = "A timekeeping device used to display the current time. Clocks come in various forms, " +
            "including analog (with hands and a dial), digital (with numerical displays), and modern smart clocks", 
            Price = 999.99M, Image = "clock.webp" },

        new Product { Id = 4, ProductName = "Headphones", 
            Description="Audio accessories worn over the ears or in-ear that provide a private and immersive listening experience", 
            Price = 880.99M, Image = "headphones.webp" }
    };

    public static List<Customer> Customers { get; } = new List<Customer>()
    {
        new Customer { Id = 1, FirstName = "Gilbert", LastName = "Perlaza", Email = "gjperlaza@gmail.com" },
        new Customer { Id = 2, FirstName = "Marian", LastName = "Balanta", Email = "mari@hotmail.com" },
    };

    public static List<Order> Orders { get; } = new List<Order>()
    {
        new Order { Id = 1, CustomerID = 1 },
        new Order { Id = 2, CustomerID = 2 },
    };

    public static List<OrderDetail> OrderDetails { get; } = new List<OrderDetail>()
    {
        new OrderDetail { Id = 1, OrderID = 1, ProductID = 1, Quantity = 2, UnitPrice = 299.99M },
        new OrderDetail { Id = 2, OrderID = 2, ProductID = 2, Quantity = 1, UnitPrice = 999.99M },
    };

    public static List<ProductCategoryProduct> ProductCategoryProducts { get; } = new List<ProductCategoryProduct>()
    {
        new ProductCategoryProduct { ProductCategoryID = 1, ProductID = 1 },
        new ProductCategoryProduct { ProductCategoryID = 2, ProductID = 2 },
        new ProductCategoryProduct { ProductCategoryID = 1, ProductID = 3 },
        new ProductCategoryProduct { ProductCategoryID = 1, ProductID = 4 }
    };
}
