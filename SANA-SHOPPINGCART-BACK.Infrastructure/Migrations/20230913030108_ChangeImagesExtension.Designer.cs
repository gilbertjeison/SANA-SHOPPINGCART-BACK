﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SANA_SHOPPINGCART_BACK.Infrastructure.DataSource;

#nullable disable

namespace SANA_SHOPPINGCART_BACK.Infrastructure.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230913030108_ChangeImagesExtension")]
    partial class ChangeImagesExtension
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SANA_SHOPPINGCART_BACK.Domain.Entities.Customer", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 9, 12, 22, 1, 8, 62, DateTimeKind.Local).AddTicks(6897));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 9, 12, 22, 1, 8, 62, DateTimeKind.Local).AddTicks(7324));

                    b.HasKey("Id");

                    b.ToTable("Customers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Email = "gjperlaza@gmail.com",
                            FirstName = "Gilbert",
                            LastName = "Perlaza"
                        },
                        new
                        {
                            Id = 2L,
                            Email = "mari@hotmail.com",
                            FirstName = "Marian",
                            LastName = "Balanta"
                        });
                });

            modelBuilder.Entity("SANA_SHOPPINGCART_BACK.Domain.Entities.Order", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 9, 12, 22, 1, 8, 62, DateTimeKind.Local).AddTicks(7920));

                    b.Property<long>("CustomerID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("UpdatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 9, 12, 22, 1, 8, 62, DateTimeKind.Local).AddTicks(8340));

                    b.HasKey("Id");

                    b.HasIndex("CustomerID");

                    b.ToTable("Orders", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CustomerID = 1L,
                            OrderDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2L,
                            CustomerID = 2L,
                            OrderDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("SANA_SHOPPINGCART_BACK.Domain.Entities.OrderDetail", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 9, 12, 22, 1, 8, 62, DateTimeKind.Local).AddTicks(9060));

                    b.Property<long>("OrderID")
                        .HasColumnType("bigint");

                    b.Property<long>("ProductID")
                        .HasColumnType("bigint");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<DateTime>("UpdatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 9, 12, 22, 1, 8, 63, DateTimeKind.Local).AddTicks(39));

                    b.HasKey("Id");

                    b.HasIndex("OrderID");

                    b.HasIndex("ProductID");

                    b.ToTable("OrderDetails", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            OrderID = 1L,
                            ProductID = 1L,
                            Quantity = 2,
                            UnitPrice = 299.99m
                        },
                        new
                        {
                            Id = 2L,
                            OrderID = 2L,
                            ProductID = 2L,
                            Quantity = 1,
                            UnitPrice = 999.99m
                        });
                });

            modelBuilder.Entity("SANA_SHOPPINGCART_BACK.Domain.Entities.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 9, 12, 22, 1, 8, 63, DateTimeKind.Local).AddTicks(1076));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("UpdatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 9, 12, 22, 1, 8, 63, DateTimeKind.Local).AddTicks(1680));

                    b.HasKey("Id");

                    b.ToTable("Products", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Description = "A pocket-sized, multifunctional device that combines the features of a mobile phone with advanced computing capabilities",
                            Image = "smartphone.webp",
                            Price = 1500.10m,
                            ProductName = "Smartphone"
                        },
                        new
                        {
                            Id = 2L,
                            Description = "A portable personal computer that provides the convenience of a desktop computer in a compact form",
                            Image = "laptop.webp",
                            Price = 3600.99m,
                            ProductName = "Laptop"
                        },
                        new
                        {
                            Id = 3L,
                            Description = "A timekeeping device used to display the current time. Clocks come in various forms, including analog (with hands and a dial), digital (with numerical displays), and modern smart clocks",
                            Image = "clock.webp",
                            Price = 999.99m,
                            ProductName = "Clock"
                        },
                        new
                        {
                            Id = 4L,
                            Description = "Audio accessories worn over the ears or in-ear that provide a private and immersive listening experience",
                            Image = "headphones.webp",
                            Price = 880.99m,
                            ProductName = "Headphones"
                        });
                });

            modelBuilder.Entity("SANA_SHOPPINGCART_BACK.Domain.Entities.ProductCategory", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("CreatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 9, 12, 22, 1, 8, 63, DateTimeKind.Local).AddTicks(2074));

                    b.Property<DateTime>("UpdatedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 9, 12, 22, 1, 8, 63, DateTimeKind.Local).AddTicks(2375));

                    b.HasKey("Id");

                    b.HasIndex("CategoryName")
                        .IsUnique();

                    b.ToTable("ProductCategories", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CategoryName = "Electronics"
                        },
                        new
                        {
                            Id = 2L,
                            CategoryName = "Computing"
                        });
                });

            modelBuilder.Entity("SANA_SHOPPINGCART_BACK.Domain.Entities.ProductCategoryProduct", b =>
                {
                    b.Property<long>("ProductCategoryID")
                        .HasColumnType("bigint");

                    b.Property<long>("ProductID")
                        .HasColumnType("bigint");

                    b.HasKey("ProductCategoryID", "ProductID");

                    b.HasIndex("ProductID");

                    b.ToTable("ProductCategoryProducts", (string)null);

                    b.HasData(
                        new
                        {
                            ProductCategoryID = 1L,
                            ProductID = 1L
                        },
                        new
                        {
                            ProductCategoryID = 2L,
                            ProductID = 2L
                        },
                        new
                        {
                            ProductCategoryID = 1L,
                            ProductID = 3L
                        },
                        new
                        {
                            ProductCategoryID = 1L,
                            ProductID = 4L
                        });
                });

            modelBuilder.Entity("SANA_SHOPPINGCART_BACK.Domain.Entities.Order", b =>
                {
                    b.HasOne("SANA_SHOPPINGCART_BACK.Domain.Entities.Customer", null)
                        .WithMany("Orders")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SANA_SHOPPINGCART_BACK.Domain.Entities.OrderDetail", b =>
                {
                    b.HasOne("SANA_SHOPPINGCART_BACK.Domain.Entities.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SANA_SHOPPINGCART_BACK.Domain.Entities.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("SANA_SHOPPINGCART_BACK.Domain.Entities.ProductCategoryProduct", b =>
                {
                    b.HasOne("SANA_SHOPPINGCART_BACK.Domain.Entities.ProductCategory", "ProductCategory")
                        .WithMany("ProductCategoryProducts")
                        .HasForeignKey("ProductCategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SANA_SHOPPINGCART_BACK.Domain.Entities.Product", "Product")
                        .WithMany("ProductCategoryProducts")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("ProductCategory");
                });

            modelBuilder.Entity("SANA_SHOPPINGCART_BACK.Domain.Entities.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("SANA_SHOPPINGCART_BACK.Domain.Entities.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("SANA_SHOPPINGCART_BACK.Domain.Entities.Product", b =>
                {
                    b.Navigation("OrderDetails");

                    b.Navigation("ProductCategoryProducts");
                });

            modelBuilder.Entity("SANA_SHOPPINGCART_BACK.Domain.Entities.ProductCategory", b =>
                {
                    b.Navigation("ProductCategoryProducts");
                });
#pragma warning restore 612, 618
        }
    }
}