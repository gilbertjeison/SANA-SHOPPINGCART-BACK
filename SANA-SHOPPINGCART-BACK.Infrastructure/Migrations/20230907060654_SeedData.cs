using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SANA_SHOPPINGCART_BACK.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 7, 1, 6, 53, 911, DateTimeKind.Local).AddTicks(6686),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 7, 0, 49, 42, 870, DateTimeKind.Local).AddTicks(6198));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 7, 1, 6, 53, 911, DateTimeKind.Local).AddTicks(6367),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 7, 0, 49, 42, 870, DateTimeKind.Local).AddTicks(5839));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "ProductCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 7, 1, 6, 53, 911, DateTimeKind.Local).AddTicks(7382),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 7, 0, 49, 42, 870, DateTimeKind.Local).AddTicks(6879));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ProductCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 7, 1, 6, 53, 911, DateTimeKind.Local).AddTicks(7000),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 7, 0, 49, 42, 870, DateTimeKind.Local).AddTicks(6563));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 7, 1, 6, 53, 911, DateTimeKind.Local).AddTicks(5278),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 7, 0, 49, 42, 870, DateTimeKind.Local).AddTicks(4496));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 7, 1, 6, 53, 911, DateTimeKind.Local).AddTicks(4905),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 7, 0, 49, 42, 870, DateTimeKind.Local).AddTicks(4094));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "OrderDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 7, 1, 6, 53, 911, DateTimeKind.Local).AddTicks(5998),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 7, 0, 49, 42, 870, DateTimeKind.Local).AddTicks(5438));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "OrderDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 7, 1, 6, 53, 911, DateTimeKind.Local).AddTicks(5640),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 7, 0, 49, 42, 870, DateTimeKind.Local).AddTicks(5006));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 7, 1, 6, 53, 911, DateTimeKind.Local).AddTicks(4462),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 7, 0, 49, 42, 870, DateTimeKind.Local).AddTicks(3694));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 7, 1, 6, 53, 911, DateTimeKind.Local).AddTicks(4084),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 7, 0, 49, 42, 870, DateTimeKind.Local).AddTicks(3319));

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1L, "gjperlaza@gmail.com", "Gilbert", "Perlaza" },
                    { 2L, "mari@hotmail.com", "Marian", "Balanta" }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "CategoryName" },
                values: new object[,]
                {
                    { 1L, "Electronics" },
                    { 2L, "Clothing" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Price", "ProductName" },
                values: new object[,]
                {
                    { 1L, null, 599.99m, "Smartphone" },
                    { 2L, null, 999.99m, "Laptop" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerID", "OrderDate" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "ProductCategoryProducts",
                columns: new[] { "ProductCategoryID", "ProductID" },
                values: new object[,]
                {
                    { 1L, 1L },
                    { 2L, 2L }
                });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "Id", "OrderID", "ProductID", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { 1L, 1L, 1L, 2, 299.99m },
                    { 2L, 2L, 2L, 1, 999.99m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "ProductCategoryProducts",
                keyColumns: new[] { "ProductCategoryID", "ProductID" },
                keyValues: new object[] { 1L, 1L });

            migrationBuilder.DeleteData(
                table: "ProductCategoryProducts",
                keyColumns: new[] { "ProductCategoryID", "ProductID" },
                keyValues: new object[] { 2L, 2L });

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 7, 0, 49, 42, 870, DateTimeKind.Local).AddTicks(6198),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 7, 1, 6, 53, 911, DateTimeKind.Local).AddTicks(6686));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 7, 0, 49, 42, 870, DateTimeKind.Local).AddTicks(5839),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 7, 1, 6, 53, 911, DateTimeKind.Local).AddTicks(6367));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "ProductCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 7, 0, 49, 42, 870, DateTimeKind.Local).AddTicks(6879),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 7, 1, 6, 53, 911, DateTimeKind.Local).AddTicks(7382));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ProductCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 7, 0, 49, 42, 870, DateTimeKind.Local).AddTicks(6563),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 7, 1, 6, 53, 911, DateTimeKind.Local).AddTicks(7000));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 7, 0, 49, 42, 870, DateTimeKind.Local).AddTicks(4496),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 7, 1, 6, 53, 911, DateTimeKind.Local).AddTicks(5278));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 7, 0, 49, 42, 870, DateTimeKind.Local).AddTicks(4094),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 7, 1, 6, 53, 911, DateTimeKind.Local).AddTicks(4905));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "OrderDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 7, 0, 49, 42, 870, DateTimeKind.Local).AddTicks(5438),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 7, 1, 6, 53, 911, DateTimeKind.Local).AddTicks(5998));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "OrderDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 7, 0, 49, 42, 870, DateTimeKind.Local).AddTicks(5006),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 7, 1, 6, 53, 911, DateTimeKind.Local).AddTicks(5640));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 7, 0, 49, 42, 870, DateTimeKind.Local).AddTicks(3694),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 7, 1, 6, 53, 911, DateTimeKind.Local).AddTicks(4462));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 7, 0, 49, 42, 870, DateTimeKind.Local).AddTicks(3319),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 7, 1, 6, 53, 911, DateTimeKind.Local).AddTicks(4084));
        }
    }
}
