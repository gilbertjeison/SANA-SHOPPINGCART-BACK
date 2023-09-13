using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SANA_SHOPPINGCART_BACK.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddCompleteData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(9475),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(2349));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(8935),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(1900));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "ProductCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 1, 23, 8, 156, DateTimeKind.Local).AddTicks(447),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(3120));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ProductCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(9968),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(2770));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(7124),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(625));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(6499),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(210));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "OrderDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(8325),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(1479));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "OrderDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(7722),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(1042));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(5912),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 1, 10, 15, 311, DateTimeKind.Local).AddTicks(9808));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(5350),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 1, 10, 15, 311, DateTimeKind.Local).AddTicks(9265));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(5350), new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(5912) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(5350), new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(5912) });

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(7722), new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(8325) });

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(7722), new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(8325) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(6499), new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(7124) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(6499), new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(7124) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(9968), new DateTime(2023, 9, 12, 1, 23, 8, 156, DateTimeKind.Local).AddTicks(447) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CategoryName", "CreatedOn", "UpdatedOn" },
                values: new object[] { "Computing", new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(9968), new DateTime(2023, 9, 12, 1, 23, 8, 156, DateTimeKind.Local).AddTicks(447) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "Description", "Image", "Price", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(8935), "A pocket-sized, multifunctional device that combines the features of a mobile phone with advanced computing capabilities", "smartphone.png", 1500.10m, new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(9475) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "Description", "Image", "Price", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(8935), "A portable personal computer that provides the convenience of a desktop computer in a compact form", "laptop.png", 3600.99m, new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(9475) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Price", "ProductName" },
                values: new object[,]
                {
                    { 3L, "A timekeeping device used to display the current time. Clocks come in various forms, including analog (with hands and a dial), digital (with numerical displays), and modern smart clocks", "clock.png", 999.99m, "Clock" },
                    { 4L, "Audio accessories worn over the ears or in-ear that provide a private and immersive listening experience", "headphones.png", 880.99m, "Headphones" }
                });

            migrationBuilder.InsertData(
                table: "ProductCategoryProducts",
                columns: new[] { "ProductCategoryID", "ProductID" },
                values: new object[,]
                {
                    { 1L, 3L },
                    { 1L, 4L }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductCategoryProducts",
                keyColumns: new[] { "ProductCategoryID", "ProductID" },
                keyValues: new object[] { 1L, 3L });

            migrationBuilder.DeleteData(
                table: "ProductCategoryProducts",
                keyColumns: new[] { "ProductCategoryID", "ProductID" },
                keyValues: new object[] { 1L, 4L });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(2349),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(9475));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(1900),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(8935));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "ProductCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(3120),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 1, 23, 8, 156, DateTimeKind.Local).AddTicks(447));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ProductCategories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(2770),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(9968));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(625),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(7124));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(210),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(6499));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "OrderDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(1479),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(8325));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "OrderDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(1042),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(7722));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedOn",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 1, 10, 15, 311, DateTimeKind.Local).AddTicks(9808),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(5912));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Customers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 9, 12, 1, 10, 15, 311, DateTimeKind.Local).AddTicks(9265),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 9, 12, 1, 23, 8, 155, DateTimeKind.Local).AddTicks(5350));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 12, 1, 10, 15, 311, DateTimeKind.Local).AddTicks(9265), new DateTime(2023, 9, 12, 1, 10, 15, 311, DateTimeKind.Local).AddTicks(9808) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 12, 1, 10, 15, 311, DateTimeKind.Local).AddTicks(9265), new DateTime(2023, 9, 12, 1, 10, 15, 311, DateTimeKind.Local).AddTicks(9808) });

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(1042), new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(1479) });

            migrationBuilder.UpdateData(
                table: "OrderDetails",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(1042), new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(1479) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(210), new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(625) });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(210), new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(625) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(2770), new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(3120) });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CategoryName", "CreatedOn", "UpdatedOn" },
                values: new object[] { "Clothing", new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(2770), new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(3120) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "Description", "Image", "Price", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(1900), null, null, 599.99m, new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(2349) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "Description", "Image", "Price", "UpdatedOn" },
                values: new object[] { new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(1900), null, null, 999.99m, new DateTime(2023, 9, 12, 1, 10, 15, 312, DateTimeKind.Local).AddTicks(2349) });
        }
    }
}
